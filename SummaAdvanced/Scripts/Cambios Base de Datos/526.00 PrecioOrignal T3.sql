ALTER TABLE proMovCierreTrabajos3 ADD PrecioOriginal QMonedaD4 NULL
go

UPDATE proMovCierreTrabajos3 SET PrecioOriginal = Precio 
GO

ALTER TABLE proMovCierreTrabajos3 Alter Column PrecioOriginal QMonedaD4 NOT NULL
go

INSERT INTO genVersion (Version) Values(526.000)
GO
