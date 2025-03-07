-- EXEC conPolizasElectroMxDatos 1, '20190101','20191130'
drop procedure conPolizasElectroMxDatos
GO

CREATE procedure conPolizasElectroMxDatos
(
	@Empresa_Id Int, 
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@TipoSolicitud  VarChar(2),
	@NumOrden  VarChar(13), 
	@NumTramite VarChar(10), 
	@Sello VarChar(max) =NULL, 
	@noCertificado varchar(20) = NULL, 
	@Certificado VarChar(max) = NULL
)
as

Select YEAR(@FechaHasta) Anio, MONTH(@FechaHasta) Mes,  @TipoSolicitud TipoSolicitud, @NumOrden NumOrden , 
	@NumTramite NumTramite, @Sello Sello, @noCertificado noCertificado, @Certificado Certificado

SELECT conAsientos.conAsientos,
	genSegmentos.Segmento_Id + '-'+ 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) AS NumUnidenPol,
		conASientos.Fecha, 
			rtrim(genSegmentos.Descripcion) + '-' +
			ISNULL(conAsientosCon.LeyendaLibroDiario, disFormularios.Descripcion) as Concepto
	
from genAsiSegmentos INNER JOIN genSegmentos ON 
	genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN disFormularios ON 
		disFormularios.disFormularios = conAsientos.Formulario_Id
	LEFT JOIN conAsientosCon ON 
		conAsientosCon.conAsientos = conAsientos.conAsientos
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
ORDER BY 3,2	

-- Transaccion

SELECT conAsientos.conAsientos,	conMovCont.Renglon, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	case when ISNULL(conMovCont.LeyendaLibroMayor,' ') = ' ' Then 
		rtrim(genSegmentos.Descripcion) + '-' + disFormularios.Descripcion 
		else conMovCont.LeyendaLibroMayor end  as Concepto, 
	case when conMovCont.Tipomov = 1 then conMovCont.importe else 0 end as Debe,	
	case when conMovCont.Tipomov = 2 then conMovCont.importe else 0 end as Haber
from conAsientos inner join conMovCont ON
	conAsientos.conAsientos = conMovCont.conAsientos
	inner join conCuentas ON 
		conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN genAsiSegmentos ON
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON 
	genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
	INNER JOIN disFormularios ON 
		disFormularios.disFormularios = conAsientos.Formulario_Id
WHERE
	conMovCont.importe <> 0 and
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
ORDER BY 1,2


-- ComNal
SELECT conAsientos.conAsientos,	venMovimientosFiscal.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, venMovimientos.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join venMovimientosFiscal ON
	conAsientos.conAsientos = venMovimientosFiscal.venMovimientos
	INNER JOIN venMovimientos ON
	venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id

WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
UNION ALL -- Cobranzas 
SELECT conAsientos.conAsientos,	venMovimientosFiscal.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.Asiento_Id_Ap = conAsientos.conAsientos
	INNER JOIN venMovimientosFiscal ON
	genCancMov.Asiento_Id = venMovimientosFiscal.venMovimientos
	INNER JOIN venMovimientos ON
	venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id

WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
-- Aplicacion en Ventas
UNION ALL
SELECT conAsientos.conAsientos,	venMovimientosFiscal.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsientoApli_Id = conAsientos.conAsientos
	INNER JOIN venMovimientosFiscal ON
	genCancMov.Asiento_Id = venMovimientosFiscal.venMovimientos
	INNER JOIN venMovimientos ON
	venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id

WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
UNION ALL
SELECT conAsientos.conAsientos,	venMovimientosFiscal.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsientoApli_Id = conAsientos.conAsientos
	INNER JOIN venMovimientosFiscal ON
	genCancMov.Asiento_Id_Ap = venMovimientosFiscal.venMovimientos
	INNER JOIN venMovimientos ON
	venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
-- Diferencias en Cambios
UNION ALL
SELECT conAsientos.conAsientos,	venMovimientosFiscal.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
	INNER JOIN venMovimientosFiscal ON
	genCancMov.Asiento_Id_Ap = venMovimientosFiscal.venMovimientos
	INNER JOIN venMovimientos ON
	venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id

WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
UNION ALL
SELECT conAsientos.conAsientos,	venMovimientosFiscal.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
	INNER JOIN venMovimientosFiscal ON
	genCancMov.Asiento_Id = venMovimientosFiscal.venMovimientos
	INNER JOIN venMovimientos ON
	venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
-- Movimientos de Proveedores Nacionales
UNION ALL
SELECT conAsientos.conAsientos,	comMovProv.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, comMovProv.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join comMovProv ON
	conAsientos.conAsientos = comMovProv.comMovProv
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =comMovProv.Proveed_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
	INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id

WHERE
	genEmpresas.Pais_Id = comProveedores.Pais and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
UNION ALL -- Pagos 
SELECT conAsientos.conAsientos,	comMovProv.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.Asiento_Id = conAsientos.conAsientos
	INNER JOIN comMovProv ON
	genCancMov.Asiento_Id_Ap = comMovProv.comMovProv
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =comMovProv.Proveed_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
	INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE
	comMovprov.ClaveFiscal IS NOT NULL AND 
	genEmpresas.Pais_Id = comProveedores.Pais and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta

-- Aplicacion en Compras
UNION ALL
SELECT conAsientos.conAsientos,	comMovProv.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsientoApli_Id = conAsientos.conAsientos
	INNER JOIN comMovProv ON
	genCancMov.Asiento_Id_ap = comMovProv.comMovProv
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =comMovProv.Proveed_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
	INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE
	genEmpresas.Pais_Id = comProveedores.Pais and 
	comMovprov.ClaveFiscal IS NOT NULL AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
UNION ALL
SELECT conAsientos.conAsientos,	comMovProv.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsientoApli_Id = conAsientos.conAsientos
	INNER JOIN comMovProv ON
	genCancMov.Asiento_Id = comMovProv.comMovProv
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =comMovProv.Proveed_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
	INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE
	genEmpresas.Pais_Id = comProveedores.Pais and 
	comMovprov.ClaveFiscal IS NOT NULL AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
-- Diferencias en Cambios
UNION ALL
SELECT conAsientos.conAsientos,	comMovProv.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
	INNER JOIN comMovProv ON
	genCancMov.Asiento_Id_ap = comMovProv.comMovProv
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =comMovProv.Proveed_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
	INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE
	genEmpresas.Pais_Id = comProveedores.Pais and 
	comMovprov.ClaveFiscal IS NOT NULL AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
UNION ALL
SELECT conAsientos.conAsientos,	comMovProv.ClaveFiscal as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
	INNER JOIN comMovProv ON
	genCancMov.Asiento_Id = comMovProv.comMovProv
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =comMovProv.Proveed_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
	INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE
	genEmpresas.Pais_Id = comProveedores.Pais and 
	comMovprov.ClaveFiscal IS NOT NULL AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
-- FIN PROVEDORES
-- Complementos de Pago
UNION ALL
SELECT conAsientos.conAsientos,	tesCFDICobranza.UUID as UUID_CFDI,
	genEntidades.Cuit AS RFC, venMovimientos.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join venMovimientos ON 
	venMovimientos.venMovimientos =conAsientos.conAsientos
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN tesCFDICobranzaCuerpo ON	tesCFDICobranzaCuerpo.tesMovimientos = conAsientos.conAsientos
	INNER JOIN tesCFDICobranza ON tesCFDICobranza.tesCFDICobranza = tesCFDICobranzaCuerpo.tesCFDICobranza
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
-- Aplicacion en Ventas
UNION ALL
SELECT conAsientos.conAsientos,	tesCFDICobranza.UUID as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsientoApli_Id = conAsientos.conAsientos
	INNER JOIN tesCFDICobranzaCuerpo ON
	genCancMov.Asiento_Id_ap = tesCFDICobranzaCuerpo.tesMovimientos
	INNER JOIN tesCFDICobranza ON
	tesCFDICobranza.tesCFDICobranza = tesCFDICobranzaCuerpo.tesCFDICobranza
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =tesCFDICobranza.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
-- Diferencias en Cambios
UNION ALL
SELECT conAsientos.conAsientos,	tesCFDICobranza.UUID as UUID_CFDI,
	genEntidades.Cuit AS RFC, genCancMov.Importe as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join genCancMov ON 
	genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
	INNER JOIN tesCFDICobranzaCuerpo ON
	genCancMov.Asiento_Id_Ap = tesCFDICobranzaCuerpo.tesMovimientos
	INNER JOIN tesCFDICobranza ON 
	tesCFDICobranza.tesCFDICobranza =  tesCFDICobranzaCuerpo.tesCFDICobranza
	INNER JOIN genEntidades ON
	genEntidades.genEntidades =tesCFDICobranza.Cliente_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
--- FIN COMPLEMENTO DE PAGO
-- NOMINAS
UNION ALL
SELECT conAsientos.conAsientos,	sueNominaCfdi.UUID as UUID_CFDI,
	genEntidades.Cuit AS RFC, 
	SUM(sueTerminada.Importe * sueTerminada.Signo)	 as MontoTotal, 
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb
from conAsientos inner join sueNominaCfdi ON 
	sueNominaCfdi.sueLiquidacion = conAsientos.conAsientos
	INNER JOIN genEntidades ON
	genEntidades.genEntidades = sueNominaCfdi.Legajo
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN sueTerminada ON 
	sueTerminada.sueLiquidacion =  sueNominaCfdi.sueLiquidacion 
WHERE
	sueTerminada.Signo <> 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
group by conAsientos.conAsientos,	sueNominaCfdi.UUID ,
	genEntidades.Cuit , genMonedas.CodigoFiscal , conAsientos.Cambio 


ORDER BY 1,2

-- CFD Ya no tengo

SELECT conAsientos.conAsientos,  ' ' AS CFD_CBB_Serie, 0 AS CFD_CBB_NumFol, ' ' as RFC, 0.00 AS MontoTotal, 
	' ' as Moneda, 0.00 as TipCamb
from conAsientos
where 1= 2
	

-- Extranjero

SELECT conAsientos.conAsientos,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) AS NumFactExt,
	genEntidades.IdFiscal as TxtId, comMovProv.Importe as MontoTotal,
	genMonedas.CodigoFiscal as Moneda, conAsientos.Cambio as TipCamb	
from genAsiSegmentos INNER JOIN genSegmentos ON 
	genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN comMovProv ON comMovProv.comMovProv = conAsientos.conAsientos 
	INNER JOIN genEntidades ON genEntidades.genEntidades = comMovProv.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comProveedores ON  comProveedores.genEntidades = comMovProv.Proveed_Id
	inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE
	genEmpresas.Pais_Id <> comProveedores.Pais and
	comMovprov.Tipomov NOT IN ('P','C') AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta	
Order By 1,2

-- Cheques

SELECT conAsientos.conAsientos,  tesBPlink.conRenglon, 
	LTRIM(STR(tesChequeras.Chequera_Id,8))+'-' +  LTRIM(STR(tesCheqProp.numCheque,9)) as Num, 
			tesBancos.Banco_Id as BanEmisNal, 
			tesIdBancoPropio.Referencia BanEmisExt, tesIdBancoPropio.numCuenta CtaOri, 
			tesCheqProp.FechaVencimiento Fecha, tesCheqProp.aLaOrden Benef, tesCheqProp.Cuit as Rfc, 
			conMovCont.ImporteMonedaOriginal as Importe, genMonedas.Moneda_Id , 
				case when genMonedas.genMonedas = genEmpresas.Medida_Id then 1 else 
					conAsientos.Cambio END TipCamb
from conAsientos INNER JOIN tesMovimientos ON
	conAsientos.conAsientos = tesMovimientos.tesMovimientos 
	INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos 
	INNER JOIN conMovCont ON  conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
							  conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN  tesIdBancoPropio ON tesIdBancoPropio.Cartera_Id = tesRengMovi.Cartera_Id
	INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	LEFT JOIN tesBancos ON tesBancos.tesBancos = tesIdBancoPropio.Banco_Id
	INNER JOIN tesBPlink ON tesBPlink.tesmovimientos = tesRengMovi.tesMovimientos AND 
							tesBPlink.conRenglon = tesRengMovi.conRenglon 
	INNER JOIN  tesCheqProp ON tesCheqProp.tesCheqProp = tesBPlink.tesCheqProp
	INNER JOIN tesChequeras ON tesChequeras.Chequera_Id = tesCheqProp.Chequera_Id and 
								tesChequeras.Cartera_Id = tesCheqProp.Cartera_Id
	INNER JOIN genMonedas ON  genMonedas.genMonedas = tesIdentifica.Moneda_Id
	inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
where
	tesChequeras.TipoChequera = 'M' AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta	
Order By 1,2
				

-- Transferencia

SELECT conAsientos.conAsientos,  tesBPlink.conRenglon, 
		tesIdBancoPropio.numCuenta CtaOri,	tesBancos.Banco_Id as BanEmisNal, 
			tesIdBancoPropio.Referencia BanEmisExt, 
			tesCheqProp.CuentaDestino as CtaDest, 
			tesBancosDes.Banco_Id as BancoDestNal, tesCheqProp.BancoDestinoExt BancoDestExt,
			tesCheqProp.FechaVencimiento Fecha, tesCheqProp.aLaOrden Benef, tesCheqProp.Cuit as Rfc, 
			conMovCont.ImporteMonedaOriginal as Importe, genMonedas.Moneda_Id , 
				case when genMonedas.genMonedas = genEmpresas.Medida_Id then 1 else 
					conAsientos.Cambio END TipCamb
from conAsientos INNER JOIN tesMovimientos ON
	conAsientos.conAsientos = tesMovimientos.tesMovimientos 
	INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos 
	INNER JOIN conMovCont ON  conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
							  conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN  tesIdBancoPropio ON tesIdBancoPropio.Cartera_Id = tesRengMovi.Cartera_Id
	INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	LEFT JOIN tesBancos ON tesBancos.tesBancos = tesIdBancoPropio.Banco_Id
	INNER JOIN tesBPlink ON tesBPlink.tesmovimientos = tesRengMovi.tesMovimientos AND 
							tesBPlink.conRenglon = tesRengMovi.conRenglon 
	INNER JOIN  tesCheqProp ON tesCheqProp.tesCheqProp = tesBPlink.tesCheqProp
	INNER JOIN tesChequeras ON tesChequeras.Chequera_Id = tesCheqProp.Chequera_Id and 
								tesChequeras.Cartera_Id = tesCheqProp.Cartera_Id
	INNER JOIN genMonedas ON  genMonedas.genMonedas = tesIdentifica.Moneda_Id
	inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
	LEFT JOIN tesBancos tesBancosDes on tesBancosDes.tesBancos = tesCheqProp.BancoDestino
where
	tesChequeras.TipoChequera = 'B' AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta	
Order By 1,2

-- Metodos de Pago otros distintos a Cheque o Transferencia


SELECT conAsientos.conAsientos,  tesRengMovi.conRenglon, 
		tesIdentifica.FormaDePagoP MetPagoPol,
			conAsientos.Fecha,  comProveedores.RazonSocial as Benef, 
			genEntidades.Cuit as Rfc, conMovCont.ImporteMonedaOriginal as Importe, 
			genMonedas.Moneda_Id , 
				case when genMonedas.genMonedas = genEmpresas.Medida_Id then 1 else 
					conAsientos.Cambio END TipCamb
from conAsientos INNER JOIN tesMovimientos ON
	conAsientos.conAsientos = tesMovimientos.tesMovimientos 
	INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos 
	INNER JOIN conMovCont ON  conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
							  conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	
	INNER JOIN genMonedas ON  genMonedas.genMonedas = tesIdentifica.Moneda_Id
	inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
	Inner join comMovProv ON  comMovProv.comMovProv = conAsientos.conAsientos 
	INNER JOIN genEntidades ON  genEntidades.genEntidades = comMovProv.Proveed_Id
	INNER JOIN comProveedores ON comProveedores.genEntidades = genEntidades.genEntidades
where
	not exists(SELECT 1 FROM tesBPlink WHERE 
			tesBPlink.tesmovimientos = tesRengMovi.tesMovimientos AND 
			tesBPlink.conRenglon = tesRengMovi.conRenglon ) AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta	
Order By 1,2



