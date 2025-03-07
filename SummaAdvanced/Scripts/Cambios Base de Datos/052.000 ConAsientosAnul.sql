INSERT INTO genVersion (Version) VALUES (52.00)
GO

CREATE TABLE conAsientosAnul(
	Asiento_Id BIGINT not null, 
	FechaAnulacion DateTime NOT NULL, 
	Usuario_Id Int NOT NULL, 
	TipoEnvio Char(1) NOT NULL, 
	Primary Key(Asiento_Id))
GO

ALTER TABLE conAsientosAnul 
	add constraint fkconAsientosAnulAsi Foreign key (Asiento_Id) References conAsientos
GO	 


ALTER TABLE conAsientosAnul 
	add constraint fkconAsientosAnulUsu Foreign key (Usuario_Id) References genUsuarios
GO	 


Alter table tesCfdiCobranza ADD FechaCancelacion DateTime, 
		UsuarioCanc_Id Int 

GO

ALTER TABLE tesCfdiCobranza 
	add constraint fktesCfdiCobranzaUsuC Foreign key (UsuarioCanc_Id) References genUsuarios
GO	 

