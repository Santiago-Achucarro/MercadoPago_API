
INSERT INTO genVersion (Version) Values(54.000)

ALTER TABLE genInstalacion ADD Licencia VarChar(36)
ALTER TABLE genInstalacion add Clave VarChar(max) 
ALTER TABLE genInstalacion ADD FechaVencimiento DateTime
GO

Update genInstalacion SET Licencia = NEWID()
GO


CREATE TABLE genUsuariosLogueados(
	Usuario_Id Int NOT NULL, 
	UltEmpresa Int NOT NULL, 
	FechaLogin DateTime NOT NULL, 
	Caduca DateTime NOT NULL, 
	Token VarChar(36) NOT NULL,
	primary key(Token))

GO


