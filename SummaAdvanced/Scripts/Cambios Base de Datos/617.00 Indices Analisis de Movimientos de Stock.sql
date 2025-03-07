
CREATE NONCLUSTERED INDEX idxstkCuerpoRevaProd
ON [dbo].[stkMoviCuerpoReva] ([Producto_Id])
GO

CREATE NONCLUSTERED INDEX idxvenMovStkHistCabe
ON [dbo].[venMovStkHist] ([stkMoviCabe],[Renglon])


GO

INSERT INTO genVersion (Version) Values(617)
GO