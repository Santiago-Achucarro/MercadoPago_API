
if exists(select 1 from sueLiquidacion )
begin
	raiserror( 'Error las tablas de liquidacion tiene datos',1,1)
end

DROP TABLE sueLiquidacionSegmento
DROP TABLE sueMovCont
DROP TABLE sueTerminadaRetro
DROP TABLE sueTerminada
DROP TABLE suePagosHabi
DROP TABLE suePagosHabiPorEmpleado
DROP TABLE sueDatoRetro
DROP TABLE sueDato
DROP TABLE sueLiquidacion

GO

CREATE TABLE sueDato
( 
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	sueLiquidacion       bigint  NOT NULL ,
	Dato                 QCantidad ,
	Dato2                QCantidad ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        qFechaHora ,
	CONSTRAINT XPKsueDato PRIMARY KEY  CLUSTERED (Legajo ASC,Concepto_Id ASC,sueLiquidacion ASC)
)
go



CREATE TABLE sueDatoRetro
( 
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	AnioRetro            smallint  NOT NULL ,
	MesRetro             smallint  NOT NULL ,
	sueLiquidacion       bigint  NOT NULL ,
	Dato                 QCantidad ,
	Dato2                QCantidad ,
	CONSTRAINT XPKsueDatoRetro PRIMARY KEY  CLUSTERED (Legajo ASC,Concepto_Id ASC,AnioRetro ASC,MesRetro ASC,sueLiquidacion ASC)
)
go



CREATE TABLE sueLiquidacion
( 
	sueLiquidacion       bigint  NOT NULL ,
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



CREATE TABLE sueMovCont
( 
	sueLiquidacion       bigint  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKsueMovCont PRIMARY KEY  CLUSTERED (sueLiquidacion ASC, Legajo ASC,Concepto_Id ASC,Cuenta_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go



CREATE TABLE suePagosHabi
( 
	sueLiquidacion       bigint  NOT NULL ,
	tesMovimientos       bigint  NULL ,
	FechaHabilitacion    qFecha ,
	Importe              qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePagosHabi PRIMARY KEY  CLUSTERED (sueLiquidacion ASC)
)
go



CREATE TABLE suePagosHabiPorEmpleado
( 
	Secuencia            integer  NOT NULL ,
	Legajo               bigint  NOT NULL ,
	sueLiquidacion       bigint  NOT NULL ,
	tesMovimientos       bigint  NULL ,
	FechaHabilitacion    qFecha ,
	Importe              qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePagosHabiPorEmpleado PRIMARY KEY  CLUSTERED (Secuencia ASC,Legajo ASC,sueLiquidacion ASC)
)
go



CREATE TABLE sueTerminada
( 
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	sueLiquidacion       bigint  NOT NULL ,
	Dato                 QCantidad  NOT NULL ,
	Dato2                QCantidad  NOT NULL ,
	Importe              qMonedaD2 ,
	Signo                smallint  NOT NULL ,
	CONSTRAINT XPKsueTerminada PRIMARY KEY  CLUSTERED (Legajo ASC,Concepto_Id ASC,sueLiquidacion ASC)
)
go



CREATE TABLE sueTerminadaRetro
( 
	Legajo               bigint  NOT NULL ,
	Concepto_Id          integer  NOT NULL ,
	AnioRetro            integer  NOT NULL ,
	MesRetro             integer  NOT NULL ,
	sueLiquidacion       bigint  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKsueTermi PRIMARY KEY  CLUSTERED (Legajo ASC,Concepto_Id ASC,AnioRetro ASC,MesRetro ASC,sueLiquidacion ASC)
)
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




ALTER TABLE sueDato
	ADD CONSTRAINT V2R_4349 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE sueDatoRetro
	ADD CONSTRAINT V2R_4353 FOREIGN KEY (Legajo,Concepto_Id,sueLiquidacion) REFERENCES sueDato(Legajo,Concepto_Id,sueLiquidacion)
go




ALTER TABLE sueLiquidacion
	ADD CONSTRAINT V2R_4214 FOREIGN KEY (sueLiquidacion) REFERENCES conAsientos(conAsientos)
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




ALTER TABLE sueMovCont
	ADD CONSTRAINT V2R_4222 FOREIGN KEY (Legajo,Concepto_Id,sueLiquidacion) REFERENCES sueTerminada(Legajo,Concepto_Id,sueLiquidacion)
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
	ADD CONSTRAINT V2R_4358 FOREIGN KEY (tesMovimientos) REFERENCES tesMovimientos(tesMovimientos)
go




ALTER TABLE suePagosHabi
	ADD CONSTRAINT V2R_4359 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePagosHabi
	ADD CONSTRAINT V2R_4357 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
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




ALTER TABLE suePagosHabiPorEmpleado
	ADD CONSTRAINT V2R_4360 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE sueTerminada
	ADD CONSTRAINT V2R_4219 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE sueTerminada
	ADD CONSTRAINT V2R_4220 FOREIGN KEY (Concepto_Id) REFERENCES sueConceptos(sueConceptos)
go




ALTER TABLE sueTerminada
	ADD CONSTRAINT V2R_4218 FOREIGN KEY (sueLiquidacion) REFERENCES sueLiquidacion(sueLiquidacion)
go




ALTER TABLE sueTerminadaRetro
	ADD CONSTRAINT V2R_4221 FOREIGN KEY (Legajo,Concepto_Id,sueLiquidacion) REFERENCES sueTerminada(Legajo,Concepto_Id,sueLiquidacion)
go




insert into genVersion (Version) Values(530.000)
GO