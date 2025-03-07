DROP PROCEDURE stkMoviConsignaInsertar
GO
CREATE PROCEDURE stkMoviConsignaInsertar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8
)
AS
	INSERT INTO stkMoviConsigna
	(
		stkMoviCabe,
		Renglon,
		comOrdenComp,
		Renglon_OC,
		Cantidad
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		@pcomOrdenComp,
		@pRenglon_OC,
		@pCantidad
	)

GO

DROP PROCEDURE stkMoviConsignaDatos
GO
CREATE PROCEDURE stkMoviConsignaDatos
(
@pstkMoviCabe bigint = null,
@pRenglon int = null,
@pcomOrdenComp int = null,
@pRenglon_OC int = null
)
AS
SET NOCOUNT ON 

SELECT stkMoviConsigna.stkMoviCabe, stkMoviConsigna.Renglon, stkMoviConsigna.comOrdenComp,
	stkMoviConsigna.Renglon_OC,  stkMoviConsigna.Cantidad
FROM stkMoviConsigna 
WHERE 
stkMoviCabe = isnull(@pstkMoviCabe, stkMoviCabe) AND 
Renglon = isnull(@pRenglon, Renglon) AND 
comOrdenComp = isnull(@pcomOrdenComp, comOrdenComp) AND 
Renglon_OC = isnull(@pRenglon_OC, Renglon_OC)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviConsignaEliminar
GO
CREATE PROCEDURE stkMoviConsignaEliminar
(
@pstkMoviCabe bigint,
@pRenglon int = null,
@pcomOrdenComp int = null,
@pRenglon_OC int = null
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviConsigna 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND (Renglon = isnull(@pRenglon,Renglon))
AND (comOrdenComp = isnull(@pcomOrdenComp, comOrdenComp))
AND (Renglon_OC = isnull(@pRenglon_OC, Renglon_OC))
 
 RETURN @@Error 

GO

GO
