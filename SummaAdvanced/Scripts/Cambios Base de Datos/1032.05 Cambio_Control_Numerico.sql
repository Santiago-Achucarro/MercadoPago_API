ALTER TABLE disControlesNumerico ADD LLevaSeparadorGrupo SINO Default 1 NOT NULL
GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1032.05);
GO


