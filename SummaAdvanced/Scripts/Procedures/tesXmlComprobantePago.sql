--select * from tesCFDICobranza

-- SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED


-- tesXmlComprobantePagoDatos 23544,1



DROP PROCEDURE tesXmlComprobantePagoDatos
GO

CREATE PROCEDURE tesXmlComprobantePagoDatos(	
	@TesCFDICobranza int, 
	@Empresa_Id INT
)

as

-- Comprobante
SELECT '3.3' as Version, 
	TesCFDICobranzaSegmentos.Segmento1C as Serie, 
	 TesCFDICobranzaSegmentos.Segmento1N as Folio, TesCFDICobranza.Fecha as Fecha,
	 TesCFDICobranzaSegmentos.TesCFDICobranza,
		'pago' as MetodoPago, 
		CASE WHEN ISNULL(TesCFDICobranza.NoCertificado,' ')=' ' THEN
		(SELECT cValor FROM genGlobales WHERE NOMBRE_VAR = 'VENNOCERTIFICADO' and Empresa_Id =@Empresa_Id) ELSE
		TesCFDICobranza.NoCertificado END AS NoCertificado, 
		convert(VarChar(max),(SELECT mValor FROM genGlobales where Nombre_var = 'GENWSAAPUBLICKEY' and Empresa_Id=@Empresa_Id)) AS Certificado,
		' ' as CondicionesDePago, 
		Convert(Numeric(18,2) , 0) as SubTotal,
		Convert(Numeric(18,2) , 0) as Descuento, 		
		genMonedas.CodigoFiscal as Moneda,
		Convert(Numeric(18,2) , 0) as Total,
		Convert(Numeric(18,2) , 0) as TipoCambio,
		'P' as TipoDeComprobante, 
		'NA' as  FormaPago, 
		genSucursalesEmpr.CodigoPostal as LugarExpedicion, ' ' Confirmacion
from TesCFDICobranza INNER JOIN genMonedas ON 
TesCFDICobranza.Moneda_Id = genMonedas.genMonedas
INNER JOIN genSucursalesEmpr ON
genSucursalesEmpr.genSucursalesEmpr = TesCFDICobranza.Sucursal
INNER JOIN TesCFDICobranzaSegmentos ON 
TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranza.TesCFDICobranza
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
Where
	TesCFDICobranzaSegmentos.TesCFDICobranza = @TesCFDICobranza 

-- Emisor
SELECT 
genEmpresas.Cuit AS Rfc,
genEmpresas.RazonSocial AS Nombre,
genEmpresas.Regimen AS RegimenFiscal,
Convert(VarChar(max),(select mValor from genGlobales where Nombre_var = 'GENWSAAPRIVATEKEY' and Empresa_Id=@Empresa_Id)) AS EmpPrivateKey,
genEmpresas.Calle AS Calle,
genEmpresas.NoExterior AS NroExterior,
genEmpresas.NoInterior as NroInterior,
genEmpresas.Localidad,
genEmpresas.Colonia,
genEmpresas.Municipio,
genProvincias.CodFiscal AS Provincia,
'MEX' AS Pais,
genEmpresas.CodigoPostal
FROM genEmpresas INNER JOIN genProvincias ON
genProvincias.genProvincias = genEmpresas.Provincia_Id
WHERE genEmpresas.genEmpresas = @Empresa_Id

-- Receptor

SELECT 
ISNULL((select MAX(Convert(VarChar(14),tesDeposito.RfcEmisorCtaOrd))
	from tesDeposito, tesCFDICobranzaCuerpo, tesBancos 
	WHERE	
	tesDeposito.tesMovimientos = tesCFDICobranzaCuerpo.tesMovimientos and 
	tesDeposito.FormaDePagoP = '17' and 
	tesBancos.RFC = tesDeposito.RfcEmisorCtaOrd and 
	tesCFDICobranzaCuerpo.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza),genEntidades.Cuit)  AS Rfc, 
	ISNULL((select MAX(tesBancos.Descripcion)
	from tesDeposito, tesCFDICobranzaCuerpo, tesBancos 
	WHERE	
	tesDeposito.tesMovimientos = tesCFDICobranzaCuerpo.tesMovimientos and 
	tesDeposito.FormaDePagoP = '17' and 
	tesBancos.RFC = tesDeposito.RfcEmisorCtaOrd and 
	tesCFDICobranzaCuerpo.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza),venClientes.RazonSocial) as Nombre, 
	genPaises.CodFiscal AS ResidenciaFiscal,
	' '  AS NumRegIdTrib,
	'P01' as UsoCfdi, 
	venClieHabitual.Direccion1_Fact Calle , venClieHabitual.NroExterior_Fact NroExterior, 
	venClieHabitual.NroInterior_Fact NroInterior, venClieHabitual.Direccion2_Fact Colonia,
	venClieHabitual.Localidad_Fact AS Localidad,
	genProvincias.CodFiscal as Provincia, 
	genPaises.CodFiscal as Pais, 
	venClieHabitual.CodPostal_Fact as CodigoPostal, 
	venClientes.Regimen as RegimenFiscalReceptor
from venClientes INNER JOIN TesCFDICobranza ON	
venClientes.genEntidades = TesCFDICobranza.Cliente_id
INNER JOIN genEntidades ON
genEntidades.genEntidades = venClientes.genEntidades
INNER JOIN  venClieHabitual ON 
venClieHabitual.genEntidades = venClientes.genEntidades and
venClieHabitual.Sucursal = venClientes.SucursalPredeter
inner join genPaises ON
venClieHabitual.Pais_id_Fact = genPaises.genPaises
INNER JOIN genProvincias ON
venClieHabitual.Provincia_id_Fact = genProvincias.genProvincias
INNER JOIN TesCFDICobranzaSegmentos ON 
TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranza.TesCFDICobranza
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
Where
	tesCFDICobranza.tesCFDICobranza = @TesCFDICobranza

-- Concepto
SELECT Convert(smallint,1) as Renglon, 
	'84111506' as ClaveProdServ,
	' ' as NoIdentificacion, 
	1.00 AS Cantidad,
	'ACT' AS ClaveUnidad,
	' ' as Unidad,
	'Pago' Descripcion, 			
	Convert(Numeric(18,2) , 0) as ValorUnitario,
	Convert(Numeric(18,2) , 0) as Importe, 
	Convert(Numeric(18,2) , 0) as Descuento	

 
-- Complemento

SELECT '1.1' as Version,  TesCFDICobranza.UUID, 
	TesCFDICobranza.FechaTimbrado, 
	isnull(TesCFDICobranza.RfcProvCertif,' ') as RfcProvCertif,
	isnull(TesCFDICobranza.Leyenda,' ') as Leyenda,
	Convert(VarChar(8000),TesCFDICobranza.SelloDigital) as SelloCFD,
	TesCFDICobranza.NoCertificadoSAT,
	Convert(VarChar(8000),TesCFDICobranza.SelloSAT) as SelloSAT
FROM TesCFDICobranza INNER JOIN TesCFDICobranzaSegmentos ON 
TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranza.TesCFDICobranza
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
WHERE
	tesCFDICobranza.tesCFDICobranza = @TesCFDICobranza


-- Complemento Pago

SELECT  TesCFDICobranzaCuerpo.tesMovimientos,
	dbo.Segmento(genAsiSegmentosCOB.Segmento_Id, genAsiSegmentosCOB.Segmento1C,
	genAsiSegmentosCOB.Segmento2C,genAsiSegmentosCOB.Segmento3C,genAsiSegmentosCOB.Segmento4C,
	genAsiSegmentosCOB.Segmento1N,genAsiSegmentosCOB.Segmento2N,genAsiSegmentosCOB.Segmento3N,
	genAsiSegmentosCOB.Segmento4N) as Comprobante,
	tesMovimientos.Fecha_Real as FechaPago, 
	ISNULL(TesDeposito.FormaDePagoP, tesIdentifica.FormaDePagoP) AS FormaDePagoP,
	MID.CodigoFiscal as MonedaP, 
	case when conAsientos.Moneda_Id != genEmpresas.Moneda_Id
			then tesRengMovi.Cambio else 1 end
		/ Case when genEmpresas.Moneda_Id = MID.genMonedas OR
			genMonedas.Moneda_Id = MID.Moneda_Id 	THEN 1 else conAsientos.cambio end as TipoCambioP, 
			/*
	ROUND(conMovCont.ImporteMonedaOriginal * case when conAsientos.Moneda_Id != tesIdentifica.Moneda_Id
	then tesRengMovi.Cambio else 1 end
	 / Case when genEmpresas.Moneda_Id = MID.genMonedas OR
		genMonedas.Moneda_Id = MID.Moneda_Id 	THEN 1 else conAsientos.cambio end,2 ) */
		conMovCont.ImporteMonedaOriginal as Monto, 
	conMovCont.Importe as MontoMxp,
	case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE TesDeposito.NumOperacion END AS NumOperacion, 
	case when ISNULL(TesDeposito.FormaDePagoP,' ') in ('01','17') THEN ' ' ELSE TesDeposito.RfcEmisorCtaOrd END AS RfcEmisorCtaOrd , 
	TesDeposito.NomBancoOrdExt,TesDeposito.CtaOrdenante,
	case when ISNULL(TesDeposito.FormaDePagoP,' ') in ('01','17') THEN ' ' ELSE ISNULL(tesBancosP.RFC,'') END AS RfcEmisorCtaBen , 
	case when ISNULL(TesDeposito.FormaDePagoP,' ') in ('01','17') THEN ' ' ELSE tesIdBancoPropio.numCuenta END AS CtaBeneficiario, 
	TesDeposito.TipoCadPago, TesDeposito.CertPago, TesDeposito.CadPago, 
	TesDeposito.SelloPago, 
	isnull((select sum(conMovCont1.Importe) 
		From conMovCont as conMovCont1
		WHERE
		conMovCont1.conasientos = conMovCont.conasientos and 
		conMovCont1.tipoMov = 2),0) as TotalPago ,
		conAsientos.cambio as CambioTes
From 
TesCFDICobranzaCuerpo INNER JOIN tesMovimientos ON
TesCFDICobranzaCuerpo.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN venMovimientos ON 
venMovimientos.venMovimientos = tesMovimientos.tesMovimientos
INNER JOIN tesRengMovi ON
tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN tesIdentifica ON
tesRengMovi.Cartera_id = tesIdentifica.tesIdentifica
inner join tesTiposId ON
tesTiposId.tesTiposId = tesIdentifica.TipoCartera
LEFT OUTER JOIN TesDeposito ON
tesRengMovi.tesMovimientos = TesDeposito.tesMovimientos and 
tesRengMovi.conRenglon = TesDeposito.Renglon
INNER JOIN conAsientos ON 
conAsientos.conAsientos = tesMovimientos.tesMovimientos
INNER JOIN conMovCont ON
conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
conMovCont.Renglon = tesRengMovi.conRenglon
INNER JOIN genMonedas ON
genMonedas.genMonedas = conAsientos.Moneda_id
INNER JOIN genMonedas MID on 
MID.genMonedas = tesIdentifica.Moneda_id
LEFT OUTER JOIN tesIdBancoPropio ON
tesIdBancoPropio.Cartera_id = tesIdentifica.tesIdentifica
LEFT OUTER JOIN tesBancos tesBancosP ON
tesBancosP.tesBancos = tesIdBancoPropio.Banco_Id
INNER JOIN TesCFDICobranzaSegmentos ON 
TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaCuerpo.tesCFDICobranza
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
INNER JOIN genAsiSegmentos  as genAsiSegmentosCOB ON
genAsiSegmentosCOB.Asiento_id = tesMovimientos.tesMovimientos
inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE 
	conMovCont.TipoMov = 1 and
	TesCFDICobranzaCuerpo.tesCFDICobranza = @TesCFDICobranza and 
	not exists(select 1 from tesDepoPorIdent WHERE
		tesDepoPorIdent.venMovimientos = tesMovimientos.tesMovimientos)
--- DEPOSITO INDETIFICADO
UNION ALL

SELECT  TesCFDICobranzaCuerpo.tesMovimientos,
	dbo.Segmento(genAsiSegmentosCOB.Segmento_Id, genAsiSegmentosCOB.Segmento1C,
	genAsiSegmentosCOB.Segmento2C,genAsiSegmentosCOB.Segmento3C,genAsiSegmentosCOB.Segmento4C,
	genAsiSegmentosCOB.Segmento1N,genAsiSegmentosCOB.Segmento2N,genAsiSegmentosCOB.Segmento3N,
	genAsiSegmentosCOB.Segmento4N) as Comprobante,
	tesMovimientos.Fecha_Real as FechaPago, 
	ISNULL(TesDeposito.FormaDePagoP, tesIdentifica.FormaDePagoP) AS FormaDePagoP,
	MID.CodigoFiscal as MonedaP, conAsientos.cambio as TipoCambioP, 
	ROUND(conMovCont.ImporteMonedaOriginal * case when conAsientos.Moneda_Id != tesIdentifica.Moneda_Id
	then tesRengMovi.Cambio else 1 end
	 / Case when genEmpresas.Moneda_Id = MID.genMonedas OR
		genMonedas.Moneda_Id = MID.Moneda_Id 	THEN 1 else conAsientos.cambio end,2 ) as Monto, 
	conMovCont.Importe as MontoMxp,
	case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE TesDeposito.NumOperacion END AS NumOperacion, 
	case when ISNULL(TesDeposito.FormaDePagoP,' ') in ('01','17') THEN ' ' ELSE TesDeposito.RfcEmisorCtaOrd END AS RfcEmisorCtaOrd , 
	TesDeposito.NomBancoOrdExt,TesDeposito.CtaOrdenante,
	case when ISNULL(TesDeposito.FormaDePagoP,' ') in ('01','17') THEN ' ' ELSE ISNULL(tesBancosP.RFC,'') END AS RfcEmisorCtaBen , 
	case when ISNULL(TesDeposito.FormaDePagoP,' ') in ('01','17') THEN ' ' ELSE tesIdBancoPropio.numCuenta END AS CtaBeneficiario, 
	TesDeposito.TipoCadPago, TesDeposito.CertPago, TesDeposito.CadPago, 
	TesDeposito.SelloPago, 
	isnull((select sum(conMovCont1.Importe) 
		From conMovCont as conMovCont1
		WHERE
		conMovCont1.conasientos = conMovCont.conasientos and 
		conMovCont1.tipoMov = 2),0) as TotalPago ,
		conAsientos.cambio as CambioTes
From 
tesDepoPorIdent inner join tesMovimientos ON
tesMovimientos.tesMovimientos = tesDepoPorIdent.venMovimientos
INNER JOIN TesCFDICobranzaCuerpo ON
TesCFDICobranzaCuerpo.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN venMovimientos ON 
venMovimientos.venMovimientos = tesDepoPorIdent.venMovimientos
INNER JOIN tesRengMovi ON
tesRengMovi.tesMovimientos = tesDepoPorIdent.tesMovimientos
INNER JOIN tesIdentifica ON
tesRengMovi.Cartera_id = tesIdentifica.tesIdentifica
inner join tesTiposId ON
tesTiposId.tesTiposId = tesIdentifica.TipoCartera
LEFT OUTER JOIN TesDeposito ON
tesRengMovi.tesMovimientos = TesDeposito.tesMovimientos and 
tesRengMovi.conRenglon = TesDeposito.Renglon
INNER JOIN conAsientos ON 
conAsientos.conAsientos = tesMovimientos.tesMovimientos
INNER JOIN conMovCont ON
conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
conMovCont.Renglon = tesRengMovi.conRenglon
INNER JOIN genMonedas ON
genMonedas.genMonedas = conAsientos.Moneda_id
INNER JOIN genMonedas MID on 
MID.genMonedas = tesIdentifica.Moneda_id
LEFT OUTER JOIN tesIdBancoPropio ON
tesIdBancoPropio.Cartera_id = tesIdentifica.tesIdentifica
LEFT OUTER JOIN tesBancos tesBancosP ON
tesBancosP.tesBancos = tesIdBancoPropio.Banco_Id
INNER JOIN TesCFDICobranzaSegmentos ON 
TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaCuerpo.tesCFDICobranza
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
INNER JOIN genAsiSegmentos  as genAsiSegmentosCOB ON
genAsiSegmentosCOB.Asiento_id = tesMovimientos.tesMovimientos
inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
WHERE 
	conMovCont.TipoMov = 1 and
	TesCFDICobranzaCuerpo.tesCFDICobranza = @TesCFDICobranza 

ORDER BY 1,2,3

-- comppago cuerpo	
SELECT TesCFDICobranzaCuerpo.tesMovimientos, venMovimientosFiscal.venMovimientos,
	venMovimientosFiscal.ClaveFiscal AS idDocumento, genAsiSegmentos.Segmento2C+genAsiSegmentos.Segmento3C as Serie, 
		genAsiSegmentos.Segmento1N as Folio, genMonedas.CodigoFiscal MonedaDR, 
		case when genMonedas.genMonedas = Cobranza.Moneda_Id then Cobranza.Cambio else
		conAsientos.Cambio end	as TipoCambioDR, 
	venMovimientosMetodoPago.NMetodoPago as MetodoPago , 
		ISNULL((SELECT COUNT(1) FROM genCancMov genCancMov1, conAsientos where 
		conAsientos.conAsientos = 	genCancMov1.Asiento_id_Ap and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		genCancMov.Asiento_Id = genCancMov1.Asiento_Id and 
		((genCancMov1.FechaAplicacion < genCancMov.FechaAplicacion) or
		(genCancMov.FechaAplicacion = genCancMov1.FechaAplicacion and 
		genCancMov1.Asiento_Id_Ap < genCancMov.Asiento_Id_Ap))),0)+1  as NumParcialidad , 
		venMovimientos.Importe - 
		ISNULL((SELECT SUM(genCancMov1.Importe) FROM genCancMov genCancMov1, conAsientos where 
		conAsientos.conAsientos = 	genCancMov1.Asiento_id_Ap and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		genCancMov.Asiento_Id = genCancMov1.Asiento_Id and 
		((genCancMov1.FechaAplicacion < genCancMov.FechaAplicacion) or
		(genCancMov.FechaAplicacion = genCancMov1.FechaAplicacion and 
		genCancMov1.Asiento_Id_Ap < genCancMov.Asiento_Id_Ap))),0)  as ImpSaldoAnt, 
		genCancMov.Importe as ImpPagado, 
		venMovimientosMetodoPago.NMetodoPago TipoPago
FROM 
	TesCFDICobranzaCuerpo inner join genCancMov ON
	TesCFDICobranzaCuerpo.tesMovimientos = genCancMov.Asiento_Id_Ap
	INNER JOIN  venMovimientos  ON
	genCancMov.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venMovimientosFiscal ON
	venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN venMovimientosMetodoPago ON
	venMovimientosMetodoPago.venMovimientos =  venMovimientos.venMovimientos
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = venMovimientos.venMovimientos
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join venCondPago ON
	venCondPago.venCondPago = venMovimientos.CondPagoCli_id
	inner join tesMovimientos ON
	TesCFDICobranzaCuerpo.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN TesCFDICobranzaSegmentos ON 
	TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaCuerpo.TesCFDICobranza
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
	INNER JOIN conAsientos AS Cobranza on Cobranza.conasientos = tesMovimientos.tesMovimientos


WHERE
	venMovimientosMetodoPago.NMetodoPago = 'PPD' AND 
	TesCFDICobranzaCuerpo.tesCFDICobranza = @TesCFDICobranza and 
	not exists(select 1 from tesDepoPorIdent WHERE
		tesDepoPorIdent.venMovimientos = tesMovimientos.tesMovimientos)
--- DEPOSITO INDETIFICADO
UNION ALL
SELECT TesCFDICobranzaCuerpo.tesMovimientos, venMovimientosFiscal.venMovimientos,
	venMovimientosFiscal.ClaveFiscal AS idDocumento, genAsiSegmentos.Segmento2C+genAsiSegmentos.Segmento3C as Serie, 
		genAsiSegmentos.Segmento1N as Folio, genMonedas.CodigoFiscal MonedaDR, 
		case when genMonedas.genMonedas = Cobranza.Moneda_Id then Cobranza.Cambio else
		conAsientos.Cambio end	as TipoCambioDR, 
	venMovimientosMetodoPago.NMetodoPago as MetodoPago , 
		ISNULL((SELECT COUNT(1) FROM genCancMov genCancMov1, conAsientos where 
		conAsientos.conAsientos = 	genCancMov1.Asiento_id_Ap and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		genCancMov.Asiento_Id = genCancMov1.Asiento_Id and 
		((genCancMov1.FechaAplicacion < genCancMov.FechaAplicacion) or
		(genCancMov.FechaAplicacion = genCancMov1.FechaAplicacion and 
		genCancMov1.Asiento_Id_Ap < genCancMov.Asiento_Id_Ap))),0)+1  as NumParcialidad , 
		venMovimientos.Importe - 
		ISNULL((SELECT SUM(genCancMov1.Importe) FROM genCancMov genCancMov1, conAsientos where 
		conAsientos.conAsientos = 	genCancMov1.Asiento_id_Ap and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		genCancMov.Asiento_Id = genCancMov1.Asiento_Id and 
		((genCancMov1.FechaAplicacion < genCancMov.FechaAplicacion) or
		(genCancMov.FechaAplicacion = genCancMov1.FechaAplicacion and 
		genCancMov1.Asiento_Id_Ap < genCancMov.Asiento_Id_Ap))),0)  as ImpSaldoAnt, 
		genCancMov.Importe as ImpPagado, 
		venMovimientosMetodoPago.NMetodoPago TipoPago
FROM 
	tesDepoPorIdent inner join tesMovimientos ON
	tesMovimientos.tesMovimientos = tesDepoPorIdent.venMovimientos
	INNER JOIN TesCFDICobranzaCuerpo ON
	TesCFDICobranzaCuerpo.tesMovimientos = tesMovimientos.tesMovimientos
	inner join genCancMov ON
	TesCFDICobranzaCuerpo.tesMovimientos = genCancMov.Asiento_Id_Ap
	INNER JOIN  venMovimientos  ON
	genCancMov.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venMovimientosFiscal ON
	venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN venMovimientosMetodoPago ON
	venMovimientosMetodoPago.venMovimientos =  venMovimientos.venMovimientos
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = venMovimientos.venMovimientos
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join venCondPago ON
	venCondPago.venCondPago = venMovimientos.CondPagoCli_id
	INNER JOIN TesCFDICobranzaSegmentos ON 
	TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaCuerpo.TesCFDICobranza
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
	INNER JOIN conAsientos AS Cobranza on Cobranza.conasientos = tesMovimientos.tesMovimientos


WHERE
	venMovimientosMetodoPago.NMetodoPago = 'PPD' AND 
	TesCFDICobranzaCuerpo.tesCFDICobranza = @TesCFDICobranza 
ORDER BY 1,2,3		


SELECT '04' as TipoRelacion 

SELECT TesCFDICobranzaRel.tesCFDICobranza, tesCFDICobranza.UUID 
FROM TesCFDICobranzaRel inner join TesCFDICobranza ON 
TesCFDICobranzaRel.tesCFDICobranzaR = TesCFDICobranza.tesCFDICobranza
INNER JOIN TesCFDICobranzaSegmentos ON 
	TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaRel.TesCFDICobranza
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
where
	TesCFDICobranzaRel.tesCFDICobranza = @TesCFDICobranza

-- TOTALES PARA V4


SELECT TesCFDICobranzaCuerpo.tesMovimientos, genCancMov.Asiento_Id as venMovmientos,
		impTipoImpuesto.TipoImpuesto,venImpuestos.Porcentaje,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe <0  AND 
			impTipoImpuesto.CodigoFiscal = 'R1' THEN 
		-venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalRetencionesIVA,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe <0  AND 
			impTipoImpuesto.CodigoFiscal = 'RS' THEN 
		-venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalRetencionesISR,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe <0  AND 
			impTipoImpuesto.CodigoFiscal = 'E2' THEN 
		-venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalRetencionesIEPS,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe <0  AND 
			impTipoImpuesto.CodigoFiscal = 'E2' THEN 
			venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalBaseRetencionesIEPS,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >0  AND 
			impTipoImpuesto.CodigoFiscal = 'I7' THEN 
		venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosBaseIVA16,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >0  AND 
			impTipoImpuesto.CodigoFiscal = 'I7' THEN 
		venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosImpuestoIVA16,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >0  AND 
			impTipoImpuesto.CodigoFiscal = 'IF' THEN 
		venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosBaseIVA8,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >0  AND 
			impTipoImpuesto.CodigoFiscal = 'IF' THEN 
		venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosImpuestoIVA8,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >=0  AND 
			impTipoImpuesto.CodigoFiscal = 'I0' THEN 
		venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosBaseIVA0,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >=0  AND 
			impTipoImpuesto.CodigoFiscal = 'I0' THEN 
		venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosImpuestoIVA0,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >=0  AND 
			impTipoImpuesto.CodigoFiscal = 'EX' THEN 
		venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosBaseIVAExento, 
		case when genMonedas.genMonedas = Cobranza.Moneda_Id then Cobranza.Cambio else 	conAsientos.Cambio end	as TipoCambio
FROM 
	TesCFDICobranzaCuerpo inner join genCancMov ON
	TesCFDICobranzaCuerpo.tesMovimientos = genCancMov.Asiento_Id_Ap
	INNER JOIN  venMovimientos  ON
	genCancMov.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venMovimientosFiscal ON
	venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN venMovimientosMetodoPago ON
	venMovimientosMetodoPago.venMovimientos =  venMovimientos.venMovimientos
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = venMovimientos.venMovimientos
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join venCondPago ON
	venCondPago.venCondPago = venMovimientos.CondPagoCli_id
	inner join tesMovimientos ON
	TesCFDICobranzaCuerpo.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN TesCFDICobranzaSegmentos ON 
	TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaCuerpo.TesCFDICobranza
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
	INNER JOIN conAsientos AS Cobranza on Cobranza.conasientos = tesMovimientos.tesMovimientos
	INNER JOIN venMovImpuestos ON  venMovImpuestos.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN venImpuestos ON  venImpuestos.venImpuestos =venMovImpuestos.Impuesto_Id
	INNER JOIN impTipoImpuesto ON venImpuestos.TipoImpuesto =  impTipoImpuesto.TipoImpuesto
	
WHERE
	TesCFDICobranzaCuerpo.tesCFDICobranza = @TesCFDICobranza and 
	not exists(select 1 from tesDepoPorIdent WHERE
		tesDepoPorIdent.venMovimientos = tesMovimientos.tesMovimientos)
group by TesCFDICobranzaCuerpo.tesMovimientos,genMonedas.genMonedas ,Cobranza.Moneda_Id , Cobranza.Cambio ,conAsientos.Cambio ,
	genCancMov.Asiento_Id,	impTipoImpuesto.TipoImpuesto,venImpuestos.Porcentaje
--- DEPOSITO INDETIFICADO
UNION ALL
SELECT TesCFDICobranzaCuerpo.tesMovimientos, genCancMov.Asiento_Id as venMovmientos,
		impTipoImpuesto.TipoImpuesto,venImpuestos.Porcentaje,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe <0  AND 
			impTipoImpuesto.CodigoFiscal = 'R1' THEN 
		-venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalRetencionesIVA,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe <0  AND 
			impTipoImpuesto.CodigoFiscal = 'RS' THEN 
		-venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalRetencionesISR,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe <0  AND 
			impTipoImpuesto.CodigoFiscal = 'E2' THEN 
		-venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalRetencionesIEPS,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe <0  AND 
			impTipoImpuesto.CodigoFiscal = 'E2' THEN 
			venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalBaseRetencionesIEPS,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >0  AND 
			impTipoImpuesto.CodigoFiscal = 'I7' THEN 
		venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosBaseIVA16,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >0  AND 
			impTipoImpuesto.CodigoFiscal = 'I7' THEN 
		venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosImpuestoIVA16,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >0  AND 
			impTipoImpuesto.CodigoFiscal = 'IF' THEN 
		venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosBaseIVA8,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >0  AND 
			impTipoImpuesto.CodigoFiscal = 'IF' THEN 
		venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosImpuestoIVA8,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >=0  AND 
			impTipoImpuesto.CodigoFiscal = 'I0' THEN 
		venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosBaseIVA0,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >=0  AND 
			impTipoImpuesto.CodigoFiscal = 'I0' THEN 
		venMovImpuestos.Importe * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosImpuestoIVA0,
		SUM(ROUND(CASE WHEN venMovImpuestos.Importe >=0  AND 
			impTipoImpuesto.CodigoFiscal = 'EX' THEN 
		venMovImpuestos.BaseImponible * genCancMov.Importe / venMovimientos.Importe ELSE 0 END,2)) AS TotalTrasladosBaseIVAExento, 
		case when genMonedas.genMonedas = Cobranza.Moneda_Id then Cobranza.Cambio else 	conAsientos.Cambio end	as TipoCambio
FROM 
	tesDepoPorIdent inner join tesMovimientos ON
	tesMovimientos.tesMovimientos = tesDepoPorIdent.venMovimientos
	INNER JOIN TesCFDICobranzaCuerpo ON
	TesCFDICobranzaCuerpo.tesMovimientos = tesMovimientos.tesMovimientos
	inner join genCancMov ON
	TesCFDICobranzaCuerpo.tesMovimientos = genCancMov.Asiento_Id_Ap
	INNER JOIN  venMovimientos  ON
	genCancMov.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venMovimientosFiscal ON
	venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN venMovimientosMetodoPago ON
	venMovimientosMetodoPago.venMovimientos =  venMovimientos.venMovimientos
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = venMovimientos.venMovimientos
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join venCondPago ON
	venCondPago.venCondPago = venMovimientos.CondPagoCli_id
	INNER JOIN TesCFDICobranzaSegmentos ON 
	TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaCuerpo.TesCFDICobranza
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
	INNER JOIN conAsientos AS Cobranza on Cobranza.conasientos = tesMovimientos.tesMovimientos
	INNER JOIN venMovImpuestos ON  venMovImpuestos.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN venImpuestos ON  venImpuestos.venImpuestos =venMovImpuestos.Impuesto_Id
	INNER JOIN impTipoImpuesto ON venImpuestos.TipoImpuesto =  impTipoImpuesto.TipoImpuesto

WHERE
	TesCFDICobranzaCuerpo.tesCFDICobranza = @TesCFDICobranza 
group by TesCFDICobranzaCuerpo.tesMovimientos,genMonedas.genMonedas ,Cobranza.Moneda_Id , Cobranza.Cambio ,conAsientos.Cambio , 
	genCancMov.Asiento_Id, 		impTipoImpuesto.TipoImpuesto,venImpuestos.Porcentaje
ORDER BY 1,2,3		



GO