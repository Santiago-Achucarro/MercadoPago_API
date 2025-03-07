drop TABLE sueInfDefFormulas
drop TABLE sueInfDefinibles
GO
CREATE TABLE genTamanioHoja
( 
	TamanioHoja          varchar(2)  NOT NULL ,
	Descripcion			 VarChar(50) not null,
	AltoIn               QCantidad ,
	AnchoIn              QCantidad ,
	Altocm               QCantidad ,
	Anchicm              QCantidad ,
	AltoPx               integer  NOT NULL ,
	AnchoPx              integer  NOT NULL ,
	CONSTRAINT XPKgenTamanioHoja PRIMARY KEY  CLUSTERED (TamanioHoja ASC)
)
go



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
	TamanioHoja          varchar(2)  NULL ,
	Horizontal           Sino ,
	Um                   varchar(2)  NOT NULL ,
	LegajoDesde          integer  NOT NULL ,
	LegajoHasta          integer  NOT NULL ,
	SucursalDesde        varchar(4)  NOT NULL ,
	SucursalHasta         varchar(4)  NOT NULL ,
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




ALTER TABLE sueInfDefinibles
	ADD CONSTRAINT V2R_4520 FOREIGN KEY (TamanioHoja) REFERENCES genTamanioHoja(TamanioHoja)
go

INSERT Into genTamanioHoja(TamanioHoja, Descripcion, AltoIn, AnchoIn, Altocm, Anchicm, AltoPx, AnchoPx) 
VALUES('CA','Carta',21.59-1.27,27.94-1.27, 8, 10.5, 0,0)
INSERT Into genTamanioHoja(TamanioHoja, Descripcion,AltoIn, AnchoIn, Altocm, Anchicm, AltoPx, AnchoPx) 
VALUES('A4','A4',21-1.27,29.7-1.27, 8.27-0.5, 11.69-0.5, 0,0)

INSERT Into genTamanioHoja(TamanioHoja, Descripcion,AltoIn, AnchoIn, Altocm, Anchicm, AltoPx, AnchoPx) 
VALUES('LE','Legal',21.59-1.27,35.56-1.27, 8.5-0.5, 14-0.5, 0,0)

INSERT Into genTamanioHoja(TamanioHoja, Descripcion,AltoIn, AnchoIn, Altocm, Anchicm, AltoPx, AnchoPx) 
VALUES('A3','A4',29.7-1.27,42-1.27, 11.69-0.5, 16.54-0.5, 0,0)
GO

INSERT INTO genVersion (Version) Values(564.00)
GO
