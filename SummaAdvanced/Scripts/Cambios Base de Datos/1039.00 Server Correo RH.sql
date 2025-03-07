Alter Table genEmpresas ADD	ServidorRH           varchar(100)  NULL ,
	PuertoRH               integer  NULL ,
	CorreoRH               varchar(200)  NULL ,
	UsuarioCorreoRH        varchar(100)  NULL ,
	ClaveRH                varchar(100)  NULL ,
	SeguridadRH            varchar(3)  NULL ,
	UsaServerRH Bit Default 0 NOT NULL
GO


INSERT INTO genVersion (Version) Values(1039.00)
GO