Alter table venCamiones add AseguraMedAmb VarChar(50)
Alter table venCamiones add PolizaMedAmbiente VarChar(30)
Alter table venCamiones add AseguraCarga VarChar(50)
Alter table venCamiones add PolizaCarga VarChar(30)
Alter table venCamiones add PrimaSeguro Numeric(18,2)
GO

INSERT INTO genVersion(Version) Values(1063.00)
GO