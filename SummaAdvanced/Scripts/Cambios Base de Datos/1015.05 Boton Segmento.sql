CREATE TABLE disControlesBotonSegmento(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	ControlAsociado_Id varchar(200) NULL,
	Icono varchar(40) NULL,
	Identidad_Id int NOT NULL,
	Filtros varchar(250) NULL,
	CONSTRAINT XPKdisControlesBotonSegmento PRIMARY KEY CLUSTERED (Formulario_Id,Control_Id)
)
GO


ALTER TABLE disControlesBotonSegmento ADD FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControles (Formulario_Id, Control_Id)
GO


ALTER TABLE disControlesBotonSegmento ADD FOREIGN KEY (Identidad_Id) REFERENCES lupIdentidades (lupIdentidades)
GO

ALTER TABLE disControlesBotonSegmento ADD FOREIGN KEY (Formulario_Id, ControlAsociado_Id) REFERENCES disControles (Formulario_Id, Control_Id)
GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1015.05);
GO


