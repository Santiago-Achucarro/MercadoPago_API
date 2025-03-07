ALTER TABLE venPediFacturados Add Reparto_Id INT
GO

ALTER TABLE venPediFacturados  ADD Constraint fkvenPediFacturadosRepa 
	Foreign Key (Reparto_Id) References  venReparto

GO

alter table venMovImpTraslado drop constraint XPKvenMovImpTrasladado
GO

alter table venMovImpTraslado add venMovImpTraslado BigInt Identity NOT NULL

alter table venMovImpTraslado ADD constraint XPKvenMovImpTrasladado
	Primary key(venMovImpTraslado)
GO

Create Index venMovImpTrasladoIK ON venMovImpTraslado (Asiento_Id , RenglonDebe)
GO


INSERT INTO genVersion (Version) Values(598.00)
GO