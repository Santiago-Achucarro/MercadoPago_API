alter table proOrden add Anulado bit
go
update proOrden set Anulado = 0
GO

alter table proOrden Alter Column Anulado bit NOT NULL
GO

insert into genVersion (Version) values(501.02)