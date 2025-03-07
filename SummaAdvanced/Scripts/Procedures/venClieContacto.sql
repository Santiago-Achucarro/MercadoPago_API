DROP PROCEDURE venClieContactoGuardar
GO
CREATE PROCEDURE venClieContactoGuardar
(
@pCliente_Id bigint,
@pSucursal int,
@pNroContacto int,
@pNombre varchar(120),
@pPuesto varchar(100),
@pEmail varchar(120),
@pTelefono varchar(30),
@pInterno varchar(20),
@pMovil varchar(30),
@pEnviaFacturas Sino,
@pEnviaRecibo Sino,
@pEnviaPedido Sino,
@pObservaciones varchar(max) = NULL,
@pInactivo Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venClieContacto WHERE (Cliente_Id = @pCliente_Id) AND (Sucursal = @pSucursal) AND (NroContacto = @pNroContacto)))
BEGIN 
	UPDATE venClieContacto
	SET		Nombre = @pNombre,
		Puesto = @pPuesto,
		Email = @pEmail,
		Telefono = @pTelefono,
		Interno = @pInterno,
		Movil = @pMovil,
		EnviaFacturas = @pEnviaFacturas,
		EnviaRecibo = @pEnviaRecibo,
		EnviaPedido = @pEnviaPedido,
		Observaciones = @pObservaciones,
		Inactivo = @pInactivo
	WHERE (Cliente_Id = @pCliente_Id) AND (Sucursal = @pSucursal) AND (NroContacto = @pNroContacto)
END 
ELSE 
BEGIN 
	INSERT INTO venClieContacto
	(
		Cliente_Id,
		Sucursal,
		NroContacto,
		Nombre,
		Puesto,
		Email,
		Telefono,
		Interno,
		Movil,
		EnviaFacturas,
		EnviaRecibo,
		EnviaPedido,
		Observaciones,
		Inactivo
	)
	VALUES 
	(
		@pCliente_Id,
		@pSucursal,
		@pNroContacto,
		@pNombre,
		@pPuesto,
		@pEmail,
		@pTelefono,
		@pInterno,
		@pMovil,
		@pEnviaFacturas,
		@pEnviaRecibo,
		@pEnviaPedido,
		@pObservaciones,
		@pInactivo
	)
END 

GO

DROP PROCEDURE venClieContactoDatos
GO
CREATE PROCEDURE venClieContactoDatos
(
@pCliente_Id bigint,
@pSucursal int,
@pNroContacto int= Null
)
AS
SET NOCOUNT ON 

SELECT venClieContacto.Cliente_Id, venClieContacto.Sucursal, venClieContacto.NroContacto, venClieContacto.Nombre,
	venClieContacto.Puesto, venClieContacto.Email, venClieContacto.Telefono, venClieContacto.Interno,
	venClieContacto.Movil, venClieContacto.EnviaFacturas, venClieContacto.EnviaRecibo, venClieContacto.EnviaPedido,
	venClieContacto.Observaciones, venClieContacto.Inactivo
FROM venClieContacto 
WHERE (Cliente_Id = @pCliente_Id)
AND (Sucursal = @pSucursal)
AND (NroContacto = isnull(@pNroContacto, NroContacto))
 
 RETURN @@Error 

GO

DROP PROCEDURE venClieContactoEliminar
GO
CREATE PROCEDURE venClieContactoEliminar
(
@pCliente_Id bigint,
@pSucursal int ,
@pNroContacto int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venClieContacto 
WHERE (Cliente_Id = @pCliente_Id)
AND (Sucursal = @pSucursal)
AND (NroContacto = ISNULL(@pNroContacto, NroContacto))
 
RETURN @@Error 

GO


