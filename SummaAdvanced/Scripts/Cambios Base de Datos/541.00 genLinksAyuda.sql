CREATE TABLE genLinksAyuda
( 
	CodigoLnk            varchar(25)  NOT NULL ,
	Dominio_Id           varchar(2)  NOT NULL ,
	Descripcion          varchar(150)  NOT NULL ,
	Link                 varchar(max)  NOT NULL ,
	CONSTRAINT XPKgenLinksAyuda PRIMARY KEY  CLUSTERED (CodigoLnk ASC,Dominio_Id ASC)
)
go

INSERT INTO genVersion (Version) Values(541.000)
