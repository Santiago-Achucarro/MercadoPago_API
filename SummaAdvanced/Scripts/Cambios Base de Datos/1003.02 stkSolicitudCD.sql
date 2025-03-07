create table stkSolicitudCD
(
    stkSolicitudCD bigint identity,
    DepositoDestino int Not Null,
    Fecha DATETIME Not Null,
    constraint stkSolicitudCDPK primary key (stkSolicitudCD),
    constraint stkSolicitudCDDeposito foreign key (DepositoDestino) references stkDepositos(stkDepositos),
    Estado char(1) Not Null
)

create table stkSolicitudCDCuerpo
(
    stkSolicitudCD bigint not Null,
    Producto_Id int,
    DepositoOrigen int,
    Observaciones varchar(max),
    Cantidad qCantidadD8,
    CantidadPendiente qCantidadD8,
    Medida_Id int,
    constraint stkSolicitudCDCuerpoPK primary key (stkSolicitudCD),
    constraint stkSolicitudCDCuerpoProductoFK foreign key (Producto_Id) references stkProductos(stkProductos),
    constraint stkSolicitudCDCuerpoDepositoFK foreign key (DepositoOrigen) references stkDepositos(stkDepositos),
    constraint stkSolicitudCDCuerpoMedidaFK foreign key (Medida_Id) references stkUniMed(stkUniMed)
)

create table stkSolicitudCDSegmento
(
    stkSolicitudCD bigint Not Null,
    Segmento_Id int,
    Segmento1N int,
    Segmento2N int,
    Segmento3N int,
    Segmento4N int,
    Segmento1C varchar(20),
    Segmento2C varchar(20),
    Segmento3C varchar(20),
    Segmento4C varchar(20),
    Empresa_Id int Not Null,
    constraint stkSolicitudCDSegmentoPK primary key (Segmento_Id, Segmento1N, Segmento2N, Segmento3N, Segmento4N, Segmento1C, Segmento2C, Segmento3C, Segmento4C, Empresa_Id),
    constraint stkSolicitudCDSegmentoFK foreign key (stkSolicitudCD) references stkSolicitudCD(stkSolicitudCD),
    constraint stkSolicitudCDSegmentoEmpresaFK foreign key (Empresa_Id) references genEmpresas(genEmpresas)
)

create table stkSolicitudCDSalida
(
    stkSolicitudCD bigint,
    constraint stkSolicitudCDSalidaFK foreign key (stkSolicitudCD) references stkSolicitudCD(stkSolicitudCD),
    stkMoviCabe bigint,
    constraint stkSolicitudSalidaMCFK foreign key (stkMoviCabe) references stkMoviCabe(stkMoviCabe),
    constraint stkSolicitudSalidaPK primary key (stkSolicitudCD, stkMoviCabe)
)
insert into genVersion (Version) values (1003.02)