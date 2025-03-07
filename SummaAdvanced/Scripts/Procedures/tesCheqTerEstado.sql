DROP PROCEDURE tesCheqTerEstadoGuardar
GO
CREATE PROCEDURE tesCheqTerEstadoGuardar
(
@pEstado_Id char(1),
@pDescripcion char(35)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesCheqTerEstado WHERE (Estado_Id = @pEstado_Id)))
BEGIN 
	UPDATE tesCheqTerEstado
	SET		Descripcion = @pDescripcion
	WHERE (Estado_Id = @pEstado_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesCheqTerEstado
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

DROP PROCEDURE tesCheqTerEstadoDatos
GO
CREATE PROCEDURE tesCheqTerEstadoDatos
(
@pEstado_Id char(1)
)
AS
SET NOCOUNT ON 

SELECT tesCheqTerEstado.Estado_Id, tesCheqTerEstado.Descripcion
FROM tesCheqTerEstado 
WHERE (Estado_Id = @pEstado_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesCheqTerEstadoEliminar
GO
CREATE PROCEDURE tesCheqTerEstadoEliminar
(
@pEstado_Id char(1) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesCheqTerEstado 
WHERE (Estado_Id = ISNULL(@pEstado_Id, Estado_Id))
 
 RETURN @@Error 

GO

GO
