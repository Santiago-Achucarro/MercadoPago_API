

ALTER TABLE comPagosHabilitados add CuotaNro Int
GO


declare @SQL VarChar(1000)
SELECT @SQL = 'ALTER TABLE '+sp.name+' DROP Constraint '+sh.name from sysobjects sh , sysobjects sp  where sh.Type = 'K' and
sp.id = sh.parent_obj AND sp.name = 'comPagosHabilitados'

EXEC(@SQL)


UPDATE comPagosHabilitados Set CuotaNro = (select MIN(CuotaNro) from genMovCuotas where
	genMovCuotas.Asiento_Id = comPagosHabilitados.comMovProv)
GO

ALTER TABLE comPagosHabilitados Alter Column CuotaNro Int NOT NULL
GO


ALTER TABLE comPagosHabilitados Add Primary key (commovprov, CuotaNro ,Secuencia)
GO

INSERT INTO genVersion(Version) Values(619.00)
GO



