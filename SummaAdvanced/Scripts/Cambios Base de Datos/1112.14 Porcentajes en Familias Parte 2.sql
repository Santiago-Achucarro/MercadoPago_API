ALTER TABLE stkFamilias ADD [Porcentaje3] [numeric](5, 2) NULL
GO

Update stkFamilias Set Porcentaje3 = 0
GO

ALTER TABLE stkFamilias Alter column [Porcentaje3] [numeric](5, 2) Not NULL
GO

ALTER TABLE stkFamilias ADD [Porcentaje4] [numeric](5, 2) NULL
GO

Update stkFamilias Set Porcentaje4 = 0
GO

ALTER TABLE stkFamilias Alter column [Porcentaje4] [numeric](5, 2) Not NULL
GO

INSERT INTO genVersion(Version) Values(1112.14);
GO