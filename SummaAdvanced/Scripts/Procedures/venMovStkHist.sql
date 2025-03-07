DROP PROCEDURE venMovStkHistGuardar
GO
CREATE PROCEDURE venMovStkHistGuardar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int,
@pstkMoviCabe bigint,
@pRenglon int,
@pCantidad qCantidadD8,
@pFacturaRemito char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovStkHist WHERE (venMovimientos = @pvenMovimientos) AND 
(RenglonCuerpo = @pRenglonCuerpo) AND (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE venMovStkHist
	SET		Cantidad = @pCantidad,
		FacturaRemito = @pFacturaRemito
	WHERE (venMovimientos = @pvenMovimientos) AND (RenglonCuerpo = @pRenglonCuerpo) AND (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO venMovStkHist
	(
		venMovimientos,
		RenglonCuerpo,
		stkMoviCabe,
		Renglon,
		Cantidad,
		FacturaRemito
	)
	VALUES 
	(
		@pvenMovimientos,
		@pRenglonCuerpo,
		@pstkMoviCabe,
		@pRenglon,
		@pCantidad,
		@pFacturaRemito
	)
END 

GO

DROP PROCEDURE venMovStkHistDatos
GO
CREATE PROCEDURE venMovStkHistDatos
(
@pvenMovimientos bigint = Null,
@pConRenglon int = Null,
@pstkMoviCabe bigint = Null,
@pRenglon int = Null
)
AS
SET NOCOUNT ON 

SELECT venMovStkHist.venMovimientos, venMovStkHist.RenglonCuerpo, venMovStkHist.stkMoviCabe,
venMovStkHist.Renglon, venMovStkHist.Cantidad, venMovStkHist.FacturaRemito, dbo.Segmento(Factu.Segmento_Id, Factu.Segmento1C, 
	Factu.Segmento2C, Factu.Segmento3C, Factu.Segmento4C, Factu.Segmento1N, Factu.Segmento2N, Factu.Segmento3N, Factu.Segmento4N) Factura,
dbo.Segmento(Remi.Segmento_Id, Remi.Segmento1C, Remi.Segmento2C, Remi.Segmento3C, Remi.Segmento4C, Remi.Segmento1N, Remi.Segmento2N, Remi.Segmento3N, Remi.Segmento4N) Remito
FROM venMovStkHist 
INNER JOIN venMovConStockCr ON venMovConStockCr.venMovimientos = venMovStkHist.venMovimientos AND venMovConStockCr.RenglonCuerpo = venMovStkHist.RenglonCuerpo
INNER JOIN stkMoviCuerpo  ON stkMoviCuerpo.stkMoviCabe = venMovStkHist.stkMoviCabe AND stkMoviCuerpo.Renglon = venMovStkHist.Renglon
Inner Join genAsiSegmentos Factu On Factu.Asiento_Id = venMovStkHist.venMovimientos
Inner Join genAsiSegmentos Remi On Remi.Asiento_Id = venMovStkHist.stkMoviCabe
WHERE venMovStkHist.venMovimientos = IsNull(@pvenMovimientos, venMovStkHist.venMovimientos)
AND (venMovStkHist.RenglonCuerpo = IsNull(@pConRenglon, venMovStkHist.RenglonCuerpo))
AND venMovStkHist.stkMoviCabe = IsNull(@pstkMoviCabe, venMovStkHist.stkMoviCabe)
AND (venMovStkHist.Renglon = IsNull(@pRenglon, venMovStkHist.Renglon))
 
 RETURN @@Error 

GO

Drop Procedure venMovStkHistDevolverIdMovStock
GO
CREATE PROCEDURE venMovStkHistDevolverIdMovStock
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 
-- Busco solo el caso 2 que es cuando se hace Factura y Remito juntos --
SELECT Distinct venMovStkHist.venMovimientos, venMovStkHist.stkMoviCabe
FROM venMovStkHist inner join conAsientos ON conAsientos.conAsientos = venMovStkHist.stkMoviCabe
WHERE venMovStkHist.venMovimientos = @pvenMovimientos And 
venMovStkHist.FacturaRemito = '2' AND 
conAsientos.Anulado = 0

RETURN @@Error 

GO


DROP PROCEDURE venMovStkHistEliminar
GO
CREATE PROCEDURE venMovStkHistEliminar
(
@pvenMovimientos bigint = Null,
@pRenglonCuerpo int = Null,
@pstkMoviCabe bigint = Null,
@pRenglon int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM venMovStkHist 
WHERE venMovimientos = isNull(@pvenMovimientos, venMovimientos)
AND RenglonCuerpo = isNull(@pRenglonCuerpo, RenglonCuerpo)
AND stkMoviCabe = isNull(@pstkMoviCabe, stkMoviCabe)
AND Renglon = isNull(@pRenglon, Renglon)
 
 RETURN @@Error 

GO

GO
