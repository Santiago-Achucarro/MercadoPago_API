-- Inf_CfdiCobranzaCabe 1, 'CPAG',2,0,0,0,'0001',' ',' ',' '
-- Inf_CfdiCobranzaEmisor 1, 'CPAG',2,0,0,0,'0001',' ',' ',' '
-- Inf_CfdiCobranzaReceptor 1, 'CPAG',2,0,0,0,'0001',' ',' ',' '
-- Inf_CfdiCobranzaConcepto 1, 'CPAG',2,0,0,0,'0001',' ',' ',' '
-- Inf_CfdiCobranzaComplemento 5, 'CPAG',648,0,0,0,'LCC',' ',' ',' '
-- Inf_CfdiCobranzaComplementoPago 5, 'CPAG',646,0,0,0,'LCC',' ',' ',' '
-- Inf_CfdiCobranzaRel 1, 'CPAG',2,0,0,0,'0001',' ',' ',' '
-- Inf_CfdiCobranzaRelCuerpo , 'CPAG',2,0,0,0,'0001',' ',' ',' '

DROP PROCEDURE Inf_CfdiCobranzaCabe
GO
CREATE PROCEDURE Inf_CfdiCobranzaCabe
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)
AS

SELECT ISNULL((SELECT cValor from genGlobales where Nombre_var = 'GENVERSIONCFDI' and 
		Empresa_Id = @pEmpresa_Id) ,'3.3') as Version, 
	TesCFDICobranzaSegmentos.Segmento1C as Serie, 
	 TesCFDICobranzaSegmentos.Segmento1N as Folio, TesCFDICobranza.Fecha as Fecha,
	 TesCFDICobranzaSegmentos.TesCFDICobranza,
		'pago' as MetodoPago, 
		CASE WHEN ISNULL(TesCFDICobranza.NoCertificado,' ')=' ' THEN
		(SELECT cValor FROM genGlobales WHERE NOMBRE_VAR = 'VENNOCERTIFICADO' and Empresa_Id =@pEmpresa_Id) ELSE
		TesCFDICobranza.NoCertificado END AS NoCertificado, 
		(SELECT mValor FROM genGlobales where Nombre_var = 'GENWSAAPUBLICKEY' and Empresa_Id =@pEmpresa_Id ) AS Certificado,
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
	genSegmentos.Segmento_Id = @pSegmento_Id and
	TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C and 
	TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C and 
	TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C and 
	TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C and 
	TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N and 
	TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N and 
	TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N and 
	TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N 

GO

DROP PROCEDURE Inf_CfdiCobranzaEmisor
GO
CREATE PROCEDURE Inf_CfdiCobranzaEmisor
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)
AS

SELECT 
genEmpresas.Cuit AS Rfc,
genEmpresas.RazonSocial AS Nombre,
genEmpresas.Regimen AS RegimenFiscal,
(select mValor from genglobales where Nombre_var = 'EMPPRIVATEKEY' and Empresa_Id=@pEmpresa_Id) AS EmpPrivateKey,
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
WHERE genEmpresas.genEmpresas = @pEmpresa_Id
GO



DROP PROCEDURE Inf_CfdiCobranzaReceptor
GO

CREATE PROCEDURE Inf_CfdiCobranzaReceptor
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)
AS


SELECT isnull((select MAX(tesDeposito.RfcEmisorCtaOrd)
	from tesDeposito, tesCFDICobranzaCuerpo, tesBancos 
	WHERE	
	tesDeposito.tesMovimientos = tesCFDICobranzaCuerpo.tesMovimientos and 
	tesDeposito.FormaDePagoP = '17' and 
	tesBancos.RFC = tesDeposito.RfcEmisorCtaOrd and 
	tesCFDICobranzaCuerpo.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza),genEntidades.Cuit) AS Rfc, 
	isnull((select MAX(tesBancos.Descripcion)
	from tesDeposito, tesCFDICobranzaCuerpo, tesBancos 
	WHERE	
	tesDeposito.tesMovimientos = tesCFDICobranzaCuerpo.tesMovimientos and 
	tesDeposito.FormaDePagoP = '17' and 
	tesBancos.RFC = tesDeposito.RfcEmisorCtaOrd and 
	tesCFDICobranzaCuerpo.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza),
	 venClientes.RazonSocial) as Nombre, 
	genPaises.CodFiscal AS ResidenciaFiscal,
	' '  AS NumRegIdTrib,
	'P01' as UsoCfdi, 
	venClieHabitual.Direccion1_Fact Calle , venClieHabitual.NroExterior_Fact NroExterior, 
	venClieHabitual.NroInterior_Fact NroInterior, venClieHabitual.Direccion2_Fact Colonia,
	venClieHabitual.Localidad_Fact AS Localidad,
	genProvincias.CodFiscal as Provincia, 
	genPaises.CodFiscal as Pais, 
	venClieHabitual.CodPostal_Fact as CodigoPostal, 
	venClientes.Regimen
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
	genSegmentos.Segmento_Id = @pSegmento_Id and
	TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C and 
	TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C and 
	TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C and 
	TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C and 
	TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N and 
	TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N and 
	TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N and 
	TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N 

GO

DROP PROCEDURE Inf_CfdiCobranzaConcepto
GO

CREATE PROCEDURE Inf_CfdiCobranzaConcepto
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)
AS

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
GO



DROP PROCEDURE Inf_CfdiCobranzaComplemento
GO

CREATE PROCEDURE Inf_CfdiCobranzaComplemento
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)
AS

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
genSegmentos.Segmento_Id = @pSegmento_Id and
	TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C and 
	TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C and 
	TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C and 
	TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C and 
	TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N and 
	TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N and 
	TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N and 
	TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N 

GO

DROP PROCEDURE Inf_CfdiCobranzaComplementoPago
GO

CREATE PROCEDURE Inf_CfdiCobranzaComplementoPago
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)
AS


SELECT  TesCFDICobranzaCuerpo.tesMovimientos,
	dbo.Segmento(genAsiSegmentosCOB.Segmento_Id, genAsiSegmentosCOB.Segmento1C,
	genAsiSegmentosCOB.Segmento2C,genAsiSegmentosCOB.Segmento3C,genAsiSegmentosCOB.Segmento4C,
	genAsiSegmentosCOB.Segmento1N,genAsiSegmentosCOB.Segmento2N,genAsiSegmentosCOB.Segmento3N,
	genAsiSegmentosCOB.Segmento4N) as Comprobante,
	tesMovimientos.Fecha_Real as FechaPago, 
	ISNULL(TesDeposito.FormaDePagoP, tesIdentifica.FormaDePagoP) AS FormaDePagoP,
	MID.CodigoFiscal as MonedaP, case when MID.CodigoFiscal='MXN' OR
		MID.genMonedas = tesIdentifica.Moneda_Id THEN 1 ELSE conAsientos.cambio end as TipoCambioP, 
	ROUND(conMovCont.ImporteMonedaOriginal / Case when genEmpresas.genEmpresas = MID.genMonedas or 
		conAsientos.Moneda_Id = tesIdentifica.Moneda_Id THEN 1 else conAsientos.cambio end,2 ) as Monto, 
	conMovCont.Importe as MontoMxp,
	ISNull(case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE TesDeposito.NumOperacion END, ' ') AS NumOperacion, 
	ISNull(case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE TesDeposito.RfcEmisorCtaOrd END, ' ') AS RfcEmisorCtaOrd , 
	ISNull(TesDeposito.NomBancoOrdExt, ' ') NomBancoOrdExt  ,
	ISNull(TesDeposito.CtaOrdenante,' ' ) CtaOrdenante,
	ISNULL(case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE ISNULL(tesBancosP.RFC,'') END, ' ') AS RfcEmisorCtaBen , 
	ISNULL(case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE tesIdBancoPropio.numCuenta END,  ' ') AS CtaBeneficiario, 
	ISNULL(TesDeposito.TipoCadPago, ' ') as TipoCadPago, 
	ISNULL(TesDeposito.CertPago, ' ') as CertPago, ISNULL(TesDeposito.CadPago, ' ') CadPago, 
	ISNULL(TesDeposito.SelloPago, ' ') SelloPago, 
	isnull((select sum(conMovCont1.Importe) 
		From conMovCont as conMovCont1
		WHERE
		conMovCont1.conasientos = conMovCont.conasientos and 
		conMovCont1.tipoMov = 2),0) as TotalPago , 
        ISNULL(venMovimientosFiscal.ClaveFiscal, ' ') AS idDocumento, 
		ISNULL(genAsiSegmentos.Segmento2C+genAsiSegmentos.Segmento3C, ' ') as Serie, 
		ISNULL(genAsiSegmentos.Segmento1N, 0) as Folio, 
		ISNULL(genMonedas.CodigoFiscal, ' ') MonedaDR, 
		ISNULL(conAsientos.Cambio, 0) as TipoCambioDR, 
		ISNULL(venMovimientosMetodoPago.NMetodoPago, '  ') as MetodoPago , 
		ISNULL((SELECT COUNT(1) FROM genCancMov genCancMov1, conAsientos where 
		conAsientos.conAsientos = genCancMov1.Asiento_Id_Ap and 
			conAsientos.Anulado= 0 and 
			conAsientos.Posteado = 1 AND 
		genCancMov.Asiento_Id = genCancMov1.Asiento_Id and 
		((genCancMov1.FechaAplicacion < genCancMov.FechaAplicacion) or
		(genCancMov.FechaAplicacion = genCancMov1.FechaAplicacion and 
		genCancMov1.Asiento_Id_Ap < genCancMov.Asiento_Id_Ap))),0)+1  as NumParcialidad , 
		ISNULL(Factura.Importe - 
		ISNULL((SELECT SUM(genCancMov1.Importe) 
			FROM genCancMov genCancMov1, conAsientos where 
			conAsientos.conAsientos = genCancMov1.Asiento_Id_Ap and 
			conAsientos.Anulado= 0 and 
			conAsientos.Posteado = 1 AND 
			genCancMov.Asiento_Id = genCancMov1.Asiento_Id and 
		((genCancMov1.FechaAplicacion < genCancMov.FechaAplicacion) or
		(genCancMov.FechaAplicacion = genCancMov1.FechaAplicacion and 
		genCancMov1.Asiento_Id_Ap < genCancMov.Asiento_Id_Ap))),0),0)  as ImpSaldoAnt, 
		Convert(Numeric(18,2) , ISNULL(genCancMov.Importe,0) * 
		conMovCont.Importe 
		/ isnull((select sum(conMovCont1.Importe) 
		From conMovCont as conMovCont1
		WHERE
		conMovCont1.conasientos = conMovCont.conasientos and 
		conMovCont1.tipoMov = 2),0)) as ImpPagado, 
		ISNULL(venMovimientosMetodoPago.NMetodoPago, ' ') TipoPago, 
		ISNULL(genEntidadesBasicasValor.Descripcion,'') AS DescripcionFPago

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
left outer join tesBancos tesBancosP on
tesBancosP.tesBancos = tesIdBancoPropio.Banco_Id
INNER JOIN TesCFDICobranzaSegmentos ON 
TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaCuerpo.tesCFDICobranza
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
INNER JOIN genAsiSegmentos  as genAsiSegmentosCOB ON
genAsiSegmentosCOB.Asiento_id = tesMovimientos.tesMovimientos
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
LEFT JOIN (genCancMov INNER JOIN venMovimientos  as Factura ON
	genCancMov.Asiento_Id = Factura.venMovimientos
	INNER JOIN venMovimientosFiscal ON
	venMovimientosFiscal.venMovimientos = Factura.venMovimientos
	INNER JOIN venMovimientosMetodoPago ON
	venMovimientosMetodoPago.venMovimientos =  Factura.venMovimientos
	INNER JOIN conAsientos as asieFact ON
	asieFact.conAsientos = Factura.venMovimientos
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = asieFact.conAsientos
	INNER JOIN genMonedas as genMonedasFact ON
	genMonedasFact.genMonedas = asieFact.Moneda_Id
	inner join venCondPago ON
	venCondPago.venCondPago = Factura.CondPagoCli_id) ON
	TesCFDICobranzaCuerpo.tesMovimientos = genCancMov.Asiento_Id_Ap

	left join genEntidadesBasicasValor on 
		genEntidadesBasicasValor.entidad_id = 6 and 
		genEntidadesBasicasValor.Clave = TesDeposito.FormaDePagoP and
		genEntidadesBasicasValor.Dominio_Id = 'MX'
WHERE 
	not exists(select 1 from tesDepoPorIdent WHERE
		tesDepoPorIdent.venMovimientos = tesMovimientos.tesMovimientos) and
	conMovCont.TipoMov = 1 and
	genSegmentos.Segmento_Id = @pSegmento_Id and
	TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C and 
	TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C and 
	TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C and 
	TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C and 
	TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N and 
	TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N and 
	TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N and 
	TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N and 
	Convert(Numeric(18,2) , ISNULL(genCancMov.Importe,0) * 
		conMovCont.Importe 
		/ isnull((select sum(conMovCont1.Importe) 
		From conMovCont as conMovCont1
		WHERE
		conMovCont1.conasientos = conMovCont.conasientos and 
		conMovCont1.tipoMov = 2),0))  > 0
UNION ALL
--- DNI

SELECT  TesCFDICobranzaCuerpo.tesMovimientos,
	dbo.Segmento(genAsiSegmentosCOB.Segmento_Id, genAsiSegmentosCOB.Segmento1C,
	genAsiSegmentosCOB.Segmento2C,genAsiSegmentosCOB.Segmento3C,genAsiSegmentosCOB.Segmento4C,
	genAsiSegmentosCOB.Segmento1N,genAsiSegmentosCOB.Segmento2N,genAsiSegmentosCOB.Segmento3N,
	genAsiSegmentosCOB.Segmento4N) as Comprobante,
	tesMovimientos.Fecha_Real as FechaPago, 
	ISNULL(TesDeposito.FormaDePagoP, tesIdentifica.FormaDePagoP) AS FormaDePagoP,
	MID.CodigoFiscal as MonedaP, case when MID.CodigoFiscal='MXN' OR
		MID.genMonedas = tesIdentifica.Moneda_Id THEN 1 ELSE conAsientos.cambio end as TipoCambioP, 
	ROUND(conMovCont.ImporteMonedaOriginal / Case when genEmpresas.genEmpresas = MID.genMonedas or 
		conAsientos.Moneda_Id = tesIdentifica.Moneda_Id THEN 1 else conAsientos.cambio end,2 ) as Monto, 
	conMovCont.Importe as MontoMxp,
	ISNull(case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE TesDeposito.NumOperacion END, ' ') AS NumOperacion, 
	ISNull(case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE TesDeposito.RfcEmisorCtaOrd END, ' ') AS RfcEmisorCtaOrd , 
	ISNull(TesDeposito.NomBancoOrdExt, ' ') NomBancoOrdExt  ,
	ISNull(TesDeposito.CtaOrdenante,' ' ) CtaOrdenante,
	ISNULL(case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE ISNULL(tesBancosP.RFC,'') END, ' ') AS RfcEmisorCtaBen , 
	ISNULL(case when ISNULL(TesDeposito.FormaDePagoP,' ')='01' THEN ' ' ELSE tesIdBancoPropio.numCuenta END,  ' ') AS CtaBeneficiario, 
	ISNULL(TesDeposito.TipoCadPago, ' ') as TipoCadPago, 
	ISNULL(TesDeposito.CertPago, ' ') as CertPago, ISNULL(TesDeposito.CadPago, ' ') CadPago, 
	ISNULL(TesDeposito.SelloPago, ' ') SelloPago, 
	isnull((select sum(conMovCont1.Importe) 
		From conMovCont as conMovCont1
		WHERE
		conMovCont1.conasientos = conMovCont.conasientos and 
		conMovCont1.tipoMov = 2),0) as TotalPago , 
        ISNULL(venMovimientosFiscal.ClaveFiscal, ' ') AS idDocumento, 
		ISNULL(genAsiSegmentos.Segmento2C+genAsiSegmentos.Segmento3C, ' ') as Serie, 
		ISNULL(genAsiSegmentos.Segmento1N, 0) as Folio, 
		ISNULL(genMonedas.CodigoFiscal, ' ') MonedaDR, 
		ISNULL(conAsientos.Cambio, 0) as TipoCambioDR, 
		ISNULL(venMovimientosMetodoPago.NMetodoPago, '  ') as MetodoPago , 
		ISNULL((SELECT COUNT(1) FROM genCancMov genCancMov1, conAsientos where 
		conAsientos.conAsientos = genCancMov1.Asiento_Id_Ap and 
			conAsientos.Anulado= 0 and 
			conAsientos.Posteado = 1 AND 
		genCancMov.Asiento_Id = genCancMov1.Asiento_Id and 
		((genCancMov1.FechaAplicacion < genCancMov.FechaAplicacion) or
		(genCancMov.FechaAplicacion = genCancMov1.FechaAplicacion and 
		genCancMov1.Asiento_Id_Ap < genCancMov.Asiento_Id_Ap))),0)+1  as NumParcialidad , 
		ISNULL(Factura.Importe - 
		ISNULL((SELECT SUM(genCancMov1.Importe) 
			FROM genCancMov genCancMov1, conAsientos where 
			conAsientos.conAsientos = genCancMov1.Asiento_Id_Ap and 
			conAsientos.Anulado= 0 and 
			conAsientos.Posteado = 1 AND 
			genCancMov.Asiento_Id = genCancMov1.Asiento_Id and 
		((genCancMov1.FechaAplicacion < genCancMov.FechaAplicacion) or
		(genCancMov.FechaAplicacion = genCancMov1.FechaAplicacion and 
		genCancMov1.Asiento_Id_Ap < genCancMov.Asiento_Id_Ap))),0),0)  as ImpSaldoAnt, 
		Convert(Numeric(18,2) , ISNULL(genCancMov.Importe,0) * 
		conMovCont.Importe 
		/ isnull((select sum(conMovCont1.Importe) 
		From conMovCont as conMovCont1
		WHERE
		conMovCont1.conasientos = conMovCont.conasientos and 
		conMovCont1.tipoMov = 2),0)) as ImpPagado, 
		ISNULL(venMovimientosMetodoPago.NMetodoPago, ' ') TipoPago, 
		ISNULL(genEntidadesBasicasValor.Descripcion,'') AS DescripcionFPago

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
left outer join tesBancos tesBancosP on
tesBancosP.tesBancos = tesIdBancoPropio.Banco_Id
INNER JOIN TesCFDICobranzaSegmentos ON 
TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaCuerpo.tesCFDICobranza
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
INNER JOIN genAsiSegmentos  as genAsiSegmentosCOB ON
genAsiSegmentosCOB.Asiento_id = tesMovimientos.tesMovimientos
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
LEFT JOIN (genCancMov INNER JOIN venMovimientos  as Factura ON
	genCancMov.Asiento_Id = Factura.venMovimientos
	INNER JOIN venMovimientosFiscal ON
	venMovimientosFiscal.venMovimientos = Factura.venMovimientos
	INNER JOIN venMovimientosMetodoPago ON
	venMovimientosMetodoPago.venMovimientos =  Factura.venMovimientos
	INNER JOIN conAsientos as asieFact ON
	asieFact.conAsientos = Factura.venMovimientos
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = asieFact.conAsientos
	INNER JOIN genMonedas as genMonedasFact ON
	genMonedasFact.genMonedas = asieFact.Moneda_Id
	inner join venCondPago ON
	venCondPago.venCondPago = Factura.CondPagoCli_id) ON
	TesCFDICobranzaCuerpo.tesMovimientos = genCancMov.Asiento_Id_Ap
	left join genEntidadesBasicasValor on 
		genEntidadesBasicasValor.entidad_id = 6 and 
		genEntidadesBasicasValor.Clave = TesDeposito.FormaDePagoP and
		genEntidadesBasicasValor.Dominio_Id = 'MX'
WHERE 
	conMovCont.TipoMov = 1 and
	genSegmentos.Segmento_Id = @pSegmento_Id and
	TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C and 
	TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C and 
	TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C and 
	TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C and 
	TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N and 
	TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N and 
	TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N and 
	TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N and 
	Convert(Numeric(18,2) , ISNULL(genCancMov.Importe,0) * 
		conMovCont.Importe 
		/ isnull((select sum(conMovCont1.Importe) 
		From conMovCont as conMovCont1
		WHERE
		conMovCont1.conasientos = conMovCont.conasientos and 
		conMovCont1.tipoMov = 2),0))  > 0


ORDER BY 1,2,3

GO
drop PROCEDURE [dbo].[Inf_CfdiCobranzaRel]
go

CREATE PROCEDURE [dbo].[Inf_CfdiCobranzaRel]
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)
AS

SELECT '04' as TipoRelacion 
FROM tesCFDICobranzaRel inner join TesCFDICobranza ON 
TesCFDICobranzaRel.tesCFDICobranzaR = TesCFDICobranza.tesCFDICobranza
INNER JOIN TesCFDICobranzaSegmentos ON 
	TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaRel.TesCFDICobranza
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
WHERE
TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C and 
	TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C and 
	TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C and 
	TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C and 
	TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N and 
	TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N and 
	TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N and 
	TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N 


GO

DROP PROCEDURE [dbo].[Inf_CfdiCobranzaRelCuerpo]
GO
CREATE PROCEDURE [dbo].[Inf_CfdiCobranzaRelCuerpo]
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

)
AS

SELECT TesCFDICobranzaRel.tesCFDICobranza, tesCFDICobranza.UUID 
FROM TesCFDICobranzaRel inner join TesCFDICobranza ON 
TesCFDICobranzaRel.tesCFDICobranzaR = TesCFDICobranza.tesCFDICobranza
INNER JOIN TesCFDICobranzaSegmentos ON 
	TesCFDICobranzaSegmentos.TesCFDICobranza =  TesCFDICobranzaRel.TesCFDICobranza
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = TesCFDICobranzaSegmentos.Segmento_Id
where
	TesCFDICobranzaSegmentos.Segmento1C = @pSegmento1C and 
	TesCFDICobranzaSegmentos.Segmento2C = @pSegmento2C and 
	TesCFDICobranzaSegmentos.Segmento3C = @pSegmento3C and 
	TesCFDICobranzaSegmentos.Segmento4C = @pSegmento4C and 
	TesCFDICobranzaSegmentos.Segmento1N = @pSegmento1N and 
	TesCFDICobranzaSegmentos.Segmento2N = @pSegmento2N and 
	TesCFDICobranzaSegmentos.Segmento3N = @pSegmento3N and 
	TesCFDICobranzaSegmentos.Segmento4N = @pSegmento4N 


GO







