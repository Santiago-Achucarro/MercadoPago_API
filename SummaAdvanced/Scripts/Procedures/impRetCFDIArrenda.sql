DROP PROCEDURE impRetCFDIArrendaGuardar
GO
CREATE PROCEDURE impRetCFDIArrendaGuardar
(
@pimpRetencionesCFDI int,
@pPagProvEfecPorFiduc numeric(18,4),
@pRendimFideicom numeric(18,4),
@pDeduccCorresp numeric(18,4),
@pMontTotRet numeric(18,4),
@pMontResFiscDistFibras numeric(18,4),
@pMontOtrosConceptDistr numeric(18,4),
@pDescrMontOtrosConceptDistr varchar(200)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIArrenda WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIArrenda
	SET		PagProvEfecPorFiduc = @pPagProvEfecPorFiduc,
		RendimFideicom = @pRendimFideicom,
		DeduccCorresp = @pDeduccCorresp,
		MontTotRet = @pMontTotRet,
		MontResFiscDistFibras = @pMontResFiscDistFibras,
		MontOtrosConceptDistr = @pMontOtrosConceptDistr,
		DescrMontOtrosConceptDistr = @pDescrMontOtrosConceptDistr
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIArrenda
	(
		impRetencionesCFDI,
		PagProvEfecPorFiduc,
		RendimFideicom,
		DeduccCorresp,
		MontTotRet,
		MontResFiscDistFibras,
		MontOtrosConceptDistr,
		DescrMontOtrosConceptDistr
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pPagProvEfecPorFiduc,
		@pRendimFideicom,
		@pDeduccCorresp,
		@pMontTotRet,
		@pMontResFiscDistFibras,
		@pMontOtrosConceptDistr,
		@pDescrMontOtrosConceptDistr
	)
END 

GO

DROP PROCEDURE impRetCFDIArrendaDatos
GO
CREATE PROCEDURE impRetCFDIArrendaDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIArrenda.impRetencionesCFDI, impRetCFDIArrenda.PagProvEfecPorFiduc, impRetCFDIArrenda.RendimFideicom,
	impRetCFDIArrenda.DeduccCorresp, impRetCFDIArrenda.MontTotRet, impRetCFDIArrenda.MontResFiscDistFibras, impRetCFDIArrenda.MontOtrosConceptDistr,
	impRetCFDIArrenda.DescrMontOtrosConceptDistr
FROM impRetCFDIArrenda 
WHERE (impRetCFDIArrenda.impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIArrendaEliminar
GO
CREATE PROCEDURE impRetCFDIArrendaEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIArrenda 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

