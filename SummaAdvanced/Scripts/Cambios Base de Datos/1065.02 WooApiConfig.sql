--drop table wooApiConfig
create  table wooApiConfig
(
    consumerKey varchar(max),
    consumerSecret varchar(max),
    apiURL varchar(200),
    adjuntosURL varchar(200),
    dirAdjuntosPublicados varchar(200),
    UsaWooCommerce bit,
    Empresa_Id int null,
    CONSTRAINT wooApiConfigFKEmpresa_Id foreign key (Empresa_Id) references genEmpresas(genEmpresas),
    SubTipoMov_Id int,
    constraint wooApiConfigFKSubTipoMov foreign key (SubTipoMov_Id) references venSubTipoMov(venSubTipoMov)
)
go
create table wooProductosId
(
    wooCommerceId int,
    Producto_Id int,
    constraint wooProductosIdFKProductos foreign key (Producto_Id) references stkProductos(stkProductos),
    constraint wooProductosIdPK primary key (Producto_Id)
)
GO
create table wooFamiliasId
(
    wooCommerceId bigint,
    Familia_Id int,
    constraint wooFamiliaIdFKFamilia foreign key (Familia_Id) references stkFamilias(stkFamilias),
    constraint wooFamiliaIdPK primary key (Familia_Id)
)

create table wooClientes
(
    Vendedor_Id bigint,
    constraint wooClientesFKVendedor foreign key (Vendedor_Id) references venVendedores(venVendedores),
    FormaEntrega_Id int,
    constraint wooClientesFKFormaEntrega foreign key (FormaEntrega_Id) references venFormaEntrega(venFormaEntrega),
    CondFisc_Id int,
    constraint wooClientesFKCondFiscal foreign key (CondFisc_Id) references venCondFiscal(venCondFiscal),
    Cobrador_Id bigint,
    constraint wooClientesFKCobrador foreign key (Cobrador_Id) references venCobradores(venCobradores),
    CategCred_Id int,
    constraint CategCred_Id foreign key (CategCred_Id) REFERENCES venCategCredito(venCategCredito),
    CondPago_Id int,
    constraint wooClientesFKCondPago foreign key (CondPago_Id) references venCondPago(venCondPago),
    ListaPrecio_Id int,
    constraint wooClientesFKListaPrecios foreign key (ListaPrecio_Id) references venListasPrecios(venListasPrecios),
    Region_Id int,
    constraint wooClientesFKRegion foreign key (Region_Id) references venRegion(venRegion),
    Zona_Id int,
    constraint wooClientesFKZona foreign key (Zona_Id) references venZona(venZona),
    TipoClie_Id int,
    constraint wooClientesFKTipoClie foreign key (TipoClie_Id) references venTiposClie(venTiposClie),
    Empresa_Id int,
    constraint wooClientesFKEmpresa foreign key (Empresa_Id) references genEmpresas(genEmpresas),
    constraint wooClientesPK primary key (Empresa_Id)
)
--drop table wooClientesCtas
create table wooClientesCtas
(
    Moneda_Id int,
    constraint wooClientesCtasFKMoneda foreign key (Moneda_Id) references genMonedas(genMonedas),
    CuentaDxVtas int,
    constraint wooClientesCtasFKCuentaDxVtas foreign key (CuentaDxVtas) references conCuentas(conCuentas),
    CtaFactAnticipo int,
    constraint wooClientesCtasFKCtaFactAnticipo foreign key (CtaFactAnticipo) references conCuentas(conCuentas),
    CtaAnticipo int,
    constraint wooClientesCtasFKCtaAnticipo foreign key (CtaAnticipo) references conCuentas(conCuentas),
    Empresa_Id int,
    constraint wooClientesCtasFKEmpresa foreign key (Empresa_Id) references genEmpresas(genEmpresas),
    constraint wooClientesCtasPK primary key (Empresa_Id, Moneda_Id)
)

--drop table wooOrders
create table wooOrders
(
    id int,
    parent_id int,
    number varchar(30),
    order_key varchar(30),
    created_via varchar(30),
    version varchar(30),
    status varchar(15),
    currency varchar(3),
    date_created datetime,
    date_created_gmt datetime,
    date_modified datetime,
    date_modified_gmt datetime,
    discount_total qCantidadD8,
    discount_tax qCantidadD8,
    shipping_total qCantidadD8,
    shipping_tax qCantidadD8,
    cart_tax qCantidadD8,
    total qCantidadD8,
    total_tax qCantidadD8,
    prices_include_tax bit,    
    customer_id int,
    customer_ip_address varchar(20),
    customer_user_agent varchar(200),
    customer_note varchar(200),
    payment_method varchar(30),
    payment_method_title varchar(30),
    transaction_id varchar(30),
    date_paid datetime,
    date_paid_gmt datetime,
    date_completed datetime,
    date_completed_gmt datetime,
    facturado bit
)
--drop table wooBillingProperties
create table wooOrdersBillingProperties
(
    order_id int,
    first_name varchar(120),
    last_name varchar(120),
    company varchar(200),
    address_1 varchar(200),
    address_2 varchar(200),
    city varchar(120),
    state varchar(50),
    postcode varchar(20),
    country varchar(120),
    email varchar(200),
    phone varchar(30)
)
--drop table wooShippingProperties
create table wooOrdersShippingProperties
(
    order_id int,
    first_name varchar(120),
    last_name varchar(120),
    company varchar(200),
    address_1 varchar(200),
    address_2 varchar(200),
    city varchar(120),
    state varchar(50),
    postcode varchar(20),
    country varchar(120)
)
--drop table wooOrdersLineItemProperties
create table wooOrdersLineItemProperties
(
    order_id int,
    item_id int,
    name varchar(80),
    product_id int,
    variation_id int null,
    quantity int,
    tax_class varchar(30),
    subtotal qCantidadD8,
    subtotal_tax qCantidadD8,
    total qCantidadD8,
    total_tax qCantidadD8,
    sku varchar(25),
    price qCantidadD8
)
--drop table wooOrdenesCuit
create table wooOrdenesCuit
(
    Order_Id int,
    Cuit varchar(25),
    --Facturado bit,
    Subido bit,
    constraint wooRFCOrdenesPK primary key(Order_Id)
)

insert into genVersion(Version) values(1065.02)