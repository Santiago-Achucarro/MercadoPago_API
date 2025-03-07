CREATE TABLE disControlesListaAdjuntos(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	PermiteAgregarArchivo Sino,
	PermiteBorrarArchivo Sino,
	MuestraDescripciones Sino,
	PermiteDescargar Sino,
	CantidadMaxima int,
	ExtensionesPermitidas varchar(40),
	TamanioMaximo int
	CONSTRAINT XPKdisControlesListaAdjuntos PRIMARY KEY (Formulario_Id, Control_Id)
) ;
GO
ALTER TABLE disControlesListaAdjuntos ADD CONSTRAINT fkControl_ControlesListaAdjuntos FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControles (Formulario_Id, Control_Id)
GO

INSERT INTO genVersion(Version) Values(514.05);

