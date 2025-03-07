DROP PROCEDURE tesCheqPropEstadoGuardar
GO
CREATE PROCEDURE tesCheqPropEstadoGuardar
(
@pEstado_Id char(1),
@pDescripcion varchar(60)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesCheqPropEstado WHERE (Estado_Id = @pEstado_Id)))
BEGIN 
	UPDATE tesCheqPropEstado
	SET		Descripcion = @pDescripcion
	WHERE (Estado_Id = @pEstado_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesCheqPropEstado
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

DROP PROCEDURE tesCheqPropEstadoDatos
GO
CREATE PROCEDURE tesCheqPropEstadoDatos
(
@pEstado_Id char(1)
)
AS
SET NOCOUNT ON 

SELECT tesCheqPropEstado.Estado_Id, tesCheqPropEstado.Descripcion
FROM tesCheqPropEstado 
WHERE (Estado_Id = @pEstado_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesCheqPropEstadoEliminar
GO
CREATE PROCEDURE tesCheqPropEstadoEliminar
(
@pEstado_Id char(1) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesCheqPropEstado 
WHERE (Estado_Id = ISNULL(@pEstado_Id, Estado_Id))
 
 RETURN @@Error 

GO

GO
