CREATE TABLE stkHojaDeRutaCuerpo
(
	stkHojaDeRuta int NOT NULL, 
	conAsientos BigInt NOT NULL, 
	Primary Key(stkHojaDeRuta, conAsientos)
)
GO

ALTER TABLE stkHojaDeRutaCuerpo ADD Constraint fkstkHojaDeRutaCuerpoHR
	Foreign Key (stkHojaDeRuta) References stkHojaDeRuta
GO

ALTER TABLE stkHojaDeRutaCuerpo ADD Constraint fkstkHojaDeRutaCuerpoAS
	Foreign Key (conAsientos) References conAsientos
GO

INSERT INTO stkHojaDeRutaCuerpo (stkHojaDeRuta, conAsientos)
SELECT HojaRuta_Id, stkMoviCabe from stkRemitos where HojaRuta_Id is not null
GO

INSERT INTO genVersion (Version) Values(601.00)
GO

