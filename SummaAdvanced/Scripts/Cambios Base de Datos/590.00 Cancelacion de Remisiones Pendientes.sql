CREATE table stkEntradasCancRemi(
	stkMoviCabeEntrada bigint NOT NULL, 
	RenglonEntrada Int NOT NULL,
	stkMoviCabeRemi BigInt NOT NULL, 
	RenglonRemi Int Not NULL,
	Cantidad QCantidadD8 NOT NULL, 
	Primary Key(stkMoviCabeEntrada))
GO

ALTER TABLE stkEntradasCancRemi ADD CONSTRAINT fkstkEntradasCancRemiEnt 
	Foreign Key (stkMoviCabeEntrada, RenglonEntrada) References stkMoviCuerpo
GO

ALTER TABLE stkEntradasCancRemi ADD CONSTRAINT fkstkEntradasCancRemiRemi 
	Foreign Key (stkMoviCabeRemi, RenglonRemi) References stkMoviCuerpo
GO

INSERT INTO genVersion(Version) Values(590.00)
GO



