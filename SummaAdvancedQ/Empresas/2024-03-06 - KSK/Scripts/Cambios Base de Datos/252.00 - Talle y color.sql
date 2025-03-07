CREATE TABLE espstkTalleTest
( 
	espstkTalleTest      integer IDENTITY ,
	Talle_Id           varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKespstkTalleTest PRIMARY KEY  CLUSTERED (espstkTalleTest ASC)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1espstkTalleTest ON espstkTalleTest
( 
	Talle_Id            ASC
)
go

ALTER TABLE espstkTalleTest
	ADD CONSTRAINT FKespstkTalleTestUsu FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE espstkTalleTest
	ADD CONSTRAINT FKespstkTalleTestUsuEmpre FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
------------------------------
CREATE TABLE espstkColorTest
( 
	espstkColorTest      integer IDENTITY ,
	Color_Id           varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKespstkColorTest PRIMARY KEY  CLUSTERED (espstkColorTest ASC)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1espstkColorTest ON espstkColorTest
( 
	Color_Id            ASC
)
go

ALTER TABLE espstkColorTest
	ADD CONSTRAINT FKespstkColorUsuTest FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE espstkColorTest
	ADD CONSTRAINT FKespstkColorTestUsuEmpre FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

------------------------------
Create table espProductosColorTalleTest
(
Producto_Id Int Not Null,
Talle_Id Int Not Null,
Color_Id Int Not Null,
CONSTRAINT XPKespProductosColorTalleTest PRIMARY KEY CLUSTERED (Producto_Id ASC)
)
Go

Alter table espProductosColorTalleTest
	ADD CONSTRAINT FKespProductosColorTalleTestP FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Alter table espProductosColorTalleTest
	ADD CONSTRAINT FKespProductosColorTalleTestC FOREIGN KEY (Color_Id) REFERENCES espstkColorTest(espstkColorTest)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Alter table espProductosColorTalleTest
	ADD CONSTRAINT FKespProductosColorTalleTestT FOREIGN KEY (Talle_Id) REFERENCES espstkTalleTest(espstkTalleTest)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert Into genVersionEmpresas (Version) Values (252)


