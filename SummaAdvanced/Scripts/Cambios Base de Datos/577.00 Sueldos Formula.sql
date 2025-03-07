INSERT INTO genVersion (Version) Values(577.00)
GO

INSERT INTO genLexico(SetFunciones, Funcion, Descripcion, Token, TipoDato) Values('SUELEXICO','FORMU','FORMULA DEL REPORTE',123,'N')
GO

ALTER TABLE sueinfdefformulas ALTER COLUMN Ancho Numeric(6,2) NOT NULL
GO
