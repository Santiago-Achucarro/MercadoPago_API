DROP PROCEDURE comOCArticuloGuardar
GO
CREATE PROCEDURE comOCArticuloGuardar
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pProducto_Id varchar(25) = NULL,
@pFactor qCantidadD8,
@pCantidadOriginal qCantidadD8,
@pPrecioOriginal qMonedaD8,
@pDeposito_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comOCArticulo WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)))
BEGIN 
	UPDATE comOCArticulo
	SET		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		Factor = @pFactor,
		CantidadOriginal = @pCantidadOriginal,
		PrecioOriginal = @pPrecioOriginal,
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
	WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)
END 
ELSE 
BEGIN 
	INSERT INTO comOCArticulo
	(
		comOrdenComp,
		Renglon_OC,
		Producto_Id,
		Factor,
		CantidadOriginal,
		PrecioOriginal,
		Deposito_Id
	)
	VALUES 
	(
		@pcomOrdenComp,
		@pRenglon_OC,
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pFactor,
		@pCantidadOriginal,
		@pPrecioOriginal,
		dbo.FuncFKstkDepositos(@pDeposito_Id)
	)
END 

GO

DROP PROCEDURE comOCArticuloDatos
GO
CREATE PROCEDURE comOCArticuloDatos
(
@pcomOrdenComp int,
@pRenglon_OC int=null
)
AS
SET NOCOUNT ON 

SELECT comOCArticulo.comOrdenComp, comOCArticulo.Renglon_OC, stkProductos.Producto_Id,
	stkProductos.Descripcion as DescripcionProductos, comOCArticulo.Factor, comOCArticulo.CantidadOriginal, comOCArticulo.PrecioOriginal,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, 
	comOCCuerpo.Cantidad, comOCCuerpo.Cantidad_Recibida, comOcCuerpo.Cantidad_Embarcada,
	comOCCuerpo.Cantidad_Facturada, comOCCuerpo.Fecha_Entrega, comOCCuerpo.Precio, comOCCuerpo.Pendiente,
	comOCCuerpo.Cantidad_Creditos, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	comOCCuerpo.CantidadConsignada, cast(0 as bit) as Marca, comOCCuerpo.Observaciones
FROM comOCArticulo 
INNER JOIN comOCCuerpo  ON (comOCCuerpo.comOrdenComp = comOCArticulo.comOrdenComp) AND (comOCCuerpo.Renglon_OC = comOCArticulo.Renglon_OC)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = comOCArticulo.Producto_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = comOCArticulo.Deposito_Id)
INNER JOIN comOrdenComp  ON (comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOCCuerpo.Medida_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comOCCuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comOCCuerpo.Centro2_Id)
WHERE (comOCArticulo.comOrdenComp = @pcomOrdenComp)
AND (comOCArticulo.Renglon_OC = isnull(@pRenglon_OC,comOCArticulo.Renglon_oc))
 
 RETURN @@Error 

GO

DROP PROCEDURE comOCArticuloEliminar
GO
CREATE PROCEDURE comOCArticuloEliminar
(
@pcomOrdenComp int,
@pRenglon_OC int= null
)
AS
SET NOCOUNT ON 

DELETE FROM comOCArticulo 
WHERE (comOrdenComp = @pcomOrdenComp)
AND (Renglon_OC = isnull(@pRenglon_OC,Renglon_oc))
 
 RETURN @@Error 

GO

GO