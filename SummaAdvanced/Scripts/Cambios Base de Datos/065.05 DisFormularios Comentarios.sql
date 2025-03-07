IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 65.05)
begin
CREATE TABLE disFormulariosComentarios(
	Formulario_Id int NOT NULL,
	FechaRegistro Datetime NOT NULL,
	FechaRegistroOrig Datetime NOT NULL,
	FechaUltModif Datetime NOT NULL,
	Comentario QMemo NOT NULL, 
	FormularioRegOrig_Id int,  
    CONSTRAINT XPKdisFormulariosComentarios PRIMARY KEY (Formulario_Id, FechaRegistro)
) ;

ALTER TABLE disFormulariosComentarios ADD CONSTRAINT fkform_disFormulariosComentarios FOREIGN KEY (Formulario_Id) REFERENCES disFormularios (disFormularios)
end
GO


IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 65.05)
begin
INSERT INTO genVersion(Version) Values(65.05);
end
GO

