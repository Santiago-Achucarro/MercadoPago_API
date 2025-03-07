--exec wooMigracionProductos 'PRUEBAPROD','PRUEBAPROD'
drop procedure wooMigracionProductos
go
create procedure wooMigracionProductos
(
    @pProductoDesde varchar(25),
    @pProductoHasta varchar(25),
    @pEmpresa_Id int
)
as
--set @pProductoDesde='ATE-60M' 
----set @pProductoHasta='ATE-60M'

select stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Descripcion, stkProductos.DescripcionDetallada, FechaUltModif, PrecioUltCompra, Acepta_Compras, CodigoBarra,
sum(stkExistencia.Cantidad) as Cantidad, stkFamilias.stkFamilias, stkFamilias.Familia_Id, stkFamilias.Descripcion as DescripcionFamilia, wooCommerceId, stkProductos.Inactivo from stkProductos
 left join stkExistencia on stkExistencia.Producto_Id=stkProductos.stkProductos
 left join stkFamilias on stkFamilias.stkFamilias=stkProductos.Familia_Id
 left join wooProductosId on wooProductosId.Producto_Id=stkProductos.stkProductos
where stkProductos.Posteado=1 --and stkProductos.Inactivo=0
and stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta
and (isnull(stkProductos.Empresa_Id,@pEmpresa_Id)=@pEmpresa_Id or @pEmpresa_Id is null)
group by stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Descripcion, stkProductos.DescripcionDetallada, FechaUltModif, PrecioUltCompra, Acepta_Compras, CodigoBarra, stkFamilias.stkFamilias, stkFamilias.Familia_Id, stkFamilias.Descripcion, wooCommerceId, stkProductos.Inactivo
select * from genAdjuntos inner join stkProductos on stkProductos.stkProductos=genAdjuntos.Identity_Id where genadjuntos.Tabla_Id='stkProductos'
and stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta and genadjuntos.Extension in('jpg','jpeg', 'png','gif','webp', 'tiff', 'psd','bmp','svg','pdf')
go

drop procedure wooProductosGuardarId
go
create procedure wooProductosGuardarId
(
    @pProducto_Id int,
    @pwooCommerceId int
)
as
if exists( select 1 from wooProductosId where Producto_Id=(@pProducto_Id))
begin
update wooProductosId set wooCommerceId=@pwooCommerceId where Producto_Id=(@pProducto_Id)
end
else
begin
insert into wooProductosId(Producto_Id, wooCommerceId) values((@pProducto_Id), @pwooCommerceId)
end
go

drop procedure wooProductosEliminarId
go
create procedure wooProductosEliminarId
(
    @pProducto_Id varchar(25)
)
as
delete wooProductosId where Producto_Id=dbo.FuncFKstkProductos(@pProducto_Id)
go

drop procedure wooProductosDatos
go
create procedure wooProductosDatos
(
    @pProducto_Id int
)
as
declare @lProducto_id varchar(25)=(select stkProductos.Producto_Id from stkProductos inner join wooProductosId on wooProductosId.Producto_Id=stkProductos.stkProductos where wooProductosId.wooCommerceId=@pProducto_Id)
exec stkProductosDatos @lProducto_id
go


drop procedure wooProductosActualizarStock
go
create procedure wooProductosActualizarStock
(
    @pEmpresa_Id int
)
AS
select stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Descripcion, stkProductos.DescripcionDetallada, FechaUltModif, PrecioUltCompra, Acepta_Compras, CodigoBarra,
sum(stkExistencia.Cantidad) as Cantidad, stkFamilias.stkFamilias, stkFamilias.Familia_Id, stkFamilias.Descripcion as DescripcionFamilia, wooCommerceId, stkProductos.Inactivo from stkProductos
 left join stkExistencia on stkExistencia.Producto_Id=stkProductos.stkProductos
 left join stkFamilias on stkFamilias.stkFamilias=stkProductos.Familia_Id
 inner join wooProductosId on wooProductosId.Producto_Id=stkProductos.stkProductos
 left join wooUltActualizacionStock on wooUltActualizacionStock.Empresa_Id=@pEmpresa_Id
where stkProductos.Posteado=1 --and stkProductos.Inactivo=0
and (stkExistencia.UltimaModificacion>wooUltActualizacionStock.Fecha or (wooUltActualizacionStock.empresa_Id is null and stkExistencia.UltimaModificacion is not null))
and (isnull(stkProductos.Empresa_Id,@pEmpresa_Id)=@pEmpresa_Id or @pEmpresa_Id is null)
group by stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Descripcion, stkProductos.DescripcionDetallada, FechaUltModif, PrecioUltCompra, Acepta_Compras, CodigoBarra, 
stkFamilias.stkFamilias, stkFamilias.Familia_Id, stkFamilias.Descripcion, wooCommerceId, stkProductos.Inactivo

if exists (select 1 from wooUltActualizacionStock where Empresa_Id=@pEmpresa_Id)
begin update wooUltActualizacionStock set Fecha=GETDATE() where Empresa_Id=@pEmpresa_Id end
else begin insert into wooUltActualizacionStock (Fecha, Empresa_Id) values (getdate(),@pEmpresa_Id) end
go