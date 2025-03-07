IF EXISTS(SELECT 1 FROM suePersonal)
	raiserror('Ya tiene empleados y va a borrar los datos',1,1)
	
GO

if exists(select 1 from sysobjects where name = 'suePersCatego' AND type = 'U')
	drop table suePersCatego
GO


if exists(select 1 from sysobjects where name = 'suePersConvenio' AND type = 'U')
	drop table suePersConvenio
GO


if exists(select 1 from sysobjects where name = 'suePersPuestos' AND type = 'U')
	drop table suePersPuestos
GO

if exists(select 1 from sysobjects where name = 'suePersTareas' AND type = 'U')
	drop table suePersTareas
GO


if exists(select 1 from sysobjects where name = 'suePersonal' AND type = 'U')
	drop table suePersonal
GO


CREATE TABLE suePersonal
( 
	genEntidades         bigint  NOT NULL ,
	Legajo               int  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Nombres              varchar(40)  NOT NULL ,
	ApellidoPaterno      varchar(30)  NOT NULL ,
	ApellidoMaterno      varchar(30)  NOT NULL ,
	NumeroDoc            varchar(20)  NOT NULL ,
	NroSegSocial         varchar(20)  NOT NULL ,
	Telefonos            varchar(120)  NOT NULL ,
	Celular              varchar(60)  NOT NULL ,
	FechaNacimiento      qFecha ,
	Sexo                 char(1)  NOT NULL ,
	Nacionalidad_Id      integer  NULL ,
	CodigoNatural        char(1)  NULL ,
	eMail                varchar(100)  NOT NULL ,
	FechaIngreso         qFecha ,
	FechaBaja            qFecha  NULL ,
	AniosReconocidos     integer  NOT NULL ,
	MesesReconocidos     integer  NOT NULL ,
	GrupoSanguineo       char(2)  NOT NULL ,
	RH                   char(1)  NOT NULL ,
	BancoSucursal        char(5)  NOT NULL ,
	BancoCuenta          char(15)  NOT NULL ,
	BancoTipoCta         char(3)  NOT NULL ,
	CuentaInactiva       Sino ,
	ClaveBancaria        varchar(25)  NOT NULL ,
	Observaciones        varchar(max)  NULL ,
	UMF                  varchar(3)  NOT NULL ,
	AvisarA              varchar(max)  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuepersonal PRIMARY KEY  CLUSTERED (genEntidades ASC)
)
go


CREATE TABLE suePersActividad
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Actividad_Id         varchar(3)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersActividad PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersAfore
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Afore_Id             varchar(5)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersAfore PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersCatego
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Categoria_Id         integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsuePersCatego PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersCondServicio
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	CondServicio_Id      varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersCondServicio PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersContable
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersContable PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersContableDatos
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	Cuenta_Id            integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Porcentaje           qPorcentaje ,
	CONSTRAINT XPKsuePersContableDatos PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC,Cuenta_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go






CREATE TABLE suePersConvenio
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Convenio_Id          integer  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoRela PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersDomicilio
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Direccion1           varchar(100)  NOT NULL ,
	Direccion2           varchar(100)  NOT NULL ,
	NroExterior          varchar(10)  NOT NULL ,
	NroInterior          varchar(10)  NOT NULL ,
	Localidad            varchar(100)  NOT NULL ,
	CodigoPostal         varchar(40)  NOT NULL ,
	EntreCalle1          varchar(60)  NOT NULL ,
	EntreCalle2          varchar(60)  NOT NULL ,
	Provincia_Id         integer  NULL ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKsuePersDomicilio PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersEstadoCivil
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	EstadoCivil_Id       varchar(3)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersEstadoCivil PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersLocalidad
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Localidad_Id         varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersLocalidad PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersModContrata
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Modalidad_Id         varchar(3)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersModContrata PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go





CREATE TABLE suePersPuestos
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Puesto_Id            integer  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersPuestos PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersSiniestrado
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Siniestro_Id         varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersIncapacidad PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersSituacionRevi
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Situacion_Id         varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersSituacionRevi PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersSucursal
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Sucursal             integer  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersSucursal PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTareas
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	Tarea_Id             integer  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTareas PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoContrato
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoContrato         varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoContrato PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoEmpleador
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoEmpleador_Id     varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoEmpleador PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoJornada
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoJornada          char(1)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoJornada PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoPago
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoPago_Id          integer  NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoPago PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoRegimen
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoRegimen          varchar(2)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoRegimen PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go



CREATE TABLE suePersTipoSDI
( 
	Legajo               bigint  NOT NULL ,
	FechaDesde           qFechaHora ,
	FechaHasta           qFechaHora ,
	TipoSDI              char(1)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKsuePersTipoSDI PRIMARY KEY  CLUSTERED (Legajo ASC,FechaDesde ASC)
)
go




ALTER TABLE suePersActividad
	ADD CONSTRAINT V2R_4183 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersActividad
	ADD CONSTRAINT V2R_4184 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersAfore
	ADD CONSTRAINT V2R_4251 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersAfore
	ADD CONSTRAINT V2R_4252 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersCatego
	ADD CONSTRAINT V2R_4162 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersCatego
	ADD CONSTRAINT V2R_4163 FOREIGN KEY (Categoria_Id) REFERENCES sueCategorias(sueCategorias)
go




ALTER TABLE suePersCatego
	ADD CONSTRAINT V2R_4164 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersCondServicio
	ADD CONSTRAINT V2R_4181 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersCondServicio
	ADD CONSTRAINT V2R_4182 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersContable
	ADD CONSTRAINT V2R_4189 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersContable
	ADD CONSTRAINT V2R_4195 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go


--alter table conCuentasSinSC
--add constraint XPKconCuentasSinSC Primary key clustered (Cuenta_Id ASC)


ALTER TABLE suePersContableDatos
	ADD CONSTRAINT V2R_4192 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentasSinSC(Cuenta_Id)
go




ALTER TABLE suePersContableDatos
	ADD CONSTRAINT V2R_4193 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE suePersContableDatos
	ADD CONSTRAINT V2R_4194 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go




ALTER TABLE suePersContableDatos
	ADD CONSTRAINT V2R_4261 FOREIGN KEY (Legajo,FechaDesde) REFERENCES suePersContable(Legajo,FechaDesde)
go










ALTER TABLE suePersConvenio
	ADD CONSTRAINT V2R_4167 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersConvenio
	ADD CONSTRAINT V2R_4168 FOREIGN KEY (Convenio_Id) REFERENCES sueConvenio(sueConvenio)
go




ALTER TABLE suePersConvenio
	ADD CONSTRAINT V2R_4173 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersDomicilio
	ADD CONSTRAINT V2R_4158 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersDomicilio
	ADD CONSTRAINT V2R_4159 FOREIGN KEY (Provincia_Id) REFERENCES genProvincias(genProvincias)
go




ALTER TABLE suePersDomicilio
	ADD CONSTRAINT V2R_4160 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersEstadoCivil
	ADD CONSTRAINT V2R_4155 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersEstadoCivil
	ADD CONSTRAINT V2R_4156 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersLocalidad
	ADD CONSTRAINT V2R_4199 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersLocalidad
	ADD CONSTRAINT V2R_4200 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersModContrata
	ADD CONSTRAINT V2R_4185 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersModContrata
	ADD CONSTRAINT V2R_4186 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersonal
	ADD CONSTRAINT V2R_36 FOREIGN KEY (genEntidades) REFERENCES genEntidades(genEntidades)
go




ALTER TABLE suePersonal
	ADD CONSTRAINT V2R_65 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE suePersonal
	ADD CONSTRAINT V2R_4151 FOREIGN KEY (Nacionalidad_Id) REFERENCES genPaises(genPaises)
go




ALTER TABLE suePersonal
	ADD CONSTRAINT V2R_4154 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersPuestos
	ADD CONSTRAINT V2R_4169 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersPuestos
	ADD CONSTRAINT V2R_4170 FOREIGN KEY (Puesto_Id) REFERENCES suePuestos(suePuestos)
go




ALTER TABLE suePersPuestos
	ADD CONSTRAINT V2R_4174 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersSiniestrado
	ADD CONSTRAINT V2R_4187 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersSiniestrado
	ADD CONSTRAINT V2R_4188 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersSituacionRevi
	ADD CONSTRAINT V2R_4179 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersSituacionRevi
	ADD CONSTRAINT V2R_4180 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersSucursal
	ADD CONSTRAINT V2R_4196 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersSucursal
	ADD CONSTRAINT V2R_4197 FOREIGN KEY (Sucursal) REFERENCES genSucursalesEmpr(genSucursalesEmpr)
go




ALTER TABLE suePersSucursal
	ADD CONSTRAINT V2R_4198 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersTareas
	ADD CONSTRAINT V2R_4165 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersTareas
	ADD CONSTRAINT V2R_4166 FOREIGN KEY (Tarea_Id) REFERENCES sueTareas(sueTareas)
go




ALTER TABLE suePersTareas
	ADD CONSTRAINT V2R_4172 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersTipoContrato
	ADD CONSTRAINT V2R_4248 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersTipoContrato
	ADD CONSTRAINT V2R_4249 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersTipoEmpleador
	ADD CONSTRAINT V2R_4171 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersTipoEmpleador
	ADD CONSTRAINT V2R_4178 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersTipoJornada
	ADD CONSTRAINT V2R_4242 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersTipoJornada
	ADD CONSTRAINT V2R_4243 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersTipoPago
	ADD CONSTRAINT V2R_4152 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersTipoPago
	ADD CONSTRAINT V2R_4153 FOREIGN KEY (TipoPago_Id) REFERENCES sueTipoPago(sueTipoPago)
go




ALTER TABLE suePersTipoPago
	ADD CONSTRAINT V2R_4157 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersTipoRegimen
	ADD CONSTRAINT V2R_4244 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersTipoRegimen
	ADD CONSTRAINT V2R_4247 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE suePersTipoSDI
	ADD CONSTRAINT V2R_4253 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go




ALTER TABLE suePersTipoSDI
	ADD CONSTRAINT V2R_4254 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go


INSERT INTO genVersion (Version) Values(512.00)
GO