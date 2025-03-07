DROP PROCEDURE impRetCFDIPagosExtrGuardar
GO
CREATE PROCEDURE impRetCFDIPagosExtrGuardar
(
@pimpRetencionesCFDI int,
@pEsBenefEfectDelCobro varchar(2),
@pPais_id int = NULL,
@pConceptoPago varchar(1),
@pDescripcionConcepto varchar(max),
@pBeneRFC varchar(14) = NULL,
@pBeneCURP varchar(18) = NULL,
@pNomDenRazSocB varchar(300) = NULL,
@pBeneConceptoPago varchar(1) = NULL,
@pBeneDescripcionConcepto varchar(max) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIPagosExtr WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIPagosExtr
	SET		EsBenefEfectDelCobro = @pEsBenefEfectDelCobro,
		Pais_id = dbo.FuncFKgenPaises(@pPais_id),
		ConceptoPago = @pConceptoPago,
		DescripcionConcepto = @pDescripcionConcepto,
		BeneRFC = @pBeneRFC,
		BeneCURP = @pBeneCURP,
		NomDenRazSocB = @pNomDenRazSocB,
		BeneConceptoPago = @pBeneConceptoPago,
		BeneDescripcionConcepto = @pBeneDescripcionConcepto
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIPagosExtr
	(
		impRetencionesCFDI,
		EsBenefEfectDelCobro,
		Pais_id,
		ConceptoPago,
		DescripcionConcepto,
		BeneRFC,
		BeneCURP,
		NomDenRazSocB,
		BeneConceptoPago,
		BeneDescripcionConcepto
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pEsBenefEfectDelCobro,
		dbo.FuncFKgenPaises(@pPais_id),
		@pConceptoPago,
		@pDescripcionConcepto,
		@pBeneRFC,
		@pBeneCURP,
		@pNomDenRazSocB,
		@pBeneConceptoPago,
		@pBeneDescripcionConcepto
	)
END 

GO

DROP PROCEDURE impRetCFDIPagosExtrDatos
GO
CREATE PROCEDURE impRetCFDIPagosExtrDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIPagosExtr.impRetencionesCFDI, impRetCFDIPagosExtr.EsBenefEfectDelCobro, genPaises.Pais_id,
	impRetCFDIPagosExtr.ConceptoPago, impRetCFDIPagosExtr.DescripcionConcepto, impRetCFDIPagosExtr.BeneRFC, impRetCFDIPagosExtr.BeneCURP,
	impRetCFDIPagosExtr.NomDenRazSocB, impRetCFDIPagosExtr.BeneConceptoPago, impRetCFDIPagosExtr.BeneDescripcionConcepto
FROM impRetCFDIPagosExtr left join genPaises ON
	genPaises.genPaises = impRetCFDIPagosExtr.Pais_id
	
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIPagosExtrEliminar
GO
CREATE PROCEDURE impRetCFDIPagosExtrEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIPagosExtr 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

