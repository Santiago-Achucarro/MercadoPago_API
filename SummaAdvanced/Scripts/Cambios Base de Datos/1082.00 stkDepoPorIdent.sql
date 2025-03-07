if exists(select 1 from sysobjects where name = 'stkDepoPorIdent' and type = 'U')
BEGIN

	DROP TABLE stkDepoPorIdent
	DROP TABLE stkDepoPorIdentImp
	

CREATE TABLE tesDepoPorIdent(
	tesMovimientos bigInt NOT NULL, 
	venMovimientos BigInt NULL, 
	Primary KEY(tesMovimientos))


ALTER TABLE tesDepoPorIdent ADD Constraint fktesDepoPorIdentTM
	FOREIGN KEY (tesMovimientos) References tesMovimientos

ALTER TABLE tesDepoPorIdent ADD Constraint fktesDepoPorIdentVM
	FOREIGN KEY (venMovimientos) References venMovimientos


CREATE TABLE tesDepoPorIdentImp(
	tesMovimientos bigInt NOT NULL, 
	Impuesto_Id INT not null, 
	BaseImponible Numeric(18,2) NOT NULL,
	Importe Numeric(18,2) NOT NULL,
	Primary KEY(tesMovimientos, Impuesto_Id))

ALTER TABLE tesDepoPorIdentImp ADD Constraint fktesDepoPorIdentImpTM
	FOREIGN KEY (tesMovimientos) References tesMovimientos

ALTER TABLE tesDepoPorIdentImp ADD Constraint fktesDepoPorIdentImpImp
	FOREIGN KEY (Impuesto_Id) References venImpuestos


END
GO

INSERT INTO genVersion(Version) Values(1082.00)
GO
