CREATE TABLE venMovimientosPreTimbrados
( 
	venMovimientos       bigint  NOT NULL ,
	Sucursal             integer  NULL ,
	Comprobante_Id       integer  NULL ,
	Segmento1N           bigint  NOT NULL ,
	Detalle              QMemo ,
	CONSTRAINT XPKvenMovimientosPreTimbrados PRIMARY KEY  CLUSTERED (venMovimientos ASC)
)
go


ALTER TABLE venMovimientosPreTimbrados
	ADD CONSTRAINT V2R_4792 FOREIGN KEY (venMovimientos) REFERENCES venMovimientos(venMovimientos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go





ALTER TABLE venMovimientosPreTimbrados
	ADD CONSTRAINT V2R_4793 FOREIGN KEY (Sucursal) REFERENCES genSucursalesEmpr(genSucursalesEmpr)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venMovimientosPreTimbrados
	ADD CONSTRAINT V2R_4794 FOREIGN KEY (Comprobante_Id) REFERENCES genTiposCompAfip(Comprobante_Id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


CREATE UNIQUE NONCLUSTERED INDEX XAK1venMovimientosPreTimbrados ON venMovimientosPreTimbrados
( 
	Sucursal              ASC,
	Comprobante_Id        ASC,
	Segmento1N            ASC
)
go

Insert Into genVersion (Version) Values (1113.10)
Go
