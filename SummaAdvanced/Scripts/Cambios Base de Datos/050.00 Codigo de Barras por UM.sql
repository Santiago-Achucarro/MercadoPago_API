INSERT INTO genVersion (Version) VALUES(50.00)
GO

ALTER TABLE stkArtiUM add CodigoBarra VarChar(25)
GO


CREATE TABLE comCFDISat(
	UUID char(36) NOT NULL,
	Empresa_Id INT NOT NULL,
	RFCEmisor char(13) NOT NULL,
	Fecha datetime NOT NULL,
	Monto numeric(18, 2) NOT NULL,
	Folio bigint NOT NULL,
	Serie varchar(100) NOT NULL,
	Subido Bit NOT NULL,
	XML varchar(max) NULL,
	Usuario Int NULL, 
	FechaCarga DateTime NULL,
PRIMARY KEY 
(
	UUID ASC
)
)

GO

