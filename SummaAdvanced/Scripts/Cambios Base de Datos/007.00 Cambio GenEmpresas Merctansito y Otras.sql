IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 7.00)
begin

INSERT INTO genVersion (Version) Values(7.0)
GO

ALTER TABLE genEmpresas Add SucursalCentral Int 
GO

ALTER TABLE genEmpresas Add CtaMercTransito Int 
GO

ALTER TABLE genEmpresas Add CtaApliImportacion Int 
GO


ALTER TABLE genEmpresas ADD Foreign Key (SucursalCentral) References genSucursalesEmpr 
GO

ALTER TABLE genEmpresas ADD Foreign Key (CtaMercTransito) References conCuentas
GO

ALTER TABLE genEmpresas ADD Foreign Key (CtaApliImportacion) References conCuentas
GO

Alter table genCancMov Add Importacion Bit
GO
UPDATE genCancMov SET Importacion =0
go
Alter table genCancMov ALTER Column Importacion Bit NOT NULL
end
GO
