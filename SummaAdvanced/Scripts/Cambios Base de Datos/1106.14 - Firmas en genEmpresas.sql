ALTER TABLE genEmpresas ADD FirmaSUE varchar(max)  NULL
GO
ALTER TABLE genEmpresas ADD	ImagenFirmaB64SUE varchar(max) NULL
GO
ALTER TABLE genEmpresas ADD FirmaTES varchar(max)  NULL
GO
ALTER TABLE genEmpresas ADD	ImagenFirmaB64TES varchar(max) NULL
GO

INSERT INTO genVersion(Version) Values(1106.14)
GO




