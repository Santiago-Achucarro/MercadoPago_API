DROP PROCEDURE comProveedoresContactoGuardar
GO
CREATE PROCEDURE comProveedoresContactoGuardar
(
@pProveed_Id bigint,
@pNroContacto int,
@pNombre varchar(120),
@pPuesto varchar(100),
@pEmail varchar(120),
@pTelefono varchar(30),
@pMovil varchar(30),
@pInterno varchar(20),
@pEnvioOC bit,
@pEnvioOP bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comProveedoresContacto WHERE (Proveed_Id = @pProveed_Id) AND (NroContacto = @pNroContacto)))
BEGIN 
	UPDATE comProveedoresContacto
	SET		Proveed_Id = @pProveed_Id,
		NroContacto = @pNroContacto,
		Nombre = @pNombre,
		Puesto = @pPuesto,
		Email = @pEmail,
		Telefono = @pTelefono,
		Movil = @pMovil,
		Interno = @pInterno,
		EnvioOC = @pEnvioOC,
		EnvioOP = @pEnvioOP
	WHERE (Proveed_Id = @pProveed_Id) AND (NroContacto = @pNroContacto)
END 
ELSE 
BEGIN 
	INSERT INTO comProveedoresContacto
	(
		Proveed_Id,
		NroContacto,
		Nombre,
		Puesto,
		Email,
		Telefono,
		Movil,
		Interno,
		EnvioOC,
		EnvioOP
	)
	VALUES 
	(
		@pProveed_Id,
		@pNroContacto,
		@pNombre,
		@pPuesto,
		@pEmail,
		@pTelefono,
		@pMovil,
		@pInterno,
		@pEnvioOC,
		@pEnvioOP
	)
END 

GO

DROP PROCEDURE comProveedoresContactoDatos
GO
CREATE PROCEDURE comProveedoresContactoDatos
(
@pProveed_Id bigint,
@pNroContacto int= Null
)
AS
SET NOCOUNT ON 

SELECT comProveedoresContacto.Proveed_Id, comProveedores.RazonSocial as RazonSocial,
		comProveedoresContacto.NroContacto, comProveedoresContacto.Nombre, comProveedoresContacto.Puesto, comProveedoresContacto.Email,
	comProveedoresContacto.Telefono, comProveedoresContacto.Movil, comProveedoresContacto.Interno, comProveedoresContacto.EnvioOC,
	comProveedoresContacto.EnvioOP
FROM comProveedoresContacto 
INNER JOIN comProveedores  ON (comProveedores.genEntidades = comProveedoresContacto.Proveed_Id)
WHERE (comProveedoresContacto.Proveed_Id = @pProveed_Id)
AND (NroContacto = isnull(@pNroContacto, NroContacto))
 
RETURN @@Error 

GO
--comProveedoresContactoEliminar 5,null
DROP PROCEDURE comProveedoresContactoEliminar
GO
CREATE PROCEDURE comProveedoresContactoEliminar
(
@pProveed_Id bigint,
@pNroContacto int= Null
)
AS
SET NOCOUNT ON 

DELETE FROM comProveedoresContacto 
WHERE (Proveed_Id = @pProveed_Id)
AND (NroContacto = isnull(@pNroContacto, NroContacto))
  
 RETURN @@Error 

GO

GO
