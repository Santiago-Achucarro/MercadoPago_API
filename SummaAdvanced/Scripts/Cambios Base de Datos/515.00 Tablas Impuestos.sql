
CREATE TABLE impFormulas
( 
	impImpuestos         integer  NOT NULL ,
	Renglon              smallint  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	Detalle              varchar(80)  NOT NULL ,
	DebeHaberAmbos       char(1)  NOT NULL ,
	CONSTRAINT XPKimpFormulas PRIMARY KEY  CLUSTERED (impImpuestos ASC,Renglon ASC)
)
go



CREATE TABLE impImpuestos
( 
	impImpuestos         integer IDENTITY ( 1,1 ) ,
	Impuesto_Id          varchar(5)  NOT NULL ,
	Empresa_Id			 Int, 
	Descripcion          varchar(60)  NOT NULL ,
	Posteado             Sino ,
	Inactivo             Sino ,
	TipoVencimiento      varchar(3)  NOT NULL ,
	DiaMesVence          smallint  NOT NULL ,
	AvisarNDias          smallint  NOT NULL ,
	ProximoVencimiento   qFecha ,
	CtaHaber_Id          integer  NULL ,
	CtaDebe_Id           integer  NULL ,
	PagoAnticipado       Sino ,
	SePaga               Sino ,
	VaAlCashFlow         Sino ,
	LiquidadoHasta       qFecha ,
	CONSTRAINT XPKimpImpuestos PRIMARY KEY  CLUSTERED (impImpuestos ASC)
)
go



CREATE TABLE impLiquidacion
( 
	conAsientos          bigint  NOT NULL ,
	Impuesto_Id          integer  NOT NULL ,
	FechaDesde           qFecha ,
	FechaHasta           qFecha ,
	FechaPago            qFecha ,
	TotalAPagar          numeric(20,2)  NOT NULL ,
	Saldo                numeric(20,2)  NOT NULL ,
	CONSTRAINT XPKimpLiquidacion PRIMARY KEY  CLUSTERED (conAsientos ASC)
)
go



CREATE TABLE tesMoviImp
( 
	tesMovimientos       bigint  NOT NULL ,
	conAsientos          bigint  NULL ,
	CONSTRAINT XPKtesMoviImp PRIMARY KEY  CLUSTERED (tesMovimientos ASC)
)
go




ALTER TABLE impFormulas
	ADD CONSTRAINT V2R_4265 FOREIGN KEY (impImpuestos) REFERENCES impImpuestos(impImpuestos)
go




ALTER TABLE impFormulas
	ADD CONSTRAINT V2R_4266 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE impImpuestos
	ADD CONSTRAINT V2R_4262 FOREIGN KEY (CtaHaber_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE impImpuestos
	ADD CONSTRAINT V2R_4263 FOREIGN KEY (CtaDebe_Id) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE impLiquidacion
	ADD CONSTRAINT V2R_4267 FOREIGN KEY (conAsientos) REFERENCES conAsientos(conAsientos)
go




ALTER TABLE impLiquidacion
	ADD CONSTRAINT V2R_4268 FOREIGN KEY (Impuesto_Id) REFERENCES impImpuestos(impImpuestos)
go




ALTER TABLE tesMoviImp
	ADD CONSTRAINT V2R_4269 FOREIGN KEY (tesMovimientos) REFERENCES tesMovimientos(tesMovimientos)
go




ALTER TABLE tesMoviImp
	ADD CONSTRAINT V2R_4270 FOREIGN KEY (conAsientos) REFERENCES impLiquidacion(conAsientos)
go


ALTER TABLE impImpuestos
	ADD CONSTRAINT V2R_4273 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go


insert into genVersion (Version) Values(515.00)