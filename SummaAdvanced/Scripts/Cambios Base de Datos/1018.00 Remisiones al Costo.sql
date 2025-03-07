ALTER TABLE genEmpresas Add RemisionesAlCosto Bit 
go

ALTER TABLE genEmpresas Add CtaRemisiones Int
go

Update genEmpresas SET RemisionesAlCosto = 1 
GO


ALTER TABLE genEmpresas Alter Column RemisionesAlCosto Bit  NOT NULL
go

ALTER TABLE genEmpresas add Constraint fkgenEmpresasCtaRemi 
	Foreign Key(CtaRemisiones) References conCuentas
GO

INSERT INTO genVersion(Version) Values(1018)
GO



