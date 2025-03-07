DROP PROCEDURE venClientesPlantillaGuardar
GO
CREATE PROCEDURE venClientesPlantillaGuardar
(
@pPlantilla_Id varchar(15),
@pPlantilla_Id_Nuevo varchar(15),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(60),
@pCuit varchar(25),
@pTipoDoc char(1),
@pIdFiscal varchar(20),
@pSucursal int,
@pRazonSocial varchar(120),
@pCondFisc_Id varchar(5) = NULL,
@pLimiteCredito qMonedaD2,
@pMonedaLimCred varchar(3) = NULL,
@pCategCred_Id varchar(5) = NULL,
@pBonificacion1 qPorcentaje,
@pBonificacion2 qPorcentaje,
@pBonificacion3 qPorcentaje,
@pPuntual Sino,
@pEstado_Id varchar(5) = NULL,
@pGeneraDebito Sino,
@pSiempre Sino,
@pIBrutos varchar(20),
@pSituacion char(1),
@pNombreFantasia varchar(120),
@pDireccion1_Fact varchar(50),
@pDireccion2_Fact varchar(50),
@pLocalidad_Fact varchar(35),
@pCodPostal_Fact varchar(15),
@pProvincia_Id_Fact varchar(5) = NULL,
@pPais_Id_Fact smallint = NULL,
@pTelefonos varchar(100),
@pFax varchar(50),
@pEMail varchar(50),
@pDireccion1_Entr varchar(50),
@pDireccion2_Entr varchar(50),
@pLocalidad_Entr varchar(36),
@pCodPostal_Entr varchar(15),
@pProvincia_Id_Entr varchar(5) = NULL,
@pPais_Id_Entr smallint = NULL,
@pTipoClie_Id varchar(5) = NULL,
@pListaPrecio_Id varchar(5) = NULL,
@pFormaEntrega_Id varchar(3) = NULL,
@pCondPagoCli_Id varchar(5) = NULL,
@pVendedor_Id varchar(5) = NULL,
@pCobrador_Id varchar(5) = NULL,
@pZona_Id varchar(5) = NULL,
@pRegion_Id varchar(5) = NULL,
@pContactos varchar(50),
@pObservaciones varchar(max),
@pBonificacion1Suc qPorcentaje,
@pBonificacion2Suc qPorcentaje,
@pBonificacion3Suc qPorcentaje,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pNroExterior_Fact varchar(10),
@pNroInterior_Fact varchar(10),
@pNroExterior_Entr varchar(10),
@pNroInterior_Entr varchar(20),
@pReclamos varchar(150),
@pMetodoDePago varchar(50),
@pNumCuenta varchar(150),
@pC_UsoCFDI varchar(3),
@pN_MetodoPago varchar(3),
@pUsaComplementoINE Sino,
@pInactivoCliente Sino,
@pPosteado Sino,
@pInactivo Sino,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venClientesPlantilla WHERE (Plantilla_Id = @pPlantilla_Id)))
BEGIN 
	UPDATE venClientesPlantilla
	SET @lIdentidad = venClientesPlantilla,
		Plantilla_Id = @pPlantilla_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Cuit = @pCuit,
		TipoDoc = @pTipoDoc,
		IdFiscal = @pIdFiscal,
		Sucursal = @pSucursal,
		RazonSocial = @pRazonSocial,
		CondFisc_Id = dbo.FuncFKvenCondFiscal(@pCondFisc_Id),
		LimiteCredito = @pLimiteCredito,
		MonedaLimCred = dbo.FuncFKgenMonedas(@pMonedaLimCred),
		CategCred_Id = dbo.FuncFKvenCategCredito(@pCategCred_Id),
		Bonificacion1 = @pBonificacion1,
		Bonificacion2 = @pBonificacion2,
		Bonificacion3 = @pBonificacion3,
		Puntual = @pPuntual,
		Estado_Id = dbo.FuncFKvenClieEstados(@pEstado_Id),
		GeneraDebito = @pGeneraDebito,
		Siempre = @pSiempre,
		IBrutos = @pIBrutos,
		Situacion = @pSituacion,
		NombreFantasia = @pNombreFantasia,
		Direccion1_Fact = @pDireccion1_Fact,
		Direccion2_Fact = @pDireccion2_Fact,
		Localidad_Fact = @pLocalidad_Fact,
		CodPostal_Fact = @pCodPostal_Fact,
		Provincia_Id_Fact = dbo.FuncFKgenProvincias(@pProvincia_Id_Fact),
		Pais_Id_Fact = dbo.FuncFKgenPaises(@pPais_Id_Fact),
		Telefonos = @pTelefonos,
		Fax = @pFax,
		EMail = @pEMail,
		Direccion1_Entr = @pDireccion1_Entr,
		Direccion2_Entr = @pDireccion2_Entr,
		Localidad_Entr = @pLocalidad_Entr,
		CodPostal_Entr = @pCodPostal_Entr,
		Provincia_Id_Entr = dbo.FuncFKgenProvincias(@pProvincia_Id_Entr),
		Pais_Id_Entr = dbo.FuncFKgenPaises(@pPais_Id_Entr),
		TipoClie_Id = dbo.FuncFKvenTiposClie(@pTipoClie_Id),
		ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		CondPagoCli_Id = dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		Vendedor_Id = dbo.FuncFKvenVendedores(@pVendedor_Id),
		Cobrador_Id = dbo.FuncFKvenCobradores(@pCobrador_Id),
		Zona_Id = dbo.FuncFKvenZona(@pZona_Id),
		Region_Id = dbo.FuncFKvenRegion(@pRegion_Id),
		Contactos = @pContactos,
		Observaciones = @pObservaciones,
		Bonificacion1Suc = @pBonificacion1Suc,
		Bonificacion2Suc = @pBonificacion2Suc,
		Bonificacion3Suc = @pBonificacion3Suc,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		NroExterior_Fact = @pNroExterior_Fact,
		NroInterior_Fact = @pNroInterior_Fact,
		NroExterior_Entr = @pNroExterior_Entr,
		NroInterior_Entr = @pNroInterior_Entr,
		Reclamos = @pReclamos,
		MetodoDePago = @pMetodoDePago,
		NumCuenta = @pNumCuenta,
		C_UsoCFDI = @pC_UsoCFDI,
		N_MetodoPago = @pN_MetodoPago,
		UsaComplementoINE = @pUsaComplementoINE,
		InactivoCliente = @pInactivoCliente,
		Posteado = @pPosteado,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id
	WHERE (Plantilla_Id = @pPlantilla_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venClientesPlantilla
	(
		Plantilla_Id,
		Empresa_Id,
		Descripcion,
		Cuit,
		TipoDoc,
		IdFiscal,
		Sucursal,
		RazonSocial,
		CondFisc_Id,
		LimiteCredito,
		MonedaLimCred,
		CategCred_Id,
		Bonificacion1,
		Bonificacion2,
		Bonificacion3,
		Puntual,
		Estado_Id,
		GeneraDebito,
		Siempre,
		IBrutos,
		Situacion,
		NombreFantasia,
		Direccion1_Fact,
		Direccion2_Fact,
		Localidad_Fact,
		CodPostal_Fact,
		Provincia_Id_Fact,
		Pais_Id_Fact,
		Telefonos,
		Fax,
		EMail,
		Direccion1_Entr,
		Direccion2_Entr,
		Localidad_Entr,
		CodPostal_Entr,
		Provincia_Id_Entr,
		Pais_Id_Entr,
		TipoClie_Id,
		ListaPrecio_Id,
		FormaEntrega_Id,
		CondPagoCli_Id,
		Vendedor_Id,
		Cobrador_Id,
		Zona_Id,
		Region_Id,
		Contactos,
		Observaciones,
		Bonificacion1Suc,
		Bonificacion2Suc,
		Bonificacion3Suc,
		Centro1_Id,
		Centro2_Id,
		NroExterior_Fact,
		NroInterior_Fact,
		NroExterior_Entr,
		NroInterior_Entr,
		Reclamos,
		MetodoDePago,
		NumCuenta,
		C_UsoCFDI,
		N_MetodoPago,
		UsaComplementoINE,
		InactivoCliente,
		Posteado,
		Inactivo,
		Usuario_Id
	)
	VALUES 
	(
		@pPlantilla_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pCuit,
		@pTipoDoc,
		@pIdFiscal,
		@pSucursal,
		@pRazonSocial,
		dbo.FuncFKvenCondFiscal(@pCondFisc_Id),
		@pLimiteCredito,
		dbo.FuncFKgenMonedas(@pMonedaLimCred),
		dbo.FuncFKvenCategCredito(@pCategCred_Id),
		@pBonificacion1,
		@pBonificacion2,
		@pBonificacion3,
		@pPuntual,
		dbo.FuncFKvenClieEstados(@pEstado_Id),
		@pGeneraDebito,
		@pSiempre,
		@pIBrutos,
		@pSituacion,
		@pNombreFantasia,
		@pDireccion1_Fact,
		@pDireccion2_Fact,
		@pLocalidad_Fact,
		@pCodPostal_Fact,
		dbo.FuncFKgenProvincias(@pProvincia_Id_Fact),
		dbo.FuncFKgenPaises(@pPais_Id_Fact),
		@pTelefonos,
		@pFax,
		@pEMail,
		@pDireccion1_Entr,
		@pDireccion2_Entr,
		@pLocalidad_Entr,
		@pCodPostal_Entr,
		dbo.FuncFKgenProvincias(@pProvincia_Id_Entr),
		dbo.FuncFKgenPaises(@pPais_Id_Entr),
		dbo.FuncFKvenTiposClie(@pTipoClie_Id),
		dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		dbo.FuncFKvenVendedores(@pVendedor_Id),
		dbo.FuncFKvenCobradores(@pCobrador_Id),
		dbo.FuncFKvenZona(@pZona_Id),
		dbo.FuncFKvenRegion(@pRegion_Id),
		@pContactos,
		@pObservaciones,
		@pBonificacion1Suc,
		@pBonificacion2Suc,
		@pBonificacion3Suc,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pNroExterior_Fact,
		@pNroInterior_Fact,
		@pNroExterior_Entr,
		@pNroInterior_Entr,
		@pReclamos,
		@pMetodoDePago,
		@pNumCuenta,
		@pC_UsoCFDI,
		@pN_MetodoPago,
		@pUsaComplementoINE,
		@pInactivoCliente,
		@pPosteado,
		@pInactivo,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venClientesPlantillaDatos
GO
CREATE PROCEDURE venClientesPlantillaDatos
(
@pPlantilla_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT venClientesPlantilla.venClientesPlantilla, venClientesPlantilla.Plantilla_Id, venClientesPlantilla.Plantilla_Id Plantilla_Id_Nueva,
	venClientesPlantilla.Empresa_Id, venClientesPlantilla.Descripcion,
	Cast( Case When venClientesPlantilla.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, venClientesPlantilla.Cuit, venClientesPlantilla.TipoDoc,
	venClientesPlantilla.IdFiscal, venClientesPlantilla.Sucursal, venClientesPlantilla.RazonSocial, 
	venCondFiscal.CondFisc_Id, venCondFiscal.Descripcion as DescripcionCondFiscal,
	venClientesPlantilla.LimiteCredito, genMonedas.Moneda_Id MonedaLimCred, genMonedas.Descripcion as DescripcionMonedaLimCred, venCategCredito.CategCred_Id,
	venCategCredito.Descripcion as DescripcionCategCredito, venClientesPlantilla.Bonificacion1, venClientesPlantilla.Bonificacion2, venClientesPlantilla.Bonificacion3,
	venClientesPlantilla.Puntual, venClieEstados.Estado_Id, venClieEstados.Descripcion as DescripcionClieEstados, venClientesPlantilla.GeneraDebito,
	venClientesPlantilla.Siempre, venClientesPlantilla.IBrutos, venClientesPlantilla.Situacion, venClientesPlantilla.NombreFantasia,
	venClientesPlantilla.Direccion1_Fact, venClientesPlantilla.Direccion2_Fact, venClientesPlantilla.Localidad_Fact, venClientesPlantilla.CodPostal_Fact,
	genProvincias.Provincia_Id Provincia_Id_Fact, genProvincias.Descripcion as DescripcionProvincia_Id_Fact, genPaises.Pais_Id Pais_Id_Fact, genPaises.Descripcion as DescripcionPais_Id_Fact,
	venClientesPlantilla.Telefonos, venClientesPlantilla.Fax, venClientesPlantilla.EMail, venClientesPlantilla.Direccion1_Entr,
	venClientesPlantilla.Direccion2_Entr, venClientesPlantilla.Localidad_Entr, venClientesPlantilla.CodPostal_Entr, genProvincias2.Provincia_Id Provincia_Id_Entr,
	genProvincias2.Descripcion as DescripcionProvincia_Id_Entr, genPaises2.Pais_Id Pais_Id_Entr, genPaises2.Descripcion as DescripcionPais_Id_Entr, venTiposClie.TipoClie_Id,
	venTiposClie.Descripcion as DescripcionTiposClie, venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, venFormaEntrega.FormaEntrega_Id,
	venFormaEntrega.RazonSocial as DescripcionFormaEntrega, venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, venVendedores.Vendedor_Id,
	venVendedores.Nombre as DescripcionVendedores, venCobradores.Cobrador_Id, venCobradores.Nombre as DescripcionCobradores, venZona.Zona_Id,
	venZona.Descripcion as DescripcionZona, venRegion.Region_Id, venRegion.Descripcion as DescripcionRegion, venClientesPlantilla.Contactos,
	venClientesPlantilla.Observaciones, venClientesPlantilla.Bonificacion1Suc, venClientesPlantilla.Bonificacion2Suc, venClientesPlantilla.Bonificacion3Suc,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	venClientesPlantilla.NroExterior_Fact, venClientesPlantilla.NroInterior_Fact, venClientesPlantilla.NroExterior_Entr, venClientesPlantilla.NroInterior_Entr,
	venClientesPlantilla.Reclamos, venClientesPlantilla.MetodoDePago, venClientesPlantilla.NumCuenta, venClientesPlantilla.C_UsoCFDI,
	venClientesPlantilla.N_MetodoPago, venClientesPlantilla.UsaComplementoINE, venClientesPlantilla.InactivoCliente, venClientesPlantilla.Posteado,
	venClientesPlantilla.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM venClientesPlantilla 
LEFT JOIN venCondFiscal  ON (venCondFiscal.venCondFiscal = venClientesPlantilla.CondFisc_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = venClientesPlantilla.MonedaLimCred)
LEFT JOIN venCategCredito  ON (venCategCredito.venCategCredito = venClientesPlantilla.CategCred_Id)
LEFT JOIN venClieEstados  ON (venClieEstados.venClieEstados = venClientesPlantilla.Estado_Id)
LEFT JOIN genProvincias  ON (genProvincias.genProvincias = venClientesPlantilla.Provincia_Id_Fact)
LEFT JOIN genPaises  ON (genPaises.genPaises = venClientesPlantilla.Pais_Id_Fact)
LEFT JOIN genProvincias genProvincias2 ON (genProvincias2.genProvincias = venClientesPlantilla.Provincia_Id_Entr)
LEFT JOIN genPaises genPaises2 ON (genPaises2.genPaises = venClientesPlantilla.Pais_Id_Entr)
LEFT JOIN venTiposClie  ON (venTiposClie.venTiposClie = venClientesPlantilla.TipoClie_Id)
LEFT JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venClientesPlantilla.ListaPrecio_Id)
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = venClientesPlantilla.FormaEntrega_Id)
LEFT JOIN venCondPago  ON (venCondPago.venCondPago = venClientesPlantilla.CondPagoCli_Id)
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = venClientesPlantilla.Vendedor_Id)
LEFT JOIN venCobradores  ON (venCobradores.venCobradores = venClientesPlantilla.Cobrador_Id)
LEFT JOIN venZona  ON (venZona.venZona = venClientesPlantilla.Zona_Id)
LEFT JOIN venRegion  ON (venRegion.venRegion = venClientesPlantilla.Region_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = venClientesPlantilla.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = venClientesPlantilla.Centro2_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = venClientesPlantilla.Usuario_Id)
WHERE (Plantilla_Id = @pPlantilla_Id)

Declare @pidentity bigint= dbo.FuncFKvenClientesPlantilla(@pPlantilla_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venClientesPlantilla'

Exec venClientesCtasPlantillaDatos @pPlantilla_Id

RETURN @@Error 

GO

DROP PROCEDURE venClientesPlantillaEliminar
GO
CREATE PROCEDURE venClientesPlantillaEliminar
(
@pPlantilla_Id varchar(15)
)
AS
SET NOCOUNT ON 

DELETE FROM venClientesPlantilla 
WHERE (Plantilla_Id = @pPlantilla_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenClientesPlantilla
GO

CREATE FUNCTION FuncFKvenClientesPlantilla
(
@pPlantilla_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venClientesPlantilla FROM venClientesPlantilla WHERE 
	Plantilla_Id = @pPlantilla_Id
  RETURN @pIdentity
END


GO
