INSERT INTO genVersion (Version) Values(68)
GO
Alter table comOcCuerpo Alter Column Precio Numeric(19,8) NOT NULL
Alter table comOcArticulo Alter Column PrecioOriginal Numeric(19,8) NOT NULL
GO


