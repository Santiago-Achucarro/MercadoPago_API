CREATE TABLE venCotizCliente
( 
	Cotizacion_Id        integer  NOT NULL ,
	RazonSocial          varchar(120)  NOT NULL ,
	Direccion1           varchar(50)  NOT NULL ,
	Direccion2           varchar(50)  NOT NULL ,
	NroExterior          varchar(10)  NOT NULL ,
	NroInterior          varchar(10)  NOT NULL ,
	Localidad            varchar(35)  NOT NULL ,
	CodigoPostal         varchar(15)  NOT NULL ,
	Provincia_Id         integer  NULL ,
	Pais_Id              integer  NULL ,
	Telefono             varchar(100)  NOT NULL ,
	CUIT                 varchar(25)  NOT NULL ,
	Email                varchar(50)  NOT NULL ,
	CONSTRAINT XPKvenCotizCliente PRIMARY KEY  CLUSTERED (Cotizacion_Id ASC)
)
go




ALTER TABLE venCotizCliente
	ADD CONSTRAINT V2R_4342 FOREIGN KEY (Cotizacion_Id) REFERENCES venCotizaciones(venCotizaciones)
go




ALTER TABLE venCotizCliente
	ADD CONSTRAINT V2R_4343 FOREIGN KEY (Provincia_Id) REFERENCES genProvincias(genProvincias)
go




ALTER TABLE venCotizCliente
	ADD CONSTRAINT V2R_4344 FOREIGN KEY (Pais_Id) REFERENCES genPaises(genPaises)
go





insert into genVersion (Version) values (506.02)