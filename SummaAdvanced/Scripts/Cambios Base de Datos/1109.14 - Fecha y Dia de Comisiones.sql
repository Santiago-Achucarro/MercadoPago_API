ALTER TABLE genEmpresas ADD FechaCierreComi qFecha NULL
GO
ALTER TABLE genEmpresas ADD	DiaComi int NULL
GO

INSERT INTO genVersion(Version) Values(1109.14)
GO

