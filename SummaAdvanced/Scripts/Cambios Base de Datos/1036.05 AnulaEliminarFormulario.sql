ALTER TABLE disFormularios ADD AnulaAccionesEliminarDefault bit DefauLt 0 NOT NULL
GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1036.05);

GO

