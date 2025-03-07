
CREATE TABLE stkInventDespacho
( 
	stkInventarios       integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Despacho_Id         integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkInventDespacho PRIMARY KEY  CLUSTERED (stkInventarios ASC,Producto_Id ASC,Despacho_Id ASC)
)
go



CREATE TABLE stkInventSerie
( 
	stkInventarios       integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkInventSerie PRIMARY KEY  CLUSTERED (stkInventarios ASC,Producto_Id ASC,Serie ASC)
)
go


ALTER TABLE stkInventDespacho
	ADD CONSTRAINT V2R_4685 FOREIGN KEY (stkInventarios,Producto_Id) REFERENCES stkInventCuerpo(stkInventarios,Producto_Id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE stkInventDespacho
	ADD CONSTRAINT V2R_4686 FOREIGN KEY (Despacho_Id) REFERENCES comDespachos(comDespachos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE stkInventSerie
	ADD CONSTRAINT V2R_4687 FOREIGN KEY (stkInventarios,Producto_Id) REFERENCES stkInventCuerpo(stkInventarios,Producto_Id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert into genVersion (Version) Values (1033.10)
Go

