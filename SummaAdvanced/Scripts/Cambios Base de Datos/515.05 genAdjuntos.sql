CREATE TABLE genAdjuntos
( 
	Tabla_Id             varchar(60)  NOT NULL ,
	Identity_Id          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Guid                 varchar(36)  NOT NULL ,
	NombreArchivo        varchar(200)  NOT NULL ,
	Extension            varchar(10)  NOT NULL ,
	CONSTRAINT XPKgenAdjuntos PRIMARY KEY  CLUSTERED (Tabla_Id ASC,Identity_Id ASC,Renglon ASC)
)
go

INSERT INTO genVersion(Version) Values(515.05);