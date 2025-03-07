insert into genVersion(Version) values (503.02)

 drop table proOrdenSubRecurso
 drop table proOrdenRecursos
 drop table proSubRecursos
 drop table proRecetasRecursos
 drop table proMovCierreRecursos
 drop table proRecursos
 
 CREATE TABLE proMovCierreRecursos
( 
	proMovCierreOrden    bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	Costo                qMonedaD4 ,
	CONSTRAINT XPKproMovCierreRecursos PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,Renglon ASC)
)
go

CREATE TABLE proOrdenRecursos
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKporOrdenRecursos PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC)
)
go
 

 CREATE TABLE proRecetasRecursos
( 
	proRecetas           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKproRecetasRecursos PRIMARY KEY  CLUSTERED (proRecetas ASC,Renglon ASC)
)
go

CREATE TABLE proOrdenSubRecurso
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	SubRecurso_Id        integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKproOrdenSubRecurso PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC,SubRecurso_Id ASC)
)
go

CREATE TABLE proRecursos
( 
	proRecursos          integer identity NOT NULL ,
	Recurso_Id           varchar(25)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Unidad_Id            integer  NULL ,
	Capacidad            qCantidadD8 ,
	Costo                qMonedaD4 ,
	UsaSubRecurso        Sino ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKproRecursos PRIMARY KEY  CLUSTERED (proRecursos ASC)
)
go

CREATE TABLE proSubRecursos
( 
	proSubRecursos       integer IDENTITY ( 1,1 ) ,
	SubRecurso_Id        varchar(25)  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Capacidad            qCantidadD8 ,
	Costo                qMonedaD4 ,
	Predeterminado       Sino ,
	Inactivo             Sino ,
	CONSTRAINT XPKproRecursosRecurso PRIMARY KEY  CLUSTERED (proSubRecursos ASC)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1proRecursos ON proRecursos
( 
	Recurso_Id            ASC
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1proRecursosRecurso ON proSubRecursos
( 
	SubRecurso_Id         ASC
)
go

ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT RV2_4138 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT RV2_4139 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go


ALTER TABLE proOrdenRecursos
	ADD CONSTRAINT RV2_4119 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go


ALTER TABLE proOrdenSubRecurso
	ADD CONSTRAINT RV2_4123 FOREIGN KEY (proOrden,Renglon) REFERENCES proOrdenRecursos(proOrden,Renglon)
go




ALTER TABLE proOrdenSubRecurso
	ADD CONSTRAINT RV2_4124 FOREIGN KEY (SubRecurso_Id) REFERENCES proSubRecursos(proSubRecursos)
go


ALTER TABLE proOrdenRecursos
	ADD CONSTRAINT RV2_4120 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go





ALTER TABLE proRecetasRecursos
	ADD CONSTRAINT RV2_4121 FOREIGN KEY (proRecetas) REFERENCES proRecetas(proRecetas)
go




ALTER TABLE proRecetasRecursos
	ADD CONSTRAINT RV2_4122 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go



ALTER TABLE proRecursos
	ADD CONSTRAINT RV2_4080 FOREIGN KEY (Unidad_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE proSubRecursos
	ADD CONSTRAINT RV2_4081 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go

