IF (NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = (54.05)))
BEGIN
CREATE TABLE disAccionesTablasaEnviar(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	TipoEvento varchar(30) NOT NULL,
	OrdenAccion smallint NOT NULL,
	Tabla_Id varchar(40) NOT NULL,
	CONSTRAINT [XPKdisAccionesTablasaEnviar] PRIMARY KEY CLUSTERED 
	(Formulario_Id,	Control_Id,	TipoEvento,	OrdenAccion, Tabla_Id)
);


ALTER TABLE disAccionesTablasaEnviar
	ADD FOREIGN KEY (Formulario_Id,	Control_Id,	TipoEvento,	OrdenAccion) REFERENCES disAcciones (Formulario_Id,	Control_Id,	TipoEvento,	OrdenAccion);

ALTER TABLE	disFormularios ADD DllCommonEsp varchar(80) NULL;
ALTER TABLE	disFormularios ADD ClaseCommonEsp varchar(80) NULL;
ALTER TABLE	disFormularios ADD DllExchangeEsp varchar(80) NULL;
ALTER TABLE	disFormularios ADD ClaseExchangeEsp varchar(80) NULL;
ALTER TABLE	disFormularios ADD ClaseEnumEsp varchar(80) NULL;
ALTER TABLE	disFormularios ADD DllEventosEsp varchar(80) NULL;
ALTER TABLE	disFormularios ADD ClaseEventosEsp varchar(80) NULL;

ALTER TABLE	disTablas ADD EsEspecializacion bit default 0 NOT NULL;
ALTER TABLE	disTablasColumnas ADD EsEspecializacion bit default 0 NOT NULL;

ALTER TABLE disAcciones ADD EsEspecializacion bit default 0 NOT NULL;
ALTER TABLE disAcciones ADD AdicionalInfo varchar(80) NULL;

END

IF (NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = (54.05)))
BEGIN
	INSERT INTO genVersion(Version) Values(54.05);
END
