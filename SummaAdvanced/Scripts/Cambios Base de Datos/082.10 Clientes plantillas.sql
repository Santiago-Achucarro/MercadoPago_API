
CREATE TABLE venClientesPlantilla
( 
	venClientesPlantilla integer IDENTITY ( 1,1 ) ,
	Plantilla_Id         varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60) NOT NULL,
	Cuit                 varchar(25)  NOT NULL ,
	TipoDoc              char(1)  NOT NULL ,
	IdFiscal             varchar(20)  NOT NULL ,
	Sucursal             integer  NOT NULL ,
	RazonSocial          varchar(120)  NOT NULL ,
	CondFisc_Id          integer  NULL ,
	LimiteCredito        qMonedaD2 ,
	MonedaLimCred        integer  NULL ,
	CategCred_Id         integer  NULL ,
	Bonificacion1        qPorcentaje ,
	Bonificacion2        qPorcentaje ,
	Bonificacion3        qPorcentaje ,
	Puntual              Sino ,
	Estado_Id            integer  NULL ,
	GeneraDebito         Sino ,
	Siempre              Sino ,
	IBrutos              varchar(20)  NOT NULL ,
	Situacion            char(1)  NOT NULL ,
	NombreFantasia       varchar(120)  NOT NULL ,
	Direccion1_Fact      varchar(50)  NOT NULL ,
	Direccion2_Fact      varchar(50)  NOT NULL ,
	Localidad_Fact       varchar(35)  NOT NULL ,
	CodPostal_Fact       varchar(15)  NOT NULL ,
	Provincia_Id_Fact    integer  NULL ,
	Pais_Id_Fact         integer  NULL ,
	Telefonos            varchar(100)  NOT NULL ,
	Fax                  varchar(50)  NOT NULL ,
	EMail                varchar(50)  NOT NULL ,
	Direccion1_Entr      varchar(50)  NOT NULL ,
	Direccion2_Entr      varchar(50)  NOT NULL ,
	Localidad_Entr       varchar(35)  NOT NULL ,
	CodPostal_Entr       varchar(15)  NOT NULL ,
	Provincia_Id_Entr    integer  NULL ,
	Pais_Id_Entr         integer  NULL ,
	TipoClie_Id          integer  NULL ,
	ListaPrecio_Id       integer  NULL ,
	FormaEntrega_Id      integer  NULL ,
	CondPagoCli_Id       integer  NULL ,
	Vendedor_Id          bigint  NULL ,
	Cobrador_Id          bigint  NULL ,
	Zona_Id              integer  NULL ,
	Region_Id            integer  NULL ,
	Contactos            varchar(50)  NOT NULL ,
	Observaciones        varchar(max)  NOT NULL ,
	Bonificacion1Suc     qPorcentaje ,
	Bonificacion2Suc     qPorcentaje ,
	Bonificacion3Suc     qPorcentaje ,
	Centro1_Id           integer  NULL ,
	Centro2_Id           integer  NULL ,
	NroExterior_Fact     varchar(10)  NOT NULL ,
	NroInterior_Fact     varchar(10)  NOT NULL ,
	NroExterior_Entr     varchar(10)  NOT NULL ,
	NroInterior_Entr     varchar(10)  NOT NULL ,
	Reclamos             varchar(150)  NOT NULL ,
	MetodoDePago         varchar(50)  NOT NULL ,
	NumCuenta            varchar(150)  NOT NULL ,
	C_UsoCFDI            varchar(3)  NOT NULL ,
	N_MetodoPago         varchar(3)  NOT NULL ,
	UsaComplementoINE    Sino ,
	InactivoCliente      Sino ,
	Posteado             Sino ,
	Inactivo             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKvenClientesPlantilla PRIMARY KEY  CLUSTERED (venClientesPlantilla ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1venClientesPlantilla ON venClientesPlantilla
( 
	Plantilla_Id          ASC
)
go



CREATE TABLE venClientesCtasPlantilla
( 
	Plantilla_Id         integer  NOT NULL ,
	Moneda_Id            integer  NOT NULL ,
	CuentaDxVtas         integer  NULL ,
	CtaFactAnticipo      integer  NULL ,
	CtaAnticipo          integer  NULL ,
	CONSTRAINT XPKvenClientesCtasPlantilla PRIMARY KEY  CLUSTERED (Plantilla_Id ASC,Moneda_Id ASC)
)
go


ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4074 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4075 FOREIGN KEY (CondFisc_Id) REFERENCES venCondFiscal(venCondFiscal)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4076 FOREIGN KEY (MonedaLimCred) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4077 FOREIGN KEY (CategCred_Id) REFERENCES venCategCredito(venCategCredito)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4078 FOREIGN KEY (Estado_Id) REFERENCES venClieEstados(venClieEstados)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4079 FOREIGN KEY (Provincia_Id_Fact) REFERENCES genProvincias(genProvincias)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4080 FOREIGN KEY (Pais_Id_Fact) REFERENCES genPaises(genPaises)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4081 FOREIGN KEY (TipoClie_Id) REFERENCES venTiposClie(venTiposClie)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4082 FOREIGN KEY (ListaPrecio_Id) REFERENCES venListasPrecios(venListasPrecios)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4083 FOREIGN KEY (FormaEntrega_Id) REFERENCES venFormaEntrega(venFormaEntrega)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4084 FOREIGN KEY (CondPagoCli_Id) REFERENCES venCondPago(venCondPago)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4085 FOREIGN KEY (Vendedor_Id) REFERENCES venVendedores(venVendedores)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4086 FOREIGN KEY (Cobrador_Id) REFERENCES venCobradores(venCobradores)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4087 FOREIGN KEY (Zona_Id) REFERENCES venZona(venZona)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4088 FOREIGN KEY (Region_Id) REFERENCES venRegion(venRegion)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4089 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4090 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4091 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4092 FOREIGN KEY (Provincia_Id_Entr) REFERENCES genProvincias(genProvincias)
go




ALTER TABLE venClientesPlantilla
	ADD CONSTRAINT R_4093 FOREIGN KEY (Pais_Id_Entr) REFERENCES genPaises(genPaises)
go







ALTER TABLE venClientesCtasPlantilla
	ADD CONSTRAINT R_4094 FOREIGN KEY (Moneda_Id) REFERENCES genMonedas(genMonedas)
go




ALTER TABLE venClientesCtasPlantilla
	ADD CONSTRAINT R_4095 FOREIGN KEY (CuentaDxVtas) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE venClientesCtasPlantilla
	ADD CONSTRAINT R_4096 FOREIGN KEY (CtaFactAnticipo) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE venClientesCtasPlantilla
	ADD CONSTRAINT R_4097 FOREIGN KEY (CtaAnticipo) REFERENCES conCuentas(conCuentas)
go




ALTER TABLE venClientesCtasPlantilla
	ADD CONSTRAINT R_4099 FOREIGN KEY (Plantilla_Id) REFERENCES venClientesPlantilla(venClientesPlantilla)
go

Insert into genVersion (Version) Values (82.10)
Go
