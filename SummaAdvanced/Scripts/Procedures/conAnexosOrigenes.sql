DROP PROCEDURE conAnexosOrigenesGuardar
GO
CREATE PROCEDURE conAnexosOrigenesGuardar
(
@pOrigen smallint,
@pDescripcion varchar(60),
@pTipoRubro varchar(3)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conAnexosOrigenes WHERE (Origen = @pOrigen)))
BEGIN 
	UPDATE conAnexosOrigenes
	SET		Descripcion = @pDescripcion,
		TipoRubro = @pTipoRubro
	WHERE (Origen = @pOrigen)
END 
ELSE 
BEGIN 
	INSERT INTO conAnexosOrigenes
	(
		Origen,
		Descripcion,
		TipoRubro
	)
	VALUES 
	(
		@pOrigen,
		@pDescripcion,
		@pTipoRubro
	)
END 

GO

DROP PROCEDURE conAnexosOrigenesDatos
GO
CREATE PROCEDURE conAnexosOrigenesDatos
(
@pOrigen smallint
)
AS
SET NOCOUNT ON 

SELECT conAnexosOrigenes.Origen, conAnexosOrigenes.Descripcion, conAnexosOrigenes.TipoRubro
FROM conAnexosOrigenes 
WHERE (Origen = @pOrigen)
 
 RETURN @@Error 

GO

DROP PROCEDURE conAnexosOrigenesEliminar
GO
CREATE PROCEDURE conAnexosOrigenesEliminar
(
@pOrigen smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conAnexosOrigenes 
WHERE (Origen = ISNULL(@pOrigen, Origen))
 
 RETURN @@Error 

GO

GO
