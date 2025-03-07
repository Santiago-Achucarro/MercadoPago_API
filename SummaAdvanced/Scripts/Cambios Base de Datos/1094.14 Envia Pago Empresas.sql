ALTER TABLE genEmpresas ADD EnviaPago [SINO] NULL 
GO
ALTER TABLE genEmpresas ADD ConfirmarEnviarPago [SINO] NULL 
GO

INSERT INTO genVersion (Version) Values(1094.14)
GO
