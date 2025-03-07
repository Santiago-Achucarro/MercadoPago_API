DROP PROCEDURE proOrdenStockInsertar
GO
CREATE PROCEDURE proOrdenStockInsertar
(
@pproMovCierreOrden bigint,
@pstkMoviCabe bigint
)
AS
BEGIN 
	INSERT INTO proOrdenStock
	(
		proMovCierreOrden,
		stkMoviCabe
	)
	VALUES 
	(
		@pproMovCierreOrden,
		@pstkMoviCabe
	)
END 
GO


DROP PROCEDURE proOrdenStockDatos
GO
CREATE PROCEDURE proOrdenStockDatos
(
@pproMovCierreOrden bigint = NULL,
@pstkMoviCabe bigint = NULL
)
AS
SET NOCOUNT ON 

SELECT proOrdenStock.proMovCierreOrden, proOrdenStock.stkMoviCabe
FROM proOrdenStock 
WHERE proMovCierreOrden = ISNULL(@pproMovCierreOrden, proMovCierreOrden)
AND stkMoviCabe = ISNULL(@pstkMoviCabe, stkMoviCabe)
 
RETURN @@Error 

GO

DROP PROCEDURE proOrdenStockEliminar
GO
CREATE PROCEDURE proOrdenStockEliminar
(
@pproMovCierreOrden bigint,
@pstkMoviCabe bigint 
)
AS
SET NOCOUNT ON 

DELETE FROM proOrdenStock 
WHERE (proMovCierreOrden = @pproMovCierreOrden)
AND (stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO


