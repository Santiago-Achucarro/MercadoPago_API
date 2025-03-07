Alter table sueInfDefFormulas Add Tipo Char(1)
GO
Update sueInfDefFormulas SET Tipo = ' ' 
GO

Alter table sueInfDefFormulas Alter Column Tipo Char(1) NOT NULL
GO


INSERT INTO genVersion (Version) Values(567.00)
GO
