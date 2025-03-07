DROP PROCEDURE impRetCFDIInteresesGuardar
GO
CREATE PROCEDURE impRetCFDIInteresesGuardar
(
@pimpRetencionesCFDI int,
@pSistFinanciero varchar(2),
@pRetiroAORESRetInt varchar(2),
@pOperFinancDerivad varchar(2),
@pMontIntNominal numeric(18,4),
@pMontIntReal numeric(18,4),
@pPerdida numeric(18,4)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIIntereses WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIIntereses
	SET		impRetencionesCFDI=@pimpRetencionesCFDI,
			SistFinanciero = @pSistFinanciero ,
			RetiroAORESRetInt =@pRetiroAORESRetInt, 
			OperFinancDerivad=@pOperFinancDerivad,
			MontIntNominal= @pMontIntNominal ,
			MontIntReal =@pMontIntReal ,
			Perdida =@pPerdida 
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIIntereses
	(
			impRetencionesCFDI,
			SistFinanciero,
			RetiroAORESRetInt, 
			OperFinancDerivad,
			MontIntNominal ,
			MontIntReal ,
			Perdida
	)
	VALUES 
	(
			@pimpRetencionesCFDI,
			@pSistFinanciero ,
			@pRetiroAORESRetInt, 
			@pOperFinancDerivad,
			@pMontIntNominal ,
			@pMontIntReal ,
			@pPerdida 
	)
END 

GO

DROP PROCEDURE impRetCFDIInteresesDatos
GO

CREATE PROCEDURE impRetCFDIInteresesDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT	impRetencionesCFDI,	SistFinanciero,	RetiroAORESRetInt,OperFinancDerivad,MontIntNominal ,MontIntReal ,Perdida
FROM impRetCFDIIntereses 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIInteresesEliminar
GO
CREATE PROCEDURE impRetCFDIInteresesEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIIntereses 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

GO
