ALTER TABLE disControlesGrilla ADD PermiteCambiarOrden bit DefauLt 0 NOT NULL
GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1009.05);

GO

