DROP PROCEDURE stkMoviCuerpoRevaGuardar
GO
CREATE PROCEDURE stkMoviCuerpoRevaGuardar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pProducto_Id varchar(25),
@pPUC_Actual qMonedaD8,
@pPUC_Anterior qMonedaD8,
@pPPP_Actual qMonedaD8,
@pPPP_Anterior qMonedaD8,
@pSTD_Actual qMonedaD8,
@pSTD_Anterior qMonedaD8,
@pImporteAjuste qMonedaD2, 
@pImporteAjusteCosto qMonedaD2, 
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviCuerpoReva WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE stkMoviCuerpoReva
	SET		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		PUC_Actual = @pPUC_Actual,
		PUC_Anterior = @pPUC_Anterior,
		PPP_Actual = @pPPP_Actual,
		PPP_Anterior = @pPPP_Anterior,
		STD_Actual = @pSTD_Actual,
		STD_Anterior = @pSTD_Anterior,
		ImporteAjuste = @pImporteAjuste,
		ImporteAjusteCosto = @pImporteAjusteCosto,
		Cantidad = @pCantidad
	WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviCuerpoReva
	(
		stkMoviCabe,
		Renglon,
		Producto_Id,
		PUC_Actual,
		PUC_Anterior,
		PPP_Actual,
		PPP_Anterior,
		STD_Actual,
		STD_Anterior,
		ImporteAjuste,
		ImporteAjusteCosto,
		Cantidad
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pPUC_Actual,
		@pPUC_Anterior,
		@pPPP_Actual,
		@pPPP_Anterior,
		@pSTD_Actual,
		@pSTD_Anterior,
		@pImporteAjuste, 
		@pImporteAjusteCosto,
		@pCantidad
	)
END 

GO

DROP PROCEDURE stkMoviCuerpoRevaDatos
GO
CREATE PROCEDURE stkMoviCuerpoRevaDatos
(
@pstkMoviCabe bigint,
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

SELECT stkMoviCuerpoReva.stkMoviCabe, stkMoviCuerpoReva.Renglon, stkProductos.Producto_Id,
	stkProductos.Descripcion as DescripcionProductos, stkMoviCuerpoReva.PUC_Actual, stkMoviCuerpoReva.PUC_Anterior, stkMoviCuerpoReva.PPP_Actual,
	stkMoviCuerpoReva.PPP_Anterior, stkMoviCuerpoReva.STD_Actual, stkMoviCuerpoReva.STD_Anterior, stkMoviCuerpoReva.ImporteAjuste, stkMoviCuerpoReva.ImporteAjusteCosto,
		' ' Cuenta_Id, ' ' CtaCompras, '' Centro1_Id, '' Centro2_Id, 
		stkMoviCuerpoReva.Cantidad
FROM stkMoviCuerpoReva 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkMoviCuerpoReva.Producto_Id)
WHERE (stkMoviCuerpoReva.stkMoviCabe = @pstkMoviCabe)
AND (stkMoviCuerpoReva.Renglon = ISNULL(@pRenglon,stkMoviCuerpoReva.Renglon))
ORDER BY 2 
RETURN @@Error 

GO
	
DROP PROCEDURE stkMoviCuerpoRevaEliminar
GO
CREATE PROCEDURE stkMoviCuerpoRevaEliminar
(
@pstkMoviCabe bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCuerpoReva 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
