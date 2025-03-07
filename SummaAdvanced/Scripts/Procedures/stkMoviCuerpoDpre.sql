DROP PROCEDURE stkMoviCuerpoDpreGuardar
GO
CREATE PROCEDURE stkMoviCuerpoDpreGuardar
(
@pStkMoviCabe bigint,
@pRenglon smallint,
@pCantidad_Original qCantidadD8,
@pCantidad qCantidadD8,
@pDif_Costo qMonedaD4,
@pDescuento qPorcentaje
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviCuerpoDpre WHERE (StkMoviCabe = @pStkMoviCabe) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE stkMoviCuerpoDpre
	SET		Cantidad_Original = @pCantidad_Original,
		Cantidad = @pCantidad,
		Dif_Costo = @pDif_Costo,
		Descuento = @pDescuento
	WHERE (StkMoviCabe = @pStkMoviCabe) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviCuerpoDpre
	(
		StkMoviCabe,
		Renglon,
		Cantidad_Original,
		Cantidad,
		Dif_Costo,
		Descuento
	)
	VALUES 
	(
		@pStkMoviCabe,
		@pRenglon,
		@pCantidad_Original,
		@pCantidad,
		@pDif_Costo,
		@pDescuento
	)
END 

GO

DROP PROCEDURE stkMoviCuerpoDpreDatos
GO
CREATE PROCEDURE stkMoviCuerpoDpreDatos
(
@pStkMoviCabe bigint,
@pRenglon smallint
)
AS
SET NOCOUNT ON 

SELECT stkMoviCuerpoDpre.Renglon, stkMoviCuerpoDpre.Cantidad_Original,
	stkMoviCuerpoDpre.Cantidad, stkMoviCuerpoDpre.Dif_Costo, stkMoviCuerpoDpre.Descuento
FROM stkMoviCuerpoDpre 
INNER JOIN stkMoviCabe ON (stkMoviCabe.stkMoviCabe = stkMoviCuerpoDpre.StkMoviCabe)
WHERE (stkMoviCuerpoDpre.StkMoviCabe = @pStkMoviCabe)
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviCuerpoDpreEliminar
GO
CREATE PROCEDURE stkMoviCuerpoDpreEliminar
(
@pStkMoviCabe bigint,
@pRenglon smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCuerpoDpre 
WHERE (StkMoviCabe = @pStkMoviCabe)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
