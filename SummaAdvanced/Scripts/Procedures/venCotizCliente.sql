DROP PROCEDURE venCotizClienteGuardar
GO
CREATE PROCEDURE venCotizClienteGuardar
(
@pvenCotizaciones int = NULL,
@pRazonSocial varchar(120) = NULL,
@pDireccion1 varchar(50) = NULL,
@pDireccion2 varchar(50) = NULL,
@pNroExterior varchar(10) = NULL,
@pNroInterior varchar(10) = NULL,
@pLocalidad varchar(35) = NULL,
@pCodigoPostal varchar(15) = NULL,
@pProvincia_Id varchar(5) = NULL,
@pPais_Id smallint = NULL,
@pTelefono varchar(100) = NULL,
@pCUIT varchar(25) = NULL,
@pEmail varchar(50) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCotizCliente WHERE Cotizacion_Id=@pvenCotizaciones))
BEGIN 
	UPDATE venCotizCliente
	SET		Cotizacion_Id = @pvenCotizaciones,
		RazonSocial = @pRazonSocial,
		Direccion1 = @pDireccion1,
		Direccion2 = @pDireccion2,
		NroExterior = @pNroExterior,
		NroInterior = @pNroInterior,
		Localidad = @pLocalidad,
		CodigoPostal = @pCodigoPostal,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		Pais_Id = dbo.FuncFKgenPaises(@pPais_Id),
		Telefono = @pTelefono,
		CUIT = @pCUIT,
		Email = @pEmail
	WHERE 
	venCotizCliente.Cotizacion_Id=@pvenCotizaciones
END 
ELSE 
BEGIN 
	INSERT INTO venCotizCliente
	(
		Cotizacion_Id,
		RazonSocial,
		Direccion1,
		Direccion2,
		NroExterior,
		NroInterior,
		Localidad,
		CodigoPostal,
		Provincia_Id,
		Pais_Id,
		Telefono,
		CUIT,
		Email
	)
	VALUES 
	(
		@pvenCotizaciones,
		@pRazonSocial,
		@pDireccion1,
		@pDireccion2,
		@pNroExterior,
		@pNroInterior,
		@pLocalidad,
		@pCodigoPostal,
		dbo.FuncFKgenProvincias(@pProvincia_Id),
		dbo.FuncFKgenPaises(@pPais_Id),
		@pTelefono,
		@pCUIT,
		@pEmail
	)
END 

GO

DROP PROCEDURE venCotizClienteDatos
GO
CREATE PROCEDURE venCotizClienteDatos
(
@pvenCotizaciones int
)
AS
SET NOCOUNT ON 

SELECT venCotizCliente.Cotizacion_Id, venCotizCliente.RazonSocial, venCotizCliente.Direccion1, venCotizCliente.Direccion2,
	venCotizCliente.NroExterior, venCotizCliente.NroInterior, venCotizCliente.Localidad, venCotizCliente.CodigoPostal,
	genProvincias.Provincia_Id, genProvincias.Descripcion as DescripcionProvincia, genPaises.Pais_Id, 
	genPaises.Descripcion as DescripcionPaises, venCotizCliente.Telefono,
	venCotizCliente.CUIT, venCotizCliente.Email
FROM venCotizCliente 
LEFT JOIN genPaises  ON (genPaises.genPaises = venCotizCliente.Pais_Id)
left join genProvincias on genProvincias=venCotizCliente.Provincia_Id
WHERE  
venCotizCliente.Cotizacion_Id=@pvenCotizaciones
 RETURN @@Error 

GO

DROP PROCEDURE venCotizClienteEliminar
GO
CREATE PROCEDURE venCotizClienteEliminar
(
@pvenCotizaciones int
)
AS
SET NOCOUNT ON 

DELETE FROM venCotizCliente 
WHERE  venCotizCliente.Cotizacion_Id=@pvenCotizaciones
 RETURN @@Error 

GO

