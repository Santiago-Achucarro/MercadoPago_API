ALTER TABLE stkDepositos add  UsaUbicacion SiNo null
GO
UPDATE stkDepositos SET UsaUbicacion = 0
GO

ALTER TABLE stkDepositos ALTER COLUMN UsaUbicacion SiNo NOT NULL
GO



CREATE TABLE stkExistenciaUbi
( 
	Empresa_Id           integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CantidadReservada    qCantidadD8 ,
	CantidadAlterna      qCantidadD8 ,
	CONSTRAINT XPKstkExistenciaUbi PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Producto_Id ASC,Deposito_Id ASC,Ubicacion_Id ASC)
)
go



CREATE TABLE stkMoviUbicacion
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad           qCantidadD8 ,
	CantidadAlterna      qCantidadD8 ,
	CONSTRAINT XPKstkMoviUbicacion PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC,Ubicacion_Id ASC)
)
go



CREATE TABLE stkUbicaciones
( 
	stkUbicaciones       integer IDENTITY ( 1,1 ) ,
	Ubicacion_Id         varchar(25)  NOT NULL ,
	Capacidad            QCantidad ,
	Usuario_Id           integer  NULL ,
	Inactivo             Sino ,
	CONSTRAINT XPKstkUbicaciones PRIMARY KEY  CLUSTERED (stkUbicaciones ASC)
)
go


CREATE UNIQUE NONCLUSTERED INDEX XAK1stkUbicaciones ON stkUbicaciones
( 
	Ubicacion_Id          ASC
)
go



CREATE TABLE venRepaUbicacion
( 
	venReparto           integer  NOT NULL ,
	Renglon_Rep          integer  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	CantidadForm         qCantidadD8 ,
	CantidadAlternaForm  qCantidadD8 ,
	CONSTRAINT XPKvenRepaUbicacion PRIMARY KEY  CLUSTERED (venReparto ASC, Renglon_Rep ASC,venPedidos ASC,Renglon_Pe ASC,Ubicacion_Id ASC)
)
go




CREATE TABLE stkExistenciaUbiSerie
( 
	Empresa_Id           integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Deposito_Id          integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qMonedaD8 ,
	CONSTRAINT XPKstkExistenciaUbiSerie PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Producto_Id ASC,Deposito_Id ASC,Serie ASC,Ubicacion_Id ASC)
)
go


CREATE TABLE stkMoviSerieUbicacion
( 
	stkMoviCabe          bigint  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkMoviSerieUbicacion PRIMARY KEY  CLUSTERED (stkMoviCabe ASC,Renglon ASC,Serie ASC,Ubicacion_Id ASC)
)
go






ALTER TABLE stkExistenciaUbi
	ADD CONSTRAINT V2R_4450 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go


ALTER TABLE stkExistenciaUbi
	ADD CONSTRAINT V2R_4451 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go




ALTER TABLE stkExistenciaUbi
	ADD CONSTRAINT V2R_4452 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE stkExistenciaUbi
	ADD CONSTRAINT V2R_4459 FOREIGN KEY (Ubicacion_Id) REFERENCES stkUbicaciones(stkUbicaciones)
go






ALTER TABLE stkMoviUbicacion
	ADD CONSTRAINT V2R_4454 FOREIGN KEY (stkMoviCabe,Renglon) REFERENCES stkMoviCuerpo(stkMoviCabe,Renglon)
go




ALTER TABLE stkMoviUbicacion
	ADD CONSTRAINT V2R_4455 FOREIGN KEY (Ubicacion_Id) REFERENCES stkUbicaciones(stkUbicaciones)
go




ALTER TABLE stkUbicaciones
	ADD CONSTRAINT V2R_4456 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go


ALTER TABLE venRepaUbicacion
	ADD CONSTRAINT V2R_4457 FOREIGN KEY (venReparto,Renglon_Rep,venPedidos,Renglon_Pe) REFERENCES venRepaPedi(venReparto,Renglon_Rep,venPedidos,Renglon_Pe)
go



ALTER TABLE venRepaUbicacion
	ADD CONSTRAINT V2R_4458 FOREIGN KEY (Ubicacion_Id) REFERENCES stkUbicaciones(stkUbicaciones)
go



ALTER TABLE stkExistenciaUbiSerie
	ADD CONSTRAINT V2R_4483 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go



ALTER TABLE stkExistenciaUbiSerie
	ADD CONSTRAINT V2R_4484 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE stkExistenciaUbiSerie
	ADD CONSTRAINT V2R_4485 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go




ALTER TABLE stkExistenciaUbiSerie
	ADD CONSTRAINT V2R_4486 FOREIGN KEY (Ubicacion_Id) REFERENCES stkUbicaciones(stkUbicaciones)
go




ALTER TABLE stkMoviSerieUbicacion
	ADD CONSTRAINT V2R_4490 FOREIGN KEY (stkMoviCabe,Renglon,Serie) REFERENCES stkMoviSerie(stkMoviCabe,Renglon,Serie)
go




ALTER TABLE stkMoviSerieUbicacion
	ADD CONSTRAINT V2R_4491 FOREIGN KEY (Ubicacion_Id) REFERENCES stkUbicaciones(stkUbicaciones)
go






INSERT INTO genVersion (Version) Values(556.00)
GO

