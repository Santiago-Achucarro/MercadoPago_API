
INSERT INTO genVersion(Version) Values(510.00)
GO


create table genTablasNombresSimplificados 
(
	NombreTabla varchar(250) NOT NULL,
	NombreSimplificado varchar(250) NOT NULL, 
	Primary KEY(NombreTabla)
)

GO


