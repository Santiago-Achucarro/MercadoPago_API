CREATE NONCLUSTERED INDEX idxStkProductosCFUM
ON [dbo].[stkProductos] ([CFVenta_Id])
INCLUDE ([UmVenta])
GO

INSERT INTO genVersion(Version) Values(606.00)
GO


