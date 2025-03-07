INSERT INTO genVersion (Version) Values(66)
GO
-- Retenciones MX

CREATE TABLE impRetCFDIArrenda
( 
	impRetencionesCFDI    integer  NOT NULL ,
	PagProvEfecPorFiduc  numeric(18,4)  NOT NULL ,
	RendimFideicom       numeric(18,4)  NOT NULL ,
	DeduccCorresp        numeric(18,4)  NOT NULL ,
	MontTotRet           numeric(18,4)  NOT NULL ,
	MontResFiscDistFibras numeric(18,4)  NOT NULL ,
	MontOtrosConceptDistr numeric(18,4)  NOT NULL ,
	DescrMontOtrosConceptDistr varchar(200)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIDetalle
( 
	impRetencionesCFDI   integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	BaseRet              numeric(18,4)  NOT NULL ,
	TipoImpuesto         Varchar(2)  NOT NULL ,
	montoRet             numeric(18,4)  NOT NULL ,
	TipoPagoRet          Varchar(11)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC,Renglon ASC)
)
go



CREATE TABLE impRetCFDIDividendos
( 
	impRetencionesCFDI       integer  NOT NULL ,
	CveTipDivOUtil       Varchar(2)  NOT NULL ,
	MontISRAcredRetMexico numeric(18,4)  NOT NULL ,
	MontISRAcredRetExtranjero numeric(18,4)  NOT NULL ,
	MontRetExtDivExt     numeric(18,4)  NOT NULL ,
	TipoSocDistrDiv      char(20)  NOT NULL ,
	MontISRAcredNal      numeric(18,4)  NOT NULL ,
	MontDivAcumNal       numeric(18,4)  NOT NULL ,
	MontDivAcumExt       numeric(18,4)  NOT NULL ,
	ProporcionRem        numeric(10,6)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIEnajAccion
( 
	impRetencionesCFDI   integer  NOT NULL ,
	ContratoIntermediacion varchar(300)  NOT NULL ,
	Ganancia             numeric(18,4)  NOT NULL ,
	Perdida              numeric(18,4)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIFiedeEmpr
( 
	impRetencionesCFDI   integer  NOT NULL ,
	MontTotEntradasPeriodo numeric(18,4)  NOT NULL ,
	PartPropAcumDelFideicom numeric(18,4)  NOT NULL ,
	PropDelMontTot       numeric(10,6)  NOT NULL ,
	Concepto             varchar(100)  NOT NULL ,
	MontTotEgresPeriodo  numeric(18,4)  NOT NULL ,
	PartPropDelFideicom  numeric(18,4)  NOT NULL ,
	PropDelMontTotE      numeric(10,6)  NOT NULL ,
	ConseptoS            varchar(100)  NOT NULL ,
	MontRetRelPagFideic  numeric(18,4)  NOT NULL ,
	DescRetRelPagFideic  varchar(100)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIOperConDeriv
( 
	impRetencionesCFDI                integer  NOT NULL ,
	MontGanAcum          numeric(18,4)  NOT NULL ,
	MontPerdDed          numeric(18,4)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIPagosExtr
( 
	impRetencionesCFDI                integer  NOT NULL ,
	EsBenefEfectDelCobro Varchar(2)  NOT NULL ,
	Pais_id              Int  NULL ,
	ConceptoPago         Varchar(1)  NOT NULL ,
	DescripcionConcepto  varchar(Max)  NOT NULL ,
	BeneRFC              Varchar(14)  NULL ,
	BeneCURP             Varchar(18)  NULL ,
	NomDenRazSocB        Varchar(300)  NULL ,
	BeneConceptoPago     Varchar(1)  NULL ,
	BeneDescripcionConcepto varchar(Max)  NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIPlanesRet
( 
	impRetencionesCFDI                integer  NOT NULL ,
	SistemaFinanc        char(2)  NOT NULL ,
	MontTotAportAnioInmAnterior numeric(18,4)  NOT NULL ,
	MontIntRealesDevengAniooInmAnt numeric(18,4)  NOT NULL ,
	HuboRetirosAnioInmAntPer char(2)  NOT NULL ,
	MontTotRetiradoAnioInmAntPer numeric(18,4)  NOT NULL ,
	MontTotExentRetiradoAnioInmAnt numeric(18,4)  NOT NULL ,
	MontTotExedenteAnioInmAnt numeric(18,4)  NOT NULL ,
	HuboRetirosAnioInmAnt char(2)  NOT NULL ,
	MontTotRetiradoAnioInmAnt numeric(18,4)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDIPremios
( 
	impRetencionesCFDI                integer  NOT NULL ,
	Provincia_id          int  NULL ,
	MontTotPago          numeric(18,4)  NOT NULL ,
	MontTotPagoGrav      numeric(18,4)  NOT NULL ,
	MontTotPagoExent     numeric(18,4)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go



CREATE TABLE impRetCFDISecFinan
( 
	impRetencionesCFDI                integer  NOT NULL ,
	IdFideicom           Varchar(20)  NOT NULL ,
	NomFideicom          Varchar(100)  NOT NULL ,
	DescripFideicom      varchar(300)  NOT NULL ,
	 PRIMARY KEY (impRetencionesCFDI ASC)
)
go


CREATE TABLE impRetencionesCFDI
( 
	impRetencionesCFDI   Integer Identity NOT NULL,
	Empresa_Id			 Int NOT NULL,
	Folio                integer  NOT NULL ,
	Sello                Varchar(Max)  NOT NULL ,
	NumCert              Varchar(20)  NOT NULL ,
	FechaExp             DateTime  NOT NULL 
		 DEFAULT  getdate(),
	CveRetenc            Varchar(2)  NULL ,
	DescRetenc           varchar(100)  NOT NULL ,
	Nacionalidad         Varchar(10)  NOT NULL ,
	RFC                  Varchar(14)  NOT NULL ,
	RazonSocial          varchar(300)  NOT NULL ,
	CURP                 char(18)  NOT NULL ,
	NroRegIdTrib         char(20)  NOT NULL ,
	Ejercicio            integer  NOT NULL ,
	MesIni               smallint  NOT NULL ,
	MesFin               smallint  NOT NULL ,
	montoTotOperacion    numeric(18,4)  NOT NULL ,
	montoTotGrav         numeric(18,4)  NOT NULL ,
	montoTotExent        numeric(18,4)  NOT NULL ,
	montoTotRet          numeric(18,4)  NOT NULL ,
	Cancelado            Bit  NOT NULL ,
	FechaCancelacion     DateTime  NULL 
		 DEFAULT  getdate(),
	FechaTimbre          Varchar(19)  NOT NULL ,
	SelloSAT             Varchar(Max)  NOT NULL ,
	NoCertificadoSAT     Varchar(20)  NOT NULL ,
	UUID	Char(36) NOT NULL,
	RfcProvCertif VarChar(12), 
	Leyenda VarChar(150), 
	Usuario_Id Int NOT NULL,
	FechaRegistro DateTime Default dbo.FechaActual() NOT NULL,
    PRIMARY KEY (impRetencionesCFDI)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1impRetencionesCFDI ON  impRetencionesCFDI
( 
	Folio  , Empresa_Id
)
go



ALTER TABLE impRetencionesCFDI
	ADD  FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios
go

ALTER TABLE impRetencionesCFDI
	ADD  FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas
go


ALTER TABLE impRetCFDIArrenda
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIDetalle
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIDividendos
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIEnajAccion
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIFiedeEmpr
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIOperConDeriv
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIPagosExtr
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIPagosExtr
	ADD  FOREIGN KEY (Pais_id) REFERENCES genPaises
go




ALTER TABLE impRetCFDIPlanesRet
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIPremios
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go




ALTER TABLE impRetCFDIPremios
	ADD  FOREIGN KEY (Provincia_id) REFERENCES genProvincias
go




ALTER TABLE impRetCFDISecFinan
	ADD  FOREIGN KEY (impRetencionesCFDI) REFERENCES impRetencionesCFDI(impRetencionesCFDI)
go

INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) Values(11, 'Tipo Retencion')
GO
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'01','Servicios profesionales')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'02','Regalías por derechos de autor')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'03','Autotransporte terrestre de carga')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'04','Servicios prestados por comisionistas')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'05','Arrendamiento')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'06','Enajenación de acciones.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'07','Enajenación de bienes objeto de la LIEPS, a través de mediadores, agentes,representantes, corredores, consignatarios o distribuidores')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'08','Enajenación de bienes inmuebles consignada en escritura pública')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'09','Enajenación de otros bienes, no consignada en escritura pública')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'10','Adquisición de desperdicios industriales')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'11','Adquisición de bienes consignada en escritura pública')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'12','Adquisición de otros bienes, no consignada en escritura pública')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'13','Otros retiros de AFORE.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'14','Dividendos o utilidades distribuidas.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'15','Remanente distribuible.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'16','Intereses.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'17','Arrendamiento en fideicomiso.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'18','Pagos realizados a favor de residentes en el extranjero.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'19','Enajenación de acciones u operaciones en bolsa de valores.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'20','Obtención de premios.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'21','Fideicomisos que no realizan actividades empresariales.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'22','Planes personales de retiro.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'23','Intereses reales deducibles por créditos hipotecarios.')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'24','Operaciones Financieras Derivadas de Capital')
INSERT INTO genEntidadesBasicasValor(Dominio_Id , Entidad_Id,Clave, Descripcion) Values('MX',11,'25','Otro tipo de retenciones')                                   
GO