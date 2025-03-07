-- V2
-- genEmpresasdATOSINT 1
DROP PROCEDURE genEmpresasGuardar
GO
CREATE PROCEDURE genEmpresasGuardar
(
@pEmpresa_Id varchar(15),
@pEmpresa_Id_Nueva varchar(15),
@pDetalle varchar(100),
@pLogo VarChar(max) = NULL,
@pExtensionArchivo varchar(20),
@pMoneda_Id varchar(3) = NULL,
@pPais_Id smallint = NULL,
@pCuit qCuit,
@pCalle varchar(120),
@pNoExterior varchar(20),
@pNoInterior varchar(20),
@pColonia varchar(80),
@pLocalidad varchar(80),
@pMunicipio varchar(80),
@pReferencia varchar(20),
@pProvincia_Id varchar(5) = NULL,
@pCodigoPostal CodigoPostal,
@pFechaInicioSumma qFecha,
@pFechaInicioSociedad qFecha,
@pNumeroIIBB varchar(30),
@pIGJ varchar(20),
@pActividad varchar(80),
@pRegimen varchar(60), 
@pTelefono varchar(120) = Null,
@pInactivo bit, 
@pUsuario_id int, 
@pCarpetaEspecial varchar(200) = NULL, 
@pUsaCantidadAlterna bit,
@pUsaDespachoImportacion bit,
@pUsaSerie bit,
@pFechaCierreVentas qFecha,
@pFechaCierreCompras qFecha,
@pFechaCierreTesoreria qFecha,
@pFechaCierreStock qFecha,
@pFechaCalculoStock qFecha, 
@pRazonSocial VarChar(120),
@pTipoCosto char(1),
@pTipoCosto2 char(1),
@pTipoCosto3 char(1), 
@pCodLocalidad VarChar(10),
@pCodColonia VarChar(10),
@pCodMunicipio VarChar(10),
@pCondFiscal VarChar(60),
@pPaginaWeb VarChar(120), 
@pCtaMercaEnTransitoImpor VarChar(25)=null, 
@pSucursalCentral VarChar(4)=null, 
@pCtaMercTransito VarChar(25)=null, 
@pCtaApliImportacion VarChar(25)=null, 
@pCentro1De VarChar(3),
@pCentro2De VarChar(3), 
@pCtaUtiCambioRealizada VarChar(25)=null,
@pCtaPerCambioRealizada VarChar(25)=null,
@pCtaUtiCambioProv VarChar(25)=null,
@pCtaPerCambioProv VarChar(25)=null,
@pCtaAjuStockPos varchar(25)=null,
@pCtaAjuStockNeg varchar(25)=null,
@pServidor varchar(100)=null,
@pPuerto int =null,
@pCorreo varchar(200)=null,
@pUsuarioCorreo varchar(100)=null,
@pClave varchar(100)=null,
@pSeguridad varchar(3)=null,
@pCFVenta_Id varchar(5)=null,
@pMedida_Id varchar(5) =null,
@pEnviaFacturas bit,
@pEnviaRecibo bit,
@pEnviaOC bit,
@pEnviaPedido bit,
@pMailClientesSinMail varchar(200)=null, 
@pFechaCierreImpuestos qFecha,
@pCFAjusCtaCte varChar(5), 
@pFechaCierreActivoFijo DateTime, 
@pFechaCalculoActivoFijo DateTime,
@pFechaCalculoActivoDiferido DateTime,
@pTipoDtoFin Char(1),
@pMontoDtoFinanciero numeric(18,2),
@pCtaDtoFinPos VarChar(25)=null,
@pCtaDtoFinNeg VarChar(25)=null,
@pFechaCierreSueldos qFecha,
@pConfirmarEnviarPedidos SiNo,
@pConfirmarEnviarOC SiNo,
@pConfirmarEnviarRecibo SiNo,
@pConfirmarEnviarFacturas SiNo,
@pFirma varchar(max) = NULL,
@pImagenFirmaB64 varchar(max) = NULL, 
@pCuentasDeposito varchar(max) = NULL, 
@pRemisionesAlCosto Bit,
@pCtaRemisiones VarChar(25)= NULL,
@pUsaServerRH Bit,
@pServidorRH varchar(100)=null,
@pPuertoRH int =null,
@pCorreoRH varchar(200)=null,
@pUsuarioCorreoRH varchar(100)=null,
@pClaveRH varchar(100)=null,
@pSeguridadRH varchar(3)=null, 
@pTipoPermisoSCT VarChar(6)= NULL,
@pNroPermisoSCT VarChar(50) = NULL, 
@pTrabajaSabado Bit =0,
@pTrabajaDomingo Bit =0,
@pOrden int,
@pUsaCompOficiales bit,
@pEnviaPago SINO,
@pConfirmarEnviarPago SiNo,
@pFirmaSUE varchar(max) = NULL,
@pImagenFirmaB64SUE varchar(max) = NULL,
@pFirmaTES varchar(max) = NULL,
@pImagenFirmaB64TES varchar(max) = NULL,
@pFechaCierreComi qFecha,
@pDiaComi int = NULL
)

AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM genEmpresas WHERE (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE genEmpresas
	SET	@lIdentidad = genEmpresas,
		Empresa_Id = @pEmpresa_Id_Nueva,
		Detalle = @pDetalle,
		Logo = @pLogo,
		ExtensionArchivo = @pExtensionArchivo,
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Pais_Id = dbo.FuncFKgenPaises(@pPais_Id),
		Cuit = @pCuit,
		Calle = @pCalle,
		NoExterior = @pNoExterior,
		NoInterior = @pNoInterior,
		Colonia = @pColonia,
		Localidad = @pLocalidad,
		Municipio = @pMunicipio,
		Referencia = @pReferencia,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		CodigoPostal = @pCodigoPostal,
		FechaInicioSumma = @pFechaInicioSumma,
		FechaInicioSociedad = @pFechaInicioSociedad,
		NumeroIIBB = @pNumeroIIBB,
		IGJ = @pIGJ,
		Actividad = @pActividad,
		Regimen = @pRegimen, 
		Inactivo = @pInactivo, 
		Telefono = @pTelefono,
		Usuario_id = @pUsuario_id, 
		CarpetaEspecial = @pCarpetaEspecial, 
		UsaCantidadAlterna =@pUsaCantidadAlterna,
		UsaDespachoImportacion = @pUsaDespachoImportacion,
		UsaSerie = @pUsaSerie,
		FechaCierreVentas = @pFechaCierreVentas,
		FechaCierreCompras= @pFechaCierreCompras,
		FechaCierreTesoreria = @pFechaCierreTesoreria,
		FechaCierreStock = @pFechaCierreStock,
		FechaCalculoStock = @pFechaCalculoStock, 
		RazonSocial = @pRazonSocial,
		TipoCosto = @pTipoCosto,
		TipoCosto2 = @pTipoCosto2,
		TipoCosto3 = @pTipoCosto3,
		CodLocalidad = @pCodLocalidad,
		CodColonia = @pCodColonia ,
		CodMunicipio = @pCodMunicipio,
		CondFiscal=	@pCondFiscal ,
		PaginaWeb = @pPaginaWeb , 
		CtaMercaEnTransitoImpor = dbo.FuncFKconCuentas(@pCtaMercaEnTransitoImpor), 
		SucursalCentral = dbo.FuncFKgenSucursalesEmpr(@pSucursalCentral), 
		CtaMercTransito =dbo.FuncFKconCuentas(@pCtaMercTransito), 
		CtaApliImportacion = dbo.FuncFKconCuentas(@pCtaApliImportacion), 
		Centro1De = @pCentro1De, 
		Centro2De = @pCentro2De, 
		CtaUtiCambioRealizada = dbo.FuncFKconCuentas(@pCtaUtiCambioRealizada),
		CtaPerCambioRealizada = dbo.FuncFKconCuentas(@pCtaPerCambioRealizada),
		CtaUtiCambioProv = dbo.FuncFKconCuentas(@pCtaUtiCambioProv),
		CtaPerCambioProv = dbo.FuncFKconCuentas(@pCtaPerCambioProv),
		CtaAjuStockPos = dbo.FuncFKconCuentas(@pCtaAjuStockPos),
		CtaAjuStockNeg = dbo.FuncFKconCuentas(@pCtaAjuStockNeg),
		Servidor=@pServidor,
		Puerto=@pPuerto,
		Correo=@pCorreo,
		UsuarioCorreo=@pUsuarioCorreo,
		Clave=@pClave,
		Seguridad=@pSeguridad,
		CFVenta_Id=dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		Medida_Id=dbo.FuncFKstkUniMed(@pMedida_Id),
		EnviaFacturas=@pEnviaFacturas,
		EnviaRecibo=@pEnviaRecibo,
		EnviaOC=@pEnviaOC,
		EnviaPedido = @pEnviaPedido,
		MailClientesSinMail=@pMailClientesSinMail, 
		FechaCierreImpuestos = @pFechaCierreImpuestos,
		CFAjusCtaCte = dbo.FuncFKstkCondFisVenta(@pCFAjusCtaCte), 
		FechaCierreActivoFijo = @pFechaCierreActivoFijo, 
		FechaCalculoActivoFijo = @pFechaCalculoActivoFijo, 
		FechaCalculoActivoDiferido = @pFechaCalculoActivoDiferido,
		TipoDtoFin = @pTipoDtoFin, 
		MontoDtoFinanciero = @pMontoDtoFinanciero,
		CtaDtoFinPos = dbo.FuncFKconCuentas(@pCtaDtoFinPos),
		CtaDtoFinNeg = dbo.FuncFKconCuentas(@pCtaDtoFinNeg),
		FechaCierreSueldos=@pFechaCierreSueldos,
		ConfirmarEnviarPedidos=@pConfirmarEnviarPedidos,
		ConfirmarEnviarFacturas=@pConfirmarEnviarFacturas,
		ConfirmarEnviarOC=@pConfirmarEnviarOC,
		ConfirmarEnviarRecibo=@pConfirmarEnviarRecibo,
		Firma=@pFirma,
		ImagenFirmaB64=@pImagenFirmaB64, 
		CuentasDeposito = @pCuentasDeposito, 
		RemisionesAlCosto = @pRemisionesAlCosto, 
		CtaRemisiones = dbo.FuncFKconCuentas(@pCtaRemisiones),
		UsaServerRH = @pUsaServerRH,
		ServidorRH=@pServidorRH,
		PuertoRH=@pPuertoRH,
		CorreoRH=@pCorreoRH,
		UsuarioCorreoRH=@pUsuarioCorreoRH,
		ClaveRH=@pClaveRH,
		SeguridadRH=@pSeguridadRH,
		TipoPermisoSCT = @pTipoPermisoSCT ,
		NroPermisoSCT = @pNroPermisoSCT, 
		TrabajaSabado= @pTrabajaSabado, 
		TrabajaDomingo = @pTrabajaDomingo,
		Orden = @pOrden,
		UsaCompOficiales = @pUsaCompOficiales,
		EnviaPago = @pEnviaPago,
		ConfirmarEnviarPago = @pConfirmarEnviarPago,
		FirmaSUE = @pFirmaSUE,
		ImagenFirmaB64SUE = @pImagenFirmaB64SUE, 
		FirmaTES = @pFirmaTES,
		ImagenFirmaB64TES = @pImagenFirmaB64TES,
		DiaComi = @pDiaComi,
		FechaCierreComi = @pFechaCierreComi
	WHERE (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genEmpresas
	(
		Empresa_Id,
		Detalle,
		Logo,
		ExtensionArchivo,
		Moneda_Id,
		Pais_Id,
		Cuit,
		Calle,
		NoExterior,
		NoInterior,
		Colonia,
		Localidad,
		Municipio,
		Referencia,
		Provincia_Id,
		CodigoPostal,
		FechaInicioSumma,
		FechaInicioSociedad,
		NumeroIIBB,
		IGJ,
		Actividad,
		Regimen, 
		Telefono,
		Inactivo, 
		Usuario_id, 
		CarpetaEspecial, 
		UsaCantidadAlterna,
		UsaDespachoImportacion,
		UsaSerie,
		FechaCierreVentas,
		FechaCierreCompras,
		FechaCierreTesoreria,
		FechaCierreStock,
		FechaCalculoStock, 
		RazonSocial,
		TipoCosto,
		TipoCosto2,
		TipoCosto3,
		CodLocalidad ,
		CodColonia,
		CodMunicipio,
		CondFiscal,
		PaginaWeb, 
		CtaMercaEnTransitoImpor ,
		SucursalCentral, 
		CtaMercTransito,
		CtaApliImportacion, 
		Centro1De, 
		Centro2De,
		CtaUtiCambioRealizada,
		CtaPerCambioRealizada,
		CtaUtiCambioProv,
		CtaPerCambioProv,
		CtaAjuStockPos,
		CtaAjuStockNeg,
		Servidor,
		Puerto,
		Correo,
		UsuarioCorreo,
		Clave,
		Seguridad,
		CFVenta_Id,
		Medida_Id,
		EnviaFacturas,
		EnviaRecibo,
		EnviaOC,
		EnviaPedido,
		MailClientesSinMail, 
		FechaCierreImpuestos,
		CFAjusCtaCte, 
		FechaCierreActivoFijo,
		FechaCalculoActivoFijo, 
		FechaCalculoActivoDiferido,
		TipoDtoFin , 
		MontoDtoFinanciero,
		CtaDtoFinPos,
		CtaDtoFinNeg,
		FechaCierreSueldos,
		ConfirmarEnviarFacturas,
		ConfirmarEnviarOC,
		ConfirmarEnviarPedidos,
		ConfirmarEnviarRecibo,
		Firma,
		ImagenFirmaB64, 
		CuentasDeposito, 
		RemisionesAlCosto, 
		CtaRemisiones, 
		UsaServerRH, 
		ServidorRH,
		PuertoRH,
		CorreoRH,
		UsuarioCorreoRH,
		ClaveRH,
		SeguridadRH,
		TipoPermisoSCT,
		NroPermisoSCT, 
		TrabajaSabado, 
		TrabajaDomingo,
		Orden,
		UsaCompOficiales,
		EnviaPago,
		ConfirmarEnviarPago,
		FirmaSUE,
		ImagenFirmaB64SUE, 
		FirmaTES,
		ImagenFirmaB64TES,
		DiaComi,
		FechaCierreComi
		)
	VALUES 
	(
		@pEmpresa_Id_Nueva,
		@pDetalle,
		@pLogo,
		@pExtensionArchivo,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKgenPaises(@pPais_Id),
		@pCuit,
		@pCalle,
		@pNoExterior,
		@pNoInterior,
		@pColonia,
		@pLocalidad,
		@pMunicipio,
		@pReferencia,
		dbo.FuncFKgenProvincias(@pProvincia_Id),
		@pCodigoPostal,
		@pFechaInicioSumma,
		@pFechaInicioSociedad,
		@pNumeroIIBB,
		@pIGJ,
		@pActividad,
		@pRegimen, 
		@pTelefono,
		@pInactivo, 
		@pUsuario_id, 
		@pCarpetaEspecial, 
		@pUsaCantidadAlterna,
		@pUsaDespachoImportacion,
		@pUsaSerie,
		@pFechaCierreVentas,
		@pFechaCierreCompras,
		@pFechaCierreTesoreria,
		@pFechaCierreStock,
		@pFechaCalculoStock, 
		@pRazonSocial,
		@pTipoCosto,
		@pTipoCosto2,
		@pTipoCosto3,
		@pCodLocalidad ,
		@pCodColonia,
		@pCodMunicipio,
		@pCondFiscal,
		@pPaginaWeb,
		dbo.FuncFKconCuentas(@pCtaMercaEnTransitoImpor),
		dbo.FuncFKgenSucursalesEmpr(@pSucursalCentral), 
		dbo.FuncFKconCuentas(@pCtaMercTransito),
		dbo.FuncFKconCuentas(@pCtaApliImportacion), 
		@pCentro1De, 
		@pCentro2De, 
		dbo.FuncFKconCuentas(@pCtaUtiCambioRealizada),
		dbo.FuncFKconCuentas(@pCtaPerCambioRealizada),
		dbo.FuncFKconCuentas(@pCtaUtiCambioProv),
		dbo.FuncFKconCuentas(@pCtaPerCambioProv),
		dbo.FuncFKconCuentas(@pCtaAjuStockPos),
		dbo.FuncFKconCuentas(@pCtaAjuStockNeg),
		@pServidor,
		@pPuerto,
		@pCorreo,
		@pUsuarioCorreo,
		@pClave,
		@pSeguridad,
		dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pEnviaFacturas,
		@pEnviaRecibo,
		@pEnviaOC,
		@pEnviaPedido,
		@pMailClientesSinMail,
		@pFechaCierreImpuestos,
		dbo.FuncFKstkCondFisVenta(@pCFAjusCtaCte), 
		@pFechaCierreActivoFijo,
		@pFechaCalculoActivoFijo, 
		@pFechaCalculoActivoDiferido,
		@pTipoDtoFin,
		@pMontoDtoFinanciero,
		dbo.FuncFKconCuentas(@pCtaDtoFinPos),
		dbo.FuncFKconCuentas(@pCtaDtoFinNeg),
		@pFechaCierreSueldos,
		@pConfirmarEnviarFacturas,
		@pConfirmarEnviarOC,
		@pConfirmarEnviarPedidos,
		@pConfirmarEnviarRecibo,
		@pFirma,
		@pImagenFirmaB64, 
		@pCuentasDeposito, 
		@pRemisionesAlCosto, 
		dbo.FuncFKconCuentas(@pCtaRemisiones), 
		@pUsaServerRH, 
		@pServidorRH,
		@pPuertoRH,
		@pCorreoRH,
		@pUsuarioCorreoRH,
		@pClaveRH,
		@pSeguridadRH,
		@pTipoPermisoSCT,
		@pNroPermisoSCT, 
		@pTrabajaSabado, 
		@pTrabajaDomingo,
		@pOrden,
		@pUsaCompOficiales,
		@pEnviaPago,
		@pConfirmarEnviarPago,
		@pFirmaSUE,
		@pImagenFirmaB64SUE, 
		@pFirmaTES,
		@pImagenFirmaB64TES,
		@pDiaComi,
		@pFechaCierreComi
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 

	DECLARE @Empresa1 Int
	SET @Empresa1 = (select MIN(genEmpresas) from genEmpresas)

	INSERT INTO genGlobales(Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,
	nValor,cValor,fValor,mValor,SubSistema,SoloLectura,lupIdentidad,WhereF10)
	select @lIdentidad Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,
	CASE WHEN Nombre_Var = 'CONPERIODOS' then nValor else 0 end nValor,' ' cValor,NULL  fValor,NULL  mValor,SubSistema,SoloLectura,lupIdentidad,
	WhereF10 from genGlobales where Empresa_Id = @Empresa1
END 

Select @lIdentidad as RetVal 
GO


DROP PROCEDURE genEmpresasDatos
GO
CREATE PROCEDURE genEmpresasDatos
(
@pEmpresa_Id varchar(15)
)
AS
SET NOCOUNT ON 

Declare @pIdentity bigint= dbo.FuncFKgenEmpresas(@pEmpresa_Id)

Exec genEmpresasDatosInt @pIdentity

GO

DROP PROCEDURE genEmpresasDatosInt
GO
CREATE PROCEDURE genEmpresasDatosInt
(
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT genEmpresas.genEmpresas, genEmpresas.Empresa_Id, genEmpresas.Detalle, genEmpresas.Logo, '' LogoOriginal,
	genEmpresas.ExtensionArchivo, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, genPaises.Pais_Id,
	genPaises.Descripcion as DescripcionPaises, genEmpresas.Cuit, genEmpresas.Calle, genEmpresas.NoExterior,
	genEmpresas.NoInterior, genEmpresas.Colonia, genEmpresas.Localidad, genEmpresas.Municipio,
	genEmpresas.Referencia, genProvincias.Provincia_Id, genProvincias.Descripcion as DescripcionProvincias, genEmpresas.CodigoPostal,
	genEmpresas.FechaInicioSumma, genEmpresas.FechaInicioSociedad, genEmpresas.FechaCierreVentas, genEmpresas.FechaCierreCompras,
	genEmpresas.FechaCierreTesoreria, genEmpresas.FechaCierreStock, genEmpresas.FechaCalculoStock, genEmpresas.FechaCierreSueldos,
	genEmpresas.NumeroIIBB, genEmpresas.IGJ,
	genEmpresas.Actividad, genEmpresas.Regimen, genEmpresas.Telefono, genEmpresas.Inactivo, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	genInstalacion.Dominio_Id, genEmpresas.CarpetaEspecial, genEmpresas.UsaCantidadAlterna,
	genEmpresas.UsaDespachoImportacion,genEmpresas.UsaSerie, genEmpresas.RazonSocial,
	genEmpresas.TipoCosto, genEmpresas.TipoCosto2, genEmpresas.TipoCosto3, 
	genEmpresas.CodLocalidad , genEmpresas.CodColonia, genEmpresas.CodMunicipio,
	genEmpresas.CondFiscal, genEmpresas.PaginaWeb, 
	conCuentas.Cuenta_Id as CtaMercaEnTransitoImpor, conCuentas.Descripcion as DescripcionCtaMercaEnTransitoImpor,
	conCuentasTran.Cuenta_Id as CtaMercTransito, conCuentasTran.Descripcion as DescripcionCtaMercTransito, 
	conCuentasApimp.Cuenta_Id as CtaApliImportacion, conCuentasApimp.Descripcion as DescripcionCtaApliImportacion, 
	genSucursalesEmpr.Sucursal as SucursalCentral, genSucursalesEmpr.Descripcion as DescripcionSucursalCentral, 
	Centro1De, Centro2De, 
		CtaUtiCambioRealizada.Cuenta_Id CtaUtiCambioRealizada, CtaUtiCambioRealizada.Descripcion as DescripcionCtaUtiCambioRealizada,
		CtaPerCambioRealizada.Cuenta_Id CtaPerCambioRealizada, CtaPerCambioRealizada.Descripcion as DescripcionCtaPerCambioRealizada,
		CtaUtiCambioProv.Cuenta_Id CtaUtiCambioProv, CtaUtiCambioProv.Descripcion as DescripcionCtaUtiCambioProv,
		CtaPerCambioProv.Cuenta_Id CtaPerCambioProv, CtaPerCambioProv.Descripcion as DescripcionCtaPerCambioProv,
		CtaAjuStockPos.Cuenta_Id as CtaAjuStockPos, CtaAjuStockPos.Descripcion as CtaAjuStockPosDescripcion,
		CtaAjuStockNeg.Cuenta_Id as CtaAjuStockNeg, CtaAjuStockNeg.Descripcion as CtaAjuStockNegDescripcion,
		genEmpresas.Servidor,genEmpresas.Puerto,genEmpresas.Correo,genEmpresas.UsuarioCorreo,genEmpresas.Clave,
		genEmpresas.Seguridad,CFVenta_Id.CFVenta_Id, CFVenta_Id.Descripcion as DescripcionCFVenta_Id,Medida_Id.Medida_Id,Medida_Id.Descripcion as DescripcionMedida_Id,genEmpresas.EnviaFacturas,genEmpresas.EnviaRecibo,
		genEmpresas.EnviaOC,genEmpresas.EnviaPedido, genEmpresas.MailClientesSinMail, genEmpresas.FechaCierreImpuestos,
		CFAjusCtaCte.CFVenta_Id CFAjusCtaCte, CFAjusCtaCte.Descripcion DescripcionCFAjusCtaCte, 
		genEmpresas.FechaCierreActivoFijo, genEmpresas.FechaCalculoActivoFijo, 
		genEmpresas.FechaCalculoActivoDiferido, 
		genEmpresas.TipoDtoFin, genEmpresas.MontoDtoFinanciero, 
	CtaDtoFinPos.Cuenta_Id as CtaDtoFinPos, CtaDtoFinPos.Descripcion  DescripcionCtaDtoFinPos,
	CtaDtoFinNeg.Cuenta_Id as CtaDtoFinNeg, CtaDtoFinNeg.Descripcion  DescripcionCtaDtoFinNeg,
	genEmpresas.ConfirmarEnviarFacturas, genEmpresas.ConfirmarEnviarOC, genEmpresas.ConfirmarEnviarPedidos, genEmpresas.ConfirmarEnviarRecibo,
	genEmpresas.Firma, genEmpresas.ImagenFirmaB64, genEmpresas.CuentasDeposito, 
	genEmpresas.RemisionesAlCosto, CtaRemisiones.Cuenta_Id as CtaRemisiones ,
		CtaRemisiones.Descripcion as DescripcionCtaRemisiones, 
		genEmpresas.UsaServerRH, genEmpresas.ServidorRH,genEmpresas.PuertoRH,genEmpresas.CorreoRH,genEmpresas.UsuarioCorreoRH,
		genEmpresas.ClaveRH,genEmpresas.SeguridadRH, genEmpresas.TipoPermisoSCT, genEmpresas.NroPermisoSCT, 
		genEmpresas.TrabajaSabado, genEmpresas.TrabajaDomingo, genEmpresas.Orden, '' MailDestino, genEmpresas.UsaCompOficiales,
		genEmpresas.EnviaPago, genEmpresas.ConfirmarEnviarPago, genEmpresas.FirmaSUE, genEmpresas.ImagenFirmaB64SUE,
		genEmpresas.FirmaTES, genEmpresas.ImagenFirmaB64TES, genEmpresas.DiaComi, genEmpresas.FechaCierreComi
FROM genEmpresas 
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = genEmpresas.Moneda_Id)
LEFT JOIN genPaises  ON (genPaises.genPaises = genEmpresas.Pais_Id)
Cross join genInstalacion
LEFT JOIN genProvincias  ON (genProvincias.genProvincias = genEmpresas.Provincia_Id)
LEFT JOIN genUsuarios ON genUsuarios.genUsuarios = genEmpresas.Usuario_id
LEFT JOIN conCuentas ON genEmpresas.CtaMercaEnTransitoImpor = conCuentas.conCuentas
LEFT JOIN conCuentas AS conCuentasTran ON genEmpresas.CtaMercTransito = conCuentasTran.conCuentas
LEFT JOIN conCuentas as conCuentasApimp ON genEmpresas.CtaApliImportacion = conCuentasApimp.conCuentas
LEFT JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = genEmpresas.SucursalCentral
LEFT JOIN conCuentas as CtaUtiCambioRealizada ON CtaUtiCambioRealizada.conCuentas = genEmpresas.CtaUtiCambioRealizada
LEFT JOIN conCuentas as CtaPerCambioRealizada ON CtaPerCambioRealizada.conCuentas = genEmpresas.CtaPerCambioRealizada
LEFT JOIN conCuentas as CtaUtiCambioProv ON CtaUtiCambioProv.conCuentas = genEmpresas.CtaUtiCambioProv
LEFT JOIN conCuentas as CtaPerCambioProv ON CtaPerCambioProv.conCuentas = genEmpresas.CtaPerCambioProv
left join conCuentas as CtaAjuStockPos on CtaAjuStockPos.conCuentas=genEmpresas.CtaAjuStockPos
left join conCuentas as CtaAjuStockNeg on CtaAjuStockNeg.conCuentas=genEmpresas.CtaAjuStockNeg
left join stkCondFisVenta CFVenta_Id on CFVenta_Id.stkCondFisVenta=genEmpresas.CFVenta_Id
left join stkUniMed Medida_Id on Medida_Id.stkUniMed=genEmpresas.Medida_Id
Left Join stkCondFisVenta as CFAjusCtaCte On CFAjusCtaCte.stkCondFisVenta = genEmpresas.CFAjusCtaCte
left join conCuentas as CtaDtoFinPos on CtaDtoFinPos.conCuentas=genEmpresas.CtaDtoFinPos
left join conCuentas as CtaDtoFinNeg on CtaDtoFinNeg.conCuentas=genEmpresas.CtaDtoFinNeg
left join conCuentas as CtaRemisiones on CtaRemisiones.conCuentas=genEmpresas.CtaRemisiones
WHERE (genEmpresas.genEmpresas= @pEmpresa_Id)

Exec genAtributosGeneralesIdentityDatos @pEmpresa_Id, 'genEmpresas'
RETURN @@Error 

GO


Drop procedure genEmpresasSetFechaActivoFijo
Go
Create procedure genEmpresasSetFechaActivoFijo
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCierreActivoFijo = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go

Drop procedure genEmpresasSetFechaSueldos
Go
Create procedure genEmpresasSetFechaSueldos
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCierreSueldos = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go


Drop procedure genEmpresasSetFechaCalcActivoFijo
Go
Create procedure genEmpresasSetFechaCalcActivoFijo
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCalculoActivoFijo = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go


Drop procedure genEmpresasSetFechaCalcActivoDiferido
Go
Create procedure genEmpresasSetFechaCalcActivoDiferido
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCalculoActivoDiferido = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go


DROP PROCEDURE genEmpresasGuardarConMovimientos
GO
CREATE PROCEDURE genEmpresasGuardarConMovimientos
(
@pEmpresa_Id varchar(15),
@pEmpresa_Id_Nueva varchar(15),
@pDetalle varchar(100),
@pLogo VarChar(max) = NULL,
@pExtensionArchivo varchar(20),
--@pMoneda_Id varchar(3) = NULL,
@pPais_Id smallint = NULL,
@pCuit qCuit,
@pCalle varchar(120),
@pNoExterior varchar(20),
@pNoInterior varchar(20),
@pColonia varchar(80),
@pLocalidad varchar(80),
@pMunicipio varchar(80),
@pReferencia varchar(20),
@pProvincia_Id varchar(5) = NULL,
@pCodigoPostal CodigoPostal,
@pFechaInicioSumma qFecha,
@pFechaInicioSociedad qFecha,
@pNumeroIIBB varchar(30),
@pIGJ varchar(20),
@pActividad varchar(80),
@pRegimen varchar(60), 
@pTelefono varchar(120) = Null,
@pInactivo bit, 
@pUsuario_id int, 
@pCarpetaEspecial varchar(200) = NULL, 
@pUsaCantidadAlterna bit,
@pUsaDespachoImportacion bit,
@pUsaSerie bit,
@pFechaCierreVentas qFecha,
@pFechaCierreCompras qFecha,
@pFechaCierreTesoreria qFecha,
@pFechaCierreStock qFecha,
@pFechaCalculoStock qFecha, 
@pRazonSocial VarChar(120),
@pTipoCosto char(1),
@pTipoCosto2 char(1),
@pTipoCosto3 char(1),
@pCodLocalidad VarChar(10),
@pCodColonia VarChar(10),
@pCodMunicipio VarChar(10),
@pCondFiscal VarChar(60),
@pPaginaWeb VarChar(120),
@pCtaMercaEnTransitoImpor VarChar(25)=null,
@pSucursalCentral VarChar(4)=null, 
@pCtaMercTransito VarChar(25)=null, 
@pCtaApliImportacion VarChar(25)=null, 
@pCentro1De VarChar(3), 
@pCentro2De VarChar(3),
@pCtaUtiCambioRealizada VarChar(25)=null,
@pCtaPerCambioRealizada VarChar(25)=null,
@pCtaUtiCambioProv VarChar(25)=null,
@pCtaPerCambioProv VarChar(25)=null,
@pCtaAjuStockPos varchar(25)=null,
@pCtaAjuStockNeg varchar(25)=null,
@pServidor varchar(100)=null,
@pPuerto int =null,
@pCorreo varchar(200)=null,
@pUsuarioCorreo varchar(100)=null,
@pClave varchar(100)=null,
@pSeguridad varchar(3)=null,
@pCFVenta_Id varchar(5)=null,
@pMedida_Id varchar(5) =null,
@pEnviaFacturas bit,
@pEnviaRecibo bit,
@pEnviaOC bit,
@pEnviaPedido bit,
@pMailClientesSinMail varchar(200)=null, 
@pFechaCierreImpuestos qFecha,
@pCFAjusCtaCte varChar(5),
@pTipoDtoFin Char(1),
@pMontoDtoFinanciero numeric(18,2),
@pCtaDtoFinPos VarChar(25)=null,
@pCtaDtoFinNeg VarChar(25)=null,
@pFechaCalculoActivoDiferido qFecha,
@pFechaCalculoActivoFijo qFecha,
@pFechaCierreActivoFijo qFecha,
@pFechaCierreSueldos qFecha,
@pConfirmarEnviarPedidos SiNo,
@pConfirmarEnviarOC SiNo,
@pConfirmarEnviarRecibo SiNo,
@pConfirmarEnviarFacturas SiNo,
@pFirma varchar(max) = NULL,
@pImagenFirmaB64 varchar(max) = NULL, 
@pCuentasDeposito VarChar(Max) = NULL, 
@pRemisionesAlCosto Bit,
@pCtaRemisiones VarChar(25)= NULL,
@pUsaServerRH Bit,
@pServidorRH varchar(100)=null,
@pPuertoRH int =null,
@pCorreoRH varchar(200)=null,
@pUsuarioCorreoRH varchar(100)=null,
@pClaveRH varchar(100)=null,
@pSeguridadRH varchar(3)=null, 
@pTipoPermisoSCT VarChar(6)= NULL,
@pNroPermisoSCT VarChar(50) = NULL, 
@pTrabajaSabado Bit =0,
@pTrabajaDomingo Bit =0,
@pOrden int,
@pUsaCompOficiales bit,
@pEnviaPago SINO,
@pConfirmarEnviarPago SINO,
@pFirmaSUE varchar(max) = NULL,
@pImagenFirmaB64SUE varchar(max) = NULL, 
@pFirmaTES varchar(max) = NULL,
@pImagenFirmaB64TES varchar(max) = NULL,
@pFechaCierreComi qFecha,
@pDiaComi int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
SET @lIdentidad = (SELECT genEmpresas FROM genEmpresas WHERE (Empresa_Id = @pEmpresa_Id))

IF (EXISTS (SELECT 1 FROM genEmpresas WHERE (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE genEmpresas
	SET	Empresa_Id = @pEmpresa_Id_Nueva,
		Detalle = @pDetalle,
		Logo = @pLogo,
		ExtensionArchivo = @pExtensionArchivo,
		--Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Pais_Id = dbo.FuncFKgenPaises(@pPais_Id),
		Cuit = @pCuit,
		Calle = @pCalle,
		NoExterior = @pNoExterior,
		NoInterior = @pNoInterior,
		Colonia = @pColonia,
		Localidad = @pLocalidad,
		Municipio = @pMunicipio,
		Referencia = @pReferencia,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		CodigoPostal = @pCodigoPostal,
		FechaInicioSumma = @pFechaInicioSumma,
		FechaInicioSociedad = @pFechaInicioSociedad,
		NumeroIIBB = @pNumeroIIBB,
		IGJ = @pIGJ,
		Actividad = @pActividad,
		Regimen = @pRegimen, 
		Inactivo = @pInactivo, 
		Telefono = @pTelefono,
		Usuario_id = @pUsuario_id, 
		CarpetaEspecial = @pCarpetaEspecial, 
		UsaCantidadAlterna =@pUsaCantidadAlterna,
		UsaDespachoImportacion = @pUsaDespachoImportacion,
		UsaSerie = @pUsaSerie,
		FechaCierreVentas = @pFechaCierreVentas,
		FechaCierreCompras= @pFechaCierreCompras,
		FechaCierreTesoreria = @pFechaCierreTesoreria,
		FechaCierreStock = @pFechaCierreStock,
		FechaCalculoStock = @pFechaCalculoStock, 
		RazonSocial = @pRazonSocial,
		TipoCosto = @pTipoCosto,
		TipoCosto2 = @pTipoCosto2,
		TipoCosto3 = @pTipoCosto3,
		CodLocalidad = @pCodLocalidad,
		CodColonia = @pCodColonia ,
		CodMunicipio = @pCodMunicipio,
		CondFiscal=	@pCondFiscal ,
		PaginaWeb = @pPaginaWeb , 
		CtaMercaEnTransitoImpor = dbo.FuncFKconCuentas(@pCtaMercaEnTransitoImpor),
		SucursalCentral = dbo.FuncFKgenSucursalesEmpr(@pSucursalCentral), 
		CtaMercTransito =dbo.FuncFKconCuentas(@pCtaMercTransito), 
		CtaApliImportacion = dbo.FuncFKconCuentas(@pCtaApliImportacion), 
		Centro1De = @pCentro1De, Centro2De = @pCentro2De,
		CtaUtiCambioRealizada = dbo.FuncFKconCuentas(@pCtaUtiCambioRealizada),
		CtaPerCambioRealizada = dbo.FuncFKconCuentas(@pCtaPerCambioRealizada),
		CtaUtiCambioProv = dbo.FuncFKconCuentas(@pCtaUtiCambioProv),
		CtaPerCambioProv = dbo.FuncFKconCuentas(@pCtaPerCambioProv),
		CtaAjuStockPos = dbo.FuncFKconCuentas(@pCtaAjuStockPos),
		CtaAjuStockNeg = dbo.FuncFKconCuentas(@pCtaAjuStockNeg),
		Servidor=@pServidor,
		Puerto=@pPuerto,
		Correo=@pCorreo,
		UsuarioCorreo=@pUsuarioCorreo,
		Clave=@pClave,
		Seguridad=@pSeguridad,
		CFVenta_Id=dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		Medida_Id=dbo.FuncFKstkUniMed(@pMedida_Id),
		EnviaFacturas=@pEnviaFacturas,
		EnviaRecibo=@pEnviaRecibo,
		EnviaOC=@pEnviaOC,
		EnviaPedido = @pEnviaPedido,
		MailClientesSinMail=@pMailClientesSinMail, 
		FechaCierreImpuestos = @pFechaCierreImpuestos,
		CFAjusCtaCte = dbo.FuncFKstkCondFisVenta(@pCFAjusCtaCte),
		TipoDtoFin = @pTipoDtoFin, 
		MontoDtoFinanciero = @pMontoDtoFinanciero,
		CtaDtoFinPos = dbo.FuncFKconCuentas(@pCtaDtoFinPos),
		CtaDtoFinNeg = dbo.FuncFKconCuentas(@pCtaDtoFinNeg),
		FechaCalculoActivoDiferido=@pFechaCalculoActivoDiferido,
		FechaCalculoActivoFijo=@pFechaCalculoActivoFijo,
		FechaCierreActivoFijo=@pFechaCalculoStock,
		FechaCierreSueldos=@pFechaCierreSueldos,
		ConfirmarEnviarPedidos=@pConfirmarEnviarPedidos,
		ConfirmarEnviarFacturas=@pConfirmarEnviarFacturas,
		ConfirmarEnviarOC=@pConfirmarEnviarOC,
		ConfirmarEnviarRecibo=@pConfirmarEnviarRecibo,
		Firma=@pFirma,
		ImagenFirmaB64=@pImagenFirmaB64, 
		CuentasDeposito = @pCuentasDeposito, 
		RemisionesAlCosto = @pRemisionesAlCosto, 
		CtaRemisiones = dbo.FuncFKconCuentas(@pCtaRemisiones),
		UsaServerRH = @pUsaServerRH,
		ServidorRH=@pServidorRH,
		PuertoRH=@pPuertoRH,
		CorreoRH=@pCorreoRH,
		UsuarioCorreoRH=@pUsuarioCorreoRH,
		ClaveRH=@pClaveRH,
		SeguridadRH=@pSeguridadRH, 
		TipoPermisoSCT = @pTipoPermisoSCT ,
		NroPermisoSCT = @pNroPermisoSCT , 
		TrabajaSabado =@pTrabajaSabado ,
		TrabajaDomingo = @pTrabajaDomingo,
		Orden = @pOrden,
		UsaCompOficiales = @pUsaCompOficiales,
		EnviaPago = @pEnviaPago,
		ConfirmarEnviarPago = @pConfirmarEnviarPago,
		FirmaSUE = @pFirmaSUE,
		ImagenFirmaB64SUE = @pImagenFirmaB64SUE, 
		FirmaTES = @pFirmaTES,
		ImagenFirmaB64TES = @pImagenFirmaB64TES,
		DiaComi = @pDiaComi,
		FechaCierreComi = @pFechaCierreComi
	WHERE (Empresa_Id = @pEmpresa_Id)
END 
Select @lIdentidad as RetVal 

GO



DROP PROCEDURE genEmpresasEliminar
GO
CREATE PROCEDURE genEmpresasEliminar
(
@pEmpresa_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genEmpresas 
WHERE (Empresa_Id = @pEmpresa_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKgenEmpresas
GO

CREATE FUNCTION FuncFKgenEmpresas
(
@pEmpresa_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genEmpresas FROM genEmpresas WHERE 
	Empresa_Id = @pEmpresa_Id
  RETURN @pIdentity
END


GO

DROP Procedure genEmpresasTodas
GO
CREATE Procedure genEmpresasTodas
AS
SELECT Empresa_Id, Detalle, genEmpresas, Orden  
FROM genEmpresas 
WHERE Inactivo = 0
ORDER BY 4, 3
GO

Drop procedure genEmpresasSetFechaCalculoStock
Go
Create procedure genEmpresasSetFechaCalculoStock
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCalculoStock = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go


Drop procedure genEmpresasSetFechaCompras
Go
Create procedure genEmpresasSetFechaCompras
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCierreCompras = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go


Drop procedure genEmpresasSetFechaVentas
Go
Create procedure genEmpresasSetFechaVentas
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCierreVentas = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go


Drop procedure genEmpresasSetFechaStock
Go
Create procedure genEmpresasSetFechaStock
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCierreStock = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go


Drop procedure genEmpresasSetFechaTesoreria
Go
Create procedure genEmpresasSetFechaTesoreria
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCierreTesoreria = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go


Drop procedure genEmpresasSetFechaImpuestos
Go
Create procedure genEmpresasSetFechaImpuestos
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCierreImpuestos = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go

Drop procedure genEmpresasSetFechaComi
Go
Create procedure genEmpresasSetFechaComi
(
@pEmpresa_Id int,
@pFechaCierre qFecha
)
As
Update genEmpresas Set FechaCierreComi = @pFechaCierre Where genEmpresas = @pEmpresa_Id
Go

