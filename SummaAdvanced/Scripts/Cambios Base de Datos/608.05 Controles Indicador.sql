IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 608.05)
begin
CREATE TABLE disControlesIndicador(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	Tipo varchar(30) NOT NULL,
	CONSTRAINT XPKdisControlesIndicador PRIMARY KEY CLUSTERED 
	(
		Formulario_Id ASC,
		Control_Id ASC
	)
);


ALTER TABLE disControlesIndicador ADD FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControles (Formulario_Id, Control_Id);

INSERT INTO genVersion(Version) Values(608.05);

end
GO



