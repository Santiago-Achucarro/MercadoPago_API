Alter table genSucursalesEmpr add codColonia VarChar(4)
Alter table genSucursalesEmpr add codLocalidad VarChar(4)
Alter table genSucursalesEmpr add codMunicipio VarChar(3)

GO


INSERT INTO genVersion (Version) Values(1050.00)
GO