IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 47.02)
Begin



CREATE TABLE stkFamilias
( 
	stkFamilias          integer IDENTITY ( 1,1 ) ,
	Familia_Id           varchar(15)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKstkFamilias PRIMARY KEY  CLUSTERED (stkFamilias ASC)
)
;



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkFamilias ON stkFamilias
( 
	Familia_Id            ASC
)
;



CREATE TABLE stkGrupos
( 
	stkGrupos            integer IDENTITY ( 1,1 ) ,
	Grupo_Id             varchar(15)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKstkGrupos PRIMARY KEY  CLUSTERED (stkGrupos ASC)
)
;



CREATE UNIQUE NONCLUSTERED INDEX XAK1stkGrupos ON stkGrupos
( 
	Grupo_Id              ASC
)
;


ALTER TABLE stkFamilias
	ADD CONSTRAINT R_4008 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
;




ALTER TABLE stkFamilias
	ADD CONSTRAINT R_4010 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
;




ALTER TABLE stkGrupos
	ADD CONSTRAINT R_4009 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
;




ALTER TABLE stkGrupos
	ADD CONSTRAINT R_4011 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
;


Alter Table stkProductos Add Familia_Id           integer  NULL;
Alter Table stkProductos Add Grupo_Id             integer  NULL;

ALTER TABLE stkProductos
	ADD CONSTRAINT R_4012 FOREIGN KEY (Familia_Id) REFERENCES stkFamilias(stkFamilias)
;




ALTER TABLE stkProductos
	ADD CONSTRAINT R_4013 FOREIGN KEY (Grupo_Id) REFERENCES stkGrupos(stkGrupos)
;

INSERT INTO genVersion(Version) Values(47.02);

End

