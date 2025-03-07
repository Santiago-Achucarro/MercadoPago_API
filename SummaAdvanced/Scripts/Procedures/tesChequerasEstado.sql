DROP PROCEDURE tesChequerasEstadoGuardar
GO
CREATE PROCEDURE tesChequerasEstadoGuardar
(
@pEstado_Id char(1),
@pDescripcion varchar(35)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesChequerasEstado WHERE (Estado_Id = @pEstado_Id)))
BEGIN 
	UPDATE tesChequerasEstado
	SET		Descripcion = @pDescripcion
	WHERE (Estado_Id = @pEstado_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesChequerasEstado
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

DROP PROCEDURE tesChequerasEstadoDatos
GO
CREATE PROCEDURE tesChequerasEstadoDatos
(
@pEstado_Id char(1)
)
AS
SET NOCOUNT ON 

SELECT tesChequerasEstado.Estado_Id, tesChequerasEstado.Descripcion
FROM tesChequerasEstado 
WHERE (Estado_Id = @pEstado_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesChequerasEstadoEliminar
GO
CREATE PROCEDURE tesChequerasEstadoEliminar
(
@pEstado_Id char(1) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesChequerasEstado 
WHERE (Estado_Id = ISNULL(@pEstado_Id, Estado_Id))
 
 RETURN @@Error 

GO

GO
