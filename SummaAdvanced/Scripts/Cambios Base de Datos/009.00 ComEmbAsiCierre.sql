IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 9.00)
begin
INSERT INTO genVersion (Version) Values (9.00)
CREATE TABLE comEmbAsiCierre(
	comEmbarques BigInt NOT NULL, 
	stkMoviCabe BigInt NOT NULL, 
	Cambio Numeric(19,8) NOT NULL,
	Primary Key(comEmbarques, stkMoviCabe));


ALTER TABLE comEmbAsiCierre Add Foreign Key (comEmbarques) REFERENCES comEmbarques;
ALTER TABLE comEmbAsiCierre Add Foreign Key (stkMoviCabe) REFERENCES stkMoviCabe;

ALTER TABLE genEmpresas Add CtaUtiCambioRealizada int; 
ALTER TABLE genEmpresas Add CtaPerCambioRealizada int; 

ALTER TABLE genEmpresas Add CtaUtiCambioProv int; 
ALTER TABLE genEmpresas Add CtaPerCambioProv int;

END
GO

