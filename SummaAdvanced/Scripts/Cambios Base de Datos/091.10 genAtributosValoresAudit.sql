
CREATE TABLE genAtributosValoresAudit
( 
	Identity_Id          bigint  NOT NULL ,
	AtributoNro          integer  NOT NULL ,
	Tabla_Id             varchar(60)  NOT NULL ,
	FechaDesde           datetime  NOT NULL ,
	FechaHasta           datetime  NOT NULL ,
	ValorN               numeric(28,8)  NULL ,
	ValorC               varchar(255)  NULL ,
	ValorF               datetime  NULL ,
	CONSTRAINT XPKgenAtributosValoresAudit PRIMARY KEY  CLUSTERED (Identity_Id ASC,AtributoNro ASC,Tabla_Id ASC,FechaDesde ASC)
)
go

Insert Into genVersion (Version) Values (91.10)
Go
