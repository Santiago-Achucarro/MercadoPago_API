Alter table genEmpresas Add TrabajaSabado bit
Alter table genEmpresas Add TrabajaDomingo bit
GO

UPDATE genEmpresas set TrabajaSabado= 0,  TrabajaDomingo = 0
GO

Alter table genEmpresas Alter Column TrabajaSabado bit NOT NULL
Alter table genEmpresas Alter Column TrabajaDomingo bit NOT NULL
GO

insert into genVersion(Version) Values(1051.00)
GO
