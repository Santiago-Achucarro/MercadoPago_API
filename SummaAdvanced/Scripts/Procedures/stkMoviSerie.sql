DROP PROCEDURE stkMoviSerieGuardar
GO
CREATE PROCEDURE stkMoviSerieGuardar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pSerie varchar(25),
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviSerie WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon) AND (Serie = @pSerie)))
BEGIN 
	UPDATE stkMoviSerie
	SET		Cantidad = @pCantidad
	WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon) AND (Serie = @pSerie)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviSerie
	(
		stkMoviCabe,
		Renglon,
		Serie,
		Cantidad
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		@pSerie,
		@pCantidad
	)
END 

GO

DROP PROCEDURE stkMoviSerieDatos
GO
CREATE PROCEDURE stkMoviSerieDatos
(
@pstkMoviCabe bigint,
@pRenglon int = null,
@pSerie varchar(25) = null
)
AS
SET NOCOUNT ON 

SELECT stkMoviSerie.stkMoviCabe, stkMoviSerie.Renglon, stkMoviSerie.Serie, isNull(stkMoviSerieUbicacion.Cantidad, stkMoviSerie.Cantidad) / stkMoviCuerpo.Factor Cantidad,
	stkSerieVencimiento.Vencimiento, ISNULL(stkUbicaciones.Ubicacion_Id,' ') AS Ubicacion_Id, Cast(0 As Numeric(18,8)) Existencia,
	Case @pstkMoviCabe When 0 Then Cast(0 As bit) Else Cast(1 As bit) End Marcado
FROM stkMoviSerie 
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
Inner Join conAsientos On conAsientos.conAsientos = stkMoviCuerpo.stkMoviCabe
Left Join stkSerieVencimiento On stkSerieVencimiento.Serie = stkMoviSerie.Serie And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
		stkSerieVencimiento.Empresa_Id = conAsientos.Empresa_Id
left join (stkMoviSerieUbicacion  INNER JOIN stkUbicaciones ON 
	stkMoviSerieUbicacion.Ubicacion_Id = stkUbicaciones.stkUbicaciones) on 
	stkMoviSerieUbicacion.stkMoviCabe = stkMoviSerie.stkMoviCabe and 
	stkMoviSerieUbicacion.Renglon = stkMoviSerie.Renglon and
	stkMoviSerieUbicacion.Serie = stkMoviSerie.Serie
WHERE stkMoviSerie.stkMoviCabe = @pstkMoviCabe
AND stkMoviCuerpo.Renglon = IsNull(@pRenglon, stkMoviCuerpo.Renglon)
AND stkMoviSerie.Serie = IsNull(@pSerie, stkMoviSerie.Serie)
 
RETURN @@Error 

GO
DROP PROCEDURE stkMoviSerieEliminar
GO
CREATE PROCEDURE stkMoviSerieEliminar
(
@pstkMoviCabe bigint,
@pRenglon int = Null,
@pSerie varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviSerie 
WHERE stkMoviCabe = @pstkMoviCabe
AND Renglon = IsNull(@pRenglon, Renglon)
AND Serie = ISNULL(@pSerie, Serie)
 
 RETURN @@Error 

GO

