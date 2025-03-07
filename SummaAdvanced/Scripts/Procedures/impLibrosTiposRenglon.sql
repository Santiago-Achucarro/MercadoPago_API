DROP PROCEDURE impLibrosTiposRenglonGuardar
GO
CREATE PROCEDURE impLibrosTiposRenglonGuardar
(
@pTipoRenglon char(2),
@pDescripcion varchar(35)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impLibrosTiposRenglon WHERE (TipoRenglon = @pTipoRenglon)))
BEGIN 
	UPDATE impLibrosTiposRenglon
	SET		Descripcion = @pDescripcion
	WHERE (TipoRenglon = @pTipoRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO impLibrosTiposRenglon
	(
		TipoRenglon,
		Descripcion
	)
	VALUES 
	(
		@pTipoRenglon,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE impLibrosTiposRenglonDatos
GO
CREATE PROCEDURE impLibrosTiposRenglonDatos
(
@pTipoRenglon char(2)
)
AS
SET NOCOUNT ON 

SELECT impLibrosTiposRenglon.TipoRenglon, impLibrosTiposRenglon.Descripcion
FROM impLibrosTiposRenglon 
WHERE (TipoRenglon = @pTipoRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE impLibrosTiposRenglonEliminar
GO
CREATE PROCEDURE impLibrosTiposRenglonEliminar
(
@pTipoRenglon char(2) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impLibrosTiposRenglon 
WHERE (TipoRenglon = ISNULL(@pTipoRenglon, TipoRenglon))
 
 RETURN @@Error 

GO

GO
