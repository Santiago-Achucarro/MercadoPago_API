
ALTER TABLE genInstalacion ADD TamanioHoja VarChar(15)
GO

ALTER TABLE genReportes ADD TamanioHoja VarChar(15)
GO

ALTER TABLE genReportes ADD AnchoHoja Int
GO

ALTER TABLE genReportes ADD AltoHoja Int
GO

UPDATE genInstalacion SET TamanioHoja = CASE WHEN Dominio_Id = 'MX' THEN 'Carta' ELSE 'A4' END
GO

INSERT INTO genVersion (Version)	Values(72.00)
GO
