DROP PROCEDURE comMovProvDPreOCInsertar
GO
CREATE PROCEDURE comMovProvDPreOCInsertar
(
@pcomMovProv bigint,
@pRenglon int,
@pcomMovProvFactOrig bigint ,
@pcomOrdenComp int ,
@pRenglon_OC int ,
@pCantidadOriginal qCantidadD8,
@pCantidad qCantidadD8,
@pDescuento qPorcentaje,
@pMonto qMonedaD8
)
AS
SET NOCOUNT ON 
	INSERT INTO comMovProvDPreOC
	(
		comMovProv,
		Renglon,
		comMovProvFactOrig,
		comOrdenComp,
		Renglon_OC,
		CantidadOriginal,
		Cantidad,
		Descuento,
		Monto
	)
	VALUES 
	(
		@pcomMovProv,
		@pRenglon,
		@pcomMovProvFactOrig,
		@pcomOrdenComp,
		@pRenglon_OC,
		@pCantidadOriginal,
		@pCantidad,
		@pDescuento,
		@pMonto
	)

GO

DROP PROCEDURE comMovProvDPreOCDatos
GO
CREATE PROCEDURE comMovProvDPreOCDatos
(
@pcomMovProv bigint,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT comMovProvDPreOC.comMovProv, comMovProvDPreOC.Renglon, comMovProvDPreOC.comMovProvFactOrig, comMovProvDPreOC.comOrdenComp,
	comMovProvDPreOC.Renglon_OC, comMovProvDPreOC.CantidadOriginal, comMovProvDPreOC.Cantidad, comMovProvDPreOC.Descuento,
	comMovProvDPreOC.Monto
FROM comMovProvDPreOC 
WHERE (comMovProv = @pcomMovProv)
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE comMovProvDPreOCEliminar
GO
CREATE PROCEDURE comMovProvDPreOCEliminar
(
@pcomMovProv bigint = NULL,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comMovProvDPreOC 
WHERE (comMovProv = ISNULL(@pcomMovProv, comMovProv))
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

