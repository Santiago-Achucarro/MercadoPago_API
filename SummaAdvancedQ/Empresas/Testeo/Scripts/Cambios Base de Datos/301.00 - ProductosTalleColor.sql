Create table espProductosColorTalleTest
(
Producto_Id Int Not Null,
Color_Id Int Not Null,
Talle_Id Int Not Null,
CONSTRAINT XPKespProductosColorTallaTest 
PRIMARY KEY CLUSTERED (Producto_Id ASC)
)
GO

ALTER TABLE espProductosColorTalleTest
	ADD CONSTRAINT Test_87 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go

ALTER TABLE espProductosColorTalleTest
	ADD CONSTRAINT Test_88 FOREIGN KEY (Color_Id) REFERENCES espstkColorTest(espstkColorTest)
go

ALTER TABLE espProductosColorTalleTest
	ADD CONSTRAINT Test_89 FOREIGN KEY (Talle_Id) REFERENCES espstkTalleTest(espstkTalleTest)
go

Insert Into genVersionEmpresas (Version) Values (301)
