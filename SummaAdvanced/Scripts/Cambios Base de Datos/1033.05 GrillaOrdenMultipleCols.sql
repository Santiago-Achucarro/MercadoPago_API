ALTER TABLE disControlesGrilla ADD PermiteOrdenMultiCols bit DefauLt 0 NOT NULL
GO

exec TempdisDisenioCopiarActual
GO

INSERT INTO genVersion(Version) Values(1033.05);

GO

