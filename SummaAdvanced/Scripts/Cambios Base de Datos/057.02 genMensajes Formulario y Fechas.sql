insert into genVersion (Version) values (57.02)
alter table genMensajes
add FechaDesde datetime null,
FechaHasta datetime null,
Parametros varchar(max) null,
Formulario_Id int null,
foreign key (Formulario_Id) references disFormularios(disFormularios)
