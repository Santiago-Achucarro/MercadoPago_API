IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 599.05)
begin
CREATE TABLE disControlesGrillaPivot(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	URLServidor varchar(200) NOT NULL,
	Catalogo varchar(100) NOT NULL,
	Cubo varchar(100) NOT NULL,
	Measures varchar(200) NOT NULL,
	Filas varchar(200) NOT NULL,
	Columnas varchar(200) NOT NULL,
	CONSTRAINT XPKdisControlesGrillaPivot PRIMARY KEY CLUSTERED 
	(
		Formulario_Id ASC,
		Control_Id ASC
	)
);


ALTER TABLE disControlesGrillaPivot ADD FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControles (Formulario_Id, Control_Id);

INSERT INTO genVersion(Version) Values(599.05);

end
GO



