DROP PROCEDURE proOrdenStockCostoInsertar
GO
CREATE PROCEDURE proOrdenStockCostoInsertar
(
@pproMovCierreOrden bigint,
@pstkMoviCabe bigint,
@pRenglon int,
@pPorcentajeCosto qPorcentaje
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proOrdenStockCosto WHERE (proMovCierreOrden = @pproMovCierreOrden) AND (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE proOrdenStockCosto
	SET		PorcentajeCosto = @pPorcentajeCosto
	WHERE (proMovCierreOrden = @pproMovCierreOrden) AND (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO proOrdenStockCosto
	(
		proMovCierreOrden,
		stkMoviCabe,
		Renglon,
		PorcentajeCosto
	)
	VALUES 
	(
		@pproMovCierreOrden,
		@pstkMoviCabe,
		@pRenglon,
		@pPorcentajeCosto
	)
END 

GO

DROP PROCEDURE proOrdenStockCostoDatos
GO
CREATE PROCEDURE proOrdenStockCostoDatos
(
@pproMovCierreOrden bigint,
@pstkMoviCabe bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

SELECT proOrdenStockCosto.proMovCierreOrden, proOrdenStockCosto.stkMoviCabe, proOrdenStockCosto.Renglon,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	proOrdenStockCosto.PorcentajeCosto
FROM proOrdenStockCosto 
INNER JOIN stkMoviCuerpo  ON stkMoviCuerpo.stkMoviCabe = proOrdenStockCosto.stkMoviCabe AND stkMoviCuerpo.Renglon = proOrdenStockCosto.Renglon
INNER JOIN stkProductos ON  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
WHERE proOrdenStockCosto.proMovCierreOrden = @pproMovCierreOrden
AND proOrdenStockCosto.stkMoviCabe = @pstkMoviCabe
AND proOrdenStockCosto.Renglon = isnull(@pRenglon,proOrdenStockCosto.Renglon)
 
RETURN @@Error 

GO

DROP PROCEDURE proOrdenStockCostoEliminar
GO
CREATE PROCEDURE proOrdenStockCostoEliminar
(
@pproMovCierreOrden bigint,
@pstkMoviCabe bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proOrdenStockCosto 
WHERE (proMovCierreOrden = @pproMovCierreOrden)
AND (stkMoviCabe = @pstkMoviCabe)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

GO
