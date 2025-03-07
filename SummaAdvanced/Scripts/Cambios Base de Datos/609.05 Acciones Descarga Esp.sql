IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 609.05)
begin
CREATE TABLE disAccionesDescargaEsp(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	TipoEvento varchar(30) NOT NULL,
	Accion varchar(30) NOT NULL,
	ControlDestino_Id varchar(200) NULL,
	Texto varchar(256) NOT NULL
);

INSERT INTO genVersion(Version) Values(609.05);

end
GO
