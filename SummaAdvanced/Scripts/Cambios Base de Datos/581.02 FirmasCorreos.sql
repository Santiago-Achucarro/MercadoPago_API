alter table genUsuarios ADD
Firma varchar(max),
ImagenFirmaB64 varchar(max)
go
alter table genEmpresas ADD
Firma varchar(max),
ImagenFirmaB64 varchar(max)
go
insert into genVersion (Version) values (581.02)