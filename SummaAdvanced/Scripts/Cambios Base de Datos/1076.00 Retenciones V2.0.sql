ALTER TABLE impRetencionesCFDI ADD CodPostal VarChar(5)
ALTER TABLE impRetencionesCFDI ADD UtilidadBimestral QMonedaD2 NULL
ALTER TABLE impRetencionesCFDI ADD ISRCorrespondiente QMonedaD2 NULL
GO

INSERT INTO genVersion(Version) Values(1076.00)
GO