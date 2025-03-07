CREATE TABLE comListaNegraMX
( 
	RFC                  varchar(13)  NOT NULL ,
	RazonSocial          varchar(500)  NOT NULL ,
	Situacion            varchar(50)  NOT NULL ,
	CONSTRAINT XPKcomListaNegraMX PRIMARY KEY  CLUSTERED (RFC ASC)
)
go


INSERT INTO genVersion (Version) Values(570.00)
GO