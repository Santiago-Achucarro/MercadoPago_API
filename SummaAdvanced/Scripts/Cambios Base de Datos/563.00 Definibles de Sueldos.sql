CREATE TABLE sueInfDefFormulas
( 
	sueInfDefinibles     integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	Alias                varchar(10)  NOT NULL ,
	Titulo               varchar(50)  NOT NULL ,
	Formula              varchar(max)  NOT NULL ,
	Formato              varchar(20)  NOT NULL ,
	Ancho                integer  NOT NULL ,
	Orden                integer  NOT NULL ,
	CONSTRAINT XPKsueInfDefFormulas PRIMARY KEY  CLUSTERED (sueInfDefinibles ASC,Columna ASC)
)
go



CREATE TABLE sueInfDefinibles
( 
	sueInfDefinibles     integer IDENTITY ( 1,1 ) ,
	Informe_Id           varchar(15)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	AgrupadoPor          varchar(3)  NOT NULL ,
	TamanioHoja          varchar(2)  NOT NULL ,
	Ancho                integer  NOT NULL ,
	Alto                 integer  NOT NULL ,
	Um                   varchar(2)  NOT NULL ,
	LegajoDesde          integer  NOT NULL ,
	LegajoHasta          integer  NOT NULL ,
	SucursalDesde        varchar(4)  NOT NULL ,
	SucursaHasta         varchar(4)  NOT NULL ,
	ConvenioDesde        varchar(5)  NOT NULL ,
	ConvenioHasta        varchar(5)  NOT NULL ,
	AnchoNombre          integer  NOT NULL ,
	Centro1Desde         varchar(8)  NOT NULL ,
	Centro1Hasta         varchar(8)  NOT NULL ,
	Centro2Desde         varchar(8)  NOT NULL ,
	Centro2Hasta         varchar(8)  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKsueInfDefinibles PRIMARY KEY  CLUSTERED (sueInfDefinibles ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueInfDefinibles ON sueInfDefinibles
( 
	Informe_Id            ASC
)
go




ALTER TABLE sueInfDefFormulas
	ADD CONSTRAINT V2R_4519 FOREIGN KEY (sueInfDefinibles) REFERENCES sueInfDefinibles(sueInfDefinibles)
go




ALTER TABLE sueInfDefinibles
	ADD CONSTRAINT V2R_4517 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueInfDefinibles
	ADD CONSTRAINT V2R_4518 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go


INSERT INTO genVersion (Version) Values(563.00)
GO

