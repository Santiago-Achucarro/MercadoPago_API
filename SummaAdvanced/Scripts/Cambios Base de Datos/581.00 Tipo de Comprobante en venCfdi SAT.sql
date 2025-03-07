ALTER Table venCFDISat add TipoComprobante Char(1) 
GO
Alter table sueNominaCfdi Add FechaCancelacion DateTime
GO

INSERT INTO genVersion (Version) Values(581.00)
GO