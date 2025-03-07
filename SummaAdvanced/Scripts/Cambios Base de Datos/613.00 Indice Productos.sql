

CREATE NONCLUSTERED INDEX vstkProductosVenIX
ON [dbo].[venListasPrecProd] ([Producto_Id])
INCLUDE ([ListaPrecio_Id],[PrecioLista])
GO

CREATE NONCLUSTERED INDEX IdxProductosInv1
ON [dbo].[stkProductos] ([Producto_Id])
INCLUDE ([Tipo_Id],[Familia_Id],[Grupo_Id])
GO

CREATE NONCLUSTERED INDEX IdxMoviCuerpoInv1
ON [dbo].[stkMoviCuerpo] ([Producto_Id])
INCLUDE ([Deposito_Id])


CREATE NONCLUSTERED INDEX IdxProductosInv2
ON [dbo].[stkProductos] ([Tipo_Id],[Producto_Id])
INCLUDE ([Descripcion],[Familia_Id],[Grupo_Id])

INSERT INTO genVersion(Version) Values(613.00)
go


