DROP PROCEDURE conRubrosGuardar
GO
CREATE PROCEDURE conRubrosGuardar
(
@pRubro_Id char(1),
@pDescripcion varchar(35),
@pTipo char(3)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conRubros WHERE (Rubro_Id = @pRubro_Id)))
BEGIN 
	UPDATE conRubros
	SET		Descripcion = @pDescripcion,
		Tipo = @pTipo
	WHERE (Rubro_Id = @pRubro_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conRubros
	(
		Rubro_Id,
		Descripcion,
		Tipo
	)
	VALUES 
	(
		@pRubro_Id,
		@pDescripcion,
		@pTipo
	)
END 

GO

DROP PROCEDURE conRubrosDatos
GO
CREATE PROCEDURE conRubrosDatos
(
@pRubro_Id char(1)
)
AS
SET NOCOUNT ON 

SELECT conRubros.Rubro_Id, conRubros.Descripcion, conRubros.Tipo
FROM conRubros 
WHERE (Rubro_Id = @pRubro_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE conRubrosEliminar
GO
CREATE PROCEDURE conRubrosEliminar
(
@pRubro_Id char(1) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conRubros 
WHERE (Rubro_Id = ISNULL(@pRubro_Id, Rubro_Id))
 
 RETURN @@Error 

GO

GO
