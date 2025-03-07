DROP PROCEDURE stkMoviSerieUbicacionInsertar
GO
CREATE PROCEDURE stkMoviSerieUbicacionInsertar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pSerie varchar(25),
@pUbicacion_Id varchar(25),
@pCantidad qCantidadD8
)
AS
	INSERT INTO stkMoviSerieUbicacion
	(
		stkMoviCabe,
		Renglon,
		Serie,
		Ubicacion_Id,
		Cantidad
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		@pSerie,
		dbo.FuncFKstkUbicaciones(@pUbicacion_Id),
		@pCantidad
	)

GO

DROP PROCEDURE stkMoviSerieUbicacionDatos
GO
CREATE PROCEDURE stkMoviSerieUbicacionDatos
(
@pstkMoviCabe bigint,
@pRenglon int,
@pSerie varchar(25),
@pUbicacion_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT stkMoviSerieUbicacion.stkMoviCabe, stkMoviSerieUbicacion.Renglon, stkMoviSerieUbicacion.Serie, 
	stkUbicaciones.Ubicacion_Id, stkMoviSerieUbicacion.Cantidad
FROM stkMoviSerieUbicacion 
INNER JOIN stkMoviSerie  ON (stkMoviSerie.stkMoviCabe = stkMoviSerieUbicacion.stkMoviCabe) AND (stkMoviSerie.Renglon = stkMoviSerieUbicacion.Renglon) AND (stkMoviSerie.Serie = stkMoviSerieUbicacion.Serie)
INNER JOIN stkUbicaciones  ON (stkUbicaciones.stkUbicaciones = stkMoviSerieUbicacion.Ubicacion_Id)
WHERE (stkMoviSerieUbicacion.stkMoviCabe = @pstkMoviCabe)
AND (stkMoviSerieUbicacion.Renglon = @pRenglon)
AND (stkMoviSerieUbicacion.Serie = @pSerie)
AND (stkMoviSerieUbicacion.Ubicacion_Id = dbo.FuncFkstkUbicaciones(@pUbicacion_Id))
 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviSerieUbicacionEliminar
GO
CREATE PROCEDURE stkMoviSerieUbicacionEliminar
(
@pstkMoviCabe bigint,
@pRenglon int = NULL,
@pSerie varchar(25) = NULL ,
@pUbicacion_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviSerieUbicacion 
WHERE stkMoviCabe = @pstkMoviCabe
AND Renglon = isnull(@pRenglon, Renglon)
AND Serie = isnull(@pSerie, Serie)
AND (@pUbicacion_Id IS NULL OR Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id))
 
 RETURN @@Error 

GO

