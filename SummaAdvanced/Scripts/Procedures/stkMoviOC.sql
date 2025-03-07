DROP PROCEDURE stkMoviOCInsertar
GO
CREATE PROCEDURE stkMoviOCInsertar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantFactPendiente qMonedaD8
)
AS
SET NOCOUNT ON 
	INSERT INTO stkMoviOC
	(
		stkMoviCabe,
		Renglon,
		comOrdenComp,
		Renglon_OC,
		CantFactPendiente
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		@pcomOrdenComp,
		@pRenglon_OC,
		@pCantFactPendiente
	)

GO

DROP PROCEDURE stkMoviOCDatos
GO
CREATE PROCEDURE stkMoviOCDatos
(
@pstkMoviCabe bigint,
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

SELECT stkMoviOC.stkMoviCabe, stkMoviOC.Renglon,  stkMoviOC.comOrdenComp,
	stkMoviOC.Renglon_OC, 
	stkProductos.Producto_id, stkProductos.Descripcion as DescripcionProducto , 
	stkMoviCuerpo.Cantidad,  stkMoviCuerpo.CantidadForm AS CantidadOriginal,
	comOCCuerpo.Cantidad as CantidadOC, comOcArticulo.CantidadOriginal as CantidadOriginalOC, stkMoviOC.CantFactPendiente
FROM stkMoviOC 
INNER JOIN stkMoviCuerpo  ON (stkMoviCuerpo.stkMoviCabe = stkMoviOC.stkMoviCabe) AND (stkMoviCuerpo.Renglon = stkMoviOC.Renglon)
INNER JOIN comOCArticulo  ON (comOCArticulo.comOrdenComp = stkMoviOC.comOrdenComp) AND (comOCArticulo.Renglon_OC = stkMoviOC.Renglon_OC)
INNER JOIN comOCCuerpo ON (comOCCuerpo.comOrdenComp = stkMoviOC.comOrdenComp) AND (comOCCuerpo.Renglon_OC = stkMoviOC.Renglon_OC)
INNER JOIN stkProductos ON stkProductos.Producto_id = stkMoviCuerpo.Producto_Id
WHERE (stkMoviOC.stkMoviCabe = @pstkMoviCabe)
AND (stkMoviOC.Renglon = isnull(@pRenglon,stkMoviOC.Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviOCEliminar
GO
CREATE PROCEDURE stkMoviOCEliminar
(
@pstkMoviCabe bigint,
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviOC 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND (stkMoviOC.Renglon = isnull(@pRenglon,stkMoviOC.Renglon))
 
 RETURN @@Error 

GO

Drop Procedure stkMoviOCActuPendiente
Go
Create Procedure stkMoviOCActuPendiente
(
@pstkMoviCabe bigint,
@pRenglon int,
@pCantidad qMonedaD8
)
As
Update stkMoviOC Set CantFactPendiente = CantFactPendiente - @pCantidad Where stkMoviCabe = @pstkMoviCabe And Renglon = @pRenglon
Go

