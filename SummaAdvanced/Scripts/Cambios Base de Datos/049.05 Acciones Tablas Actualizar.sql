IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 49.05)
begin

	Create Table disAccionesTablasaActualizar(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	TipoEvento varchar(30) NOT NULL,
	OrdenAccion smallint NOT NULL,
	Tabla_Id varchar(40) NOT NULL,
	CONSTRAINT [XPKdisAccionesTablasaActualizar] PRIMARY KEY CLUSTERED 
	(Formulario_Id,	Control_Id,	TipoEvento,	OrdenAccion, Tabla_Id)
);

ALTER TABLE disAccionesTablasaActualizar
	ADD FOREIGN KEY (Formulario_Id,	Control_Id,	TipoEvento,	OrdenAccion) REFERENCES disAcciones (Formulario_Id,	Control_Id,	TipoEvento,	OrdenAccion)
;
END
GO


IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 49.05)
begin
	INSERT INTO genVersion(Version) Values(49.05);
END