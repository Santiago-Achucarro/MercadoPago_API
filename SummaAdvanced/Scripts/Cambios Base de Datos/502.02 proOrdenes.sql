insert into genVersion (Version) values('502.02')

alter table proOrden
add
Cantidad qCantidadD8,
CantidadIngresada qCantidadD8,
FechaEmision datetime,
CantidadProgramada qCantidadD8,
FechaNecesidad datetime,
FechaProduccion datetime null,
FechaFin datetime null,
CantidadTerminada qCantidadD8,
CierreAutomatico bit,
Medida_Id int,
Factor qMonedaD8,
foreign key (Medida_Id) references stkUniMed(stkUniMed)


