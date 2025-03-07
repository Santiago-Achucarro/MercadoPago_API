CREATE TABLE stkRemiConforma(
stkMoviCabe BigInt Not NULL,
Usuario_Id  Int Not NULL,
FechaConforma DateTime Not Null,
FechaRegistro DateTime Not Null,
Observaciones QMemo NULL,
Primary Key(stkMoviCabe)
)
GO

ALTER TABLE stkRemiConforma ADD Constraint fkstkRemiConformaCabe 
	Foreign Key (stkMoviCabe) References stkMovicabe
GO

ALTER TABLE stkRemiConforma ADD Constraint fkstkRemiConformaUsu
	Foreign Key (Usuario_Id) References genUsuarios
GO

INSERT INTO genVersion (Version) Values(600.00)
GO

