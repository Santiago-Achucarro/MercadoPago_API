DROP VIEW vgenLetraCompras
GO

CREATE VIEW vgenLetraCompras
AS
SELECT ' ' as Valor, 'S/L' as Descripcion
UNION
SELECT 'A' as Valor, 'A' as Descripcion
UNION
SELECT 'B' as Valor, 'B' as Descripcion
UNION
SELECT 'C' as Valor, 'C' as Descripcion
UNION
SELECT 'M' as Valor, 'M' as Descripcion
--UNION
--SELECT 'F' as Valor, 'F' as Descripcion
--UNION
--SELECT 'X' as Valor, 'X' as Descripcion

GO