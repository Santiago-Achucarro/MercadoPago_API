alter table genEmpresas add FechaCierreSueldos datetime
go
update genEmpresas set FechaCierreSueldos= FechaInicioSumma
go
insert into genVersion (version) values (557.02) 
go