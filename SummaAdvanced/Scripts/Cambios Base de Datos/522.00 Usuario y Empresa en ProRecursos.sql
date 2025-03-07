Alter table proRecursos Add Empresa_Id Int 
Alter table proRecursos Add Usuario_Id Int 
GO
UPDATE proRecursos SET Usuario_Id = 1
GO


ALTER TABLE proRecursos
	ADD CONSTRAINT V2R_4259 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
go




ALTER TABLE proRecursos
	ADD CONSTRAINT V2R_4281 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go



Alter table proTrabajo3Prov add Deposito_Id int 
GO

ALTER TABLE proTrabajo3Prov
	ADD CONSTRAINT V2R_4282 FOREIGN KEY (Deposito_Id) REFERENCES stkDepositos(stkDepositos)
go



INSERT INTO genVersion (Version) Values(522.000)
GO
