Create table espColoresKSK
(
Color_Id varChar(10) Not Null,
Descripcion varChar(50) Not Null,
Inactivo bit Not Null,
CONSTRAINT XPKespColoresKSK PRIMARY KEY CLUSTERED (Color_Id ASC)
)
Go

Create table espTallesKSK
(
Talle_Id varChar(10) Not Null,
Descripcion varChar(50) Not Null,
Inactivo bit Not Null,
CONSTRAINT XPKespTallesKSK PRIMARY KEY CLUSTERED (Talle_Id ASC)
)
Go

Create table espProductosColorTallaKSK
(
Producto_Id Int Not Null,
Color_Id varChar(10) Not Null,
Talle_Id varChar(10) Not Null,
CONSTRAINT XPKespProductosColorTallaKSK PRIMARY KEY CLUSTERED (Producto_Id ASC)
)
Go

ALTER TABLE espProductosColorTallaKSK
	ADD CONSTRAINT KSK_87 FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
go