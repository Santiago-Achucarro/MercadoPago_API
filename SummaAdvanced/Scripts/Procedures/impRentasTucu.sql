
--impRentasTucumanAcreditan 'PTUCUACR' ,2022,4,'C:\Adv\PH\ACREDITAN 042022.TXT'
Drop PROCEDURE impRentasTucumanAcreditan
Go
CREATE PROCEDURE impRentasTucumanAcreditan
(    
@pTxt VARCHAR(200),
@pPadron_Id varChar(10),
@pAnio SMALLINT,
@pMes SMALLINT,
@pTrimestre int
)    
AS    
SET NOCOUNT ON    
IF EXISTS (SELECT * FROM tempdb.dbo.sysobjects WHERE name = '#tmpRentas0')    
	DROP TABLE #tmpRentas0


	    
CREATE TABLE #tmpRentas0 										   

(    
Col1 varchar(max)
)

DECLARE @SQL VARCHAR(200)    
--set @pTxt='C:\Adv\PH\ACREDITAN 042022.TXT'
SET @SQL = 'BULK INSERT #tmpRentas0 FROM ''' + @pTxt + ''' WITH (FIELDTERMINATOR = '''', ROWTERMINATOR = ''\n'') '    
EXEC (@SQL)

DELETE FROM impPadronTxt WHERE Mes = @pMes AND Anio = @pAnio and Padron_Id = dbo.funcFKimpPadron(@pPadron_Id)

INSERT INTO impPadronTxt     
(Padron_id,Anio, Mes, CUIT, Trimestre, Alicuota)    
SELECT dbo.funcFKimpPadron(@pPadron_Id), @pAnio, @pMes,     
substring(Col1, 1, 2) + '-' + substring(Col1, 3, 8) + '-' + substring(Col1, 11, 1),     
1,
case when Substring(col1,193,5) in ('-----')  then 0 else cast(replace(Substring(col1,193,5), ',', '.') AS NUMERIC(5,2)) end as alicuota
FROM #tmpRentas0     

DROP TABLE #tmpRentas0

Select Cast(Count(1) as bigint) CantGral From impPadronTxt WHERE Mes = @pMes AND Anio = @pAnio and Padron_Id = dbo.funcFKimpPadron(@pPadron_Id)
GO


--impRentasTucumanCoef '','PCOEFTU',2022,4,1
Drop PROCEDURE impRentasTucumanCoef
Go
CREATE PROCEDURE impRentasTucumanCoef
(    
@pTxt VARCHAR(200),
@pPadron_Id varChar(10),
@pAnio SMALLINT,
@pMes SMALLINT,
@pTrimestre int
)    
AS    
SET NOCOUNT ON    
IF EXISTS (SELECT * FROM tempdb.dbo.sysobjects WHERE name = '#tmpRentas0')    
	DROP TABLE #tmpRentas0


	    
CREATE TABLE #tmpRentas0 

(    
Col1 varchar(max)
)

DECLARE @SQL VARCHAR(200)    

SET @SQL = 'BULK INSERT #tmpRentas0 FROM ''' + @pTxt + ''' WITH (FIELDTERMINATOR = '''', ROWTERMINATOR = ''\n'') '    
EXEC (@SQL)

DELETE FROM impPadronTxt WHERE Mes = @pMes AND Anio = @pAnio and Padron_Id = dbo.funcFKimpPadron(@pPadron_Id)

INSERT INTO impPadronTxt     
(Padron_id,Anio, Mes, CUIT, Trimestre, Alicuota)    
SELECT dbo.funcFKimpPadron(@pPadron_Id), @pAnio, @pMes,     
substring(Col1, 1, 2) + '-' + substring(Col1, 3, 8) + '-' + substring(Col1, 11, 1),     
1,
case when Substring(col1,17,6) in ('-.----')  then 0 else cast(replace(Substring(col1,17,6), ',', '.') AS NUMERIC(5,4)) end as alicuota
FROM #tmpRentas0     

DROP TABLE #tmpRentas0

Select Cast(Count(1) as bigint) CantGral From impPadronTxt WHERE Mes = @pMes AND Anio = @pAnio and Padron_Id = dbo.funcFKimpPadron(@pPadron_Id)
GO



