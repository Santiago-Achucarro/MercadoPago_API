ALTER TABLE sueConceptos Alter Column Descripcion VarChar(60) NOT NULL
GO

INSERT INTO genVersion (Version) Values(548.00)
GO