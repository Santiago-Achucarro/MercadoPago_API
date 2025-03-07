
DROP PROCEDURE inf_tesCobraProvDatos
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE inf_tesCobraProvDatos
(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos from 
	tesMovimientos INNER JOIN genAsiSegmentos ON
	tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )


SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
		genUsuarios.Apellido_y_Nombres as Usuario,
tesMovimientos.tesMovimientos, tesSubTiposMov.Tipomov, 
conAsientos.Fecha,conAsientos.FechaRegistro, genMonedas.Moneda_Id, 
	genMonedas.Descripcion as DescrpcionMoneda,  conAsientos.Cambio, 
	conAsientos.CambioMonedaOriginal, conAsientos.Anulado, 
	conAsientos.Observaciones, conAsientos.Posteado,
	disFormularios.Formulario_Id, disFormularios.Descripcion as DescripcionFormulario,
	tesSubTiposMov.SubTipo_Id, tesSubTiposMov.Descripcion as DescripcionSubTiposMov, 
	tesMovimientos.Fecha_Real, 
	venClientes.Cliente_Id, venClientes.RazonSocial as RazonSocialCliente,
	comProveedores.Proveed_Id, comProveedores.RazonSocial as RazonSocialProveedor,comProveedores.Direccion1, comProveedores.Direccion2,genProvincias.Descripcion as ProvinciaProv,
	genPaises.Descripcion as PaisProv,
	Convert(Numeric(18,2), 0) as TotalDebe,
	Convert(Numeric(18,2), 0) as TotalHaber,
	Convert(Numeric(18,2), 0) as TotalHabilitado
FROM tesMovimientos 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = tesMovimientos.tesMovimientos)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN tesSubTiposMov  ON (tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN disFormularios ON  disFormularios.disFormularios = conAsientos.Formulario_Id
LEFT OUTER JOIN (venMovimientos INNER JOIN venClientes ON
	venMovimientos.Cliente_Id = venClientes.genEntidades) ON 
	venMovimientos.venMovimientos = tesMovimientos.tesMovimientos
LEFT OUTER JOIN (comMovprov INNER JOIN comProveedores ON
	comMovprov.Proveed_Id = comProveedores.genEntidades) ON 
	comMovprov.comMovprov = tesMovimientos.tesMovimientos
inner join genUsuarios on conAsientos.Usuario_Id=genUsuarios.genUsuarios
inner join genProvincias on genProvincias.genProvincias=comProveedores.Provincia_Id
inner join genPaises on genPaises.genPaises=comProveedores.Pais
WHERE (tesMovimientos = @ptesMovimientos)

go
DROP PROCEDURE inf_tesCobraProvCuerpo
GO
CREATE PROCEDURE inf_tesCobraProvCuerpo
(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)

)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos from 
	tesMovimientos INNER JOIN genAsiSegmentos ON
	tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
tesRengMovi.tesMovimientos, tesRengMovi.conRenglon,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionIdentifica, 
	conMovCont.ImporteMonedaOriginal as ImporteOrig, conMovCont.Importe, 
	tesRengMovi.Cambio, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	conMovCont.Tipomov, conMovCont.Clase, 
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
	venClientes.Cliente_Id CTCliente_Id, venClientes.RazonSocial CTRazonSocial, 
	comMovprov.comMovprov FPAsiento_Id,  comMovprov.Fecha_CCP FPFecha_Ane, 
	comMovprov.FechaFiscal FPFechaFiscal,
	isNull(comProveedores.Proveed_Id, genEntidades.Cuit) FPCuit, genEntidades.TipoDoc FPTipoDoc, genEntidades.IdFiscal FPIdFiscal,
	isnull(comProveedores.RazonSocial, comProvAnexo.RazonSocial) FPRazonSocial,  
	isnull(comProveedores.Direccion1, comProvAnexo.Direccion1) FPDireccion1, 
	isnull(comProveedores.Direccion2, comProvAnexo.Direccion2) FPDireccion2, 
	isnull(comProveedores.Localidad, comProvAnexo.Localidad) as Localidad, 
	isnull(comProveedores.CodigoPostal, comProvAnexo.Cod_Postal) as Cod_Postal, 
	genProvincias.Provincia_Id, 
	genProvincias.Descripcion FPDescripcionPcia,
	comCondFiscal.CondFiscal_Id FPCondFiscal_Id, comCondFiscal.Descripcion as FPDescripcionCondFiscal, 
	comOrigenesFiscales.Origen_id FPOrigen_Id , comOrigenesFiscales.Descripcion as FPDescripcionOrigen,
	comMovprov.VieneDeFiscal FPVieneDeFiscal, comMovprov.XMLFiscal FPXMLFiscal, comMovProv.TipoCompFE FPTipoCompFE,
	comMovprov.ClaveFiscal FPClaveFiscal, tesRengMovicomMovProv.Renglon FPconRenglonProv, 
	'  ' as FPArchvoXml,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
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
		TesDeposito.CertPago as TDCertPago
FROM tesRengMovi 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = tesRengMovi.tesMovimientos) AND (conMovCont.Renglon = tesRengMovi.conRenglon)
INNER JOIN tesIdentifica  ON (tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id)
INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT OUTER JOIN conCentro1 ON  conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT OUTER JOIN conCentro2 ON  conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN tesTiposID ON (tesTiposID.tesTiposID = tesIdentifica.TipoCartera)
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id 
LEFT OUTER JOIN (tesCheqProp INNER JOIN tesBPlink ON 
			tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp
			INNER JOIN tesChequeras on tesChequeras.Chequera_Id = tesCheqProp.Chequera_Id
			LEFT OUTER JOIN tesBancos ON tesBancos.tesBancos = tesCheqProp.BancoDestino) ON
				tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos AND 
				tesBPlink.conRenglon =tesRengMovi.conRenglon
LEFT OUTER JOIN (tesCheqTerceros inner join tesCTLink ON tesCTLink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros
				INNER JOIN tesBancos tesBancosCT ON tesBancosCT.tesBancos = tesCheqTerceros.Banco_Id
				INNER JOIN tesClearing ON tesClearing.Clearing = tesCheqTerceros.Clearing
				INNER JOIN venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id) ON 
					tesCTLink.tesMovimientos = tesRengMovi.tesMovimientos and 
					tesCTLink.conRenglon =tesRengMovi.conRenglon 
					
LEFT OUTER JOIN ( tesRengMovicomMovProv inner join comMovprov ON
					tesRengMovicomMovProv.comMovprov = comMovprov.comMovprov 
					left join comProvAnexo ON comMovprov.Proveed_Id = comProvAnexo.genEntidades
					left join comProveedores ON comMovprov.Proveed_Id = comProveedores.genEntidades
				INNER JOIN genEntidades ON genEntidades.genEntidades = comMovprov.Proveed_Id
				INNER JOIN comCondFiscal ON comCondFiscal.comCondFiscal = comMovprov.CondFiscal_Id
				INNER JOIN comOrigenesFiscales ON comOrigenesFiscales.comOrigenesFiscales  = comMovprov.Origen_id
				INNER JOIN genProvincias ON genProvincias.genProvincias = ISNULL(comProvAnexo.Provincia_Id, comProveedores.Provincia_Id)
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
			TesDeposito.Renglon = TesDeposito.Renglon

			
				
WHERE tesRengMovi.tesMovimientos = @ptesMovimientos and 
	conMovCont.Tipomov = 1
ORDER BY 2
go


DROP PROCEDURE inf_tesCobraProvAdicional
GO
CREATE PROCEDURE inf_tesCobraProvAdicional
(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)

)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos from 
	tesMovimientos INNER JOIN genAsiSegmentos ON
	tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )


	SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
		genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio, genMovCuotas.CuotaNro, genMovCuotas.FechaVencimiento,
		genMovCuotas.Importe, genMovCuotas.Saldo, Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri,
		conAsientos.conAsientos, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, genCancMov.Importe ImporteHabilitado,
		isnull((select max(tesRengMovi.Cambio) from tesRengMovi, conMovCont conMovCont1 WHERE
			tesRengMovi.TesMovimientos = genCancMov.Asiento_Id_Ap and 
			tesRengMovi.TesMovimientos = conMovCont1.conAsientos AND 
			tesRengMovi.conRenglon = conMovCont1.Renglon and 
			conMovCont.Cuenta_id = conMovCont1.Cuenta_id),1)  as CambioPago,
			comMovProv.Fecha_CCP	
		
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
	INNER JOIN genCancMov ON genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
			genCancMov.CuotaNro_Ap = genMovCuotas.CuotaNro 
		where
				genCancMov.Asiento_Id = @ptesMovimientos and 
		genCancMov.CuotaNro = 1

go

