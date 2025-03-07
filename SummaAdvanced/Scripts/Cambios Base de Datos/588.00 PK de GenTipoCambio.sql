
alter table genTipoCambio Drop constraint [XPKgenTipoCambio]
go
alter table genTipoCambio ALTER Column Empresa_Id Int NOT NULL
go
alter table genTipoCambio Add constraint [XPKgenTipoCambio] Primary Key(Moneda_Id, Fecha, Empresa_Id)
GO


Insert into genVersion (Version) Values(588)
GO