
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 18.02)
begin

INSERT INTO genVersion(Version) Values(18.02);

CREATE TABLE conOrigAplicCtas
( 
 GrupoOAF_Id          varchar(5)  NOT NULL ,
 Cuenta_Id            integer  NOT NULL ,
 NetoDebeHaber        char(1)  NOT NULL ,
 CONSTRAINT XPKconOrigAplicCtas PRIMARY KEY  CLUSTERED (GrupoOAF_Id ASC,Cuenta_Id ASC)
);


CREATE TABLE conOrigAplicReng
( 
 GrupoOAF_Id          varchar(5)  NOT NULL ,
 Empresa_Id           integer  NULL ,
 Destino              integer  NOT NULL ,
 Origen               integer  NOT NULL ,
 Descripcion          varchar(100)  NOT NULL ,
 CONSTRAINT XPKconOrigAplicReng PRIMARY KEY  CLUSTERED (GrupoOAF_Id ASC)
);



CREATE TABLE conRubrosPrevi
( 
 RubroPrevi_Id        varchar(5)  NOT NULL ,
 Empresa_Id           integer  NULL ,
 Descripcion          varchar(100)  NOT NULL ,
 ActivoPasivo         char(1)  NOT NULL ,
 Corriente            Sino ,
 Orden                integer  NOT NULL ,
 CONSTRAINT XPKconRubrosPrevi PRIMARY KEY  CLUSTERED (RubroPrevi_Id ASC)
);



CREATE TABLE conRubrosPreviCtas
( 
 RubroPrevi_Id        varchar(5)  NOT NULL ,
 Cuenta_Id            integer  NOT NULL ,
 CONSTRAINT XPKconRubrosPreviCtas PRIMARY KEY  CLUSTERED (RubroPrevi_Id ASC,Cuenta_Id ASC)
);

ALTER TABLE conOrigAplicCtas
 ADD CONSTRAINT R_3965 FOREIGN KEY (GrupoOAF_Id) REFERENCES conOrigAplicReng(GrupoOAF_Id);

ALTER TABLE conOrigAplicCtas
 ADD CONSTRAINT R_3966 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas);




ALTER TABLE conOrigAplicReng
 ADD CONSTRAINT R_3964 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas);




ALTER TABLE conRubrosPrevi
 ADD CONSTRAINT R_3967 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas);



ALTER TABLE conRubrosPreviCtas
 ADD CONSTRAINT R_3968 FOREIGN KEY (RubroPrevi_Id) REFERENCES conRubrosPrevi(RubroPrevi_Id);



ALTER TABLE conRubrosPreviCtas
 ADD CONSTRAINT R_3969 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas);
end
go