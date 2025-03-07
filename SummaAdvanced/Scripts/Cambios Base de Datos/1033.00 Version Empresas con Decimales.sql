DECLARE @SQL char(250)

SELECT @SQL = 'ALTER TABLE '+sp.name+' DROP Constraint '+sh.name from sysobjects sh , sysobjects sp  where sh.Type = 'K' and
sp.id = sh.parent_obj AND sp.name = 'genVersionEmpresas'

EXEC(@SQL)
GO

ALTER TABLE genVersionEmpresas Alter column Version Numeric(18,3) NOT NULL
GO
ALTER TABLE genVersionEmpresas add Primary kEY(Version) 
GO

INSERT INTO genVersion (Version) Values(1033.00)
GO

