CREATE TABLE sueFamiliares
( 
	Legajo               bigint  NOT NULL ,
	TipoDoc              char(1)  NOT NULL ,
	NroDoc               varchar(25)  NOT NULL ,
	Relacion             char(1)  NOT NULL ,
	ApellidoyNombre      varchar(50)  NOT NULL ,
	Sexo                 char(1)  NOT NULL ,
	FechaNacimiento      qFecha ,
	ACargoDesde          qFecha ,
	FechaBaja            qFecha  NULL ,
	FechaCarga           qFecha ,
	Ganancias            Sino ,
	Incapacitado         Sino ,
	AdhObSocial          Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueFamiliares PRIMARY KEY  CLUSTERED (Legajo ASC,TipoDoc ASC,NroDoc ASC)
)
go



ALTER TABLE sueFamiliares
	ADD CONSTRAINT V2R_4594 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE sueFamiliares
	ADD CONSTRAINT V2R_4595 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert into genVersion (Version) Values (1016.10)
Go
