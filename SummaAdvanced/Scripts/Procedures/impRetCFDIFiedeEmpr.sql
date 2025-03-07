DROP PROCEDURE impRetCFDIFiedeEmprGuardar
GO
CREATE PROCEDURE impRetCFDIFiedeEmprGuardar
(
@pimpRetencionesCFDI int,
@pMontTotEntradasPeriodo numeric(18,4),
@pPartPropAcumDelFideicom numeric(18,4),
@pPropDelMontTot numeric(10,6),
@pConcepto varchar(100),
@pMontTotEgresPeriodo numeric(18,4),
@pPartPropDelFideicom numeric(18,4),
@pPropDelMontTotE numeric(10,6),
@pConseptoS varchar(100),
@pMontRetRelPagFideic numeric(18,4),
@pDescRetRelPagFideic varchar(100)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIFiedeEmpr WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIFiedeEmpr
	SET		MontTotEntradasPeriodo = @pMontTotEntradasPeriodo,
		PartPropAcumDelFideicom = @pPartPropAcumDelFideicom,
		PropDelMontTot = @pPropDelMontTot,
		Concepto = @pConcepto,
		MontTotEgresPeriodo = @pMontTotEgresPeriodo,
		PartPropDelFideicom = @pPartPropDelFideicom,
		PropDelMontTotE = @pPropDelMontTotE,
		ConseptoS = @pConseptoS,
		MontRetRelPagFideic = @pMontRetRelPagFideic,
		DescRetRelPagFideic = @pDescRetRelPagFideic
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIFiedeEmpr
	(
		impRetencionesCFDI,
		MontTotEntradasPeriodo,
		PartPropAcumDelFideicom,
		PropDelMontTot,
		Concepto,
		MontTotEgresPeriodo,
		PartPropDelFideicom,
		PropDelMontTotE,
		ConseptoS,
		MontRetRelPagFideic,
		DescRetRelPagFideic
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pMontTotEntradasPeriodo,
		@pPartPropAcumDelFideicom,
		@pPropDelMontTot,
		@pConcepto,
		@pMontTotEgresPeriodo,
		@pPartPropDelFideicom,
		@pPropDelMontTotE,
		@pConseptoS,
		@pMontRetRelPagFideic,
		@pDescRetRelPagFideic
	)
END 

GO

DROP PROCEDURE impRetCFDIFiedeEmprDatos
GO
CREATE PROCEDURE impRetCFDIFiedeEmprDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIFiedeEmpr.impRetencionesCFDI, impRetCFDIFiedeEmpr.MontTotEntradasPeriodo, impRetCFDIFiedeEmpr.PartPropAcumDelFideicom,
	impRetCFDIFiedeEmpr.PropDelMontTot, impRetCFDIFiedeEmpr.Concepto, impRetCFDIFiedeEmpr.MontTotEgresPeriodo, impRetCFDIFiedeEmpr.PartPropDelFideicom,
	impRetCFDIFiedeEmpr.PropDelMontTotE, impRetCFDIFiedeEmpr.ConseptoS, impRetCFDIFiedeEmpr.MontRetRelPagFideic, impRetCFDIFiedeEmpr.DescRetRelPagFideic
FROM impRetCFDIFiedeEmpr 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIFiedeEmprEliminar
GO
CREATE PROCEDURE impRetCFDIFiedeEmprEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIFiedeEmpr 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

