
Alter table conCuentas drop Constraint FkconCuentasAxi 
GO

Alter table conCuentas Add Constraint FkconCuentasAxi Foreign Key(RubroAxi_Id)
REFERENCES conRubrosAxi (conRubrosAxi)
GO

INSERT INTO genVersion(Version) Values(569.00)
GO