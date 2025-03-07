
DROP PROCEDURE tesMovimientosGuardar
GO
CREATE PROCEDURE tesMovimientosGuardar
(
@ptesMovimientos bigint,
@pSubTipo_Id varchar(3),
@pFecha_Real qFecha
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesMovimientos WHERE (tesMovimientos = @ptesMovimientos)))
BEGIN 
	UPDATE tesMovimientos
	SET SubTipo_Id = dbo.FuncFKtesSubTiposMov(@pSubTipo_Id),
		Fecha_Real = @pFecha_Real
	WHERE (tesMovimientos = @ptesMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO tesMovimientos
	(
		tesMovimientos,
		SubTipo_Id,
		Fecha_Real
	)
	VALUES 
	(
		@ptesMovimientos,
		dbo.FuncFKtesSubTiposMov(@pSubTipo_Id),
		@pFecha_Real
	)
END 

GO

DROP PROCEDURE tesMovimientosDatos
GO
CREATE PROCEDURE tesMovimientosDatos
(
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 


SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
tesMovimientos.tesMovimientos, tesSubTiposMov.Tipomov, 
conAsientos.Fecha,conAsientos.FechaRegistro, genMonedas.Moneda_Id, 
	genMonedas.Descripcion as DescrpcionMoneda,  conAsientos.Cambio, 
	conAsientos.CambioMonedaOriginal, conAsientos.Anulado, 
	conAsientos.Observaciones, conAsientos.Posteado,
	disFormularios.Formulario_Id, disFormularios.Descripcion as DescripcionFormulario,
	tesSubTiposMov.SubTipo_Id, tesSubTiposMov.Descripcion as DescripcionSubTiposMov, 
	tesMovimientos.Fecha_Real, 
	venClientes.Cliente_Id, venClientes.RazonSocial as RazonSocialCliente,
	comProveedores.Proveed_Id, comProveedores.RazonSocial as RazonSocialProveedor,
	Convert(Numeric(18,2), 0) as TotalDebe,
	Convert(Numeric(18,2), 0) as TotalHaber,
	Convert(Numeric(18,2), 0) as TotalHabilitado, 
	cast(1 as Bit) ControlaFormulario,
	ISNULL(Sum(CMCDebe.ImporteMonedaOriginal),0) TotalDebeOriginal,
	ISNULL(Sum(CMCHaber.ImporteMonedaOriginal),0) TotalHaberOriginal,
	genSucursalesEmpr.Sucursal, Convert(Numeric(18,2), 0) as Diferencia
FROM tesMovimientos 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = tesMovimientos.tesMovimientos)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN tesSubTiposMov  ON (tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN disFormularios ON  disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
LEFT OUTER JOIN (venMovimientos INNER JOIN venClientes ON
	venMovimientos.Cliente_Id = venClientes.genEntidades) ON 
	venMovimientos.venMovimientos = tesMovimientos.tesMovimientos
LEFT OUTER JOIN (comMovprov INNER JOIN comProveedores ON
	comMovprov.Proveed_Id = comProveedores.genEntidades) ON 
	comMovprov.comMovprov = tesMovimientos.tesMovimientos
LEFT OUTER Join conMovCont CMCDebe On CMCDebe.conAsientos = conAsientos.conAsientos And CMCDebe.TipoMov = 1
LEFT OUTER Join conMovCont CMCHaber On CMCHaber.conAsientos = conAsientos.conAsientos And CMCHaber.TipoMov = 2
WHERE (tesMovimientos = @ptesMovimientos)
Group By genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
tesMovimientos.tesMovimientos, tesSubTiposMov.Tipomov, 
conAsientos.Fecha,conAsientos.FechaRegistro, genMonedas.Moneda_Id, 
	genMonedas.Descripcion, conAsientos.Cambio, 
	conAsientos.CambioMonedaOriginal, conAsientos.Anulado, 
	conAsientos.Observaciones, conAsientos.Posteado,
	disFormularios.Formulario_Id, disFormularios.Descripcion,
	tesSubTiposMov.SubTipo_Id, tesSubTiposMov.Descripcion, 
	tesMovimientos.Fecha_Real, 
	venClientes.Cliente_Id, venClientes.RazonSocial,
	comProveedores.Proveed_Id, comProveedores.RazonSocial, genSucursalesEmpr.Sucursal

GO

DROP PROCEDURE tesFactAnexoMovDatos
GO
CREATE PROCEDURE tesFactAnexoMovDatos
(
@ptesMovimientos bigint, 
@pTipomovCont Int
)
AS
SET NOCOUNT ON 




/* Cuerpo ANEXO */


SELECT comMovDetalle.comMovProv as Asiento_Id, comMovDetalle.Renglon, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	conBaseDistri.Base_Id,
	comMovDetalle.Detalle, comMovDetalle.Importe, 
	tesRengMovicomMovProv.Renglon as RenglonRenMovi
FROM tesRengMovicomMovProv 	INNER JOIN  comMovDetalle on tesRengMovicomMovProv.comMovProv = comMovDetalle.comMovProv
Inner join comMovprov on comMovprov.comMovProv = comMovDetalle.comMovprov
INNER JOIN conCuentas ON conCuentas.conCuentas = comMovDetalle.Cuenta_Id
LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = comMovDetalle.Centro1_Id
LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = comMovDetalle.Centro2_Id
LEFT OUTER JOIN conBaseDistri ON conBaseDistri.conBaseDistri =comMovDetalle.Base_Id
INNER JOIN conMovCont ON 
	conMovCont.conAsientos = tesRengMovicomMovProv.tesMovimientos and 
	conMovCont.Renglon = tesRengMovicomMovProv.Renglon
Where
	tesRengMovicomMovProv.tesMovimientos = @ptesMovimientos and 
	conMovCont.TipoMov = @pTipomovCont


/* Impuestos */
SELECT comMovImpuestos.conRenglon, 
	comImpuestos.Impuesto_Id, comImpuestos.Descripcion as DescripcionImpuestos, comMovImpuestos.Porcentaje,
	comImpuestos.FormulaCalc,
	comMovImpuestos.Base_Imponible, comMovImpuestos.Importe_Impuesto, 
	conCuentas.Cuenta_Id as CtaDebe, conCuentas.Descripcion as DescripcionCuentaDebe, 
	conCuentas.Cuenta_Id as CtaHaber, conCuentas.Descripcion as DescripcionCuentaHaber, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	tesRengMovicomMovProv.Renglon as RenglonRenMovi
FROM tesRengMovicomMovProv INNER JOIN  comMovImpuestos ON
tesRengMovicomMovProv.comMovProv = comMovImpuestos.comMovProv
INNER JOIN comMovprov ON (comMovImpuestos.comMovProv = comMovProv.comMovProv)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = comMovImpuestos.comMovProv) AND 
			(conMovCont.Renglon = comMovImpuestos.conRenglon)
INNER JOIN comImpuestos  ON (comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id)
LEFT OUTER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
inner join conMovCont as conMovContF ON conMovContF.conAsientos = tesRengMovicomMovProv.tesMovimientos and 
	conMovContF.Renglon =tesRengMovicomMovProv.Renglon
WHERE 
	tesRengMovicomMovProv.tesMovimientos = @ptesMovimientos and 
	conMovContF.TipoMov = @pTipoMovCont
GO

/* RengMovi */
DROP PROCEDURE tesRengMoviDHDatos
GO
CREATE PROCEDURE tesRengMoviDHDatos
(
@ptesMovimientos bigint,
@pTipomov int,
@pconRenglon int=null
)
AS
SET NOCOUNT ON 

SELECT tesRengMovi.tesMovimientos, tesRengMovi.conRenglon,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionIdentifica, 
	conMovCont.ImporteMonedaOriginal * case when tesRengMovi.TipomovCont = conmovcont.Tipomov then 1 else -1 end 	as ImporteOrig, 
	conMovCont.Importe * case when tesRengMovi.TipomovCont = conmovcont.Tipomov then 1 else -1 end 	as Importe, 
	tesRengMovi.Cambio, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	tesRengMovi.TipomovCont as Tipomov, conMovCont.Clase, 
	tesTiposID.TipoCartera, tesCheqProp.tesCheqProp,  
	tesChequeras.Chequera_Id CPChequera_Id, tesCheqProp.numCheque CPnumCheque, tesChequeras.Estado_Id CPEstado_Id,
	tesChequeras.TipoChequera CPTipoChequera , tesChequeras.Desde CPChequeraDesde, tesChequeras.Hasta CPChequeraHasta, 
	tesChequeras.Proximo CPChequeraProximo,
	tesCheqProp.FechaVencimiento CPFechaVencimiento, tesCheqProp.AlaOrden CPAlaOrden, 
	tesCheqProp.CUIT CPCuit, tesCheqProp.CuentaDestino CPCuentaDestino, 
	tesBancos.Banco_Id as CPBanco_Id , tesBancos.Descripcion as  CPDescripcionBanco, 
	tesCheqProp.BancoDestinoExt CPBancoDestinoExt, 
	tesCheqTerceros.tesCheqTerceros ,tesBancosCT.Banco_Id CTBanco_Id, 
	tesBancosCT.Descripcion as  CTDescripcionBanco, 
	tesClearing.Clearing CTClearing, tesClearing.cVariable CTVariable, 
	tesCheqTerceros.ClearingDias CTClearingDias, 
	tesCheqTerceros.FechaVencimiento CTFechaVencimiento, 
	tesCheqTerceros.sucBanco CTsucBanco, tesCheqTerceros.cuentaBanco CTcuentaBanco,
	tesCheqTerceros.numCheque CTnumCheque, tesCheqTerceros.Estado_Id CTEstado_Id, 
	venClientes.Cliente_Id CTCliente_Id, venClientes.RazonSocial CTRazonSocial, '' CTLectoraCheques, 
	ISNULL(tesCheqTerceros.CTCuit,'') CTCuit,
	comMovprov.comMovprov FPAsiento_Id,  comMovprov.Fecha_CCP FPFecha_Ane, 
	comMovprov.FechaFiscal FPFechaFiscal,
	comProveedores.Proveed_Id FPCuit, genEntidades.TipoDoc FPTipoDoc, genEntidades.IdFiscal FPIdFiscal,
	comProveedores.RazonSocial FPRazonSocial,  
	comProveedores.Direccion1 FPDireccion1, 
	comProveedores.Direccion2 FPDireccion2, 
	comProveedores.Localidad as Localidad, 
	comProveedores.CodigoPostal as Cod_Postal, 
	ISNULL(genProvincias.Provincia_Id,' ') Provincia_Id, 
	ISNULL(genProvincias.Descripcion,' ')  FPDescripcionPcia,
	ISNULL(comCondFiscal.CondFiscal_Id,' ') FPCondFiscal_Id, 
	ISNULL(comCondFiscal.Descripcion,' ') as FPDescripcionCondFiscal, 
	comOrigenesFiscales.Origen_id FPOrigen_Id , comOrigenesFiscales.Descripcion as FPDescripcionOrigen,
	comMovprov.VieneDeFiscal FPVieneDeFiscal, comMovprov.XMLFiscal FPXMLFiscal, comMovProv.TipoCompFE FPTipoCompFE,
	comMovprov.ClaveFiscal FPClaveFiscal, tesRengMovicomMovProv.Renglon FPconRenglonProv, 
	'  ' as FPArchvoXml,
	genSegmentos.Segmento_Id , genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	tesRengMoviRetProv.Porcentaje, tesRengMoviRetProv.Exencion, tesRengMoviRetProv.BaseImponible,
	tesRengMoviRetProv.Acum, tesRengMoviRetProv.TRet, tesRengMoviRetProv.AcumTot,
	dbo.Segmento(segMovProv.Segmento_Id, segMovProv.Segmento1C, segMovProv.Segmento2C,
	segMovProv.Segmento3C, segMovProv.Segmento4C, segMovProv.Segmento1N, segMovProv.Segmento2N,
	segMovProv.Segmento3N, segMovProv.Segmento4N) FacturaRet, tesRengMoviRetProv.comMovProv,
	tesRengMoviRetClie.SucursalRet, tesRengMoviRetClie.ComprobanteRet,
	TesDeposito.FormaDePagoP as TDFormaDePagoP, TesDeposito.NumOperacion AS TDNumOperacion, 
		TesDeposito.CtaOrdenante as TDCtaOrdenante,
		TesDeposito.RfcEmisorCtaOrd as TDRfcEmisorCtaOrd, 
		TesDeposito.NomBancoOrdExt as TDNomBancoOrdExt, 
		TesDeposito.TipoCadPago as TDTipoCadPago, 
		TesDeposito.CadPago AS TDCadPago, TesDeposito.SelloPago as TDSelloPago, 
		TesDeposito.CertPago as TDCertPago,
	conMovCont.Importe * 0 Diferencia,
	tesTarjetas3.tesTarjetas3 ,tesBancosT3.Banco_Id T3Banco_Id, 
	tesBancosT3.Descripcion as T3DescripcionBanco, tesTarjetas3.Estado T3Estado, 
	tesTarjetas3.Cuotas T3Cuotas, tesTarjetas3.Cupon T3Cupon, tesTarjetas3.Lote T3Lote, 
	tesTarjetas3.Comercio T3Comercio,  tesTarjetas3.NroAutorizacion T3NroAutorizacion,
	tesTarjetas3.NroTarjeta T3NroTarjeta, T3venClientes.Cliente_Id T3Cliente_Id, 
	T3venClientes.RazonSocial T3RazonSocial
FROM tesRengMovi 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = tesRengMovi.tesMovimientos) AND (conMovCont.Renglon = tesRengMovi.conRenglon)
INNER JOIN tesIdentifica  ON (tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id)
INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT OUTER JOIN conCentro1 ON  conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT OUTER JOIN conCentro2 ON  conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN tesTiposID ON (tesTiposID.tesTiposID = tesIdentifica.TipoCartera)
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id 
LEFT OUTER JOIN (tesCheqProp INNER JOIN tesBPlink ON tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp
			INNER JOIN tesChequeras on tesChequeras.Chequera_Id = tesCheqProp.Chequera_Id And
				tesChequeras.Empresa_Id = tesCheqProp.Empresa_Id And
				tesCheqProp.Cartera_Id = tesChequeras.Cartera_Id
			Left JOIN tesBancos ON tesBancos.tesBancos = tesCheqProp.BancoDestino) ON
				tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos AND 
				tesBPlink.conRenglon =tesRengMovi.conRenglon
LEFT OUTER JOIN (tesCheqTerceros inner join tesCTLink ON tesCTLink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros
				INNER JOIN tesBancos tesBancosCT ON tesBancosCT.tesBancos = tesCheqTerceros.Banco_Id
				INNER JOIN tesClearing ON tesClearing.Clearing = tesCheqTerceros.Clearing
				Left JOIN venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id) ON 
					tesCTLink.tesMovimientos = tesRengMovi.tesMovimientos and 
					tesCTLink.conRenglon =tesRengMovi.conRenglon 
					
LEFT OUTER JOIN ( tesRengMovicomMovProv inner join comMovprov ON
					tesRengMovicomMovProv.comMovprov = comMovprov.comMovprov 
					left join comProveedores ON comMovprov.Proveed_Id = comProveedores.genEntidades
				INNER JOIN genEntidades ON genEntidades.genEntidades = comMovprov.Proveed_Id
				left JOIN comCondFiscal ON comCondFiscal.comCondFiscal = comMovprov.CondFiscal_Id
				left JOIN comOrigenesFiscales ON comOrigenesFiscales.comOrigenesFiscales  = comMovprov.Origen_id
				LEFT JOIN genProvincias ON genProvincias.genProvincias = comProveedores.Provincia_Id
				INNER JOIN genAsiSegmentos AS genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
				INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id) ON
					tesRengMovicomMovProv.tesMovimientos = tesRengMovi.tesMovimientos AND 
					tesRengMovicomMovProv.Renglon = tesRengMovi.conRenglon
Left Join (tesRengMoviRetProv Left Join 
		(conAsientos conAsientosMovProv Inner Join genAsiSegmentos segMovProv On segMovProv.Asiento_Id = conAsientosMovProv.conAsientos)
			On conAsientosMovProv.conAsientos = tesRengMoviRetProv.comMovProv) On tesRengMoviRetProv.tesMovimientos = tesRengMovi.tesMovimientos And
							tesRengMoviRetProv.conRenglon = tesRengMovi.conRenglon
Left Join tesIdRetProv On tesIdRetProv.Cartera_Id = tesRengMovi.Cartera_Id 
Left Join tesRengMoviRetClie On tesRengMoviRetClie.tesMovimientos = tesRengMovi.tesMovimientos And
								tesRengMoviRetClie.conRenglon = tesRengMovi.conRenglon
LEFT JOIn TesDeposito ON TesDeposito.tesMovimientos = tesRengmovi.tesMovimientos and 
			TesDeposito.Renglon = tesRengmovi.conRenglon

--Tarjetas
LEFT OUTER JOIN (tesTarjetas3 INNER JOIN tesIdTarjetas3 ON tesTarjetas3.Cartera_Id = tesIdTarjetas3.Cartera_Id				
				INNER JOIN tesT3Link ON tesT3Link.tesTarjetas3 = tesTarjetas3.tesTarjetas3
				INNER JOIN tesBancos tesBancosT3 ON tesBancosT3.tesBancos = tesIdTarjetas3.Banco_Id
				LEFT JOIN venClientes T3venClientes ON T3venClientes.genEntidades = tesTarjetas3.Cliente_Id) ON 
					tesT3Link.tesMovimientos = tesRengMovi.tesMovimientos and 
					tesT3Link.conRenglon =tesRengMovi.conRenglon 
			
WHERE tesRengMovi.tesMovimientos = @ptesMovimientos and 
	tesRengMovi.conRenglon = isnull(@pconRenglon, tesRengMovi.conRenglon) and 
	tesRengMovi.TipomovCont = isnull(@pTipomov, conMovCont.Tipomov)
ORDER BY 2

RETURN @@Error 
GO

DROP PROCEDURE tesMovimientosCambio 
GO
CREATE PROCEDURE tesMovimientosCambio (
	@ptesMovimientos bigint
	)
AS	
SELECT genMonedas.Moneda_Id, genMonedas.Descripcion, max(tesRengMovi.Cambio) as Cambio
From conMovCont 
Inner join conCuentas ON conMovCont.Cuenta_Id =conCuentas.conCuentas
inner join genMonedas ON genMonedas.genMonedas =conCuentas.Moneda_id
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos =conMovCont.conAsientos AND 
	tesRengMovi.conRenglon = conMovCont.Renglon
Where
conMovCont.conAsientos = @ptesMovimientos
GROUP BY genMonedas.Moneda_Id, genMonedas.Descripcion
GO


DROP PROCEDURE tesMovimientosDatosBase
GO
-- tesMovimientosDatosBase 1
CREATE PROCEDURE tesMovimientosDatosBase
(
@Empresa_Id INT, 
@Segmento_Id Char(5),
@Segmento1C Char(25),
@Segmento2C Char(25),
@Segmento3C Char(25),
@Segmento4C Char(25),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int

)
AS
SET NOCOUNT ON 
DECLARE @ptesMovimientos bigint

SELECT @pTesMovimientos = Asiento_Id FROM genAsiSegmentos 
	WHERE
		genAsiSegmentos.Empresa_Id = @Empresa_Id and 
		genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_Id) AND
		genAsiSegmentos.Segmento1C = @Segmento1C AND 
		genAsiSegmentos.Segmento2C = @Segmento2C AND 
		genAsiSegmentos.Segmento3C = @Segmento3C AND 
		genAsiSegmentos.Segmento4C = @Segmento4C AND 
		genAsiSegmentos.Segmento1N = @Segmento1N AND 
		genAsiSegmentos.Segmento2N = @Segmento2N AND 
		genAsiSegmentos.Segmento3N = @Segmento3N AND 
		genAsiSegmentos.Segmento4N = @Segmento4N

-- Print @pTesMovimientos	

-- Principal
EXECUTE tesMovimientosDatos @ptesMovimientos

-- Debe
Exec tesRengMoviDHDatos @ptesMovimientos, 1, NULL
-- Haber
Exec tesRengMoviDHDatos @ptesMovimientos, 2, NULL

-- ConciliacDebe
Exec tesRengConciliacDatos @ptesMovimientos, NULL,1
-- ConciliacHaber
Exec tesRengConciliacDatos @ptesMovimientos, NULL,2

-- CheqTercerosHaber
SELECT CAST(0 as bit) as Marca,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	tesBancos.Banco_Id, tesBancos.Descripcion AS DescripcionBanco,
	tesCheqTerceros.FechaVencimiento, tesCheqTerceros.sucBanco, 
	tesCheqTerceros.numCheque, tesCheqTerceros.Estado_Id,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	tesCheqTerceros.tesCheqTerceros, conMovCont.Importe, 
	conMovCont.ImporteMonedaOriginal, '' LectoraCheques, ISNULL(tesCheqTerceros.CTCuit,'') CTCuit
FROM tesCheqTerceros 
INNER JOIN tesIdentifica ON tesCheqTerceros.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN tesBancos ON tesBancos.tesBancos = tesCheqTerceros.Banco_Id
INNER JOIN tesCTlink ON tesCTlink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros AND
	tesCTlink.Secuencia = tesCheqTerceros.SecuenciaActual
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesCTlink.tesMovimientos and 
	tesRengMovi.conRenglon = tesCTlink.conRenglon
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon =tesRengMovi.conRenglon
LEFT OUTER JOIN  venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id
WHERE
	1=2


-- FactAneCuerpoDebe , FactAneImpuestoDebe
Exec tesFactAnexoMovDatos @pTesMovimientos, 1
-- FactAneCuerpoHaber, FactAneImpuestoHaber
Exec tesFactAnexoMovDatos @pTesMovimientos, 2

-- FactClientes
-- Cobranzas y/o Pagos a Clientes
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	conAsientos.Fecha as Fecha, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio,
	genMovCuotas.Importe, genMovCuotas.Saldo, Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri, 
	conAsientos.conAsientos, conCuentas.Cuenta_Id, genCancMov.Importe as MontoACobrar, 
	isnull((select max(tesRengMovi.Cambio) from tesRengMovi, conMovCont conMovCont1 WHERE
		tesRengMovi.TesMovimientos =genCancMov.Asiento_Id_Ap and 
		tesRengMovi.TesMovimientos = conMovCont1.conAsientos AND 
		tesRengMovi.conRenglon  = 	conMovCont1.Renglon and 
		conMovCont.Cuenta_id =conMovCont1.Cuenta_id),1)  as CambioCobra, 
		genMovCuotas.CuotaNro, genCancMov.EsVentaContado, venMovimientosMetodoPago.NMetodoPago, 
		conMovCont.Clase, genMovCuotas.FechaVencimiento
from genAsiSegmentos 
INNER JOIN venMovimientos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
inner JOIN genMovCuotas ON genMovCuotas.Asiento_id = conAsientos.conAsientos
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos  AND conMovCont.Clase =	'CLI'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipomov = venMovimientos.venTipomov
INNER JOIN genCancMov ON genCancMov.Asiento_Id = conAsientos.conAsientos and 
genCancMov.CuotaNro = genMovCuotas.CuotaNro and
genCancMov.Asiento_Id_Ap = @ptesMovimientos and 
genCancMov.CuotaNro_ap = 1
LEFT JOIN venMovimientosMetodoPago ON venMovimientosMetodoPago.venMovimientos = venMovimientos.venMovimientos


-- AntClientes
-- Anticipos de Clientes 
SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, tesRengMovi.Cambio,
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	conAsientos.conAsientos, conCuentas.Cuenta_id as Cuenta_Id, 
		conCuentas.Descripcion as DescripcionCuenta
from tesRengMovi INNER JOIN conAsientos ON
conAsientos.conAsientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON
conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
conMovCont.Renglon = tesRengMovi.conRenglon and 
conMovCont.Clase = 'ANTCL'
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON
genMonedas.genMonedas = conCuentas.Moneda_Id
Where 
tesRengMovi.TesMovimientos =  @pTesMovimientos


-- FactProveedores
-- Pagos y/o Cobranzas de Proveedores
	SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
		genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio, genMovCuotas.CuotaNro,
		genMovCuotas.Importe, genMovCuotas.Saldo, conMovCont.Importe as SaldoOri, conAsientos.conAsientos,
		conCuentas.Cuenta_Id, IsNull(comPagosHabilitados.ImporteHabilitado, genCancMov.Importe) ImporteHabilitado,
		isnull((select max(tesRengMovi.Cambio) from tesRengMovi, conMovCont conMovCont1 WHERE
			tesRengMovi.TesMovimientos = genCancMov.Asiento_Id_Ap and 
			tesRengMovi.TesMovimientos = conMovCont1.conAsientos AND 
			tesRengMovi.conRenglon = conMovCont1.Renglon and 
			conMovCont.Cuenta_id = conMovCont1.Cuenta_id),1)  as CambioPago,
		IsNull(comPagosHabilitados.Importe1, 0) Importe1, IsNull(comPagosHabilitados.Importe2, 0) Importe2, 
		IsNull(comPagosHabilitados.Importe3, 0) Importe3, IsNull(comPagosHabilitados.FechaHabilitacion, conAsientos.Fecha) FechaHabilitacion,
		comMovProv.comMovProv, IsNull(comPagosHabilitados.Secuencia, 1) Secuencia, comMovProv.Fecha_CCP, 
			conAsientos.Usuario_Id
	From genAsiSegmentos 
	INNER JOIN comMovprov ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovprov.comMovprov
	inner JOIN genMovCuotas ON genMovCuotas.Asiento_id = conAsientos.conAsientos
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos  AND
		conMovCont.Clase =	'PRO'
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comMovTipos ON
	comMovTipos.Tipomov = comMovprov.Tipomov
	INNER JOIN genCancMov ON genCancMov.Asiento_Id = conAsientos.conAsientos and 
		genCancMov.CuotaNro = genMovCuotas.CuotaNro and
		genCancMov.Asiento_Id_Ap = @ptesMovimientos and 
		genCancMov.CuotaNro_ap = 1
	Left Join comPagosHabilitados On comPagosHabilitados.tesMovimientos = conAsientos.conAsientos And
										comPagosHabilitados.comMovProv = genCancMov.Asiento_Id

-- AntProveedores
-- Anticipos de Proveedores
SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, tesRengMovi.Cambio,
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	conAsientos.conAsientos, 0 as TipoCtaProv, ' ' as DescripcionProveedoresTipoPasivo,
	conCuentas.Cuenta_id as Cuenta_Id, 
		conCuentas.Descripcion as DescripcionCuenta, ' ' as Usuario_id, 
		 conAsientos.conAsientos as comPagosAnticipo ,conAsientos.conAsientos,
			' ' DescripcionUsuario ,   conAsientos.conAsientos as comEmbarque
From tesRengMovi 
INNER JOIN conAsientos ON conAsientos.conAsientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon = tesRengMovi.conRenglon and 
	conMovCont.Clase = 'ANTPR'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id
Where 
tesRengMovi.TesMovimientos =  @pTesMovimientos



-- CarteraUnica
-- PARA LOS QUE PIDEN UNA CARTERA PARA DEBE O HABER
SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 0.00 as ImporteOrig, 0.00 as Importe, 
	' ' as Estado_Id, CAST(null as datetime) as FechaHasta, '' Centro1_Id, '' Centro2_Id
From tesIdentifica
WHERE 1=2

-- Reversa
-- para Reversion de OP
SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
tesMovimientos.tesMovimientos, conAsientos.Fecha, 
	Convert(numeric(18,2), 0) as Monto, 
		'  ' Entidad_Id, ' ' EntidadDescripcion 
FROM tesMovimientos  inner join tesMoviReversa on
tesMovimientos.tesMovimientos = tesMoviReversa.tesMoviReversa
INNER JOIN conAsientos  ON (conAsientos.conAsientos = tesMovimientos.tesMovimientos)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE 
	tesMoviReversa.tesMovimientos = @ptesMovimientos

-- TiposCambio
-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos


-- genAtributosGenerales
Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'

-- CarteraUnicaContra
-- PARA LOS QUE PIDEN DOS CARTERA PARA DEBE O HABER
SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 0.00 as ImporteOrig, 0.00 as Importe, 
	' ' as Estado_Id, CAST(null as datetime) as FechaHasta, CAST(null as datetime) as FechaDesde, Cast(0 As bit) Marca, '' as Lupa, '' DescripcionLupa
From tesIdentifica
WHERE 1=2

-- CheqTercerosDebe
SELECT  CAST(0 as bit) as Marca,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	tesBancos.Banco_Id, tesBancos.Descripcion AS DescripcionBanco,
	tesCheqTerceros.FechaVencimiento, tesCheqTerceros.sucBanco, 
	tesCheqTerceros.numCheque,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	tesCheqTerceros.tesCheqTerceros, conMovCont.Importe, 
	conMovCont.ImporteMonedaOriginal, '' LectoraCheques, ISNULL(tesCheqTerceros.CTCuit,'') CTCuit
FROM tesCheqTerceros 
INNER JOIN tesIdentifica ON tesCheqTerceros.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN tesBancos ON tesBancos.tesBancos = tesCheqTerceros.Banco_Id
INNER JOIN tesCTlink ON tesCTlink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros AND
	tesCTlink.Secuencia = tesCheqTerceros.SecuenciaActual
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesCTlink.tesMovimientos and 
	tesRengMovi.conRenglon = tesCTlink.conRenglon
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon =tesRengMovi.conRenglon
LEFT OUTER JOIN  venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id
WHERE
	1=2

-- tesRengMoviRetProvDebe --
Select tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, tesIdRetProv.Formula,
	tesRengMoviRetProv.Porcentaje, tesRengMoviRetProv.Exencion,
	tesRengMoviRetProv.BaseImponible, tesRengMoviRetProv.Acum, tesRengMoviRetProv.TRet, tesRengMoviRetProv.AcumTot,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR
From tesRengMoviRetProv
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesRengMoviRetProv.tesMovimientos and 
	tesRengMovi.conRenglon = tesRengMoviRetProv.conRenglon
Inner Join tesIdentifica On tesIdentifica.Cartera_Id = tesRengMovi.Cartera_Id
Inner Join tesIdRetProv On tesIdRetProv.Cartera_Id = tesIdentifica.Cartera_Id
Left Join (conAsientos Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos) 
			On conAsientos.conAsientos = tesRengMoviRetProv.comMovProv
Where 1 = 2

-- tesRengMoviRetProvHaber --
Select tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, tesIdRetProv.Formula,
	tesRengMoviRetProv.Porcentaje, tesRengMoviRetProv.Exencion,
	tesRengMoviRetProv.BaseImponible, tesRengMoviRetProv.Acum, tesRengMoviRetProv.TRet, tesRengMoviRetProv.AcumTot,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR
From tesRengMoviRetProv
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesRengMoviRetProv.tesMovimientos and 
	tesRengMovi.conRenglon = tesRengMoviRetProv.conRenglon
Inner Join tesIdentifica On tesIdentifica.Cartera_Id = tesRengMovi.Cartera_Id
Inner Join tesIdRetProv On tesIdRetProv.Cartera_Id = tesIdentifica.Cartera_Id
Left Join (conAsientos Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos) 
			On conAsientos.conAsientos = tesRengMoviRetProv.comMovProv
Where 1 = 2

-- tesMoviGravadoDebe --
SELECT tesMoviGravado.tesMovimientos, tesMoviGravado.TipoCtaProv, comProveedoresTipoPasivo.Descripcion as DescripcionProveedoresTipoPasivo,
	tesMoviGravado.Importe
FROM tesMoviGravado 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesMoviGravado.tesMovimientos)
INNER JOIN comProveedoresTipoPasivo  ON (comProveedoresTipoPasivo.TipoCtaProv = tesMoviGravado.TipoCtaProv)
WHERE 1 = 2
 
-- tesMoviGravadoHaber --
SELECT tesMoviGravado.tesMovimientos, tesMoviGravado.TipoCtaProv, comProveedoresTipoPasivo.Descripcion as DescripcionProveedoresTipoPasivo,
	tesMoviGravado.Importe
FROM tesMoviGravado 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesMoviGravado.tesMovimientos)
INNER JOIN comProveedoresTipoPasivo  ON (comProveedoresTipoPasivo.TipoCtaProv = tesMoviGravado.TipoCtaProv)
WHERE 1 = 2

--- AJ ReqCompPago

SELECT comMovProv.VieneDeFiscal as ReqCompPago ,  ' ' AS Segmento_Id, 0 as Segmento1N, 
	0 as Segmento2N, 0 as Segmento3N, 0 as Segmento4N, 
	' '  as Segmento1C, ' '  as Segmento2C,' '  as Segmento3C, ' '  as Segmento4C
from 
	comMovProv where comMovProv.comMovProv = @ptesMovimientos

-- FM Grilla de PDF generados por retenciones a proveedores --
Select '' PDF, '' NombreArchivo, Cast(0 As bigint) tesMovimientos, Cast(0 As Int) conRenglon

-- AJ Para V2 Impuestos y Sueldos

-- Impuestos y Sueldos
SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
		' ' Impuesto_Id, '  ' Descripcion,
		0.00 TotalaPagar, 
		conAsientos.Fecha FechaDesde, conAsientos.Fecha FechaHasta, conAsientos.Fecha FechaPago, 
		conAsientos.conAsientos, 0 as Grupo_Id, 0 as Anio, 0 as Mes, 0 as Quincena, 0 as Decena, 0 as Semana, 0 Vez
	FROM conAsientos INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
		1 = 2
		
Select Cast(0 As bigint) tesMovimientos, '' Impuesto_Id, '' DescripcionImpuestos, Cast(0 As numeric(12,2)) BaseImponible,
	Cast(0 As numeric(12,2)) Importe

SELECT tesMoviOficial.tesMovimientos, tesMoviOficial.Sucursal_Of, tesMoviOficial.Comprobante_Of 
FROM tesMoviOficial
WHERE 
	tesMoviOficial.tesMovimientos = @ptesMovimientos


--TarjetasHaber
SELECT CAST(0 as bit) as Marca, tesIdentifica.Cartera_Id, 
	tesIdentifica.Descripcion as DescripcionCartera, 
	tesBancos.Banco_Id, tesBancos.Descripcion AS DescripcionBanco,
	tesTarjetas3.Estado, tesTarjetas3.Cuotas, tesTarjetas3.Cupon, tesTarjetas3.Lote, 
	tesTarjetas3.Comercio,  tesTarjetas3.NroAutorizacion, tesTarjetas3.NroTarjeta, 
	tesTarjetas3.tesTarjetas3, conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	venClientes.Cliente_Id, venClientes.RazonSocial 
FROM tesTarjetas3 
INNER JOIN tesIdentifica ON tesTarjetas3.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN tesIdTarjetas3 ON tesTarjetas3.Cartera_Id = tesIdTarjetas3.Cartera_Id				
INNER JOIN tesT3Link ON tesT3Link.tesTarjetas3 = tesTarjetas3.tesTarjetas3 AND
	tesT3Link.Secuencia = tesTarjetas3.SecuenciaActual
INNER JOIN tesBancos ON tesBancos.tesBancos = tesIdTarjetas3.Banco_Id
INNER JOIN tesRengMovi ON tesT3Link.tesMovimientos = tesRengMovi.tesMovimientos AND
	tesT3Link.conRenglon = tesRengMovi.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon =tesRengMovi.conRenglon
LEFT OUTER JOIN  venClientes ON venClientes.genEntidades = tesTarjetas3.Cliente_Id
WHERE
	1=2
	

--TarjetasDebe
SELECT CAST(0 as bit) as Marca, tesIdentifica.Cartera_Id, 
	tesIdentifica.Descripcion as DescripcionCartera, 
	tesBancos.Banco_Id, tesBancos.Descripcion AS DescripcionBanco,
	tesTarjetas3.Estado, tesTarjetas3.Cuotas, tesTarjetas3.Cupon, tesTarjetas3.Lote, 
	tesTarjetas3.Comercio,  tesTarjetas3.NroAutorizacion, tesTarjetas3.NroTarjeta, 
	tesTarjetas3.tesTarjetas3, conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	venClientes.Cliente_Id, venClientes.RazonSocial 
FROM tesTarjetas3 
INNER JOIN tesIdentifica ON tesTarjetas3.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN tesIdTarjetas3 ON tesTarjetas3.Cartera_Id = tesIdTarjetas3.Cartera_Id				
INNER JOIN tesT3Link ON tesT3Link.tesTarjetas3 = tesTarjetas3.tesTarjetas3 AND
	tesT3Link.Secuencia = tesTarjetas3.SecuenciaActual
INNER JOIN tesBancos ON tesBancos.tesBancos = tesIdTarjetas3.Banco_Id
INNER JOIN tesRengMovi ON tesT3Link.tesMovimientos = tesRengMovi.tesMovimientos AND
	tesT3Link.conRenglon = tesRengMovi.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon =tesRengMovi.conRenglon
LEFT OUTER JOIN  venClientes ON venClientes.genEntidades = tesTarjetas3.Cliente_Id
WHERE
	1=2



RETURN @@Error 

GO

DROP PROCEDURE tesMovimientosEliminar
GO
CREATE PROCEDURE tesMovimientosEliminar
(
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM tesMovimientos 
WHERE (tesMovimientos = @ptesMovimientos)
 
RETURN @@Error 

GO

DROP PROCEDURE tesMovimientosDatosBaseDatosOfi
GO
CREATE PROCEDURE tesMovimientosDatosBaseDatosOfi  
(  
@pSucursal_Of Sucursal,  
@pComprobante_Of int  
)  
AS  
SET NOCOUNT ON   
  
Declare @ptesMovimientos as BigInt  
SET @ptesMovimientos = (SELECT tesMovimientos   
 FROM  tesMoviOficial  
 WHERE Sucursal_Of = @pSucursal_Of AND   
 Comprobante_Of = @pComprobante_Of AND
 NOT EXISTS (SELECT 1 FROM tesRecOfiAnul 
 WHERE tesMoviOficial.Sucursal_Of = tesRecOfiAnul.Sucursal_Of AND 
 tesMoviOficial.Comprobante_Of = tesRecOfiAnul.Comprobante_Of))  
  
SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Empresa_Id, genAsiSegmentos.Segmento1N,  
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,   
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,   
genAsiSegmentos.Segmento4C  
FROM tesMovimientos   
INNER JOIN genAsiSegmentos ON tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id  
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id  
 WHERE tesMovimientos.tesMovimientos = @ptesMovimientos  
  
RETURN @@Error   
GO


DROP PROCEDURE tesMovimientosDatosOfi
GO
CREATE PROCEDURE tesMovimientosDatosOfi
(
@pSucursal_Of Sucursal,
@pComprobante_Of int
)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (SELECT tesMovimientos 
	FROM  tesMoviOficial
	WHERE Sucursal_Of = @pSucursal_Of AND 
	Comprobante_Of = @pComprobante_Of)

SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Empresa_Id, genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
genAsiSegmentos.Segmento4C
FROM tesMovimientos 
INNER JOIN genAsiSegmentos ON tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE tesMovimientos.tesMovimientos = @ptesMovimientos

RETURN @@Error 
GO


DROP PROCEDURE tesMovimientosDatosOfi
GO
CREATE PROCEDURE tesMovimientosDatosOfi
(
@pSucursal_Of Sucursal,
@pComprobante_Of int
)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (SELECT tesMovimientos 
	FROM  tesMoviOficial
	WHERE Sucursal_Of = @pSucursal_Of AND 
	Comprobante_Of = @pComprobante_Of)

SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Empresa_Id, genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
genAsiSegmentos.Segmento4C
FROM tesMovimientos 
INNER JOIN genAsiSegmentos ON tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE tesMovimientos.tesMovimientos = @ptesMovimientos

RETURN @@Error 
GO


DROP PROCEDURE tesMovimientosDatosOfi
GO
CREATE PROCEDURE tesMovimientosDatosOfi
(
@pSucursal_Of Sucursal,
@pComprobante_Of int
)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (SELECT tesMovimientos 
	FROM  tesMoviOficial
	WHERE Sucursal_Of = @pSucursal_Of AND 
	Comprobante_Of = @pComprobante_Of)

SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Empresa_Id, genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
genAsiSegmentos.Segmento4C
FROM tesMovimientos 
INNER JOIN genAsiSegmentos ON tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE tesMovimientos.tesMovimientos = @ptesMovimientos

RETURN @@Error 
GO


