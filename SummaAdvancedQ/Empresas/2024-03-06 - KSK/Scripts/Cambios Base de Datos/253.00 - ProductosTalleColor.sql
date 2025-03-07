Create table espProductosColorTalleKSK
(
Producto_Id Int Not Null,
Color_Id Int Not Null,
Talle_Id Int Not Null,
CONSTRAINT XPKespProductosColorTallaKSK 
PRIMARY KEY CLUSTERED (Producto_Id ASC)
)
GO

ALTER TABLE espProductosColorTalleKSK
	ADD CONSTRAINT KSK_87 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go

ALTER TABLE espProductosColorTalleKSK
	ADD CONSTRAINT KSK_88 FOREIGN KEY (Color_Id) REFERENCES espstkColorKSK(espstkColorKSK)
go

ALTER TABLE espProductosColorTalleKSK
	ADD CONSTRAINT KSK_89 FOREIGN KEY (Talle_Id) REFERENCES espstkTalleKSK(espstkTalleKSK)
go

Insert Into genVersionEmpresas (Version) Values (253)
