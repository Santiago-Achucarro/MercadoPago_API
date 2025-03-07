
CREATE TABLE proOrdenProdSerie
( 
	proOrden             integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	Serie                varchar(25)  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKproOrdenProdSerie PRIMARY KEY  CLUSTERED (proOrden ASC,Renglon ASC, Serie ASC)
)
go



ALTER TABLE proOrdenProdSerie
	ADD CONSTRAINT V21_4583 FOREIGN KEY (proOrden,Renglon) REFERENCES proOrdenProd(proOrden,Renglon)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert into genVersion (Version) Values (1025.11)
Go

