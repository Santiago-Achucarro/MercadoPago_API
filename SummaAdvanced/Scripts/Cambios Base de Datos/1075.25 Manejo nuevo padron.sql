Alter table impPadron Add StoreProcedure varChar(200) Null
Go

CREATE TABLE impPadronTxt(
	Padron_Id int NOT NULL,
	Cuit varchar(25) NOT NULL,
	Anio int NOT NULL,
	Mes int NOT NULL,
	Trimestre int NOT NULL,
	Alicuota numeric(15, 4) NULL,
 CONSTRAINT XPKimpPadronTxt PRIMARY KEY CLUSTERED 
(Padron_Id ASC,Cuit ASC,Anio ASC,Mes ASC,Trimestre ASC)
)
GO

INSERT INTO genVersion(Version) Values(1075.25)
GO









