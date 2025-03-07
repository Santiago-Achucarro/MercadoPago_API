
CREATE TABLE conInfDefCuentas
( 
	Informe_Id           integer  NOT NULL ,
	Fila                 integer  NOT NULL ,
	CuentaDesde          varchar(25)  NOT NULL ,
	CuentaHasta          varchar(25)  NOT NULL ,
	CONSTRAINT XPKconInfDefCuentas PRIMARY KEY  CLUSTERED (Informe_Id ASC,Fila ASC,CuentaDesde ASC)
)
go


CREATE TABLE conInfDefFilas
( 
	Informe_Id           integer  NOT NULL ,
	Fila                 integer  NOT NULL ,
	Nivel                integer  NOT NULL ,
	Titulo               varchar(100)  NOT NULL ,
	Tipo                 char(2)  NOT NULL ,
	Fuente               char(1)  NOT NULL ,
	InvierteSigno        Sino ,
	Centro1Desde         varchar(8)  NOT NULL ,
	Centro1Hasta         varchar(8)  NOT NULL ,
	Centro2Desde         varchar(8)  NOT NULL ,
	Centro2Hasta         varchar(8)  NOT NULL ,
	CONSTRAINT XPKconInfDefFilas PRIMARY KEY  CLUSTERED (Informe_Id ASC,Fila ASC)
)
go




CREATE TABLE conInfDefinibles
( 
	conInfDefinibles     integer IDENTITY ( 1,1 ) ,
	Informe_Id           varchar(15)  NOT NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Empresa_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKconInfDefinibles PRIMARY KEY  CLUSTERED (conInfDefinibles ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1conInfDefinibles ON conInfDefinibles
( 
	Informe_Id            ASC
)
go




ALTER TABLE conInfDefCuentas
	ADD CONSTRAINT V2R_4516 FOREIGN KEY (Informe_Id,Fila) REFERENCES conInfDefFilas(Informe_Id,Fila)
go




ALTER TABLE conInfDefFilas
	ADD CONSTRAINT V2R_4515 FOREIGN KEY (Informe_Id) REFERENCES conInfDefinibles(conInfDefinibles)
go




ALTER TABLE conInfDefinibles
	ADD CONSTRAINT V2R_4513 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE conInfDefinibles
	ADD CONSTRAINT V2R_4514 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go


INSERT INTO genVersion (Version) Values(562.00)
GO
