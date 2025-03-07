Alter table venMovImpTraslado add DifCambio Numeric(18,2) 
Alter table venMovImpTraslado add RenDifCambio Int
GO

UPDATE venMovImpTraslado SET DifCambio = 0 WHERE DifCambio IS NULL
GO

Alter table venMovImpTraslado Alter Column DifCambio Numeric(18,2) NOT NULL
GO

Alter table venMovImpTraslado add Constraint fkvenMovImpTrasladoDC 
FOREIGN KEY (Asiento_Id, RenDifCambio) References conMovCont
GO

Alter table comMovImpAcredita add DifCambio Numeric(18,2) 
Alter table comMovImpAcredita Add RenDifCambio Int
GO

UPDATE comMovImpAcredita SET DifCambio = 0 WHERE DifCambio IS NULL
GO

Alter table comMovImpAcredita Alter Column DifCambio Numeric(18,2) NOT NULL
GO

Alter table comMovImpAcredita add Constraint fkcomMovImpAcreditaDC 
FOREIGN KEY (Asiento_Id, RenDifCambio) References conMovCont
GO

INSERT INTO genVersion(Version) Values(599.00)
GO
