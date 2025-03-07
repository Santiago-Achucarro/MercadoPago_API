CREATE TABLE disControlesBotonLupa(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	ControlAsociado_Id varchar(200) NULL,
	Icono varchar(40) NULL,
	CamposClave smallint NOT NULL,
	CantMaxRegAMostrar int NOT NULL,
	OrderBy varchar(40) NULL,
	UsaAccion Sino NOT NULL,
	Identidad_Id int NOT NULL,
	Filtros varchar(250) NULL,
	AdicionalesCampos varchar(250) NULL,
	AdicionalesControles varchar(250) NULL,
	AdicionalesParametros varchar(250) NULL
	CONSTRAINT XPKdisControlesBotonLupa PRIMARY KEY CLUSTERED (Formulario_Id,Control_Id)
)
GO


ALTER TABLE disControlesBotonLupa ADD FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControles (Formulario_Id, Control_Id)
GO


ALTER TABLE disControlesBotonLupa ADD FOREIGN KEY (Identidad_Id) REFERENCES lupIdentidades (lupIdentidades)
GO

ALTER TABLE disControlesBoton ADD FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControles (Formulario_Id, Control_Id)
GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1012.05);
GO


