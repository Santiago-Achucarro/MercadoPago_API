CREATE TABLE disFormulariosConfirmados (
Formulario_Id int NOT NULL,
Confirmado bit NOT NULL,
Comentario varchar(max),
CONSTRAINT XPKdisFormulariosConfirmados PRIMARY KEY (Formulario_Id)
)

GO
INSERT INTO genVersion (Version) VALUES(1120.05)
GO