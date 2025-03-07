drop procedure espstkexistenciaxdepositoKSK
go

create procedure espstkexistenciaxdepositoKSK
@ProductoDesde varchar(25) = '0810201141AZ134',
@Sucursal  char(4) = '0225',
@Empresa int = 1,
@ListaPrecios varchar(5) = 'LOC'

as

-- exec espstkexistenciaxdepositoKSK '0810221141LO134', '0225', 1
-- select * from stkproductos


declare @producto varchar(20);
-- select  @producto = substring(@ProductoDesde,1,len(@productoDesde)-3)
select  @producto = Left(@ProductoDesde,12)



select @ProductoDesde as Producto, @Sucursal as Sucursal, @Empresa as Empresa, @ListaPrecios as Lista


select c.stkProductos, c.Producto_Id, c.Descripcion, a.Cantidad, e.PrecioLista, e.PrecioPromocion
,b.Deposito_Id, b.Descripcion Deposito
from stkExistencia a
inner join stkdepositos b on a.Deposito_id = b.stkDepositos
inner join stkProductos c on a.Producto_Id = c.stkProductos
inner join genSucursalesEmpr d on b.Sucursal = d.genSucursalesEmpr
inner join venListasPrecios f on f.ListaPrecio_Id = @ListaPrecios
inner join venListasPrecProd e on e.Producto_id = c.stkProductos and f.venListasPrecios = e.ListaPrecio_Id
where 
d.Sucursal = @Sucursal
and c.Producto_Id like @producto+'%'
and a.Empresa_Id = @Empresa
order by 2
go