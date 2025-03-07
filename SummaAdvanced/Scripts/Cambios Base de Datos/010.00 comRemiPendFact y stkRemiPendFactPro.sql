IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 10.00)
begin

INSERT INTO genVersion(Version) Values(10);

CREATE TABLE stkRemiPendFactPro(
	stkMoviCabe BigInt NOT NULL,
	Renglon Int NOT NULL, 
	CantidadPendiente Numeric(19,8) NOT NULL,
	Primary key(stkMoviCabe, Renglon));


ALTER TABLE stkRemiPendFactPro add Foreign key(stkMoviCabe, Renglon) 
	REFERENCES stkMoviCuerpo;

CREATE TABLE comRemiPendFact(
	comMovprov BigInt NOT NULL,
	RenlonCuerpo INT NOT NULL,
	stkMoviCabe BigInt NOT NULL,
	Renglon Int NOT NULL, 
	CantidadFacturado Numeric(19,8) NOT NULL,
	Primary key(comMovprov, RenlonCuerpo));

ALTER TABLE comRemiPendFact add Foreign key(comMovprov) 
	REFERENCES comMovprov;

ALTER TABLE comRemiPendFact add Foreign key(stkMoviCabe, Renglon) 
	REFERENCES stkRemiPendFactPro;

END



