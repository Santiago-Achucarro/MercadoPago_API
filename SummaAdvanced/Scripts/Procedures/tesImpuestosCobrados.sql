 -- impImpuestosCobradosDatos  5, '20210901','20210930'
DROP PROCEDURE impImpuestosCobradosDatos 
GO
CREATE PROCEDURE impImpuestosCobradosDatos 
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
	genCancMov.Asiento_Id as venMovimientos, tesMovimientos.tesMovimientos, 
	venImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	-Convert(numeric(18,2),venMovImpuestos.BaseImponible/ FACTURA.Importe * genCancMov.Importe*
	conMovCont.ImporteMonedaOriginal * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end 
	 / venMovimientos.Importe  *venTipoMov.Signo * conAsientosCom.Cambio) as BaseImponible, 
	-Convert(numeric(18,2),venMovImpuestos.Importe/ FACTURA.Importe * genCancMov.Importe*
		conMovCont.ImporteMonedaOriginal * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end 
		/ venMovimientos.Importe* conAsientosCom.Cambio  * venTipoMov.Signo) as Monto, 
	-Convert(numeric(18,2),conMovCont.Importe / venMovimientos.Importe * genCancMov.Importe*venTipoMov.Signo) as TotalCobro, 
	venClientes.Cliente_Id, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N) as venSegmento ,
		tesIdBancoPropio.Cartera_Id as Banco_Id, 
		conAsientosCom.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		conAsientos.Cambio as CambioCobra, conAsientos.Cambio*0 as DifCambio
		
 from 
	tesMovimientos inner join venMovimientos ON
	tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id_AP = venMovimientos.venMovimientos
	INNER JOIN venMovImpuestos ON
	venMovImpuestos.venMovimientos = genCancMov.Asiento_Id
	INNER JOIN venImpuestos on 
	venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	INNER JOIN venSubTipoMov ON 
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon =tesRengMovi.conRenglon
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
	conCuentas.conCuentas = venImpuestos.Cuenta_Id
	INNER JOIN conCuentas CtaReversion ON 
	CtaReversion.conCuentas = venImpuestos.CtaReversion
	INNER JOIN conAsientos as conAsientosCom ON
	conAsientosCom.conAsientos = genCancMov.Asiento_Id
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos genAsiSegmentosCOM ON
	genAsiSegmentosCom.Asiento_Id = conAsientosCom.conAsientos
	INNER JOIN tesIdentifica tesIdBancoPropio ON 
	tesIdBancoPropio.tesIdentifica = tesConciliacion.tesIdentifica
	INNER JOIN venClientes  ON
		venClientes.genEntidades = venMovimientos.Cliente_Id
		INNER JOIN venMovimientos AS FACTURA ON 
	FACTURA.venMovimientos = genCancMov.Asiento_Id
	INNER JOIN genMonedas ON conAsientosCom.Moneda_Id = genMonedas.genMonedas
	inner join conAsientos  conAsientosF on conAsientosF.conAsientos = FACTURA.venMovimientos
		Where
		conMovCont.TipoMov = CASE WHEN venTipoMov.Signo = 1 then 2 else 1 end and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 AND 
		conAsientosF.Anulado = 0 AND 
		conAsientosF.Posteado = 1 AND 
		conAsientos.Empresa_Id = @Empresa and 
		case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END 
			between @FechaDesde And @FechaHasta and 
		venImpuestos.PorVencimiento = 1 and 
		conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id

UNION ALL
-- CHEQUES
select 
	case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END AS Fecha,
	genCancMov.Asiento_Id as venMovimientos, tesMovimientos.tesMovimientos, 
	venImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	-Convert(numeric(18,2),venMovImpuestos.BaseImponible/ FACTURA.Importe * genCancMov.Importe* 
		conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end 
		/ venMovimientos.Importe * venTipoMov.Signo* conAsientosCom.Cambio) as BaseImponible, 
	-Convert(numeric(18,2),venMovImpuestos.Importe/ FACTURA.Importe * genCancMov.Importe*
	conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end 
	/ venMovimientos.Importe * venTipoMov.Signo* conAsientosCom.Cambio) as Monto, 
	-Convert(numeric(18,2),conMovCont.Importe / venMovimientos.Importe * genCancMov.Importe*venTipoMov.Signo) as TotalCobro, 
	venClientes.Cliente_Id, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N) as venSegmento ,
		tesIdBancoPropio.Cartera_Id as Banco_Id, 
		conAsientosCom.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		conAsientos.Cambio as CambioCobra, conAsientos.Cambio*0 as DifCambio
		
 from 
	tesMovimientos inner join venMovimientos ON
	tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id_AP = venMovimientos.venMovimientos
	INNER JOIN venMovImpuestos ON
	venMovImpuestos.venMovimientos = genCancMov.Asiento_Id
	INNER JOIN venImpuestos on 
	venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	INNER JOIN venSubTipoMov ON 
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	inner join tesCTlink ON
	tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos AND 
	tesCTlink.conRenglon = tesRengMovi.conRenglon
	INNER JOIN tesCheqTerceros ON
	tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon =tesRengMovi.conRenglon
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN tesConciliacion ON
	tesConciliacion.tesIdentifica = tesCheqTerceros.BancoConc and 
	tesConciliacion.NumeroConc = tesCheqTerceros.NumeroConc and
	tesConciliacion.Empresa_Id =conAsientos.Empresa_Id
	INNER JOIN conCuentas ON 
	conCuentas.conCuentas = venImpuestos.Cuenta_Id
	INNER JOIN conCuentas CtaReversion ON 
	CtaReversion.conCuentas = venImpuestos.CtaReversion
	INNER JOIN conAsientos as conAsientosCom ON
	conAsientosCom.conAsientos = genCancMov.Asiento_Id
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos genAsiSegmentosCOM ON
	genAsiSegmentosCom.Asiento_Id = conAsientosCom.conAsientos
	INNER JOIN tesIdentifica tesIdBancoPropio ON 
	tesCheqTerceros.BancoConc = tesIdBancoPropio.tesIdentifica
	INNER JOIN venClientes  ON
		venClientes.genEntidades = venMovimientos.Cliente_Id
		INNER JOIN venMovimientos AS FACTURA ON 
	FACTURA.venMovimientos = genCancMov.Asiento_Id
	INNER JOIN genMonedas ON conAsientosCom.Moneda_Id = genMonedas.genMonedas
	inner join conAsientos  conAsientosF on conAsientosF.conAsientos = FACTURA.venMovimientos
		Where
		conMovCont.TipoMov = CASE WHEN venTipoMov.Signo = 1 then 2 else 1 end and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 AND 
		conAsientosF.Anulado = 0 AND 
		conAsientosF.Posteado = 1 AND 
		conAsientos.Empresa_Id = @Empresa and 
		case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END 
			between @FechaDesde And @FechaHasta and 
		venImpuestos.PorVencimiento = 1 and 
		conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id


UNION ALL
-- NO BANCO
select 
	genCancMov.FechaAplicacion AS Fecha,
	genCancMov.Asiento_Id as venMovimientos, tesMovimientos.tesMovimientos, 
	venImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	-Convert(numeric(18,2),venMovImpuestos.BaseImponible/ FACTURA.Importe * 	genCancMov.Importe*
		conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end 
		/ venMovimientos.Importe  * venTipoMov.Signo* conAsientosCom.Cambio) as BaseImponible, 
	-Convert(numeric(18,2),venMovImpuestos.Importe/ venMovimientos.Importe * genCancMov.Importe*
	conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end 
	 / FACTURA.Importe  * venTipoMov.Signo* conAsientosCom.Cambio) as Monto, 
	-Convert(numeric(18,2),conMovCont.Importe / venMovimientos.Importe * genCancMov.Importe*venTipoMov.Signo) as TotalCobro, 
	venClientes.Cliente_Id, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N) as venSegmento , 
		 ' ' as Banco_Id,
		 conAsientosCom.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		conAsientos.Cambio as CambioCobra, conAsientos.Cambio*0 as DifCambio

 from 
	tesMovimientos inner join venMovimientos ON
	tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id_AP = venMovimientos.venMovimientos
	INNER JOIN venMovImpuestos ON
	venMovImpuestos.venMovimientos = genCancMov.Asiento_Id
	INNER JOIN venImpuestos on 
	venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	INNER JOIN venSubTipoMov ON 
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon =tesRengMovi.conRenglon
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN conCuentas ON 
	conCuentas.conCuentas = venImpuestos.Cuenta_Id
	INNER JOIN conCuentas CtaReversion ON 
	CtaReversion.conCuentas = venImpuestos.CtaReversion
	INNER JOIN conAsientos as conAsientosCom ON
	conAsientosCom.conAsientos = genCancMov.Asiento_Id
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos genAsiSegmentosCOM ON
	genAsiSegmentosCom.Asiento_Id = conAsientosCom.conAsientos
	INNER JOIN venClientes  ON
		venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN venMovimientos AS FACTURA ON 
	FACTURA.venMovimientos = genCancMov.Asiento_Id
	INNER JOIN genMonedas ON conAsientosCom.Moneda_Id = genMonedas.genMonedas
	inner join conAsientos  conAsientosF on conAsientosF.conAsientos = FACTURA.venMovimientos
	Where
		conMovCont.TipoMov = CASE WHEN venTipoMov.Signo = 1 then 2 else 1 end and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 AND 
		conAsientosF.Anulado = 0 AND 
		conAsientosF.Posteado = 1 AND 
		conAsientos.Empresa_Id = @Empresa and 
		genCancMov.FechaAplicacion  between @FechaDesde And @FechaHasta and 
		venImpuestos.PorVencimiento = 1 AND 
		conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id and 
		not exists(select 1 from tesRengConciliac WHERE
			tesRengConciliac.tesMovimientos = tesRengMovi.tesMovimientos and 
			tesRengConciliac.conRenglon = tesRengMovi.conRenglon) and
		not exists(select 1 from tesCTlink WHERE
			tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos and 
			tesCTlink.conRenglon = tesRengMovi.conRenglon) 

UNION ALL
-- PAGO A CLIENTES
select 
	case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END AS Fecha,
	genCancMov.Asiento_Id_AP as venMovimientos, tesMovimientos.tesMovimientos, 
	venImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	-Convert(numeric(18,2),venMovImpuestos.BaseImponible/ FACTURA.Importe * genCancMov.Importe*
	conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end / venMovimientos.Importe  * conAsientosCom.Cambio) as BaseImponible, 
	-Convert(numeric(18,2),venMovImpuestos.Importe/ FACTURA.Importe * genCancMov.Importe*
		conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end / venMovimientos.Importe  * conAsientosCom.Cambio) as Monto, 
	-Convert(numeric(18,2),conMovCont.Importe / venMovimientos.Importe * genCancMov.Importe) as TotalCobro, 
	venClientes.Cliente_Id, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N) as venSegmento ,
		tesIdBancoPropio.Cartera_Id as Banco_Id,
		conAsientosCom.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		conAsientos.Cambio as CambioCobra, conAsientos.Cambio*0 as DifCambio
		
 from 
	tesMovimientos inner join venMovimientos ON
	tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venMovImpuestos ON
	venMovImpuestos.venMovimientos = genCancMov.Asiento_Id_AP
	INNER JOIN venImpuestos on 
	venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	INNER JOIN venSubTipoMov ON 
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon =tesRengMovi.conRenglon
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
	conCuentas.conCuentas = venImpuestos.Cuenta_Id
	INNER JOIN conCuentas CtaReversion ON 
	CtaReversion.conCuentas = venImpuestos.CtaReversion
	INNER JOIN conAsientos as conAsientosCom ON
	conAsientosCom.conAsientos = genCancMov.Asiento_Id_AP
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos genAsiSegmentosCOM ON
	genAsiSegmentosCom.Asiento_Id = conAsientosCom.conAsientos
	INNER JOIN tesIdentifica tesIdBancoPropio ON 
	tesIdBancoPropio.tesIdentifica = tesConciliacion.tesIdentifica
	INNER JOIN venClientes  ON
		venClientes.genEntidades = venMovimientos.Cliente_Id
		INNER JOIN venMovimientos AS FACTURA ON 
	FACTURA.venMovimientos = genCancMov.Asiento_Id_AP
	INNER JOIN genMonedas ON conAsientosCom.Moneda_Id = genMonedas.genMonedas
	inner join conAsientos  conAsientosF on conAsientosF.conAsientos = FACTURA.venMovimientos
		Where
		conMovCont.TipoMov = 2 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 AND 
		conAsientosF.Anulado = 0 AND 
		conAsientosF.Posteado = 1 AND 
		conAsientos.Empresa_Id = @Empresa and 
		case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END 
			between @FechaDesde And @FechaHasta and 
		venImpuestos.PorVencimiento = 1 and 
		conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id
UNION ALL
-- CHEQUES
select 
	case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END AS Fecha,
	genCancMov.Asiento_Id_AP as venMovimientos, tesMovimientos.tesMovimientos, 
	venImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	-Convert(numeric(18,2),venMovImpuestos.BaseImponible/ FACTURA.Importe * genCancMov.Importe* 
		conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end / venMovimientos.Importe * conAsientosCom.Cambio) as BaseImponible, 
	-Convert(numeric(18,2),venMovImpuestos.Importe/ FACTURA.Importe * genCancMov.Importe*
	conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end  / venMovimientos.Importe * conAsientosCom.Cambio) as Monto, 
	-Convert(numeric(18,2),conMovCont.Importe / venMovimientos.Importe * genCancMov.Importe) as TotalCobro, 
	venClientes.Cliente_Id, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N) as venSegmento ,
		tesIdBancoPropio.Cartera_Id as Banco_Id,
		conAsientosCom.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		conAsientos.Cambio as CambioCobra, conAsientos.Cambio*0 as DifCambio
		
 from 
	tesMovimientos inner join venMovimientos ON
	tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venMovImpuestos ON
	venMovImpuestos.venMovimientos = genCancMov.Asiento_Id_AP
	INNER JOIN venImpuestos on 
	venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	INNER JOIN venSubTipoMov ON 
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	inner join tesCTlink ON
	tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos AND 
	tesCTlink.conRenglon = tesRengMovi.conRenglon
	INNER JOIN tesCheqTerceros ON
	tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon =tesRengMovi.conRenglon
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN tesConciliacion ON
	tesConciliacion.tesIdentifica = tesCheqTerceros.BancoConc and 
	tesConciliacion.NumeroConc = tesCheqTerceros.NumeroConc and
	tesConciliacion.Empresa_Id =conAsientos.Empresa_Id
	INNER JOIN conCuentas ON 
	conCuentas.conCuentas = venImpuestos.Cuenta_Id
	INNER JOIN conCuentas CtaReversion ON 
	CtaReversion.conCuentas = venImpuestos.CtaReversion
	INNER JOIN conAsientos as conAsientosCom ON
	conAsientosCom.conAsientos = genCancMov.Asiento_Id_AP
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos genAsiSegmentosCOM ON
	genAsiSegmentosCom.Asiento_Id = conAsientosCom.conAsientos
	INNER JOIN tesIdentifica tesIdBancoPropio ON 
	tesCheqTerceros.BancoConc = tesIdBancoPropio.tesIdentifica
	INNER JOIN venClientes  ON
		venClientes.genEntidades = venMovimientos.Cliente_Id
		INNER JOIN venMovimientos AS FACTURA ON 
	FACTURA.venMovimientos = genCancMov.Asiento_Id_AP
	INNER JOIN genMonedas ON conAsientosCom.Moneda_Id = genMonedas.genMonedas
	inner join conAsientos  conAsientosF on conAsientosF.conAsientos = FACTURA.venMovimientos
		Where
		conMovCont.TipoMov = 2 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 AND 
		conAsientosF.Anulado = 0 AND 
		conAsientosF.Posteado = 1 AND 
		conAsientos.Empresa_Id = @Empresa and 
		case when  tesConciliacion.FechaConciliacion > genCancMov.FechaAplicacion THEN 
		tesConciliacion.FechaConciliacion  ELSE genCancMov.FechaAplicacion END 
			between @FechaDesde And @FechaHasta and 
		venImpuestos.PorVencimiento = 1 and 
		conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id


UNION ALL
-- NO BANCO
select 
	genCancMov.FechaAplicacion AS Fecha,
	genCancMov.Asiento_Id_AP as venMovimientos, tesMovimientos.tesMovimientos, 
	venImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	-Convert(numeric(18,2),venMovImpuestos.BaseImponible/ FACTURA.Importe * 	genCancMov.Importe*
		conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end  / venMovimientos.Importe  * conAsientosCom.Cambio) as BaseImponible, 
	-Convert(numeric(18,2),venMovImpuestos.Importe/ venMovimientos.Importe * genCancMov.Importe*
	conMovCont.ImporteMonedaOriginal  * case when tesIdentifica.moneda_Id = conAsientosCom.Moneda_id then 1 else 
			 1/conAsientosCom.Cambio end  / FACTURA.Importe  * conAsientosCom.Cambio) as Monto, 
	-Convert(numeric(18,2),conMovCont.Importe / venMovimientos.Importe * genCancMov.Importe) as TotalCobro, 
	venClientes.Cliente_Id, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N) as venSegmento , 
		 ' ' as Banco_Id, 
		 conAsientosCom.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		conAsientos.Cambio as CambioCobra, conAsientos.Cambio*0 as DifCambio

 from 
	tesMovimientos inner join venMovimientos ON
	tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
	INNER JOIN genCancMov ON
	genCancMov.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venMovImpuestos ON
	venMovImpuestos.venMovimientos = genCancMov.Asiento_Id_AP
	INNER JOIN venImpuestos on 
	venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	INNER JOIN venSubTipoMov ON 
	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon =tesRengMovi.conRenglon
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN conCuentas ON 
	conCuentas.conCuentas = venImpuestos.Cuenta_Id
	INNER JOIN conCuentas CtaReversion ON 
	CtaReversion.conCuentas = venImpuestos.CtaReversion
	INNER JOIN conAsientos as conAsientosCom ON
	conAsientosCom.conAsientos = genCancMov.Asiento_Id_AP
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos genAsiSegmentosCOM ON
	genAsiSegmentosCom.Asiento_Id = conAsientosCom.conAsientos
	INNER JOIN venClientes  ON
		venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN venMovimientos AS FACTURA ON 
	FACTURA.venMovimientos = genCancMov.Asiento_Id_AP
	INNER JOIN genMonedas ON conAsientosCom.Moneda_Id = genMonedas.genMonedas
	inner join conAsientos  conAsientosF on conAsientosF.conAsientos = FACTURA.venMovimientos
	Where
		conMovCont.TipoMov = 2 and  
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 AND 
		conAsientosF.Anulado = 0 AND 
		conAsientosF.Posteado = 1 AND 
		conAsientos.Empresa_Id = @Empresa and 
		genCancMov.FechaAplicacion  between @FechaDesde And @FechaHasta and 
		venImpuestos.PorVencimiento = 1 AND 
		conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id and 
		not exists(select 1 from tesRengConciliac WHERE
			tesRengConciliac.tesMovimientos = tesRengMovi.tesMovimientos and 
			tesRengConciliac.conRenglon = tesRengMovi.conRenglon) and
		not exists(select 1 from tesCTlink WHERE
			tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos and 
			tesCTlink.conRenglon = tesRengMovi.conRenglon) 

-- DEPOSITOS POR IDENTIFICAR COBRADOS BANCO
UNION ALL
SELECT tesConciliacion.FechaConciliacion AS Fecha,
	NULL as venMovimientos, tesMovimientos.tesMovimientos, 
	venImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	tesDepoPorIdentImp.BaseImponible as BaseImponible, 
	tesDepoPorIdentImp.Importe * conAsientos.Cambio as Monto, 
	conMovCont.Importe as TotalCobro, 
	'' Cliente_Id, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
		'' as venSegmento ,
		tesIdBancoPropio.Cartera_Id as Banco_Id, 
		tesRengMovi.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		tesRengMovi.Cambio as CambioCobra, conAsientos.Cambio*0 as DifCambio
FROM tesDepoPorIdent 
	INNER JOIN  tesDepoPorIdentImp ON tesDepoPorIdent.tesMovimientos = tesDepoPorIdentImp.tesMovimientos
	inner join conAsientos ON  conAsientos.conAsientos = tesDepoPorIdent.tesMovimientos
	INNER JOIN venImpuestos  ON venImpuestos.venImpuestos =tesDepoPorIdentImp.Impuesto_Id
	INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesDepoPorIdentImp.tesMovimientos AND 
			tesRengMovi.TipomovCont = 1
	INNER JOIN tesIdentifica ON  tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN conMovCont ON  conMovCont.conAsientos =tesRengMovi.tesMovimientos and 
		conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN tesRengConcilEsp ON 	tesRengConcilEsp.tesMovimientos =tesRengMovi.tesMovimientos and 
		tesRengConcilEsp.conRenglon = tesRengMovi.conRenglon
	INNER JOIN tesConciliacion ON  tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc AND 
			tesConciliacion.tesIdentifica = tesRengConcilEsp.tesIdentifica
	INNER JOIN tesMovimientos ON  tesMovimientos.tesMovimientos =tesRengMovi.tesMovimientos
	INNER JOIN tesIdentifica tesIdBancoPropio on  tesIdBancoPropio.tesIdentifica =tesRengConcilEsp.tesIdentifica
	inner join conCuentas ON  conCuentas.conCuentas = venImpuestos.Cuenta_Id
	inner join conCuentas CtaReversion ON  CtaReversion.conCuentas = venImpuestos.CtaReversion
	INNER JOIN genAsiSegmentos ON  genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
	INNER JOIN genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id
WHERE
		conAsientos.Posteado = 1 AND 
		conAsientos.Anulado = 0 AND 
		conAsientos.Empresa_Id = @Empresa and 
		tesConciliacion.FechaConciliacion between @FechaDesde And @FechaHasta and 
		venImpuestos.PorVencimiento = 1 AND 
		conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id

-- la reversion del anterior cuando ya lo identifica
UNION ALL
SELECT genCancMov.FechaAplicacion AS Fecha,
	conAsientosR.conAsientos as venMovimientos, conAsientos.conAsientos tesMovimientos, 
	venImpuestos.Impuesto_Id, tesIdentifica.Cartera_Id, 
	CONVERT(Numeric(18,2),-tesDepoPorIdentImp.BaseImponible * conAsientos.Cambio / venMovimientos.Importe * genCancMov.Importe) 	as BaseImponible, 
	CONVERT(Numeric(18,2),-tesDepoPorIdentImp.Importe * conAsientos.Cambio / venMovimientos.Importe * genCancMov.Importe) as Monto, 
	CONVERT(Numeric(18,2),-conMovCont.Importe/ venMovimientos.Importe * genCancMov.Importe) as TotalCobro, 
	venClientes.Cliente_Id, conCuentas.Cuenta_Id, CtaReversion.Cuenta_Id as CtaReversion,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, 
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as tesSegmento ,
	dbo.Segmento(genAsiSegmentosCom.Segmento_Id, genAsiSegmentosCom.Segmento1C,genAsiSegmentosCom.Segmento2C, 
		genAsiSegmentosCom.Segmento3C, genAsiSegmentosCom.Segmento4C, genAsiSegmentosCom.Segmento1N,genAsiSegmentosCom.Segmento2N, 
		genAsiSegmentosCom.Segmento3N, genAsiSegmentosCom.Segmento4N)   as venSegmento ,
		tesIdBancoPropio.Cartera_Id as Banco_Id, 
		conAsientos.Cambio as CambioFact, genMonedas.Moneda_Id as Moneda_Id, 
		conAsientos.Cambio as CambioCobra, conAsientos.Cambio*0 as DifCambio
FROM tesDepoPorIdent 
	INNER JOIN  tesDepoPorIdentImp ON tesDepoPorIdent.tesMovimientos = tesDepoPorIdentImp.tesMovimientos
	inner join conAsientos  conAsientosR on conAsientosR.conAsientos =tesDepoPorIdent.venMovimientos
	INNER JOIN genCancMov ON  genCancMov.Asiento_Id_ap = conAsientosR.conAsientos
	inner join conAsientos AS Factura on  Factura.conAsientos = genCancMov.Asiento_Id
	inner join genAsiSegmentos genAsiSegmentosCom ON genAsiSegmentosCom.Asiento_Id =Factura.conAsientos
	INNER JOIN venMovimientos ON  venMovimientos.venMovimientos=conAsientosR.conAsientos
	INNER JOIN venClientes ON  venClientes.genEntidades =venMovimientos.Cliente_Id
	inner join conAsientos ON  conAsientos.conAsientos = tesDepoPorIdent.tesMovimientos
	INNER JOIN venImpuestos  ON venImpuestos.venImpuestos =tesDepoPorIdentImp.Impuesto_Id
	INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesDepoPorIdentImp.tesMovimientos AND 
			tesRengMovi.TipomovCont = 1
	INNER JOIN tesIdentifica ON  tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN conMovCont ON  conMovCont.conAsientos =tesRengMovi.tesMovimientos and 
		conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN tesRengConcilEsp ON 	tesRengConcilEsp.tesMovimientos =tesRengMovi.tesMovimientos and 
		tesRengConcilEsp.conRenglon = tesRengMovi.conRenglon
	INNER JOIN tesConciliacion ON  tesConciliacion.NumeroConc = tesRengConcilEsp.NumeroConc AND 
			tesConciliacion.tesIdentifica = tesRengConcilEsp.tesIdentifica
	INNER JOIN tesMovimientos ON  tesMovimientos.tesMovimientos =tesRengMovi.tesMovimientos
	INNER JOIN tesIdentifica tesIdBancoPropio on  tesIdBancoPropio.tesIdentifica =tesRengConcilEsp.tesIdentifica
	inner join conCuentas ON  conCuentas.conCuentas = venImpuestos.Cuenta_Id
	inner join conCuentas CtaReversion ON  CtaReversion.conCuentas = venImpuestos.CtaReversion
	INNER JOIN genAsiSegmentos ON  genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
	INNER JOIN genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id

WHERE
		conAsientos.Posteado = 1 AND 
		conAsientos.Anulado = 0 AND 
		conAsientosR.Posteado = 1 AND 
		conAsientosR.Anulado = 0 AND 
		Factura.Posteado = 1 AND 
		Factura.Anulado = 0 AND 
		conAsientos.Empresa_Id = @Empresa and 
		genCancMov.FechaAplicacion between @FechaDesde And @FechaHasta and 
		venImpuestos.PorVencimiento = 1 AND 
		conCuentas.Cuenta_Id <>  CtaReversion.Cuenta_Id

ORDER BY 1
GO



