DROP PROCEDURE comOcEstadosGuardar
GO
CREATE PROCEDURE comOcEstadosGuardar
(
@pEstado_Id char(1),
@pDescripcion varchar(25)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comOcEstados WHERE (Estado_Id = @pEstado_Id)))
BEGIN 
	UPDATE comOcEstados
	SET		Descripcion = @pDescripcion
	WHERE (Estado_Id = @pEstado_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comOcEstados
	(
		Estado_Id,
		Descripcion
	)
	VALUES 
	(
		@pEstado_Id,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE comOcEstadosDatos
GO
CREATE PROCEDURE comOcEstadosDatos
(
@pEstado_Id char(1)
)
AS
SET NOCOUNT ON 

SELECT comOcEstados.Estado_Id, comOcEstados.Descripcion
FROM comOcEstados 
WHERE (Estado_Id = @pEstado_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE comOcEstadosEliminar
GO
CREATE PROCEDURE comOcEstadosEliminar
(
@pEstado_Id char(1) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comOcEstados 
WHERE (Estado_Id = ISNULL(@pEstado_Id, Estado_Id))
 
 RETURN @@Error 

GO

GO
