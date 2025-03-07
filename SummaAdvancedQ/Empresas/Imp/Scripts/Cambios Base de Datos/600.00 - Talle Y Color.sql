CREATE TABLE espstkTalleImp
( 
	espstkTalleImp      integer IDENTITY ,
	Talle_Id           varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKespstkTalleImp PRIMARY KEY  CLUSTERED (espstkTalleImp ASC)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1espstkTalleImp ON espstkTalleImp
( 
	Talle_Id            ASC
)
go

ALTER TABLE espstkTalleImp
	ADD CONSTRAINT FKespstkTalleImpUsu FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE espstkTalleImp
	ADD CONSTRAINT FKespstkTalleImpUsuEmpre FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
------------------------------
CREATE TABLE espstkColorImp
( 
	espstkColorImp      integer IDENTITY ,
	Color_Id           varchar(15)  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(35)  NOT NULL ,
	Inactivo             Sino ,
	Usuario_Id           integer  NOT NULL ,
	Posteado             Sino ,
	CONSTRAINT XPKespstkColorImp PRIMARY KEY  CLUSTERED (espstkColorImp ASC)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1espstkColorImp ON espstkColorImp
( 
	Color_Id            ASC
)
go

ALTER TABLE espstkColorImp
	ADD CONSTRAINT FKespstkColorUsuImp FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE espstkColorImp
	ADD CONSTRAINT FKespstkColorImpUsuEmpre FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

------------------------------
Create table espProductosColorTalleImp
(
Producto_Id Int Not Null,
Talle_Id Int Not Null,
Color_Id Int Not Null,
CONSTRAINT XPKespProductosColorTalleImp PRIMARY KEY CLUSTERED (Producto_Id ASC)
)
Go

Alter table espProductosColorTalleImp
	ADD CONSTRAINT FKespProductosColorTalleImpP FOREIGN KEY (Producto_Id) REFERENCES stkProductos(stkProductos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Alter table espProductosColorTalleImp
	ADD CONSTRAINT FKespProductosColorTalleImpC FOREIGN KEY (Color_Id) REFERENCES espstkColorImp(espstkColorImp)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Alter table espProductosColorTalleImp
	ADD CONSTRAINT FKespProductosColorTalleImpT FOREIGN KEY (Talle_Id) REFERENCES espstkTalleImp(espstkTalleImp)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Insert Into genVersionEmpresas (Version) Values (600)


