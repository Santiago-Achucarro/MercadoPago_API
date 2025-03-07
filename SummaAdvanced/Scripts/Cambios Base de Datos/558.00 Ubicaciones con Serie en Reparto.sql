CREATE TABLE venRepaPediSerieUbi
( 
	venReparto           integer  NOT NULL ,
	Renglon_Rep          integer  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Renglon_Pe           integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Ubicacion_Id         integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKvenRepaPediSerieUbi PRIMARY KEY  CLUSTERED (venReparto ASC,Renglon_Rep ASC,venPedidos ASC,Renglon_Pe ASC,Serie ASC,Ubicacion_Id ASC)
)
go




ALTER TABLE venRepaPediSerieUbi
	ADD CONSTRAINT V2R_4493 FOREIGN KEY (venReparto,Renglon_Rep,venPedidos,Renglon_Pe,Serie) REFERENCES venRepaPediSerie(venReparto,Renglon_Rep,venPedidos,Renglon_Pe,Serie)
go




ALTER TABLE venRepaPediSerieUbi
	ADD CONSTRAINT V2R_4494 FOREIGN KEY (Ubicacion_Id) REFERENCES stkUbicaciones(stkUbicaciones)
go


INSERT INTO genVersion (Version) Values(558.00)
GO