

CREATE TABLE disControlesGrafico(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	SubTitulo varchar(50),
	Leyenda varchar(10),
	Tipo varchar(30) NOT NULL,
	SubTipo varchar(30) NOT NULL,
	PermiteCambiarSubTipo bit,
	TituloEjevalores varchar(80),
	CONSTRAINT XPKdisControlesGrafico PRIMARY KEY (Formulario_Id, Control_Id)
) ;
GO
ALTER TABLE disControlesGrafico ADD CONSTRAINT fkControl_ControlesGrafico FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControles (Formulario_Id, Control_Id)
GO


CREATE TABLE disControlesGraficoTorta(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	ValoresASeparar smallint,
	UbicacionTituloPorcion varchar(40) NOT NULL,
	FormatoTituloPorcion varchar(10) NOT NULL,
	CONSTRAINT XPKdisControlesGraficoTorta PRIMARY KEY (Formulario_Id, Control_Id)
) ;
GO
ALTER TABLE disControlesGraficoTorta ADD CONSTRAINT fkControl_ControlesGraficoTorta FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControlesGrafico (Formulario_Id, Control_Id)
GO

INSERT INTO genVersion(Version) Values(509.05);

