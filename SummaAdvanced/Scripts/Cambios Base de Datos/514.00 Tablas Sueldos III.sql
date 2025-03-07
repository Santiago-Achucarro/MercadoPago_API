


CREATE TABLE sueConceptos
( 
	sueConceptos         integer IDENTITY ( 1,1 ) ,
	Concepto_Id          integer  NOT NULL ,
	Descripcion          varchar(20)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Formula              varchar(max)  NOT NULL ,
	LlevaDato            Sino ,
	CuentaDebe           integer  NULL ,
	CuentaHaber          integer  NULL ,
	SubCuentaDebe        integer  NULL ,
	SubCuentaHaber       integer  NULL ,
	Retroactivo          Sino  NOT NULL ,
	--segunda solapa
	Extraordinario       Sino  NOT NULL ,
	TipoPercepcion       varchar(3)  NULL ,
	TipoDeduccion        varchar(3)  NULL ,
	TipoOtro             varchar(3)  NULL ,
	TipoHora             char(1)  NULL ,
	TipoIncapacidad      smallint  NULL ,
	EsExento             Sino ,
	--
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueConceptos PRIMARY KEY  CLUSTERED (sueConceptos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1sueConceptos ON sueConceptos
( 
	Concepto_Id           ASC
)
go

CREATE TABLE sueConceptosProp
( 
	sueConceptosProp     integer IDENTITY ( 1,1 ) ,
	Propiedad            varchar(10)  NOT NULL ,
	Orden                integer  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	Agrupamiento         varchar(20)  NOT NULL ,
	CONSTRAINT XPKsueConceptosProp PRIMARY KEY  CLUSTERED (sueConceptosProp ASC)
)
go



CREATE TABLE sueConceptosPropValor
( 
	Concepto_Id          integer  NOT NULL ,
	Propiedad            integer  NOT NULL ,
	SiNo                 Sino ,
	CONSTRAINT XPKsueConceptosPropValor PRIMARY KEY  CLUSTERED (Concepto_Id ASC,Propiedad ASC)
)
go





ALTER TABLE sueConceptos
	ADD CONSTRAINT V2R_4201 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueConceptos
	ADD CONSTRAINT V2R_4202 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueConceptos
	ADD CONSTRAINT V2R_4205 FOREIGN KEY (CuentaDebe) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE sueConceptos
	ADD CONSTRAINT V2R_4206 FOREIGN KEY (CuentaHaber) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE sueConceptos
	ADD CONSTRAINT V2R_4207 FOREIGN KEY (SubCuentaDebe) REFERENCES conSubCuentas(conSubCuentas)
go




ALTER TABLE sueConceptos
	ADD CONSTRAINT V2R_4208 FOREIGN KEY (SubCuentaHaber) REFERENCES conSubCuentas(conSubCuentas)
go







ALTER TABLE sueConceptosPropValor
	ADD CONSTRAINT V2R_4203 FOREIGN KEY (Concepto_Id) REFERENCES sueConceptos(sueConceptos)
go




ALTER TABLE sueConceptosPropValor
	ADD CONSTRAINT V2R_4204 FOREIGN KEY (Propiedad) REFERENCES sueConceptosProp(sueConceptosProp)
go


INSERT INTO genVersion(Version) Values(514.00)

GO
