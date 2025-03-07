ALTER TABLE disControlesGrafico ADD Colores Varchar(140)

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1081.05);

GO
