DROP PROCEDURE stkCostosEliminar
GO

CREATE PROCEDURE stkCostosEliminar
(
	@pProducto_Id VarChar(25),
	@pEmpresa_Id Int
)
AS

delete from stkproductosCostos where Producto_Id = dbo.FuncfkstkProductos(@pProducto_Id) and Empresa_Id = @pEmpresa_Id
delete from stkProductosCostosSucursal where Producto_Id = dbo.FuncfkstkProductos(@pProducto_Id) and Empresa_Id = @pEmpresa_Id
delete from stkProductosCostoCierre where Producto_Id = dbo.FuncfkstkProductos(@pProducto_Id) and Empresa_Id = @pEmpresa_Id
delete from stkProductosCostoCierreSucursal where Producto_Id = dbo.FuncfkstkProductos(@pProducto_Id) and Empresa_Id = @pEmpresa_Id

GO

