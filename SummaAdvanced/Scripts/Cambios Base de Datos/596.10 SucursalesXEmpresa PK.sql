Alter TABLE genUsuariosSucursal Alter column Usuario_Id int Not Null
GO
Alter TABLE genUsuariosSucursal Alter column Sucursal_Id int Not Null
Go
Alter TABLE genUsuariosSucursal Alter column Empresa_Id int Not Null
Go
Alter table genUsuariosSucursal Add CONSTRAINT XPKgenUsuariosSucursal PRIMARY KEY  CLUSTERED (Usuario_Id ASC, Empresa_Id ASC)
Go
insert into genVersion(version)values(596.10)
Go

