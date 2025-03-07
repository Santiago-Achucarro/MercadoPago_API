ALTER TABLE disControlesFecha ADD EsFechaHora SINO Default 0 NOT NULL
ALTER TABLE disControlesFecha ADD ValorHora varchar(5) NULL
GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1049.05);
GO


