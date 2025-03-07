CREATE TABLE genLogRequest(
	genLogRequest int IDENTITY(1,1) NOT NULL,
	NombreClase varchar(254) NOT NULL,
	Tipo varchar(100) NOT nULL,	
	Request varchar(Max) NOT Null,
	RequestEsp varchar(Max),
	Accion varchar(254),
	FechaRegistro qFechaHora NOT NULL,
	Usuario_Id int NOT NULL,
	CONSTRAINT XPKgenLogRequest PRIMARY KEY CLUSTERED (genLogRequest)
)
GO
INSERT INTO genVersion(Version) Values(1042.05);

GO



