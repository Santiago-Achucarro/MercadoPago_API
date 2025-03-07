CREATE TABLE sueTablaVacacion
( 
	sueTablaVacacion     integer IDENTITY ( 1,1 ) ,
	TablaVac_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Dias                 integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKsueTablaVacacion PRIMARY KEY  CLUSTERED (sueTablaVacacion ASC)
)
go


CREATE UNIQUE NONCLUSTERED INDEX XAK1sueTablaVacacion ON sueTablaVacacion
( 
	TablaVac_Id           ASC
)
go


CREATE TABLE sueTablaVacReng
( 
	TablaVac_Id          integer  NOT NULL ,
	Antiguedad           integer  NOT NULL ,
	Dias                 integer  NOT NULL ,
	CONSTRAINT XPKsueTablaVacReng PRIMARY KEY  CLUSTERED (TablaVac_Id ASC,Antiguedad ASC)
)
go



CREATE TABLE sueVacCorresponden
( 
	Legajo               bigint  NOT NULL ,
	Anio                 integer  NOT NULL ,
	Dias                 integer  NOT NULL ,
	CONSTRAINT XPKsueVacCorresponden PRIMARY KEY  CLUSTERED (Legajo ASC,Anio ASC)
)
go



CREATE TABLE sueVacTomadas
( 
	Legajo               bigint  NOT NULL ,
	Anio                 integer  NOT NULL ,
	FechaDesde           qFecha ,
	Dias                 integer  NOT NULL ,
	FechaHasta           qFecha ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsueVacTomadas PRIMARY KEY  CLUSTERED (Legajo ASC,Anio ASC,FechaDesde ASC)
)
go


Alter table sueCategorias Add TablaVac_Id int
GO

Alter table sueCategorias Add Sindicalizado SiNo null
GO

Update sueCategorias set Sindicalizado = 0
GO

Alter table sueCategorias Alter Column Sindicalizado SiNo NOT NULL
GO




ALTER TABLE sueTablaVacacion
	ADD CONSTRAINT V2R_4426 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueTablaVacacion
	ADD CONSTRAINT V2R_4427 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueTablaVacReng
	ADD CONSTRAINT V2R_4428 FOREIGN KEY (TablaVac_Id) REFERENCES sueTablaVacacion(sueTablaVacacion)
go




ALTER TABLE sueVacCorresponden
	ADD CONSTRAINT V2R_4429 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE sueVacTomadas
	ADD CONSTRAINT V2R_4430 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE sueVacTomadas
	ADD CONSTRAINT V2R_4431 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go



ALTER TABLE sueCategorias
	ADD CONSTRAINT V2R_4432 FOREIGN KEY (TablaVac_Id) REFERENCES sueTablaVacacion(sueTablaVacacion)
go


INSERT INTO genVersion (Version) Values(538.00)
GO

