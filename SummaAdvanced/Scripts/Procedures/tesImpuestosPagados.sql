
-- impImpuestosPagadosDatos 3,'20200801','20200831'

DROP PROCEDURE impImpuestosPagadosDatos 
GO
CREATE PROCEDURE impImpuestosPagadosDatos 
(
 @Empresa Int, 
 @FechaDesde DateTime, 
 @FechaHasta DateTime
)
as
SELECT @FechaDesde as FechaDesde, @FechaHasta  FechaHasta

select 
	case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END AS Fecha,
	genCancMov.Asiento_Id_ap as comMovprov, tesMovimientos.tesMovimientos, 
	comImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	Convert(numeric(18,2),comMovImpuestos.Base_Imponible / comMovProvFact.Importe * genCancMov.Importe*
	  conMovCont.ImporteMonedaOriginal / case when tesIdentifica.Moneda_Id = conAsientos.Moneda_Id Then 1 else	
		conAsientos.Cambio end 	* case when conmovcont.Tipomov = tesRengmovi.TipomovCont then 1 else -1 end  / comMovProv.Importe *	comMovTipos.Signo*conAsientosCom.Cambio ) as BaseImponible, 
	Convert(numeric(18,2),comMovImpuestos.Importe_Impuesto/ comMovProvFact.Importe * genCancMov.Importe*
	conMovCont.ImporteMonedaOriginal / case when tesIdentifica.Moneda_Id = conAsientos.Moneda_Id Then 1 else	
		conAsientos.Cambio end 	* case when conmovcont.Tipomov = tesRengmovi.TipomovCont then 1 else -1 end  / comMovProv.Importe *	comMovTipos.Signo*conAsientosCom.Cambio) as Monto, 
	Convert(numeric(18,2),conMovCont.Importe / comMovProv.Importe * genCancMov.Importe*	comMovTipos.Signo) as TotalPago, 
	'P' Origen, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N) as comSegmento , 
		 conAsientosCom.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		 case when conAsientosCom.Moneda_Id = genEmpresas.Moneda_Id then 
			tesRengMovi.Cambio else conAsientos.Cambio end  as CambioPago, conAsientos.Cambio*0 as DifCambio
		
 from 
	tesMovimientos inner join comMovprov ON
	tesMovimientos.tesMovimientos = comMovprov.comMovProv
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id = comMovprov.comMovProv
	INNER JOIN comMovProv as ComMovprovFact ON
	ComMovprovFact.comMovProv = genCancMov.Asiento_Id_ap
	INNER JOIN comMovImpuestos ON
	comMovImpuestos.comMovProv = genCancMov.Asiento_Id_ap
	INNER JOIN comImpuestos on 
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	INNER JOIN tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon =tesRengMovi.conRenglon
	INNER JOIN comMovTipos ON
	comMovTipos.TipoMov = comMovProv.TipoMov
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN tesRengConcilEsp ON
	tesRengConcilEsp.tesMovimientos = tesRengMovi.tesMovimientos and 
	tesRengConcilEsp.conRenglon = tesRengMovi.conRenglon
	INNER JOIN tesConciliacion ON
	tesConciliacion.tesIdentifica = tesRengMovi.Cartera_Id and 
	tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc and
	tesConciliacion.Empresa_Id =conAsientos.Empresa_Id
	INNER JOIN conCuentas ON 
	conCuentas.conCuentas = comImpuestos.CtaDebe
	INNER JOIN conCuentas CtaReversion ON 
	CtaReversion.conCuentas = comImpuestos.CtaReversion
	INNER JOIN conAsientos as conAsientosCom ON
	conAsientosCom.conAsientos = genCancMov.Asiento_Id_ap
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos genAsiSegmentosCOM ON
	genAsiSegmentosCom.Asiento_Id = conAsientosCom.conAsientos
	INNER JOIN genMonedas ON conAsientosCom.Moneda_Id = genMonedas.genMonedas
	INNER JOIN  genEmpresas on genEmpresas.genEmpresas= @Empresa
		Where
		tesRengMovi.TipomovCont = CASE WHEN comMovTipos.Signo = 1 then 2 else 1 end and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		conAsientosCom.Anulado = 0 and
		conAsientosCom.Posteado = 1 and
		conAsientos.Empresa_Id = @Empresa and 
		case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END 
			between @FechaDesde And @FechaHasta and 
		comImpuestos.PorAcreditacion = 1 
		--and conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id
UNION ALL
-- NO BANCO
select 
	genCancMov.FechaAplicacion AS Fecha,
	genCancMov.Asiento_Id_ap as comMovprov, tesMovimientos.tesMovimientos, 
	comImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	Convert(numeric(18,2),comMovImpuestos.Base_Imponible / comMovProvFact.Importe * genCancMov.Importe*
	  conMovCont.ImporteMonedaOriginal / case when tesIdentifica.Moneda_Id = conAsientos.Moneda_Id Then 1 else	
		conAsientos.Cambio end 	* case when conmovcont.Tipomov = tesRengmovi.TipomovCont then 1 else -1 end  / comMovProv.Importe *	comMovTipos.Signo*conAsientoscom.Cambio ) as BaseImponible, 
	Convert(numeric(18,2),comMovImpuestos.Importe_Impuesto/ comMovProvFact.Importe * genCancMov.Importe*
	  conMovCont.ImporteMonedaOriginal / case when tesIdentifica.Moneda_Id = conAsientos.Moneda_Id Then 1 else	
		conAsientos.Cambio end 	* case when conmovcont.Tipomov = tesRengmovi.TipomovCont then 1 else -1 end  / comMovProv.Importe *	comMovTipos.Signo*conAsientoscom.Cambio ) as Monto, 
	Convert(numeric(18,2),conMovCont.Importe / comMovProv.Importe * genCancMov.Importe*	comMovTipos.Signo) as TotalPago, 
	'P' Origen, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N) as comSegmento , 
		 conAsientosCom.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		 case when conAsientosCom.Moneda_Id = genEmpresas.Moneda_Id then 
			tesRengMovi.Cambio else conAsientos.Cambio end  as CambioPago, conAsientos.Cambio*0 as DifCambio

 from 
	tesMovimientos inner join comMovprov ON
	tesMovimientos.tesMovimientos = comMovprov.comMovProv
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id = comMovprov.comMovProv
	INNER JOIN comMovProv as ComMovprovFact ON
	ComMovprovFact.comMovProv = genCancMov.Asiento_Id_AP
	INNER JOIN comMovImpuestos ON
	comMovImpuestos.comMovProv = genCancMov.Asiento_Id_AP
	INNER JOIN comImpuestos on 
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	INNER JOIN tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon =tesRengMovi.conRenglon
	INNER JOIN comMovTipos ON
	comMovTipos.TipoMov = comMovProv.TipoMov
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN conCuentas ON 
	conCuentas.conCuentas = comImpuestos.CtaDebe
	INNER JOIN conCuentas CtaReversion ON 
	CtaReversion.conCuentas = comImpuestos.CtaReversion
	INNER JOIN conAsientos as conAsientosCom ON
	conAsientosCom.conAsientos = genCancMov.Asiento_Id_AP
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos genAsiSegmentosCOM ON
	genAsiSegmentosCom.Asiento_Id = conAsientosCom.conAsientos
	INNER JOIN genMonedas ON conAsientosCom.Moneda_Id = genMonedas.genMonedas
	INNER JOIN  genEmpresas on genEmpresas.genEmpresas= @Empresa
	Where
		tesRengMovi.TipomovCont = CASE WHEN comMovTipos.Signo = 1 then 2 else 1 end and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		conAsientosCom.Anulado = 0 and
		conAsientosCom.Posteado = 1 and
		conAsientos.Empresa_Id = @Empresa and 
		genCancMov.FechaAplicacion  between @FechaDesde And @FechaHasta and 
		comImpuestos.PorAcreditacion = 1 AND 
		-- conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id and 
		not exists(select 1 from tesRengConciliac WHERE
			tesRengConciliac.tesMovimientos = tesRengMovi.tesMovimientos and 
			tesRengConciliac.conRenglon = tesRengMovi.conRenglon)

ORDER BY 1

GO
		
-- impImpuestosPagadosAsiDatos  1, '20180501','20180531'		
DROP PROCEDURE impImpuestosPagadosAsiDatos 
GO
CREATE PROCEDURE impImpuestosPagadosAsiDatos 
(
 @Empresa Int, 
 @FechaDesde DateTime, 
 @FechaHasta DateTime
)
as

SELECT @FechaDesde as FechaDesde, @FechaHasta  FechaHasta

SELECT Distinct genAsiSegmentos.Asiento_Id , 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C
from comMovImpAcredita INNER JOIN genAsiSegmentos ON
comMovImpAcredita.Asiento_Id = genAsiSegmentos.Asiento_Id
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN conAsientos ON
conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
Where
	conAsientos.Fecha BETWEEN @FechaDesde And @FechaHasta and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa
ORDER BY 1

GO




