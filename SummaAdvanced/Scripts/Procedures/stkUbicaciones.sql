DROP PROCEDURE stkUbicacionesGuardar
GO
CREATE PROCEDURE stkUbicacionesGuardar
(
@pUbicacion_Id varchar(25),
@pUbicacion_Id_Nuevo varchar(25),
@pCapacidad QCantidad,
@pUsuario_Id int = NULL,
@pInactivo Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkUbicaciones WHERE (Ubicacion_Id = @pUbicacion_Id)))
BEGIN 
	UPDATE stkUbicaciones
	SET		@lIdentidad = stkUbicaciones,
		Ubicacion_Id = @pUbicacion_Id_Nuevo,
		Capacidad = @pCapacidad,
		Usuario_Id = @pUsuario_Id,
		Inactivo = @pInactivo
	WHERE (Ubicacion_Id = @pUbicacion_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkUbicaciones
	(
		Ubicacion_Id,
		Capacidad,
		Usuario_Id,
		Inactivo
	)
	VALUES 
	(
		@pUbicacion_Id,
		@pCapacidad,
		@pUsuario_Id,
		@pInactivo
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkUbicacionesDatos
GO
CREATE PROCEDURE stkUbicacionesDatos
(
@pUbicacion_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT stkUbicaciones.stkUbicaciones, stkUbicaciones.Ubicacion_Id, stkUbicaciones.Capacidad, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, stkUbicaciones.Inactivo
FROM stkUbicaciones 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkUbicaciones.Usuario_Id)
WHERE (Ubicacion_Id = @pUbicacion_Id)
 


  Declare @pidentity bigint= dbo.FuncFKstkUbicaciones(@pUbicacion_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkUbicaciones'
 RETURN @@Error 

GO

DROP PROCEDURE stkUbicacionesEliminar
GO
CREATE PROCEDURE stkUbicacionesEliminar
(
@pUbicacion_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkUbicaciones 
WHERE (Ubicacion_Id = @pUbicacion_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkUbicaciones
GO

CREATE FUNCTION FuncFKstkUbicaciones
(
@pUbicacion_Id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkUbicaciones FROM stkUbicaciones WHERE 
	Ubicacion_Id = @pUbicacion_Id
  RETURN @pIdentity
END


GO
