drop procedure stkCostoUltimaCompra
go
create procedure stkCostoUltimaCompra
(
    @pProducto_Id varchar(25)
)
as
select  Producto_Id, CostoUltCompra from stkProductos
where Producto_Id=@pProducto_Id
go