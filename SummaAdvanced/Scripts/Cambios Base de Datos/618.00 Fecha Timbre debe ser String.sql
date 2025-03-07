ALTER TABLE impRetencionesCfDI Alter Column FechaTimbre VarChar(19) 
GO
Alter table impRetCFDIDetalle Alter Column TipoPagoRet VarChar(17)
GO

INSERT INTO genVersion (Version) Values(618)
GO

