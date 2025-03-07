
create table afiResponsables
(
    afiResponsables int identity,
    Responsable_Id varchar(15),
    Descripcion varchar(200),
    Empresa_Id int,
    Posteado SiNo,
    Inactivo SiNo,
    constraint afiResponsablesPK primary key (afiResponsables)
)

create table afiResponsableActivo
(
    Responsable_Id int,
    ActivoFijo_Id int,
    FechaAsignacion datetime,
    constraint afiResponsablesActivoResponsableFK foreign key (Responsable_Id) references afiResponsables(afiResponsables),
    constraint afiResponsablesActivoAFFK foreign key (Activofijo_Id) references afiActivoFijo(afiActivoFijo),
    constraint afiResponsablesActivoPK primary key (Responsable_Id, ActivoFijo_Id, FechaAsignacion),
    Cantidad qCantidad
)


insert into genVersion(Version) values (1011.02)