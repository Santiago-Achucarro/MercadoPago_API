DECLARE @SQL VARCHAR(MAX)
SET @SQL = (
SELECT 'Alter table sueConceptos drop constraint  '+sysobjectsC.name FROM sysconstraints 
	inner join sysobjects ON 
	sysconstraints.id = sysobjects.id
	INNER JOIN syscolumns ON 
	syscolumns.id = sysobjects.id  and
	syscolumns.Colid = sysconstraints.colid
	inner join sysobjects sysobjectsC on 
	sysobjectsC.id =  sysconstraints.constid
where 
	sysobjects.name = 'sueconceptos' and 
	syscolumns.Name = 'Reservado')

EXEC sp_sqlexec @SQL
GO

Alter table sueConceptos Add ColumnaRecibo smallint
GO

Alter table sueConceptos Add Signo smallint
GO


Update sueConceptos set Signo = 1 where Concepto_Id < 4000
Update sueConceptos set Signo = 1 where Concepto_Id between 6001 And 7999
Update sueConceptos set Signo = -1 where Concepto_Id between 4001 And 5000
Update sueConceptos set Signo = 0 where Concepto_Id > 8000
GO

Update sueConceptos set ColumnaRecibo = 1 where Concepto_Id < 4000
Update sueConceptos set ColumnaRecibo = 1 where Concepto_Id between 6001 And 7999
Update sueConceptos set ColumnaRecibo = 2 where Concepto_Id between 4001 And 5000
Update sueConceptos set ColumnaRecibo = 0 where Concepto_Id > 8000
GO

Alter table sueConceptos Alter Column ColumnaRecibo smallint not null
GO

Alter table sueConceptos Alter Column Signo smallint not null
GO


Alter table sueConceptos Drop Column Reservado
GO




CREATE TABLE sueDato
( 
	sueLiquidacion       integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Dato                 QCantidad ,
	Dato2                QCantidad ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKsueDato PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC)
)
go



CREATE TABLE sueDatoRetro
( 
	sueLiquidacion       integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	AnioRetro            smallint  NOT NULL ,
	MesRetro             smallint  NOT NULL ,
	Dato                 QCantidad ,
	Dato2                QCantidad ,
	CONSTRAINT XPKsueDatoRetro PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC,AnioRetro ASC,MesRetro ASC)
)
go



CREATE TABLE sueLiquidacion
( 
	sueLiquidacion       integer IDENTITY ( 1,1 ) ,
	Asiento_Id           bigint  NULL ,
	Grupo_Id             integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	FechaPago            qFecha ,
	FechaDeposito        qFecha  NULL ,
	PeriodoDeposito      varchar(20)  NULL ,
	CtaSueldosAPagar     integer  NOT NULL ,
	FechaInicial         qFecha  NULL ,
	FechaFinal           qFecha  NULL ,
	Periodo_Id           char(1)  NULL ,
	PorEmpleado          Sino ,
	Anio                 integer  NOT NULL ,
	Mes                  integer  NOT NULL ,
	Quincena             integer  NOT NULL ,
	Semana               integer  NOT NULL ,
	Decena               integer  NOT NULL ,
	Vez                  integer  NOT NULL ,
	FechaContabilizacion qFecha ,
	CONSTRAINT XPKsueLiquidacion PRIMARY KEY  CLUSTERED (sueLiquidacion ASC)
)
go



CREATE TABLE sueLiquidacionSegmento
( 
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           Sucursal ,
	sueLiquidacion       integer  NULL ,
	CONSTRAINT XPKsueLiquidacionSegmento PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Segmento_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE sueMovCont
( 
	sueLiquidacion       integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKsueMovCont PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC,Cuenta_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go



CREATE TABLE suePagosHabi
( 
	sueLiquidacion       integer  NOT NULL ,
	tesMovimientos       bigint  NULL ,
	FechaHabilitacion    qFecha ,
	Importe              qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePagosHabi PRIMARY KEY  CLUSTERED (sueLiquidacion ASC)
)
go



CREATE TABLE suePagosHabiPorEmpleado
( 
	sueLiquidacion       integer  NOT NULL ,
	Secuencia            integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	tesMovimientos       bigint  NULL ,
	FechaHabilitacion    qFecha ,
	Importe              qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePagosHabiPorEmpleado PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Secuencia ASC,Legajo ASC)
)
go



CREATE TABLE suePeriodosSugeridos
( 
	Empresa_Id           integer  NOT NULL ,
	Anio                 integer  NOT NULL ,
	Mes                  integer  NOT NULL ,
	Quincena             integer  NOT NULL ,
	Semana               integer  NOT NULL ,
	Decena               integer  NOT NULL ,
	Vez                  integer  NOT NULL ,
	CONSTRAINT XPKsuePeriodosSugeridos PRIMARY KEY  CLUSTERED (Empresa_Id ASC)
)
go



CREATE TABLE sueTerminada
( 
	sueLiquidacion       integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Dato                 QCantidad  NOT NULL ,
	Dato2                QCantidad  NOT NULL ,
	Importe              qMonedaD2 ,
	Signo				 Smallint NOT NULL,
	CONSTRAINT XPKsueTerminada PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC)
)
go



CREATE TABLE sueTerminadaRetro
( 
	sueLiquidacion       integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	AnioRetro            integer  NOT NULL ,
	MesRetro             integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKsueTermi PRIMARY KEY  CLUSTERED (sueLiquidacion ASC,Legajo ASC,Concepto_Id ASC,AnioRetro ASC,MesRetro ASC)
)
go




ALTER TABLE sueDato
	ADD CONSTRAINT V2R_4349 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE sueDato
	ADD CONSTRAINT V2R_4350 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE sueDato
	ADD CONSTRAINT V2R_4351 FOREIGN KEY (Concepto_Id) REFERENCES sueConceptos(sueConceptos)
go




ALTER TABLE sueDato
	ADD CONSTRAINT V2R_4352 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE sueDatoRetro
	ADD CONSTRAINT V2R_4353 FOREIGN KEY (sueLiquidacion,Legajo,Concepto_Id) REFERENCES sueDato(sueLiquidacion,Legajo,Concepto_Id)
go




ALTER TABLE sueLiquidacion
	ADD CONSTRAINT V2R_4214 FOREIGN KEY (Asiento_Id) REFERENCES conAsientos(conAsientos)
go




ALTER TABLE sueLiquidacion
	ADD CONSTRAINT V2R_4215 FOREIGN KEY (Grupo_Id) REFERENCES sueGrupos(sueGrupos)
go




ALTER TABLE sueLiquidacion
	ADD CONSTRAINT V2R_4217 FOREIGN KEY (CtaSueldosAPagar) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE sueLiquidacion
	ADD CONSTRAINT V2R_4356 FOREIGN KEY (Periodo_Id) REFERENCES suePeriodicidad(Periodo_Id)
go




ALTER TABLE sueLiquidacionSegmento
	ADD CONSTRAINT V2R_4226 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go




ALTER TABLE sueLiquidacionSegmento
	ADD CONSTRAINT V2R_4227 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueLiquidacionSegmento
	ADD CONSTRAINT V2R_4354 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE sueMovCont
	ADD CONSTRAINT V2R_4222 FOREIGN KEY (sueLiquidacion,Legajo,Concepto_Id) REFERENCES sueTerminada(sueLiquidacion,Legajo,Concepto_Id)
go




ALTER TABLE sueMovCont
	ADD CONSTRAINT V2R_4223 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE sueMovCont
	ADD CONSTRAINT V2R_4224 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE sueMovCont
	ADD CONSTRAINT V2R_4225 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go




ALTER TABLE suePagosHabi
	ADD CONSTRAINT V2R_4357 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE suePagosHabi
	ADD CONSTRAINT V2R_4358 FOREIGN KEY (tesMovimientos) REFERENCES tesMovimientos(tesMovimientos)
go




ALTER TABLE suePagosHabi
	ADD CONSTRAINT V2R_4359 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePagosHabiPorEmpleado
	ADD CONSTRAINT V2R_4360 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE suePagosHabiPorEmpleado
	ADD CONSTRAINT V2R_4361 FOREIGN KEY (tesMovimientos) REFERENCES tesMovimientos(tesMovimientos)
go




ALTER TABLE suePagosHabiPorEmpleado
	ADD CONSTRAINT V2R_4362 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePagosHabiPorEmpleado
	ADD CONSTRAINT V2R_4363 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePeriodosSugeridos
	ADD CONSTRAINT V2R_4355 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE sueTerminada
	ADD CONSTRAINT V2R_4218 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE sueTerminada
	ADD CONSTRAINT V2R_4219 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE sueTerminada
	ADD CONSTRAINT V2R_4220 FOREIGN KEY (Concepto_Id) REFERENCES sueConceptos(sueConceptos)
go




ALTER TABLE sueTerminadaRetro
	ADD CONSTRAINT V2R_4221 FOREIGN KEY (sueLiquidacion,Legajo,Concepto_Id) REFERENCES sueTerminada(sueLiquidacion,Legajo,Concepto_Id)
go


insert into genVersion (Version) Values(525.000)
GO



