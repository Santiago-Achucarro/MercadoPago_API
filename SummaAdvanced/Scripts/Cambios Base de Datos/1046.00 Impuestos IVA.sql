Update impTipoImpuesto SET Referencia01 = 'IVA' WHERE CodigoFiscal in ('I7','T0','EX','IF')
GO

INSERT INTO genVersion (Version) Values(1046.00)