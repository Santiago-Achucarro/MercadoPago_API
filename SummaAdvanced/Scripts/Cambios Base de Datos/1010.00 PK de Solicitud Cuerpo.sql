ALTER TABLE stkSolicitudCDCuerpo ADD Renglon Int 
GO
Update stkSolicitudCDCuerpo set Renglon =1
GO

ALTER TABLE stkSolicitudCDCuerpo Alter Column Renglon Int NOT NULL
GO

DECLARE @SQL char(250)

SELECT @SQL = 'ALTER TABLE '+sp.name+' DROP Constraint '+sh.name from sysobjects sh , sysobjects sp  where sh.Type = 'K' and
sp.id = sh.parent_obj AND sp.name = 'stkSolicitudCDCuerpo'

EXEC(@SQL)

ALTER TABLE stkSolicitudCDCuerpo add Primary kEY(stkSolicitudCD,Renglon) 
GO

INSERT INTO genVersion(Version) Values(1010.00)
GO
