
CREATE TABLE comProveedoresContacto
( 
	Proveed_Id           bigint  NOT NULL ,
	NroContacto          integer  NOT NULL ,
	Nombre               varchar(120)  NOT NULL ,
	Puesto               varchar(100)  NOT NULL ,
	Email                varchar(120)  NOT NULL ,
	Telefono             varchar(50)  NOT NULL ,
	Movil                varchar(30)  NOT NULL ,
	Interno              varchar(20)  NOT NULL ,
	EnvioOC              bit  NOT NULL ,
	EnvioOP              bit  NOT NULL 
)
go

ALTER TABLE comProveedoresContacto
	ADD CONSTRAINT FKcomProvContactoProv FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go

INSERT INTO genVersion(Version) Values(1098.25)
GO