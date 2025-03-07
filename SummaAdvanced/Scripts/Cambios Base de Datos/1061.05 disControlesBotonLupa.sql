ALTER TABLE disControlesBotonLupa ADD ReemplazaEnDestino bit DefauLt 0 NOT NULL

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1061.05);

GO

