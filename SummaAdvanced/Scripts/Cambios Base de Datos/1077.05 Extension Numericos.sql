ALTER TABLE disControlesNumerico Alter Column ValorMinimo Numeric(25, 8) NULL
ALTER TABLE disControlesNumerico Alter Column ValorMaximo Numeric(25, 8) NULL
GO

INSERT INTO genVersion(Version) Values(1077.05)
GO

