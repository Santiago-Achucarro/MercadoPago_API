--DROP TABLE sisFormulariosDocumentosRTF
--DROP TABLE sisDocumentosRTF
--DROP TABLE sisFormularios
--GO
CREATE TABLE sisDocumentosRTF(
	sisDocumentosRTF int IDENTITY(1,1) NOT NULL,
	Nombre varchar(40) NOT NULL,
	Descripcion varchar(80) NULL,
	Contenido varchar(max) NULL,
	PRIMARY KEY CLUSTERED (sisDocumentosRTF)
) 
GO

CREATE TABLE sisFormularios(
	sisFormularios int IDENTITY(1,1) NOT NULL,
	Nombre varchar(40) NOT NULL,
	Descripcion varchar(80) NULL,
	PRIMARY KEY CLUSTERED (sisFormularios)
) 
GO

CREATE TABLE sisFormulariosDocumentosRTF(
	sisDocumentosRTF int NOT NULL,
	sisFormularios int NOT NULL,
	PRIMARY KEY CLUSTERED (sisDocumentosRTF, sisFormularios)
) 
GO

ALTER TABLE SisFormulariosDocumentosRTF ADD CONSTRAINT fkFormulario_sisFormulariosDocumentosRTF FOREIGN KEY (sisFormularios) REFERENCES sisFormularios(sisFormularios)
ALTER TABLE SisFormulariosDocumentosRTF ADD CONSTRAINT fkdocumentoRTF_sisFormulariosDocumentosRTF FOREIGN KEY (sisDocumentosRTF) REFERENCES sisDocumentosRTF(sisDocumentosRTF)
GO
