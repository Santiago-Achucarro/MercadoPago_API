drop procedure venListasPreciosXLSCatalogo
go
create procedure venListasPreciosXLSCatalogo
(
    @pListaDesde varchar(5),
    @pListaHasta varchar(5),
    @pProductoDesde varchar(25),
    @pProductoHasta varchar(25),
    @pFecha datetime
)
as
select @pListaDesde as ListaDesde, @pListaHasta as ListaHasta, @pProductoDesde as ProductoDesde, @pProductoHasta as ProductoHasta,
@pFecha as Fecha
select venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion, genMonedas.Moneda_Id, genUsuarios.Usuario_Id as UsuAutorizado,
DecimalesPu,venListasPrecios.Inactivo, venListasPrecios.Posteado, case when venListasPrecios.Empresa_Id is null then 1 else 0 end as PTodasEmpresas,
LlevaImpuestoInclu, venListasVersion.VigenciaDesde, venListasVersion.VigenciaHasta, venListasVersion.Version
from venListasPrecios
inner join genMonedas on genMonedas.genMonedas=venListasPrecios.Moneda_Id
inner join genUsuarios on genUsuarios.genUsuarios=venListasPrecios.UsuAutorizado
inner join venListasVersion on venListasVersion.ListaPrecio_Id=venListasPrecios.venListasPrecios
where venListasPrecios.ListaPrecio_Id BETWEEN @pListaDesde and @pListaHasta and  @pFecha BETWEEN VigenciaDesde and VigenciaHasta

select venListasPrecios.ListaPrecio_Id, stkProductos.Producto_Id, PrecioLista, PrecioPromocion, AdmiteRegalo
from venListasPrecProd
inner join venListasPrecios on venListasPrecios.venListasPrecios=venListasPrecProd.ListaPrecio_Id
inner join stkProductos on stkProductos.stkProductos=venListasPrecProd.Producto_Id
inner join venListasVersion on venListasVersion.ListaPrecio_Id=venListasPrecios.venListasPrecios and venListasVersion.Version=venListasPrecProd.Version
where venListasPrecios.ListaPrecio_Id BETWEEN @pListaDesde and @pListaHasta and
stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta and @pFecha between VigenciaDesde and VigenciaHasta
go