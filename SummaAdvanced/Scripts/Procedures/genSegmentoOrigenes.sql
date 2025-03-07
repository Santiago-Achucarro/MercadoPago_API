-- genSegmentoOrigenesDatos 1
DROP PROCEDURE genSegmentoOrigenesGuardar
GO
CREATE PROCEDURE genSegmentoOrigenesGuardar
(
@pOriSeg_id smallint,
@pDescripcion varchar(80)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genSegmentoOrigenes WHERE (OriSeg_id = @pOriSeg_id)))
BEGIN 
	UPDATE genSegmentoOrigenes
	SET		Descripcion = @pDescripcion
	WHERE (OriSeg_id = @pOriSeg_id)
END 
ELSE 
BEGIN 
	INSERT INTO genSegmentoOrigenes
	(
		OriSeg_id,
		Descripcion
	)
	VALUES 
	(
		@pOriSeg_id,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE genSegmentoOrigenesDatos
GO
CREATE PROCEDURE genSegmentoOrigenesDatos
(
@pOriSeg_id smallint
)
AS
SET NOCOUNT ON 

SELECT genSegmentoOrigenes.OriSeg_id, genSegmentoOrigenes.Descripcion
FROM genSegmentoOrigenes 
WHERE (OriSeg_id = @pOriSeg_id)
 
 RETURN @@Error 

GO

DROP PROCEDURE genSegmentoOrigenesEliminar
GO
CREATE PROCEDURE genSegmentoOrigenesEliminar
(
@pOriSeg_id smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genSegmentoOrigenes 
WHERE (OriSeg_id = ISNULL(@pOriSeg_id, OriSeg_id))
 
 RETURN @@Error 

GO

GO
