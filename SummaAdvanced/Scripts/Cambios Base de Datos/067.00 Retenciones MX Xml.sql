INSERT INTO  genVersion (Version) Values(67.000)
GO

ALTER TABLE impRetencionesCFDI add Xml text
GO
ALTER TABLE impRetCFDIDetalle Alter Column TipoPagoRet VarChar(17) NOT NULL
GO


