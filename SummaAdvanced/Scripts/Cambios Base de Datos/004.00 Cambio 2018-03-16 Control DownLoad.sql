IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 4.0)
begin

insert into genVersion (Version) Values (4.0)
GO

DROP TABLE disControlesDownLoad
GO
CREATE TABLE disControlesDownLoad(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	CarpetaServidor varchar(200) NOT NULL,
	ArchivoADescargar varchar(200) NOT NULL,
	ArchivoDescargado varchar(200) NOT NULL,   
    CONSTRAINT XPKdisControlesDownLoad PRIMARY KEY (Formulario_Id ASC, Control_Id ASC)
) ON [PRIMARY]

GO

ALTER TABLE disControlesDownLoad ADD CONSTRAINT fkControl_disControlesDownLoad FOREIGN KEY (Formulario_Id, Control_Id) REFERENCES disControles (Formulario_Id, Control_Id)
end
GO


