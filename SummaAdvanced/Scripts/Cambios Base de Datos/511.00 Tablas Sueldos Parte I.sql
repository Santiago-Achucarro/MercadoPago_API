-- drop table sueCategorias

CREATE TABLE sueCategorias
( 
	sueCategorias        integer IDENTITY ( 1,1 ) ,
	Categoria_Id         varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Periodo_Id           char(1)  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	Empresa_Id int,
	foreign key (Empresa_Id) references genEmpresas(genEmpresas),
	CONSTRAINT XPKsueCategorias PRIMARY KEY  CLUSTERED (sueCategorias ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueCategorias ON sueCategorias
( 
	Categoria_Id          ASC
)
go



CREATE TABLE sueConvenio
( 
	sueConvenio          integer IDENTITY ( 1,1 ) ,
	Convenio_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	Empresa_Id int,
	foreign key (Empresa_Id) references genEmpresas(genEmpresas),
	CONSTRAINT XPKsueTipoRelacion PRIMARY KEY  CLUSTERED (sueConvenio ASC)
)
go



CREATE TABLE sueGrupos
( 
	sueGrupos            integer IDENTITY ( 1,1 ) ,
	Grupo_Id             integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Segmento_Id          integer  NULL ,
	Periodo_Id           char(1)  NULL ,
	CtaSueldoAPagar      integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsueGrupos PRIMARY KEY  CLUSTERED (sueGrupos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueGrupos ON sueGrupos
( 
	Grupo_Id              ASC
)
go



CREATE TABLE suePeriodicidad
( 
	Periodo_Id           char(1)  NOT NULL ,
	Descripcion          varchar(30)  NOT NULL ,
	Dias                 qMonedaD4 ,
	FechaActiva          qFecha ,
	CONSTRAINT XPKsuePeriodicidad PRIMARY KEY  CLUSTERED (Periodo_Id ASC),
	Empresa_Id int,
	foreign key(Empresa_Id) references genEmpresas(genEmpresas)
)
go



CREATE TABLE suePuestos
( 
	suePuestos           integer IDENTITY ( 1,1 ) ,
	Puesto_Id            varchar(5)  NOT NULL ,
	Descripcion          varchar(20)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePuesto PRIMARY KEY  CLUSTERED (suePuestos ASC),
	Empresa_Id int,
	foreign key (Empresa_Id) references genEmpresas(genEmpresas)
)
go



CREATE TABLE sueTareas
( 
	sueTareas            integer IDENTITY ( 1,1 ) ,
	Tarea_Id             varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueTareas PRIMARY KEY  CLUSTERED (sueTareas ASC),
	Empresa_Id int,
	foreign key (Empresa_Id) references genEmpresas(genEmpresas)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueTareas ON sueTareas
( 
	Tarea_Id              ASC
)
go



CREATE TABLE sueTipoPago
( 
	sueTipoPago          integer IDENTITY ( 1,1 ) ,
	TipoPago_Id          varchar(5)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsueTipoPago PRIMARY KEY  CLUSTERED (sueTipoPago ASC)
)
go


--- FK




ALTER TABLE sueCategorias
	ADD CONSTRAINT V2R_4161 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueCategorias
	ADD CONSTRAINT V2R_4212 FOREIGN KEY (Periodo_Id) REFERENCES suePeriodicidad(Periodo_Id)
go




ALTER TABLE sueConvenio
	ADD CONSTRAINT V2R_4176 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueGrupos
	ADD CONSTRAINT V2R_4209 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go




ALTER TABLE sueGrupos
	ADD CONSTRAINT V2R_4210 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueGrupos
	ADD CONSTRAINT V2R_4211 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueGrupos
	ADD CONSTRAINT V2R_4213 FOREIGN KEY (Periodo_Id) REFERENCES suePeriodicidad(Periodo_Id)
go




ALTER TABLE sueGrupos
	ADD CONSTRAINT V2R_4216 FOREIGN KEY (CtaSueldoAPagar) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE suePuestos
	ADD CONSTRAINT V2R_4177 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueTareas
	ADD CONSTRAINT V2R_4175 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueTipoPago
	ADD CONSTRAINT V2R_4148 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueTipoPago
	ADD CONSTRAINT V2R_4149 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go



INSERT INTO genVersion (Version) Values(511.00)
GO
