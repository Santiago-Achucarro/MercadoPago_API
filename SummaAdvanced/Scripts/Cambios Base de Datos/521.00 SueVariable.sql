
CREATE TABLE sueVariable
( 
	Legajo               bigint  NOT NULL ,
	Grupo_Id             integer  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKsueVariable PRIMARY KEY  CLUSTERED (Legajo ASC,Grupo_Id ASC,Concepto_Id ASC)
)
go




ALTER TABLE sueVariable
	ADD CONSTRAINT V2R_4277 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE sueVariable
	ADD CONSTRAINT V2R_4278 FOREIGN KEY (Grupo_Id) REFERENCES sueGrupos(sueGrupos)
go




ALTER TABLE sueVariable
	ADD CONSTRAINT V2R_4279 FOREIGN KEY (Concepto_Id) REFERENCES sueConceptos(sueConceptos)
go




ALTER TABLE sueVariable
	ADD CONSTRAINT V2R_4280 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go

ALTER TABLE sueConceptos Add Reservado Bit Default 0 NOT NULL
GO


CREATE TABLE sueCateNombre
( 
	CateNombre_Id        integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	PorEmpresa           Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueCateNombre PRIMARY KEY  CLUSTERED (CateNombre_Id ASC)
)
go



CREATE TABLE sueImpNombre
( 
	Importe_Id           integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueImpNombre PRIMARY KEY  CLUSTERED (Importe_Id ASC)
)
go



CREATE TABLE sueLiqEmpCatego
( 
	Categoria_Id         integer  NOT NULL ,
	CateNombre_Id        integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqEmpCatego PRIMARY KEY  CLUSTERED (Categoria_Id ASC,CateNombre_Id ASC,Empresa_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueLiqImpCatego
( 
	Categoria_Id        integer  NOT NULL ,
	CateNombre_Id        integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqImpCatego PRIMARY KEY  CLUSTERED (Categoria_Id ASC,CateNombre_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueLiqPersImportes
( 
	Legajo               bigint  NOT NULL ,
	Importe_Id           integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqPersImportes PRIMARY KEY  CLUSTERED (Legajo ASC,Importe_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueLiqVarEmpGlobales
( 
	VarGlobal_Id         integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqVarEmpGlobales PRIMARY KEY  CLUSTERED (VarGlobal_Id ASC,Empresa_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueLiqVarGlobales
( 
	VarGlobal_Id         integer  NOT NULL ,
	Fecha_Hasta          qFecha ,
	Fecha_Desde          qFecha ,
	Valor                qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueLiqVarGlobales PRIMARY KEY  CLUSTERED (VarGlobal_Id ASC,Fecha_Hasta ASC)
)
go



CREATE TABLE sueVarGlobales
( 
	VarGlobal_Id         integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	PorEmpresa           Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsueVarGlobNombres PRIMARY KEY  CLUSTERED (VarGlobal_Id ASC)
)
go




ALTER TABLE sueCateNombre
	ADD CONSTRAINT V2R_4290 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueImpNombre
	ADD CONSTRAINT V2R_4288 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueLiqEmpCatego
	ADD CONSTRAINT V2R_4299 FOREIGN KEY (CateNombre_Id) REFERENCES sueCateNombre(CateNombre_Id)
go




ALTER TABLE sueLiqEmpCatego
	ADD CONSTRAINT V2R_4300 FOREIGN KEY (Categoria_Id) REFERENCES sueCategorias(sueCategorias)
go




ALTER TABLE sueLiqEmpCatego
	ADD CONSTRAINT V2R_4301 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueLiqEmpCatego
	ADD CONSTRAINT V2R_4302 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueLiqImpCatego
	ADD CONSTRAINT V2R_4291 FOREIGN KEY (CateNombre_Id) REFERENCES sueCateNombre(CateNombre_Id)
go




ALTER TABLE sueLiqImpCatego
	ADD CONSTRAINT V2R_4292 FOREIGN KEY (Categoria_Id) REFERENCES sueCategorias(sueCategorias)
go




ALTER TABLE sueLiqImpCatego
	ADD CONSTRAINT V2R_4293 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueLiqPersImportes
	ADD CONSTRAINT V2R_4285 FOREIGN KEY (Importe_Id) REFERENCES sueImpNombre(Importe_Id)
go




ALTER TABLE sueLiqPersImportes
	ADD CONSTRAINT V2R_4286 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueLiqPersImportes
	ADD CONSTRAINT V2R_4287 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE sueLiqVarEmpGlobales
	ADD CONSTRAINT V2R_4296 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueLiqVarEmpGlobales
	ADD CONSTRAINT V2R_4297 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueLiqVarEmpGlobales
	ADD CONSTRAINT V2R_4298 FOREIGN KEY (VarGlobal_Id) REFERENCES sueVarGlobales(VarGlobal_Id)
go




ALTER TABLE sueLiqVarGlobales
	ADD CONSTRAINT V2R_4283 FOREIGN KEY (VarGlobal_Id) REFERENCES sueVarGlobales(VarGlobal_Id)
go




ALTER TABLE sueLiqVarGlobales
	ADD CONSTRAINT V2R_4284 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueVarGlobales
	ADD CONSTRAINT V2R_4289 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go





INSERT INTO genVersion(Version) Values(521.000)
GO