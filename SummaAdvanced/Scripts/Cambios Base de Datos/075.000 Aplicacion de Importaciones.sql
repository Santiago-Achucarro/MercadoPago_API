INSERT INTO genVersion (Version) Values(75.000)
GO

CREATE TABLE genCancMovApliImpor (
	conAsientos BigInt NOT NULL, 
	Renglon Int NOT NULL, 
	EsDelAp Bit NOT NULL,
	Primary Key (conAsientos, Renglon))
GO


ALTER TABLE genCancMovApliImpor
	ADD CONSTRAINT R_4071 FOREIGN KEY (conAsientos,Renglon) REFERENCES conMovCont(conAsientos,Renglon)
go



UPDATE conmovcont set clase = 'PRO' where Clase = 'FPRO'
GO