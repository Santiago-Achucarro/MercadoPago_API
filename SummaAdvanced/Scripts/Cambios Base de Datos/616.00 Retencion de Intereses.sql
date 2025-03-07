CREATE TABLE impRetCFDIIntereses(
	impRetencionesCFDI int NOT NULL,
	SistFinanciero Char(2) NOT NULL,
	RetiroAORESRetInt Char(2) NOT NULL,
	OperFinancDerivad Char(2) NOT NULL,
	MontIntNominal Numeric(18,4) NOT NULL, 
	MontIntReal Numeric(18,4) NOT NULL,
	Perdida Numeric(18,4) NOT NULL,
	Primary Key(impRetencionesCFDI))
GO

ALTER TABLE impRetCFDIIntereses ADD Constraint
	FkimpRetCFDIIntereses Foreign Key (impRetencionesCFDI)
	REFERENCES impRetencionesCFDI
GO

INSERT INTO genVersion(Version) Values(616.00)
GO