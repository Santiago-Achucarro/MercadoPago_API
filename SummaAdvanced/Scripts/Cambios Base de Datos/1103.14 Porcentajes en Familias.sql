ALTER TABLE stkFamilias ADD [Porcentaje1] [numeric](5, 2) NULL
GO

ALTER TABLE stkFamilias ADD [Porcentaje2] [numeric](5, 2) NULL
GO

INSERT INTO genVersion(Version) Values(1103.14);
GO

