DROP PROCEDURE comMovPOCInsertar
GO
CREATE PROCEDURE comMovPOCInsertar
(
@pcomMovProv bigint,
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8,
@pCantidadOriginal qCantidadD8,
@pFactor qCantidadD8, 
@pCambio qMonedaD8
)
AS
BEGIN 
	INSERT INTO comMovPOC
	(
		comMovProv,
		comOrdenComp,
		Renglon_OC,
		Cantidad,
		CantidadOriginal,
		Factor,
		Cambio
	)
	VALUES 
	(
		@pcomMovProv,
		@pcomOrdenComp,
		@pRenglon_OC,
		@pCantidad,
		@pCantidadOriginal,
		@pFactor,
		@pCambio
	)
END 

GO

DROP PROCEDURE comMovPOCDatos
GO
CREATE PROCEDURE comMovPOCDatos
(
@pcomMovProv bigint,
@pcomOrdenComp int,
@pRenglon_OC int=null
)
AS
SET NOCOUNT ON 

SELECT comMovPOC.comMovProv, 
	comMovPOC.comOrdenComp, comMovPOC.Renglon_OC, 
	comOCCuerpo.Cantidad CantidadOC, comOCCuerpo.Cantidad_Recibida, 
	comOCCuerpo.Cantidad_Facturada, comOCCuerpo.Fecha_Entrega,
	comOCCuerpo.Precio, comOCCuerpo.Pendiente, comOCCuerpo.Cantidad_Creditos, 
	ISNULL(comOCArticulo.PrecioOriginal, comOCCuerpo.Precio) AS PrecioOriginal,
	ISNULL(comOCArticulo.CantidadOriginal, comOCCuerpo.Cantidad) AS CantidadOriginalOC,
	comMovPOC.Cantidad, comMovPOC.CantidadOriginal, comMovPOC.Factor,
	stkUniMed.Medida_id, stkUniMed.Descripcion as DescripcionMedida, 
	conCentro1.Centro1_id, conCentro1.Descripcion DescripcionCentro1,
	conCentro2.Centro2_id, conCentro2.Descripcion DescripcionCentro2, 
	stkProductos.Producto_id, ISNULL(stkProductos.Descripcion, comOcMemo.Detalle) as Detalle, 
	commovpoc.Cambio
FROM comMovPOC 
INNER JOIN comMovProv  ON (comMovProv.comMovProv = comMovPOC.comMovProv)
INNER JOIN comOCCuerpo  ON (comOCCuerpo.comOrdenComp = comMovPOC.comOrdenComp) AND (comOCCuerpo.Renglon_OC = comMovPOC.Renglon_OC)
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
INNER JOIN conCentro1 ON conCentro1.conCentro1 = comOCCuerpo.Centro1_id
INNER JOIN conCentro2 ON conCentro2.conCentro2 = comOCCuerpo.Centro2_id
LEFT OUTER JOIN (comOCArticulo INNER JOIN stkProductos ON
comOCArticulo.Producto_id =stkProductos.stkProductos) ON
comOCArticulo.comOrdenComp = comOCCuerpo.comOrdenComp AND 
comOCArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
LEFT OUTER JOIN comOCMemo ON
comOCMemo.comOrdenComp = comOCCuerpo.comOrdenComp AND 
comOCMemo.Renglon_OC = comOCCuerpo.Renglon_OC
WHERE (comMovPOC.comMovProv = @pcomMovProv)
AND (comMovPOC.comOrdenComp = @pcomOrdenComp)
AND (comMovPOC.Renglon_OC = ISNULL(@pRenglon_OC,comMovPOC.Renglon_OC))
ORDER BY 3 

RETURN @@Error 

GO

DROP PROCEDURE comMovPOCEliminar
GO
CREATE PROCEDURE comMovPOCEliminar
(
@pcomMovProv bigint,
@pcomOrdenComp int,
@pRenglon_OC int
)
AS
SET NOCOUNT ON 

DELETE FROM comMovPOC 
WHERE (comMovProv = @pcomMovProv)
AND (comOrdenComp = @pcomOrdenComp)
AND (Renglon_OC = @pRenglon_OC)
 
 RETURN @@Error 

GO


DROP PROCEDURE comMovPOCDatosPendiente
GO
CREATE PROCEDURE comMovPOCDatosPendiente
(
@pcomOrdenComp int
)
AS
SET NOCOUNT ON 

SELECT comOCCuerpo.comOrdenComp, comOCCuerpo.Renglon_OC, 
	comOCCuerpo.Cantidad CantidadOC, comOCCuerpo.Cantidad_Recibida, 
	comOCCuerpo.Cantidad_Facturada, comOCCuerpo.Fecha_Entrega,
	comOCCuerpo.Precio, comOCCuerpo.Pendiente, comOCCuerpo.Cantidad_Creditos, 
	ISNULL(comOCArticulo.PrecioOriginal, comOCCuerpo.Precio) AS PrecioOriginal,
	ISNULL(comOCArticulo.CantidadOriginal, comOCCuerpo.Cantidad) AS CantidadOriginalOC,
	comOCCuerpo.Cantidad*0 as Cantidad, comOCCuerpo.Cantidad*0 as CantidadOriginal, 
	comOCArticulo.Factor, stkUniMed.Medida_id, stkUniMed.Descripcion as DescripcionMedida, 
	conCentro1.Centro1_id, conCentro1.Descripcion DescripcionCentro1,
	conCentro2.Centro2_id, conCentro2.Descripcion DescripcionCentro2, 
	stkProductos.Producto_id, ISNULL(stkProductos.Descripcion, comOcMemo.Detalle) as Detalle, 
	1.0000 as Cambio
FROM 
comOCCuerpo INNER JOIN stkUniMed ON stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
INNER JOIN conCentro1 ON conCentro1.conCentro1 = comOCCuerpo.Centro1_id
INNER JOIN conCentro2 ON conCentro2.conCentro2 = comOCCuerpo.Centro2_id
LEFT OUTER JOIN (comOCArticulo INNER JOIN stkProductos ON
comOCArticulo.Producto_id =stkProductos.stkProductos) ON
comOCArticulo.comOrdenComp = comOCCuerpo.comOrdenComp AND 
comOCArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
LEFT OUTER JOIN comOCMemo ON
comOCMemo.comOrdenComp = comOCCuerpo.comOrdenComp AND 
comOCMemo.Renglon_OC = comOCCuerpo.Renglon_OC
WHERE (comOCCuerpo.comOrdenComp = @pcomOrdenComp)
ORDER BY 3 

RETURN @@Error 

GO
