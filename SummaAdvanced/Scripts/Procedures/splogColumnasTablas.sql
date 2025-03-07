
DROP PROCEDURE logColumnasTablas
GO
CREATE PROCEDURE logColumnasTablas
(
@pNAME VarChar(100) 
)
AS
SET NOCOUNT ON 

select syscolumns.name, systypes.name Tipo,  
                 syscolumns.length long, syscolumns.colid, syscolumns.id,  systypes.xusertype,  
                 systypes.length longEst, sysindexkeys.keyno, syscolumns.isnullable  ,
				 systypes.xprec, systypes.xscale, systypes.type
                 from sysobjects inner join syscolumns on sysobjects.id = syscolumns.id  
                 inner join systypes on systypes.xusertype = syscolumns.xusertype  
                 left join sysindexkeys on sysobjects.id  = sysindexkeys.id and  
                 syscolumns.colid  = sysindexkeys.colid and sysindexkeys.indid = 1  
                 where sysobjects.name  =   @pNAME   Order by 4
 
RETURN @@Error 

GO

