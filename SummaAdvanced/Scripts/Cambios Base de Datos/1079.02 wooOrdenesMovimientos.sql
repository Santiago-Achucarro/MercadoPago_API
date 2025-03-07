create table wooOrdenesVenMovimientos
(
    venMovimientos bigint,
    wooOrden int,
constraint wooOrdenesVenMovimientosFKVenMov foreign key (venMovimientos) references venMovimientos(venMovimientos),
--constraint wooOrdenesVenMovimientosFKwooOrden foreign key (wooOrden) references wooorders(id),
)
GO

alter table wooApiConfig add ProductoEnvios int,
constraint wooApiConfigFKProductoEnvios foreign key (ProductoEnvios) references stkProductos(stkProductos)
GO

insert into genVersion(Version) values(1079.02)