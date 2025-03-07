DROP TABLE suePersonal
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



CREATE UNIQUE NONCLUSTERED INDEX XAK1suepersonal ON suePersonal
( 
	Legajo                ASC
)
go



CREATE TABLE afiActivoFijo
( 
	afiActivoFijo        integer IDENTITY ( 1,1 ) ,
	ActivoFijo_Id        varchar(15)  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Descripcion          varchar(max)  NOT NULL ,
	FechaAlta            qFecha ,
	FechaIniDepre        qFecha ,
	FechaBaja            qFecha  NULL ,
	ValorInicial         qMonedaD2 ,
	ValorFiscal          qMonedaD2 ,
	VidaUtil             integer  NOT NULL ,
	VidaUtilRestante     integer  NOT NULL ,
	PorResidual          qPorcentaje ,
	AmortAcumulada       qMonedaD2 ,
	Rubro_Id             integer  NULL ,
	Cantidad             QCantidad ,
	CtaValorOrigen_Id    integer  NULL ,
	CtaAmortAcum_Id      integer  NULL ,
	CtaAmortizacion_Id   integer  NULL ,
	Tipo                 varchar(2)  NOT NULL ,
	ValorInicialSI       qMonedaD2 ,
	AmortAcumSI          qMonedaD2 ,
	Usuario_Id           integer  NULL ,
	FechaCarga           qFechaHora ,
	CONSTRAINT XPKafiActivoFijo PRIMARY KEY  CLUSTERED (afiActivoFijo ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1afiActivoFijo ON afiActivoFijo
( 
	ActivoFijo_Id         ASC,
	Empresa_Id            ASC
)
go




exec sp_bindefault 'FechaHora_Actual', 'afiActivoFijo.FechaCarga'
go



CREATE TABLE afiBajas
( 
	conAsientos          bigint  NOT NULL ,
	Causa                varchar(max)  NOT NULL ,
	Cantidad             QCantidad ,
	Monto                qMonedaD2 ,
	MontoFiscal          qMonedaD2 ,
	MontoDepreciacion    qMonedaD2 ,
	CONSTRAINT XPKafiBajas PRIMARY KEY  CLUSTERED (conAsientos ASC)
)
go



CREATE TABLE afiCentros
( 
	ActivoFijo_Id        integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Porcentaje           qPorcentaje ,
	CONSTRAINT XPKafiCentros PRIMARY KEY  CLUSTERED (ActivoFijo_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go



CREATE TABLE afiModulos
( 
	Asiento_Id           bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	ActivoFijo_Id        integer  NULL ,
	CONSTRAINT XPKafiModulos PRIMARY KEY  CLUSTERED (Asiento_Id ASC,Renglon ASC)
)
go



CREATE TABLE afiMovimientos
( 
	afiActivoFijo        integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	conAsientos          bigint  NOT NULL ,
	TipoMov              varchar(2)  NOT NULL ,
	CONSTRAINT XPKafiMovimientos PRIMARY KEY  CLUSTERED (afiActivoFijo ASC,Renglon ASC,conAsientos ASC)
)
go



CREATE TABLE afiRubros
( 
	afiRubros            integer IDENTITY ( 1,1 ) ,
	Rubro_Id             varchar(5)  NOT NULL ,
	Descripcion          varchar(120)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	VidaUtil             integer  NOT NULL ,
	VidaUtilFiscal       integer  NOT NULL ,
	CtaValorOrigen_Id    integer  NULL ,
	CtaAmortAcum_Id      integer  NULL ,
	CtaAmortizacion_Id   integer  NULL ,
	Tipo                 varchar(2)  NOT NULL ,
	Digitos              smallint  NOT NULL ,
	Usuario_Id           integer  NULL ,
	FechaAlta            qFechaHora ,
	Posteado             Sino ,
	CONSTRAINT XPKafiRubros PRIMARY KEY  CLUSTERED (afiRubros ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1afiRubros ON afiRubros
( 
	Rubro_Id              ASC
)
go




CREATE TABLE proCausas
( 
	proCausas            integer IDENTITY ( 1,1 ) ,
	Causa_Id             varchar(5)  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKproCausas PRIMARY KEY  CLUSTERED (proCausas ASC)
)
go



CREATE TABLE proCentroProductivo
( 
	proCentroProductivo  integer IDENTITY ( 1,1 ) ,
	CtroProd_Id          varchar(8)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKproCentroProductivo PRIMARY KEY  CLUSTERED (proCentroProductivo ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proCentroProductivo ON proCentroProductivo
( 
	CtroProd_Id           ASC
)
go



CREATE TABLE proMovCierreOrden
( 
	proMovCierreOrden    bigint IDENTITY ( 1,1 ) ,
	proOrden             integer  NULL ,
	Cantidad             qCantidadD8 ,
	Parcial              Sino ,
	Causa_Id             integer  NULL ,
	CONSTRAINT XPKproMovCierreOrden PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC)
)
go



CREATE TABLE proMovCierreRecursos
( 
	proMovCierreOrden    bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	Costo                qMonedaD4 ,
	CONSTRAINT XPKproMovCierreRecursos PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,Renglon ASC)
)
go



CREATE TABLE proMovCierreTrabajos3
( 
	proMovCierreOrden    bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Trabajo3_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	Moneda_Id            integer  NOT NULL ,
	Proveed_Id           bigint  NOT NULL ,
	Precio               qMonedaD4 ,
	CONSTRAINT XPKproMovCierreTrabajos3 PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,Renglon ASC)
)
go



CREATE TABLE proOrden
( 
	proOrden             integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	TamBatch             qCantidadD8 ,
	Receta_Id            integer  NULL ,
	Observaciones        varchar(max)  NOT NULL ,
	CONSTRAINT XPKproOrden PRIMARY KEY  CLUSTERED (proOrden ASC)
)
go



CREATE TABLE proOrdenProd
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	EntradaSalida        char(1)  NOT NULL ,
	Medida_Id            integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	PorcentajeCosto      qPorcentaje ,
	Deposito_Id          integer  NULL ,
	TomaDepoT3           Sino ,
	CONSTRAINT XPKporOrdenProd PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC)
)
go



CREATE TABLE proOrdenRecursos
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKporOrdenRecursos PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC)
)
go



CREATE TABLE proOrdenSegmento
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	proOrden             integer  NULL ,
	CONSTRAINT XPKporOrdenSegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE proOrdenStock
( 
	proMovCierreOrden    bigint  NOT NULL ,
	stkMoviCabe          bigint  NOT NULL ,
	CONSTRAINT XPKproCierreOrden PRIMARY KEY  CLUSTERED (proMovCierreOrden ASC,stkMoviCabe ASC)
)
go



CREATE TABLE proOrdenSubRecurso
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	SubRecurso_Id        integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKproOrdenSubRecurso PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC,SubRecurso_Id ASC)
)
go



CREATE TABLE proOrdenTrabajos3
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	proTrabajo3          integer  NOT NULL ,
	Proveed_Id           bigint  NULL ,
	CONSTRAINT XPKporOrdenTrabajos3 PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC)
)
go



CREATE TABLE proProgramaOrden
( 
	proProgramas         integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	proOrden             integer  NOT NULL ,
	CONSTRAINT XPKproProgramaOrden PRIMARY KEY  CLUSTERED (proProgramas ASC,Renglon ASC,proOrden ASC)
)
go



CREATE TABLE proProgramas
( 
	proProgramas         integer IDENTITY ( 1,1 ) ,
	Descripcion          varchar(80)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Fecha                qFecha ,
	FechaDesde           qFecha ,
	FechaHasta           qFecha ,
	Deposito_Id          integer  NULL ,
	ProductoDesde        varchar(25)  NOT NULL ,
	ProductoHasta        varchar(20)  NOT NULL ,
	Lunes                Sino ,
	Martes               Sino ,
	Miercoles            Sino ,
	Jueves               Sino ,
	Viernes              Sino ,
	Sabado               Sino ,
	Domingo              Sino ,
	GrupoDesde           varchar(15)  NOT NULL ,
	GrupoHasta           varchar(20)  NOT NULL ,
	FamiliaDesde         varchar(15)  NOT NULL ,
	FamiliaHasta         varchar(15)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKproPrograma PRIMARY KEY  CLUSTERED (proProgramas ASC)
)
go



CREATE TABLE proProgramasCuerpo
( 
	proProgramas         integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NULL ,
	Cantidad             qCantidadD8 ,
	Observaciones        varchar(20)  NULL ,
	FechaNecesidad       qFecha ,
	Confirmado           Sino ,
	Receta_Id            integer  NOT NULL ,
	CONSTRAINT XPKproProgramasCuerpo PRIMARY KEY  CLUSTERED (proProgramas ASC,Renglon ASC)
)
go



CREATE TABLE proProgramasSegmento
( 
	Segmento_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	proProgramas         integer  NULL ,
	CONSTRAINT XPKproProgramasSegmento PRIMARY KEY  CLUSTERED (Segmento_Id ASC,Empresa_Id ASC,Segmento1N ASC,Segmento2N ASC,Segmento3N ASC,Segmento4N ASC,Segmento1C ASC,Segmento2C ASC,Segmento3C ASC,Segmento4C ASC)
)
go



CREATE TABLE proRecetas
( 
	proRecetas           integer IDENTITY ( 1,1 ) ,
	Receta_Id            varchar(25)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(80)  NOT NULL ,
	CtroProd_Id          integer  NULL ,
	TamBatch             qCantidadD8 ,
	Agrupa               Sino ,
	Corte                Sino ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	FechaModificacion    qFechaHora ,
	CONSTRAINT XPKproRecetas PRIMARY KEY  CLUSTERED (proRecetas ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proRecetas ON proRecetas
( 
	Receta_Id             ASC
)
go



CREATE TABLE proRecetasProd
( 
	Receta_Id            integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	EntradaSalida        char(1)  NOT NULL ,
	Medida_Id            integer  NULL ,
	Formula              varchar(max)  NOT NULL ,
	Cantidad             qCantidadD8 ,
	PorcentajeCosto      qPorcentaje ,
	Deposito_Id          integer  NULL ,
	Observaciones        varchar(max)  NULL ,
	TomaDepoT3           Sino ,
	CONSTRAINT XPKproRecetasProd PRIMARY KEY  CLUSTERED (Receta_Id ASC,Renglon ASC)
)
go



CREATE TABLE proRecetasRecursos
( 
	proRecetas           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKproRecetasRecursos PRIMARY KEY  CLUSTERED (proRecetas ASC,Renglon ASC)
)
go



CREATE TABLE proRecetasTrabajo3
( 
	Receta_Id            integer  NOT NULL ,
	Trabajo3_Id          integer  NOT NULL ,
	CONSTRAINT XPKproRecetasTrabajo3 PRIMARY KEY  CLUSTERED (Receta_Id ASC,Trabajo3_Id ASC)
)
go



CREATE TABLE proRecursos
( 
	proRecursos          integer  NOT NULL ,
	Recurso_Id           varchar(25)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Unidad_Id            integer  NULL ,
	Capacidad            qCantidadD8 ,
	Costo                qMonedaD4 ,
	UsaSubRecurso        Sino ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKproRecursos PRIMARY KEY  CLUSTERED (proRecursos ASC)
)
go



CREATE TABLE proSubRecursos
( 
	proSubRecursos       integer IDENTITY ( 1,1 ) ,
	SubRecurso_Id        varchar(25)  NOT NULL ,
	Recurso_Id           integer  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Capacidad            qCantidadD8 ,
	Costo                qMonedaD4 ,
	Predeterminado       Sino ,
	Inactivo             Sino ,
	CONSTRAINT XPKproRecursosRecurso PRIMARY KEY  CLUSTERED (proSubRecursos ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proRecursosRecurso ON proSubRecursos
( 
	SubRecurso_Id         ASC
)
go



CREATE TABLE proTrabajo3
( 
	proTrabajo3          integer IDENTITY ( 1,1 ) ,
	Trabajo3_Id          varchar(25)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Cuenta_Id            integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKproTrabajo3 PRIMARY KEY  CLUSTERED (proTrabajo3 ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1proTrabajo3 ON proTrabajo3
( 
	Trabajo3_Id           ASC
)
go



CREATE TABLE proTrabajo3Prov
( 
	Trabajo3_Id          integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Proveedor_Id         bigint  NULL ,
	Moneda_Id            integer  NULL ,
	Precio               qMonedaD4 ,
	Medida_Id            integer  NULL ,
	Cantidad             qCantidadD8 ,
	Predeterminado       Sino ,
	CONSTRAINT XPKproTrabajo3Prov PRIMARY KEY  CLUSTERED (Trabajo3_Id ASC,Renglon ASC)
)
go



CREATE TABLE provarGlobales
( 
	Variable_Id          smallint  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Valor                qCantidadD8 ,
	CONSTRAINT XPKprovarGlobales PRIMARY KEY  CLUSTERED (Variable_Id ASC)
)
go





ALTER TABLE afiActivoFijo
	ADD CONSTRAINT RV2_4091 FOREIGN KEY (Rubro_Id) REFERENCES afiRubros(afiRubros)
go




ALTER TABLE afiActivoFijo
	ADD CONSTRAINT RV2_4093 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE afiActivoFijo
	ADD CONSTRAINT RV2_4095 FOREIGN KEY (CtaValorOrigen_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE afiActivoFijo
	ADD CONSTRAINT RV2_4096 FOREIGN KEY (CtaAmortAcum_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE afiActivoFijo
	ADD CONSTRAINT RV2_4098 FOREIGN KEY (CtaAmortizacion_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE afiActivoFijo
	ADD CONSTRAINT RV2_4100 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE afiBajas
	ADD CONSTRAINT RV2_4105 FOREIGN KEY (conAsientos) REFERENCES conAsientos(conAsientos)
go




ALTER TABLE afiCentros
	ADD CONSTRAINT RV2_4102 FOREIGN KEY (ActivoFijo_Id) REFERENCES afiActivoFijo(afiActivoFijo)
go




ALTER TABLE afiCentros
	ADD CONSTRAINT RV2_4103 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE afiCentros
	ADD CONSTRAINT RV2_4104 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go




ALTER TABLE afiModulos
	ADD CONSTRAINT RV2_4145 FOREIGN KEY (Asiento_Id,Renglon) REFERENCES conMovCont(conAsientos,Renglon)
go




ALTER TABLE afiModulos
	ADD CONSTRAINT RV2_4146 FOREIGN KEY (ActivoFijo_Id) REFERENCES afiActivoFijo(afiActivoFijo)
go




ALTER TABLE afiMovimientos
	ADD CONSTRAINT RV2_4106 FOREIGN KEY (afiActivoFijo) REFERENCES afiActivoFijo(afiActivoFijo)
go




ALTER TABLE afiMovimientos
	ADD CONSTRAINT RV2_4107 FOREIGN KEY (conAsientos) REFERENCES conAsientos(conAsientos)
go




ALTER TABLE afiRubros
	ADD CONSTRAINT RV2_4092 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE afiRubros
	ADD CONSTRAINT RV2_4094 FOREIGN KEY (CtaValorOrigen_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE afiRubros
	ADD CONSTRAINT RV2_4097 FOREIGN KEY (CtaAmortAcum_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE afiRubros
	ADD CONSTRAINT RV2_4099 FOREIGN KEY (CtaAmortizacion_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE afiRubros
	ADD CONSTRAINT RV2_4101 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go






ALTER TABLE proCausas
	ADD CONSTRAINT RV2_4130 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE proCentroProductivo
	ADD CONSTRAINT RV2_4061 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE proCentroProductivo
	ADD CONSTRAINT RV2_4062 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go




ALTER TABLE proCentroProductivo
	ADD CONSTRAINT RV2_4068 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE proCentroProductivo
	ADD CONSTRAINT RV2_4069 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE proMovCierreOrden
	ADD CONSTRAINT RV2_4134 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proMovCierreOrden
	ADD CONSTRAINT RV2_4137 FOREIGN KEY (Causa_Id) REFERENCES proCausas(proCausas)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT RV2_4138 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proMovCierreRecursos
	ADD CONSTRAINT RV2_4139 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT RV2_4140 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT RV2_4141 FOREIGN KEY (Trabajo3_Id) REFERENCES proTrabajo3(proTrabajo3)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT RV2_4142 FOREIGN KEY (Moneda_Id) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE proMovCierreTrabajos3
	ADD CONSTRAINT RV2_4143 FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go




ALTER TABLE proOrden
	ADD CONSTRAINT RV2_4088 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE proOrden
	ADD CONSTRAINT RV2_4090 FOREIGN KEY (Receta_Id) REFERENCES proRecetas(proRecetas)
go




ALTER TABLE proOrdenProd
	ADD CONSTRAINT RV2_4112 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proOrdenProd
	ADD CONSTRAINT RV2_4113 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE proOrdenProd
	ADD CONSTRAINT RV2_4114 FOREIGN KEY (Medida_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE proOrdenProd
	ADD CONSTRAINT RV2_4115 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go




ALTER TABLE proOrdenRecursos
	ADD CONSTRAINT RV2_4119 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proOrdenRecursos
	ADD CONSTRAINT RV2_4120 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go




ALTER TABLE proOrdenSegmento
	ADD CONSTRAINT RV2_4116 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proOrdenSegmento
	ADD CONSTRAINT RV2_4117 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go




ALTER TABLE proOrdenSegmento
	ADD CONSTRAINT RV2_4118 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE proOrdenStock
	ADD CONSTRAINT RV2_4131 FOREIGN KEY (stkMoviCabe) REFERENCES stkMoviCabe(stkMoviCabe)
go




ALTER TABLE proOrdenStock
	ADD CONSTRAINT RV2_4135 FOREIGN KEY (proMovCierreOrden) REFERENCES proMovCierreOrden(proMovCierreOrden)
go




ALTER TABLE proOrdenSubRecurso
	ADD CONSTRAINT RV2_4123 FOREIGN KEY (proOrden,Renglon) REFERENCES proOrdenRecursos(proOrden,Renglon)
go




ALTER TABLE proOrdenSubRecurso
	ADD CONSTRAINT RV2_4124 FOREIGN KEY (SubRecurso_Id) REFERENCES proSubRecursos(proSubRecursos)
go




ALTER TABLE proOrdenTrabajos3
	ADD CONSTRAINT RV2_4125 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proOrdenTrabajos3
	ADD CONSTRAINT RV2_4126 FOREIGN KEY (proTrabajo3) REFERENCES proTrabajo3(proTrabajo3)
go




ALTER TABLE proOrdenTrabajos3
	ADD CONSTRAINT RV2_4127 FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go




ALTER TABLE proProgramaOrden
	ADD CONSTRAINT RV2_4128 FOREIGN KEY (proProgramas,Renglon) REFERENCES proProgramasCuerpo(proProgramas,Renglon)
go




ALTER TABLE proProgramaOrden
	ADD CONSTRAINT RV2_4129 FOREIGN KEY (proOrden) REFERENCES proOrden(proOrden)
go




ALTER TABLE proProgramas
	ADD CONSTRAINT RV2_4086 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE proProgramas
	ADD CONSTRAINT RV2_4087 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE proProgramas
	ADD CONSTRAINT RV2_4089 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go




ALTER TABLE proProgramasCuerpo
	ADD CONSTRAINT RV2_4082 FOREIGN KEY (proProgramas) REFERENCES proProgramas(proProgramas)
go




ALTER TABLE proProgramasCuerpo
	ADD CONSTRAINT RV2_4083 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE proProgramasCuerpo
	ADD CONSTRAINT RV2_4085 FOREIGN KEY (Receta_Id) REFERENCES proRecetas(proRecetas)
go




ALTER TABLE proProgramasSegmento
	ADD CONSTRAINT RV2_4109 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE proProgramasSegmento
	ADD CONSTRAINT RV2_4110 FOREIGN KEY (Segmento_Id) REFERENCES genSegmentos(genSegmentos)
go




ALTER TABLE proProgramasSegmento
	ADD CONSTRAINT RV2_4111 FOREIGN KEY (proProgramas) REFERENCES proProgramas(proProgramas)
go




ALTER TABLE proRecetas
	ADD CONSTRAINT RV2_4059 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE proRecetas
	ADD CONSTRAINT RV2_4060 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE proRecetas
	ADD CONSTRAINT RV2_4063 FOREIGN KEY (CtroProd_Id) REFERENCES proCentroProductivo(proCentroProductivo)
go




ALTER TABLE proRecetasProd
	ADD CONSTRAINT RV2_4064 FOREIGN KEY (Receta_Id) REFERENCES proRecetas(proRecetas)
go




ALTER TABLE proRecetasProd
	ADD CONSTRAINT RV2_4065 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE proRecetasProd
	ADD CONSTRAINT RV2_4066 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go




ALTER TABLE proRecetasProd
	ADD CONSTRAINT RV2_4070 FOREIGN KEY (Medida_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE proRecetasRecursos
	ADD CONSTRAINT RV2_4121 FOREIGN KEY (proRecetas) REFERENCES proRecetas(proRecetas)
go




ALTER TABLE proRecetasRecursos
	ADD CONSTRAINT RV2_4122 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go




ALTER TABLE proRecetasTrabajo3
	ADD CONSTRAINT RV2_4077 FOREIGN KEY (Receta_Id) REFERENCES proRecetas(proRecetas)
go




ALTER TABLE proRecetasTrabajo3
	ADD CONSTRAINT RV2_4078 FOREIGN KEY (Trabajo3_Id) REFERENCES proTrabajo3(proTrabajo3)
go




ALTER TABLE proRecursos
	ADD CONSTRAINT RV2_4080 FOREIGN KEY (Unidad_Id) REFERENCES stkUniMed(stkUniMed)
go




ALTER TABLE proSubRecursos
	ADD CONSTRAINT RV2_4081 FOREIGN KEY (Recurso_Id) REFERENCES proRecursos(proRecursos)
go




ALTER TABLE proTrabajo3
	ADD CONSTRAINT RV2_4071 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE proTrabajo3
	ADD CONSTRAINT RV2_4072 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE proTrabajo3
	ADD CONSTRAINT RV2_4079 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE proTrabajo3Prov
	ADD CONSTRAINT RV2_4073 FOREIGN KEY (Trabajo3_Id) REFERENCES proTrabajo3(proTrabajo3)
go




ALTER TABLE proTrabajo3Prov
	ADD CONSTRAINT RV2_4074 FOREIGN KEY (Proveedor_Id) REFERENCES comProveedores(genEntidades)
go




ALTER TABLE proTrabajo3Prov
	ADD CONSTRAINT RV2_4075 FOREIGN KEY (Moneda_Id) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE proTrabajo3Prov
	ADD CONSTRAINT RV2_4076 FOREIGN KEY (Medida_Id) REFERENCES stkUniMed(stkUniMed)
go


Alter table genEmpresas add FechaCierreActivoFijo DateTime
GO

Alter table genEmpresas add FechaCalculoActivoFijo DateTime
GO

Alter table genEmpresas add FechaCalculoActivoDiferido DateTime
GO

UPDATE genEmpresas Set FechaCierreActivoFijo = Dateadd(dd,-1,FechaInicioSumma)
GO
UPDATE genEmpresas Set FechaCalculoActivoFijo = FechaCierreActivoFijo, 
	FechaCalculoActivoDiferido =FechaCierreActivoFijo
GO

Alter table genEmpresas Alter Column FechaCierreActivoFijo DateTime NOT NULL
GO

Alter table genEmpresas Alter Column FechaCalculoActivoFijo DateTime NOT NULL
GO

Alter table genEmpresas Alter Column FechaCalculoActivoDiferido DateTime NOT NULL
GO


Alter table stkDepositos Add Proveed_Id BigInt NULL
GO

ALTER TABLE stkDepositos
	ADD CONSTRAINT RV2_4144 FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go


INSERT INTO genSegmentos(Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, Inactivo, Usuario_Id, Posteado, TamanioVariable) VALUES('PROG', 'Programa de Produccion', 8, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, '1N')
INSERT INTO genSegmentos(Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, Inactivo, Usuario_Id, Posteado, TamanioVariable) VALUES('PORD', 'Ordenes de Produccion', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, '1N')
INSERT INTO genSegmentos(Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, Inactivo, Usuario_Id, Posteado, TamanioVariable) VALUES('DEP', 'Depreciaciones', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, '1N')
INSERT INTO genSegmentos(Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, Inactivo, Usuario_Id, Posteado, TamanioVariable) VALUES('ABAJ', 'Bajas Activo Fijo', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, '1N')
GO

INSERT INTO genVersion (Version) Values(500.00)
GO
