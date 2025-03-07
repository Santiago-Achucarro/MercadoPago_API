CREATE TABLE espstkTalleTt
( 
	espstkTalleTt      integer IDENTITY ,
	Talle_Id           varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKespstkTalleTt PRIMARY KEY  CLUSTERED (espstkTalleTt ASC)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1espstkTalleTt ON espstkTalleTt
( 
	Talle_Id            ASC
)
go

ALTER TABLE espstkTalleTt
	ADD CONSTRAINT FKespstkTalleTtUsu FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE espstkTalleTt
	ADD CONSTRAINT FKespstkTalleTtUsuEmpre FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
------------------------------
CREATE TABLE espstkColorTt
( 
	espstkColorTt      integer IDENTITY ,
	Color_Id           varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKespstkColorTt PRIMARY KEY  CLUSTERED (espstkColorTt ASC)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1espstkColorTt ON espstkColorTt
( 
	Color_Id            ASC
)
go

ALTER TABLE espstkColorTt
	ADD CONSTRAINT FKespstkColorUsuTt FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE espstkColorTt
	ADD CONSTRAINT FKespstkColorTtUsuEmpre FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

------------------------------
Create table espProductosColorTalleTt
(
Producto_Id Int Not Null,
Talle_Id Int Not Null,
Color_Id Int Not Null,
CONSTRAINT XPKespProductosColorTalleTt PRIMARY KEY CLUSTERED (Producto_Id ASC)
)
Go

Alter table espProductosColorTalleTt
	ADD CONSTRAINT FKespProductosColorTalleTtP FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Alter table espProductosColorTalleTt
	ADD CONSTRAINT FKespProductosColorTalleTtC FOREIGN KEY (Color_Id) REFERENCES espstkColorTt(espstkColorTt)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Alter table espProductosColorTalleTt
	ADD CONSTRAINT FKespProductosColorTalleTtT FOREIGN KEY (Talle_Id) REFERENCES espstkTalleTt(espstkTalleTt)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert Into genVersionEmpresas (Version) Values (400)


