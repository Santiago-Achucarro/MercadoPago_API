Alter table tesIdentifica Add OrdenPtoVta Int null
Go

INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('T3','Tarjetas_de_Clientes')

CREATE TABLE tesIdTarjetas3
( 
	Cartera_Id           integer  NOT NULL ,
	MaxCuotas            integer  NOT NULL ,
	Banco_Id             integer  NULL ,
	TipoTarjeta          integer  NULL ,
	CONSTRAINT XPKtesIdTarjetas3 PRIMARY KEY  CLUSTERED (Cartera_Id ASC)
)
go



CREATE TABLE tesIdTarjetasTipo
( 
	tesIdTarjetasTipo    integer IDENTITY ( 1,1 ) ,
	TipoTarjeta          varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Clase                varchar(20)  NOT NULL ,
	Usuario_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	CONSTRAINT XPKtesIdTarjetasTipo PRIMARY KEY  CLUSTERED (tesIdTarjetasTipo ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesIdTarjetasTipo ON tesIdTarjetasTipo
( 
	TipoTarjeta           ASC
)
go



CREATE TABLE tesT3Link
( 
	tesMovimientos       bigint  NOT NULL ,
	conRenglon           integer  NOT NULL ,
	tesTarjetas3         integer  NULL ,
	Secuencia            integer  NOT NULL ,
	Estado               char(1)  NULL ,
	CONSTRAINT XPKtesT3Link PRIMARY KEY  CLUSTERED (tesMovimientos ASC,conRenglon ASC)
)
go



CREATE TABLE tesT3Promociones
( 
	tesT3Promociones     integer IDENTITY ( 1,1 ) ,
	Promocion_Id         integer  NOT NULL ,
	Descripcion          varchar(100)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	VigenciaDesde        qFecha ,
	VigenciaHasta        qFecha ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKtesT3Promociones PRIMARY KEY  CLUSTERED (tesT3Promociones ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesT3Promociones ON tesT3Promociones
( 
	Promocion_Id          ASC
)
go



CREATE TABLE tesT3PromocionesCuotas
( 
	tesT3Promociones     integer  NOT NULL ,
	Cuota                integer  NOT NULL ,
	Coeficiente          qCantidadD8 ,
	CONSTRAINT XPKtesT3PromocionesCuotas PRIMARY KEY  CLUSTERED (tesT3Promociones ASC,Cuota ASC)
)
go



CREATE TABLE tesT3TerminalComercio
( 
	Terminal_Id          integer  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	Comercio_Id          integer  NOT NULL ,
	CONSTRAINT XPKtesT3TerminalComercio PRIMARY KEY  CLUSTERED (Terminal_Id ASC,Cartera_Id ASC)
)
go



CREATE TABLE tesT3Terminales
( 
	tesT3Terminales      integer IDENTITY ( 1,1 ) ,
	Terminal_Id          integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Sucursal             integer  NULL ,
	Cartera_Id           integer  NULL ,
	Inactivo             Sino ,
	Posteado             Sino ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKtesT3Terminales PRIMARY KEY  CLUSTERED (tesT3Terminales ASC)
)
go



CREATE UNIQUE NONCLUSTERED INDEX XAK1tesT3Terminales ON tesT3Terminales
( 
	Terminal_Id           ASC
)
go



CREATE TABLE tesTarjetas3
( 
	tesTarjetas3         integer IDENTITY ( 1,1 ) ,
	Cartera_Id           integer  NULL ,
	Estado               char(1)  NULL ,
	Cuotas               integer  NOT NULL ,
	Cupon                integer  NOT NULL ,
	Lote                 integer  NOT NULL ,
	Comercio             integer  NOT NULL ,
	CONSTRAINT XPKtesTarjetas3 PRIMARY KEY  CLUSTERED (tesTarjetas3 ASC)
)
go



CREATE TABLE tesTarjetas3Estado
( 
	Estado               char(1)  NOT NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	CONSTRAINT XPKtesTarjetas3Estado PRIMARY KEY  CLUSTERED (Estado ASC)
)
go



CREATE TABLE tesTarjetasPromociones
( 
	Cartera_Id           integer  NOT NULL ,
	Promocion_Id         integer  NOT NULL ,
	CONSTRAINT XPKtesTarjetasPromociones PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Promocion_Id ASC)
)
go



ALTER TABLE tesIdTarjetas3
	ADD CONSTRAINT V2R_4690 FOREIGN KEY (Cartera_Id) REFERENCES tesIdentifica(tesIdentifica)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesIdTarjetas3
	ADD CONSTRAINT V2R_4696 FOREIGN KEY (Banco_Id) REFERENCES tesBancos(tesBancos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesIdTarjetas3
	ADD CONSTRAINT V2R_4699 FOREIGN KEY (TipoTarjeta) REFERENCES tesIdTarjetasTipo(tesIdTarjetasTipo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesIdTarjetasTipo
	ADD CONSTRAINT V2R_4697 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesIdTarjetasTipo
	ADD CONSTRAINT V2R_4698 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Link
	ADD CONSTRAINT V2R_4693 FOREIGN KEY (tesMovimientos,conRenglon) REFERENCES tesRengMovi(tesMovimientos,conRenglon)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Link
	ADD CONSTRAINT V2R_4694 FOREIGN KEY (tesTarjetas3) REFERENCES tesTarjetas3(tesTarjetas3)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Link
	ADD CONSTRAINT V2R_4695 FOREIGN KEY (Estado) REFERENCES tesTarjetas3Estado(Estado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Promociones
	ADD CONSTRAINT V2R_4707 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Promociones
	ADD CONSTRAINT V2R_4708 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3PromocionesCuotas
	ADD CONSTRAINT V2R_4709 FOREIGN KEY (tesT3Promociones) REFERENCES tesT3Promociones(tesT3Promociones)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3TerminalComercio
	ADD CONSTRAINT V2R_4705 FOREIGN KEY (Terminal_Id) REFERENCES tesT3Terminales(tesT3Terminales)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3TerminalComercio
	ADD CONSTRAINT V2R_4706 FOREIGN KEY (Cartera_Id) REFERENCES tesIdTarjetas3(Cartera_Id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Terminales
	ADD CONSTRAINT V2R_4700 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Terminales
	ADD CONSTRAINT V2R_4701 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Terminales
	ADD CONSTRAINT V2R_4702 FOREIGN KEY (Sucursal) REFERENCES genSucursalesEmpr(genSucursalesEmpr)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesT3Terminales
	ADD CONSTRAINT V2R_4704 FOREIGN KEY (Cartera_Id) REFERENCES tesIdBancoPropio(Cartera_Id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesTarjetas3
	ADD CONSTRAINT V2R_4691 FOREIGN KEY (Cartera_Id) REFERENCES tesIdTarjetas3(Cartera_Id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesTarjetas3
	ADD CONSTRAINT V2R_4692 FOREIGN KEY (Estado) REFERENCES tesTarjetas3Estado(Estado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesTarjetasPromociones
	ADD CONSTRAINT V2R_4710 FOREIGN KEY (Cartera_Id) REFERENCES tesIdTarjetas3(Cartera_Id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE tesTarjetasPromociones
	ADD CONSTRAINT V2R_4711 FOREIGN KEY (Promocion_Id) REFERENCES tesT3Promociones(tesT3Promociones)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go





Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASLISTASPRECIOS', 'TARJETA', 'Importe_a_incrementar_por_intereres_a_la_factura', 103, 'N')
Go


INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor)
	VALUES(1, 'GENWSPA4TOKEN','Token consulta de padrón A4', 'M',5,0,'VEN', 0, null, null, NULL, NULL, Null, '')	
Go

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor)
	VALUES(1, 'GENWSPA4SIGN','Sign consulta de padrón A4', 'M',5,0,'VEN', 0, null, null, NULL, NULL, Null, '')	
Go

Insert Into genVersion (Version) Values (1048.10)
go
