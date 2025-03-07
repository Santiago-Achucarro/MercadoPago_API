drop procedure wooApiConfigDatos
go
create procedure wooApiConfigDatos
(
@pEmpresa_Id int
)
as
select ConsumerKey, ConsumerSecret, apiURL, AdjuntosURL, dirAdjuntosPublicados, UsaWooCommerce, wooApiConfig.Empresa_Id, venSubTipoMov.SubTipoMov_Id, 
venSubTipoMov.Descripcion as DescripcionSubTipoMov, stkProductos.Producto_Id as ProductoFlete, stkProductos.Descripcion as DescripcionProducto
from wooApiConfig
left join venSubTipoMov on venSubTipoMov.venSubTipoMov=wooApiConfig.SubTipoMov_Id
left join stkProductos on stkProductos.stkProductos=wooApiConfig.ProductoEnvios
exec wooClientesDatos @pEmpresa_Id
go

drop procedure wooApiConfigGuardar
go
create procedure wooApiConfigGuardar
    (
    @pConsumerKey varchar(max),
    @pConsumerSecret varchar(max),
    @papiURL varchar(200),
    @pAdjuntosURL varchar(200),
    @pdirAdjuntosPublicados varchar(200),
    @pUsaWooCommerce bit,
    @pEmpresa_Id int=null,
    @pSubTipoMov_Id varchar(5),
    @pProductoFletes varchar(25)
)
as
if(@pEmpresa_Id is null)
begin
    delete wooApiConfig
end

if(exists( select 1
from wooApiConfig
where isnull(Empresa_Id, @pEmpresa_Id)=@pEmpresa_Id)) --actualizando normal
begin
    update wooApiConfig set consumerKey=@pConsumerKey, consumerSecret=@pConsumerSecret, apiURL=@papiURL, adjuntosURL=@pAdjuntosURL, dirAdjuntosPublicados=@pdirAdjuntosPublicados, UsaWooCommerce=@pUsaWooCommerce, Empresa_Id=@pEmpresa_Id, 
    SubTipoMov_Id=dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id), ProductoEnvios=dbo.FuncFKstkProductos(@pProductoFletes) where isnull(Empresa_Id, @pEmpresa_Id)=@pEmpresa_Id
END

ELSE

begin

    if(@pEmpresa_Id is not null and exists(select 1
        from wooApiConfig
        where Empresa_Id is null))
--quitando el para todas las empresas
    begin
        insert into wooApiConfig
            (consumerKey, consumerSecret, apiURL, adjuntosURL, dirAdjuntosPublicados, UsaWooCommerce, Empresa_Id, SubTipoMov_Id)
        select wooApiConfig.consumerKey, consumerSecret, apiURL, adjuntosURL, dirAdjuntosPublicados, UsaWooCommerce, genEmpresas.genEmpresas, venSubTipoMov.SubTipoMov_Id
        from genEmpresas inner join wooApiConfig on wooApiConfig.Empresa_Id is null
        left join venSubTipoMov on venSubTipoMov.venSubTipoMov=wooApiConfig.SubTipoMov_Id and venSubTipoMov.SubTipoMov_Id=@pSubTipoMov_Id
        delete wooApiConfig where Empresa_Id is null
        update wooApiConfig set consumerKey=@pConsumerKey, consumerSecret=@pConsumerSecret, apiURL=@papiURL, adjuntosURL=@pAdjuntosURL, dirAdjuntosPublicados=@pdirAdjuntosPublicados, UsaWooCommerce=@pUsaWooCommerce, Empresa_Id=@pEmpresa_Id, SubTipoMov_Id=dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id), ProductoEnvios=dbo.FuncFKstkProductos(@pProductoFletes) where isnull(Empresa_Id, @pEmpresa_Id)=@pEmpresa_Id
    end
    else
    begin
        --primer registro o agregando ptodasEmpresas
        insert into wooApiConfig
            (consumerKey, consumerSecret, apiURL, adjuntosURL, dirAdjuntosPublicados, UsaWooCommerce, Empresa_Id, SubTipoMov_Id, ProductoEnvios)
        values
            (@pConsumerKey, @pConsumerSecret, @papiURL, @pAdjuntosURL, @pdirAdjuntosPublicados, @pUsaWooCommerce, @pEmpresa_Id, dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id), dbo.FuncFKstkProductos(@pProductoFletes))
    end
end
