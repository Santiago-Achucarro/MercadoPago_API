Drop Table genLogRequest
Go

CREATE TABLE genLogRequest(
	genLogRequest int IDENTITY(1,1) NOT NULL,
	Empresa_Id int Not Null,
	NombreClase varchar(254) NOT NULL,
	Tipo varchar(100) NOT nULL,	
	Request varchar(Max) NOT Null,
	RequestEsp varchar(Max),
	Accion varchar(254),
	FechaRegistro qFechaHora NOT NULL,
	Formulario_Id varchar(100) Not null,
	Usuario_Id int NOT NULL,
	Segmento_Id Int Null,
	Segmento1C varChar(20) Null,
	Segmento2C varChar(20) Null,
	Segmento3C varChar(20) Null,
	Segmento4C varChar(20) Null,
	Segmento1N int Null,
	Segmento2N int Null,
	Segmento3N int Null,
	Segmento4N int Null,
	CONSTRAINT XPKgenLogRequest PRIMARY KEY CLUSTERED (genLogRequest)
)
GO

ALTER TABLE genLogRequest Add Constraint 
	fkgenLogRequest Foreign Key (Empresa_Id) 
	REFERENCES genEmpresas
GO

INSERT INTO genVersion(Version) Values(1042.10);

GO