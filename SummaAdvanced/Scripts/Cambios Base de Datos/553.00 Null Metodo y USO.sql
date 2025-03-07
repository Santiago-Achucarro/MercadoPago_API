ALTER TABLE venCotizaciones Alter Column MetodoPago varchar(3)  NULL 
ALTER TABLE venCotizaciones Alter Column UsoCfdi varchar(3)  NULL 
GO

INSERT INTO genVersion(Version) Values(553.00)
GO
	