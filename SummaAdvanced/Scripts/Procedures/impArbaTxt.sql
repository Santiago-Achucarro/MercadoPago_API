Drop procedure impArbaTxtImportar
Go


CREATE PROCEDURE impArbaTxtImportar
(    
@pTxt VARCHAR(200),    
@pMes SMALLINT,    
@pAnio SMALLINT,
@pReg CHAR(1)
)    
AS    
SET NOCOUNT ON

IF EXISTS (SELECT * FROM tempdb.dbo.sysobjects WHERE name = '#tmpRentas0')    
	DROP TABLE #tmpRentas0

CREATE TABLE #tmpRentas0 
(    
Reg CHAR(1),    
Col1 CHAR(8),    
VigDesde CHAR(8),    
VigHasta CHAR(8),    
Cuit CHAR(11),    
Col2 CHAR(1),    
Col3 CHAR(1),    
Col4 CHAR(1),    
Alic CHAR(4),    
Grupo CHAR(2),  
Col5 VARCHAR(50)
)

DECLARE @SQL VARCHAR(200)    
--SET @SQL = 'BULK INSERT #tmpRentas0 FROM ''' + @pTxt + ''' WITH (FIELDTERMINATOR = '';'', ROWTERMINATOR = ''\n'') '    
--EMP CAMBIO EL ROWTERMINATOR PORQUE EL ARCHIVO VIENE COMO UNIX (LF)
SET @SQL = 'BULK INSERT #tmpRentas0 FROM ''' + @pTxt + ''' WITH (FIELDTERMINATOR = '';'', ROWTERMINATOR = '''+CHAR(10)+''')'
EXEC (@SQL)

--SELECT * FROM #tmpRentas0  
DELETE FROM impArbatxt WHERE Mes = @pMes AND Anio = @pAnio AND Regimen = @pReg   

INSERT INTO impArbatxt     
(Regimen, Anio, Mes, CUIT, FechaVigDesde, FechaVigHasta, Alicuota, Grupo)    
SELECT Reg, @pAnio, @pMes,     
substring(Cuit, 1, 2) + '-' + substring(Cuit, 3, 8) + '-' + substring(Cuit, 11, 1),     
substring(VigDesde, 5,4) + substring(VigDesde, 3,2) + substring(VigDesde, 1,2),    
substring(VigHasta, 5,4) + substring(VigHasta, 3,2) + substring(VigHasta, 1,2),    
cast(replace(Alic, ',', '.') AS NUMERIC(5,2)),    
cast(Grupo AS SMALLINT)  
FROM #tmpRentas0     
WHERE cast(substring(VigDesde, 3,2) AS SMALLINT) = @pMes and     
cast(substring(VigDesde, 5,4) AS SMALLINT) = @pAnio    
DROP TABLE #tmpRentas0

Select Cast(Count(1) As bigint) Cant From impArbaTxt WHERE Mes = @pMes AND Anio = @pAnio AND Regimen = @pReg
GO


Drop procedure impArbaTxtDatos
Go
Create procedure impArbaTxtDatos
(
@pMes SMALLINT,    
@pAnio SMALLINT
)
As

Declare @lMes smallint
Declare @lAnio smallint

If @pMes = 0
	Set @lMes = Convert(SmallInt, Month(getDate()))
Else
	Set @lMes = @pMes

If @pAnio = 0
	Set @lAnio = Convert(SmallInt, Year(getDate()))
Else
	Set @lAnio = @pAnio

Select '' ArchivoRet, '' ArchivoPer, @lMes Mes, @lAnio Anio,
(Select Count(1) From impArbaTxt WHERE Mes = @pMes AND Anio = @pAnio AND Regimen = 'R') CantRet,
(Select Count(1) From impArbaTxt WHERE Mes = @pMes AND Anio = @pAnio AND Regimen = 'P')  CantPer

Select (Select top 1 FechaVigDesde from  ImpArbaTxt ORDER BY FechaVigDesde DESC) VigDesde,
(Select top 1 FechaVigHasta from  ImpArbaTxt ORDER BY FechaVigHasta DESC) VigHasta
Go
