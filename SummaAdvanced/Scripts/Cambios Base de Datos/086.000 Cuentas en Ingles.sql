ALTER TABLE conCuentas Add Description VarChar(80)
GO

Update conCuentas Set Description = Descripcion
GO

ALTER TABLE conCuentas ALTER Column Description VarChar(80) NOT NULL
GO

Alter table conSubCuentas Add Description VarChar(50) 
GO
UPDATE conSubCuentas SET Description = Descripcion
GO

Alter table conSubCuentas Alter Column Description VarChar(50) NOT NULL
GO

Alter table conAnexosGrupos Add Description VarChar(60)
GO
Update conAnexosGrupos Set Description = Descripcion
GO

Alter table conAnexosGrupos Alter Column Description VarChar(60) NOT NULL
GO

insert into genVersion (Version) Values(86.000)
GO