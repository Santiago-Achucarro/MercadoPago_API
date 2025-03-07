Drop procedure impCABATxtDatos
Go
Create procedure impCABATxtDatos
(
@pAnio SMALLINT,
@pMes SMALLINT,
@pTrimestre smallint   
)
As

Declare @lMes smallint
Declare @lAnio smallint
Declare @lTrimestre smallint

If @pMes = 0
	Set @lMes = Convert(SmallInt, Month(getDate()))
Else
	Set @lMes = @pMes

If @pAnio = 0
	Set @lAnio = Convert(SmallInt, Year(getDate()))
Else
	Set @lAnio = @pAnio

If @pTrimestre = 0
	Set @lTrimestre = Convert(SmallInt, Floor((Month(getDate() - 1)/3)+1))
Else
	Set @lTrimestre = @pTrimestre

Select '' ArchivoRegGral, '' ArchivoMagSup, '' ArchivoRiesFisc, '' ArchivoExentos, @lMes Mes, @lAnio Anio, @lTrimestre Trimestre, '' MesTrimestre,
(Select Count(1) From impRentasCapGralTxt WHERE Mes = @lMes AND Anio = @lAnio) CantGral,
(Select Count(1) From impRentasCapMagSupTxt WHERE Mes = @lMes AND Anio = @lAnio) CantMagSup,
(Select Count(1) From impRentasCapExentosTxt WHERE Trimestre = @lTrimestre AND Anio = @lAnio) CantExentos,
(Select Count(1) From impRentasCapRiesgoTxt WHERE Trimestre = @lTrimestre AND Anio = @lAnio) CantRiesgo

Select 
(Select top 1 FechaVigDesde From impRentasCapGralTxt ORDER BY FechaVigDesde DESC) VigGralDesde,
(Select top 1 FechaVigHasta From impRentasCapGralTxt ORDER BY FechaVigHasta DESC) VigGralHasta,
(Select top 1 FechaVigDesde From impRentasCapMagSupTxt ORDER BY FechaVigDesde DESC) VigMagSupDesde,
(Select top 1 FechaVigHasta From impRentasCapMagSupTxt ORDER BY FechaVigHasta DESC) VigMagSupHasta,
(Select top 1 FechaVigDesde From impRentasCapExentosTxt ORDER BY FechaVigDesde DESC) VigExentosDesde,
(Select top 1 FechaVigHasta From impRentasCapExentosTxt ORDER BY FechaVigHasta DESC) VigExentosHasta,
(Select top 1 FechaVigDesde From impRentasCapRiesgoTxt ORDER BY FechaVigDesde DESC) VigRiesgoDesde,
(Select top 1 FechaVigHasta From impRentasCapRiesgoTxt ORDER BY FechaVigHasta DESC) VigRiesgoHasta
Go


Drop PROCEDURE impRentasCapGralTxtImpor
Go
CREATE PROCEDURE impRentasCapGralTxtImpor
(    
@pAnio SMALLINT,
@pMes SMALLINT,
@pTxt VARCHAR(200)
)    
AS    
SET NOCOUNT ON    
IF EXISTS (SELECT * FROM tempdb.dbo.sysobjects WHERE name = '#tmpRentas0')    
	DROP TABLE #tmpRentas0
	    
CREATE TABLE #tmpRentas0 
(
Col1 CHAR(8),    
VigDesde CHAR(8),    
VigHasta CHAR(8),    
Cuit CHAR(11), 
Tipo CHAR(1),    
Col3 CHAR(1),    
Col4 CHAR(1),    
AlicP CHAR(4),    
AlicR CHAR(4),    
GrupoP CHAR(2),
GrupoR CHAR(2),
Col5 VARCHAR(200)
)

DECLARE @SQL VARCHAR(200)    
SET @SQL = 'BULK INSERT #tmpRentas0 FROM ''' + @pTxt + ''' WITH (FIELDTERMINATOR = '';'', ROWTERMINATOR = ''\n'') '    
EXEC (@SQL)

DELETE FROM impRentasCapGralTxt WHERE Mes = @pMes AND Anio = @pAnio 

INSERT INTO impRentasCapGralTxt     
(Anio, Mes, CUIT, FechaVigDesde, FechaVigHasta,Tipo,AlicuotaPer, AlicuotaRet, GrupoPer, GrupoRet)    
SELECT @pAnio, @pMes,     
substring(Cuit, 1, 2) + '-' + substring(Cuit, 3, 8) + '-' + substring(Cuit, 11, 1),     
substring(VigDesde, 5,4) + substring(VigDesde, 3,2) + substring(VigDesde, 1,2),    
substring(VigHasta, 5,4) + substring(VigHasta, 3,2) + substring(VigHasta, 1,2),    
substring(Tipo,1,1),   
cast(replace(AlicP, ',', '.') AS NUMERIC(5,2)),
cast(replace(AlicR, ',', '.') AS NUMERIC(5,2)),
cast(GrupoP AS SMALLINT),
cast(GrupoR AS SMALLINT)
FROM #tmpRentas0     
WHERE cast(substring(VigDesde, 3,2) AS SMALLINT) = @pMes and     
cast(substring(VigDesde, 5,4) AS SMALLINT) = @pAnio    

DROP TABLE #tmpRentas0

Select Cast(Count(1) as bigint) CantGral From impRentasCapGralTxt WHERE Mes = @pMes AND Anio = @pAnio
GO


Drop PROCEDURE impRentasCapMagSupTxtImpor
Go
CREATE PROCEDURE impRentasCapMagSupTxtImpor
(    
@pAnio SMALLINT,
@pMes SMALLINT,
@pTxt VARCHAR(200)
)    
AS    
SET NOCOUNT ON    
IF EXISTS (SELECT * FROM tempdb.dbo.sysobjects WHERE name = '#tmpRentas0')    
	DROP TABLE #tmpRentas0

CREATE TABLE #tmpRentas0 
(
Col1 CHAR(8),    
VigDesde CHAR(8),    
VigHasta CHAR(8),    
Cuit CHAR(11), 
Col2 CHAR(1),    
Col3 CHAR(1),    
Col4 CHAR(1),    
AlicP CHAR(4),    
AlicR CHAR(4),    
GrupoP CHAR(2),
GrupoR CHAR(2),
Col5 VARCHAR(200)
)

DECLARE @SQL VARCHAR(200)    
SET @SQL = 'BULK INSERT #tmpRentas0 FROM ''' + @pTxt + ''' WITH (FIELDTERMINATOR = '';'', ROWTERMINATOR = ''\n'') '    
EXEC (@SQL)    

DELETE FROM impRentasCapMagSupTxt WHERE Mes = @pMes AND Anio = @pAnio 
INSERT INTO impRentasCapMagSupTxt     
(Anio, Mes, CUIT, FechaVigDesde, FechaVigHasta, AlicuotaPer, AlicuotaRet, GrupoPer, GrupoRet)    
SELECT @pAnio, @pMes,     
substring(Cuit, 1, 2) + '-' + substring(Cuit, 3, 8) + '-' + substring(Cuit, 11, 1),     
substring(VigDesde, 5,4) + substring(VigDesde, 3,2) + substring(VigDesde, 1,2),    
substring(VigHasta, 5,4) + substring(VigHasta, 3,2) + substring(VigHasta, 1,2),    
cast(replace(AlicP, ',', '.') AS NUMERIC(5,2)),
cast(replace(AlicR, ',', '.') AS NUMERIC(5,2)),
cast(GrupoP AS SMALLINT),
cast(GrupoR AS SMALLINT)
FROM #tmpRentas0     
WHERE cast(substring(VigDesde, 3,2) AS SMALLINT) = @pMes and     
cast(substring(VigDesde, 5,4) AS SMALLINT) = @pAnio    
DROP TABLE #tmpRentas0

Select Cast(Count(1) As bigint) CantMagSup From impRentasCapMagSupTxt WHERE Mes = @pMes AND Anio = @pAnio
GO


Drop PROCEDURE impRentasCapExentosTxtImpor
Go
CREATE PROCEDURE impRentasCapExentosTxtImpor
(    
@pAnio SMALLINT,
@pTrim SMALLINT,
@pTxt VARCHAR(200)
)    
AS    
SET NOCOUNT ON    
IF EXISTS (SELECT * FROM tempdb.dbo.sysobjects WHERE name = '#tmpRentas0')    
	DROP TABLE #tmpRentas0

CREATE TABLE #tmpRentas0
(
Col1 CHAR(8),    
VigDesde CHAR(8),    
VigHasta CHAR(8),    
Cuit CHAR(11), 
Col2 CHAR(1),    
Col3 CHAR(1),    
Col4 CHAR(1),    
AlicP CHAR(4),    
AlicR CHAR(4),    
GrupoP CHAR(2),
GrupoR CHAR(2),
Col5 VARCHAR(200)
)    
DECLARE @SQL VARCHAR(200)    
SET @SQL = 'BULK INSERT #tmpRentas0 FROM ''' + @pTxt + ''' WITH (FIELDTERMINATOR = '';'', ROWTERMINATOR = ''\n'') '    
EXEC (@SQL)    

DELETE FROM impRentasCapExentosTxt WHERE Trimestre = @pTrim AND Anio = @pAnio 
INSERT INTO impRentasCapExentosTxt     
(Anio, Trimestre, CUIT, FechaVigDesde, FechaVigHasta, AlicuotaPer, AlicuotaRet, GrupoPer, GrupoRet)    
SELECT @pAnio, @pTrim,     
substring(Cuit, 1, 2) + '-' + substring(Cuit, 3, 8) + '-' + substring(Cuit, 11, 1),     
substring(VigDesde, 5,4) + substring(VigDesde, 3,2) + substring(VigDesde, 1,2),    
substring(VigHasta, 5,4) + substring(VigHasta, 3,2) + substring(VigHasta, 1,2),    
cast(replace(AlicP, ',', '.') AS NUMERIC(5,2)),
cast(replace(AlicR, ',', '.') AS NUMERIC(5,2)),
cast(GrupoP AS SMALLINT),
cast(GrupoR AS SMALLINT)
FROM #tmpRentas0     
WHERE (Floor((cast(substring(VigDesde,3,2) AS SMALLINT)-1)/3)+1) = @pTrim and     
cast(substring(VigDesde, 5,4) AS SMALLINT) = @pAnio    
DROP TABLE #tmpRentas0

Select Cast(Count(1) As bigint) CantExentos From impRentasCapExentosTxt WHERE Trimestre = @pTrim AND Anio = @pAnio
GO


Drop PROCEDURE impRentasCapRiesgoTxtImport
Go
CREATE PROCEDURE impRentasCapRiesgoTxtImport
(    
@pAnio SMALLINT,
@pTrim SMALLINT,
@pTxt VARCHAR(200)
)    
AS    
SET NOCOUNT ON    
IF EXISTS (SELECT * FROM tempdb.dbo.sysobjects WHERE name = '#tmpRentas0')    
	DROP TABLE #tmpRentas0

CREATE TABLE #tmpRentas0
(
Col1 CHAR(8),    
VigDesde CHAR(8),    
VigHasta CHAR(8),    
Cuit CHAR(11), 
Col2 CHAR(1),    
Col3 CHAR(1),    
Col4 CHAR(1),    
AlicP CHAR(4),    
AlicR CHAR(4),    
GrupoP CHAR(2),
GrupoR CHAR(2),
Col5 VARCHAR(200)
)    
DECLARE @SQL VARCHAR(200)    
SET @SQL = 'BULK INSERT #tmpRentas0 FROM ''' + @pTxt + ''' WITH (FIELDTERMINATOR = '';'', ROWTERMINATOR = ''\n'') '    
EXEC (@SQL)    

DELETE FROM impRentasCapRiesgoTxt WHERE Trimestre = @pTrim AND Anio = @pAnio

INSERT INTO impRentasCapRiesgoTxt     
(Anio, Trimestre, CUIT, FechaVigDesde, FechaVigHasta, AlicuotaPer, AlicuotaRet, GrupoPer, GrupoRet)    
SELECT @pAnio, @pTrim,     
substring(Cuit, 1, 2) + '-' + substring(Cuit, 3, 8) + '-' + substring(Cuit, 11, 1),     
substring(VigDesde, 5,4) + substring(VigDesde, 3,2) + substring(VigDesde, 1,2),    
substring(VigHasta, 5,4) + substring(VigHasta, 3,2) + substring(VigHasta, 1,2),    
cast(replace(AlicP, ',', '.') AS NUMERIC(5,2)),
cast(replace(AlicR, ',', '.') AS NUMERIC(5,2)),
cast(GrupoP AS SMALLINT),
cast(GrupoR AS SMALLINT)
FROM #tmpRentas0     
WHERE (Floor((cast(substring(VigDesde,3,2) AS SMALLINT)-1)/3)+1) = @pTrim and     
cast(substring(VigDesde, 5,4) AS SMALLINT) = @pAnio

DROP TABLE #tmpRentas0

Select Cast(Count(1) As bigint) CantRiesgo From impRentasCapRiesgoTxt WHERE Trimestre = @pTrim AND Anio = @pAnio
GO

