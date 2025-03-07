CREATE TABLE stkProductosCombo
( 
	Combo_Id             integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Cantidad             qCantidadD8 ,
	CONSTRAINT XPKstkProductosCombo PRIMARY KEY  CLUSTERED (Combo_Id ASC,Producto_Id ASC)
)
go



ALTER TABLE stkProductosCombo
	ADD CONSTRAINT V2R_4434 FOREIGN KEY (Combo_Id) REFERENCES stkProductos(stkProductos)
go




ALTER TABLE stkProductosCombo
	ADD CONSTRAINT V2R_4435 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go

INSERT INTO genVersion (Version) Values(545.00)
GO
