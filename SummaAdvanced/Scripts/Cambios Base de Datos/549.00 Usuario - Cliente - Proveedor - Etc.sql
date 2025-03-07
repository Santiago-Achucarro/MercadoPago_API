Alter table genUsuarios Add Cliente_Id BigInt 
Alter table genUsuarios Add Proveed_Id BigInt 
Alter table genUsuarios Add Vendedor_Id BigInt 
Alter table genUsuarios Add Cobrador_Id BigInt 
Alter table genUsuarios Add Legajo BigInt 
GO


ALTER TABLE genUsuarios
	ADD CONSTRAINT V2R_4442 FOREIGN KEY (Cliente_Id) REFERENCES venClientes(genEntidades)
go




ALTER TABLE genUsuarios
	ADD CONSTRAINT V2R_4443 FOREIGN KEY (Proveed_Id) REFERENCES comProveedores(genEntidades)
go




ALTER TABLE genUsuarios
	ADD CONSTRAINT V2R_4444 FOREIGN KEY (Vendedor_Id) REFERENCES venVendedores(venVendedores)
go




ALTER TABLE genUsuarios
	ADD CONSTRAINT V2R_4445 FOREIGN KEY (Cobrador_Id) REFERENCES venCobradores(venCobradores)
go




ALTER TABLE genUsuarios
	ADD CONSTRAINT V2R_4446 FOREIGN KEY (Legajo) REFERENCES suePersonal(genEntidades)
go


INSERT INTO genVersion (Version) Values(549.00)
GO