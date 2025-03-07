
--DECLARE @ConstraintName nvarchar(200)
--SELECT @ConstraintName = CONSTRAINT_NAME FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE where TABLE_NAME = 'venCartaPorteFact' AND COLUMN_NAME = 'venMovimientosFactCP' 
--and CONSTRAINT_NAME LIKE 'PK__venCarta%'
--EXEC('ALTER TABLE venCartaPorteFact DROP CONSTRAINT ' + @ConstraintName)

DECLARE @SQL char(250)
SELECT @SQL = 'ALTER TABLE '+sp.name+' DROP Constraint '+sh.name from sysobjects sh , sysobjects sp  where sh.Type = 'K' and
sp.id = sh.parent_obj AND sp.name = 'venCartaPorteFact'
EXEC(@SQL)

ALTER TABLE [venCartaPorteFact] ALTER COLUMN venMovimientosFact BigInt NOT NULL



ALTER TABLE [dbo].[venCartaPorteFact] 
ADD PRIMARY KEY(venMovimientosFactCP, venMovimientosFact)
GO
  
ALTER TABLE [dbo].[venCartaPorteFact] 
ADD 
Parada int,
DistanciaRecorrida Numeric(5,2),
FechaHoraLLegada qFecha NULL
GO
  


insert into genVersion(Version) Values(1067.03)
GO