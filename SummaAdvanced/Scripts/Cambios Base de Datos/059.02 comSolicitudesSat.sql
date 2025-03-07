insert into genVersion (Version) values (59.02)

go
CREATE TABLE comSolicitudesSat
(
	Solicitud int,
	primary key (Solicitud),
    FechaDesde datetime NOT NULL,
    FechaHasta datetime not NULL,
	Empresa_Id int,
	foreign key (Empresa_Id) references genEmpresas(genEmpresas),
	Emitidos bit,
	Descargados bit,
	Fecha Datetime,
	Usuario_Id int,
	foreign key (Usuario_Id) references genUsuarios(genUsuarios)
);
go