Drop Procedure sisAccion_Datos
GO

CREATE PROCEDURE sisAccion_Datos
(
	@pAccion_Id varchar(200)
)

AS
SET NOCOUNT ON  

SELECT Controlador, ModoTransaccion, ModoDebug  
FROM sisAccionesConfig
WHERE Accion_Id = @pAccion_Id
GO

Drop Procedure sisAccion_Guardar
GO

create PROCEDURE sisAccion_Guardar
(
	@pAccion_Id varchar(200),
	@pAccion_Id_Anterior varchar(200),	
	@pDescripcion varchar(254) = NULL,
	@pControlador varchar(254),
	@pModoTransaccion int
)
AS
SET NOCOUNT ON  
IF (exists(select 1 from sisAccionesConfig Where Accion_Id = @pAccion_Id_Anterior))
BEGIN
	UPDATE sisAccionesConfig
	SET Accion_Id = @pAccion_Id,	
		Descripcion = @pDescripcion,
		Controlador = @pControlador,
		ModoTransaccion = @pModoTransaccion
	WHERE Accion_Id = @pAccion_Id_Anterior
END
ELSE
BEGIN
	INSERT INTO sisAccionesConfig(Accion_Id, Descripcion, Controlador, ModoTransaccion)
	VALUES (@pAccion_Id, @pDescripcion, @pControlador, @pModoTransaccion)
END
RETURN @@Error 
GO

Drop Procedure sisAcciones_Datos
GO

CREATE procedure sisAcciones_Datos
As
Select Accion_Id, Descripcion, Controlador, ModoTransaccion, ModoDebug 
From sisAccionesConfig
GO


Drop Procedure sisAccion_Eliminar
GO

CREATE PROCEDURE sisAccion_Eliminar
(
	@pAccion_Id varchar(200)
)

AS
SET NOCOUNT ON  

DELETE FROM sisAccionesConfig
WHERE Accion_Id = @pAccion_Id
GO


Drop Procedure sisAccion_UpdateDebug
GO

CREATE PROCEDURE sisAccion_UpdateDebug
(
	@pAccion_Id varchar(200),
	@pModoDebug bit
)

AS
SET NOCOUNT ON  

UPDATE sisAccionesConfig
SET ModoDebug = @pModoDebug
WHERE Accion_Id = @pAccion_Id
GO
