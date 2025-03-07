
CREATE TABLE sueArchivosTxt
( 
	sueArchivosTxt       integer IDENTITY ( 1,1 ) ,
	Archivo_Id           varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Resumen1             integer  NULL ,
	PosicionResumen1     char(1)  NOT NULL ,
	Resumen2             integer  NULL ,
	PosicionResumen2     char(1)  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKsueArchivosTxt PRIMARY KEY  CLUSTERED (sueArchivosTxt ASC)
)
go



CREATE TABLE sueArchivosTxtCuerpo
( 
	sueArchivosTxt       integer  NOT NULL ,
	Columna              integer  NOT NULL ,
	Formula              QMemo  NOT NULL ,
	Tipo                 char(1)  NOT NULL ,
	Longitud             smallint  NOT NULL ,
	Decimales            smallint  NOT NULL ,
	Relleno              char(1)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Orden                smallint  NOT NULL ,
	Formato              varchar(25)  NULL ,
	CONSTRAINT XPKsueArchivosTxtCuerpo PRIMARY KEY  CLUSTERED (sueArchivosTxt ASC,Columna ASC)
)
go




ALTER TABLE sueArchivosTxt
	ADD CONSTRAINT V2R_4407 FOREIGN KEY (Resumen1) REFERENCES sueArchivosTxt(sueArchivosTxt)
go




ALTER TABLE sueArchivosTxt
	ADD CONSTRAINT V2R_4408 FOREIGN KEY (Resumen2) REFERENCES sueArchivosTxt(sueArchivosTxt)
go




ALTER TABLE sueArchivosTxt
	ADD CONSTRAINT V2R_4409 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueArchivosTxt
	ADD CONSTRAINT V2R_4410 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueArchivosTxtCuerpo
	ADD CONSTRAINT V2R_4411 FOREIGN KEY (sueArchivosTxt) REFERENCES sueArchivosTxt(sueArchivosTxt)
go


insert into genVersion (Version) Values(531.000)
go