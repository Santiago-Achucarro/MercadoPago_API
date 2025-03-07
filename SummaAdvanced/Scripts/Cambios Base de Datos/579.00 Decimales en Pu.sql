ALTER TABLE venListasPrecios Add DecimalesPu Int 
GO

Update venListasPrecios SET DecimalesPu = 8
GO

ALTER TABLE venListasPrecios Alter Column DecimalesPu Int Not NULL
GO

INSERT INTO genVersion(Version) Values(579)
GO
