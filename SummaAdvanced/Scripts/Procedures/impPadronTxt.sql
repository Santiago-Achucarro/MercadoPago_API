DROP PROCEDURE impPadronTxtDatos
GO
CREATE PROCEDURE impPadronTxtDatos
(
@pPadron_Id varChar(10),
@pCuit varchar(25),
@pAnio int,
@pMes int = null, 
@pTrimestre int = null
)
AS
SET NOCOUNT ON 

SELECT impPadron.Padron_Id, impPadron.Descripcion, impPadronTxt.Cuit, Year(dbo.FechaActual()) Anio, Year(dbo.FechaActual()) Mes,
	impPadronTxt.Trimestre, impPadronTxt.Alicuota, impPadron.StoreProcedure, '' Archivo
FROM impPadronTxt 
Inner Join impPadron on 
impPadronTxt.Padron_Id = impPadron.impPadron
WHERE (impPadronTxt.Padron_Id = dbo.FuncFKimpPadron(@pPadron_Id))
AND (Cuit = @pCuit)
AND (Anio = @pAnio)
AND (Mes = Isnull(@pMes,Mes))
AND (Trimestre = Isnull(@pTrimestre,Trimestre))
 
RETURN @@Error 

GO

DROP PROCEDURE impPadronTxtEliminar
GO
CREATE PROCEDURE impPadronTxtEliminar
(
@pPadron_Id varChar(10),
@pCuit varchar(25) = NULL,
@pAnio int = NULL,
@pMes int = NULL,
@pTrimestre int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impPadronTxt 
WHERE (Padron_Id = dbo.FuncFKimpPadron(@pPadron_Id))
AND (Cuit = ISNULL(@pCuit, Cuit))
AND (Anio = ISNULL(@pAnio, Anio))
AND (Mes = ISNULL(@pMes, Mes))
AND (Trimestre = ISNULL(@pTrimestre, Trimestre))
 
 RETURN @@Error 

GO

--impPadronTxtEliminarUlt 'PBARET'

DROP PROCEDURE impPadronTxtEliminarUlt
GO
CREATE PROCEDURE impPadronTxtEliminarUlt
(
@pPadron_Id varChar(10)
)
AS
SET NOCOUNT ON 

DELETE FROM impPadronTxt 
WHERE (Padron_Id = dbo.FuncFKimpPadron(@pPadron_Id))
and not exists (select 1 from genEntidades where genEntidades.Cuit = impPadronTxt.Cuit)
RETURN @@Error 

GO


DROP PROCEDURE impPadronTxtImportarConXML
GO
CREATE PROCEDURE impPadronTxtImportarConXML
(    
@pPadron_Id varchar(10),
@pXML VARCHAR(MAX),    
@pAnio int,
@pMes int,    
@pTrimestre int
)    
AS
BEGIN
SET NOCOUNT ON
DECLARE @xml XML= cast(@pXML as XML) 

DECLARE @lPadron int = dbo.FuncFKimpPadron(@pPadron_Id)

INSERT INTO impPadronTxt (Padron_Id, Cuit, Anio, Mes, Trimestre, Alicuota) 
SELECT  @lPadron, elmt.value('@C','varchar(25)'), @pAnio, @pMes, @pTrimestre, elmt.value('@P','numeric(15, 4)')
FROM @xml.nodes('/root/E') AS A(elmt);
END

GO



DROP PROCEDURE impPadronTxtEliminarCaducados
GO
CREATE PROCEDURE impPadronTxtEliminarCaducados
(
@pPadron_Id varChar(10),
@pAnioCaducado int,
@pMesCaducado int,    
@pTrimestreCaducado int,
@pAnio int,
@pMes int,    
@pTrimestre int
)
AS
SET NOCOUNT ON 

--Borro los caducados
DELETE FROM impPadronTxt 
WHERE (Padron_Id = dbo.FuncFKimpPadron(@pPadron_Id))
AND (
	 (anio < @pAnioCaducado) OR
	 ((anio = @pAnioCaducado) AND (mes <= @pMesCaducado) and (Trimestre <= @pTrimestreCaducado))
	 )
AND not exists (select 1 from genEntidades where genEntidades.Cuit = impPadronTxt.Cuit)

-- FM 03/07/2023 Si da error de timeout en la eliminación de los registros de meses anteriores --
-- comentar el Delete anterior y descomentar este Delete de acá abajo que va borrando de a tandas --
-- de a 100 mil registros --

--DECLARE @BatchSize INT = 100000; -- Tamaño de cada lote
--DECLARE @RowsAffected INT = 1; -- Inicializar variable de filas afectadas

--WHILE @RowsAffected > 0
--BEGIN
--    BEGIN TRANSACTION;

--	DELETE TOP (@BatchSize) FROM impPadronTxt 
--	WHERE (Padron_Id = dbo.FuncFKimpPadron(@pPadron_Id))
--	AND (
--		 (anio < @pAnioCaducado) OR
--		 ((anio = @pAnioCaducado) AND (mes <= @pMesCaducado) and (Trimestre <= @pTrimestreCaducado))
--		 )
--	AND not exists (select 1 from genEntidades where genEntidades.Cuit = impPadronTxt.Cuit)

--    SET @RowsAffected = @@ROWCOUNT;

--    IF @@ERROR <> 0
--    BEGIN
--        COMMIT; -- Confirmar los cambios hasta el punto del error
--        BREAK; -- Salir del bucle en caso de error
--    END

--    COMMIT; -- Confirmar los cambios del lote actual
--END

--Borro los que se quieren volver a importar
DELETE FROM impPadronTxt 
WHERE (Padron_Id = dbo.FuncFKimpPadron(@pPadron_Id))
AND anio = @pAnio 
AND mes = @pMes 
AND trimestre = @pTrimestre


RETURN @@Error 

GO
