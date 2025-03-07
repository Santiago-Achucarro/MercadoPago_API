drop procedure wooExistenciaProd
go
create procedure wooExistenciaProd
(
    @pProducto_Id varchar(25),
    @pEmpresa_Id int =null
)
as
select stkExistencia.Empresa_Id, stkProductos.Producto_Id, stkDepositos.Deposito_Id, Cantidad, CantidadReservada, CantidadAlterna from stkexistencia
inner join stkProductos on stkProductos.stkProductos=stkExistencia.Producto_Id
inner join stkDepositos on stkDepositos.stkDepositos=stkExistencia.Deposito_Id
where stkProductos.Producto_Id=@pProducto_Id and stkExistencia.empresa_Id=isnull(@pEmpresa_Id,stkExistencia.empresa_Id) and stkDepositos.Deposito_Id!='wocom' and Cantidad>0
order by cantidad desc
go
