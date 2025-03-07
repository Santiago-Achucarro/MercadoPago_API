DROP PROCEDURE impRetCFDIDividendosGuardar
GO
CREATE PROCEDURE impRetCFDIDividendosGuardar
(
@pimpRetencionesCFDI int,
@pCveTipDivOUtil varchar(2),
@pMontISRAcredRetMexico numeric(18,4),
@pMontISRAcredRetExtranjero numeric(18,4),
@pMontRetExtDivExt numeric(18,4),
@pTipoSocDistrDiv char(20),
@pMontISRAcredNal numeric(18,4),
@pMontDivAcumNal numeric(18,4),
@pMontDivAcumExt numeric(18,4),
@pProporcionRem numeric(10,6)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIDividendos WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIDividendos
	SET		CveTipDivOUtil = @pCveTipDivOUtil,
		MontISRAcredRetMexico = @pMontISRAcredRetMexico,
		MontISRAcredRetExtranjero = @pMontISRAcredRetExtranjero,
		MontRetExtDivExt = @pMontRetExtDivExt,
		TipoSocDistrDiv = @pTipoSocDistrDiv,
		MontISRAcredNal = @pMontISRAcredNal,
		MontDivAcumNal = @pMontDivAcumNal,
		MontDivAcumExt = @pMontDivAcumExt,
		ProporcionRem = @pProporcionRem
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIDividendos
	(
		impRetencionesCFDI,
		CveTipDivOUtil,
		MontISRAcredRetMexico,
		MontISRAcredRetExtranjero,
		MontRetExtDivExt,
		TipoSocDistrDiv,
		MontISRAcredNal,
		MontDivAcumNal,
		MontDivAcumExt,
		ProporcionRem
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pCveTipDivOUtil,
		@pMontISRAcredRetMexico,
		@pMontISRAcredRetExtranjero,
		@pMontRetExtDivExt,
		@pTipoSocDistrDiv,
		@pMontISRAcredNal,
		@pMontDivAcumNal,
		@pMontDivAcumExt,
		@pProporcionRem
	)
END 

GO

DROP PROCEDURE impRetCFDIDividendosDatos
GO
CREATE PROCEDURE impRetCFDIDividendosDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIDividendos.impRetencionesCFDI, impRetCFDIDividendos.CveTipDivOUtil, impRetCFDIDividendos.MontISRAcredRetMexico,
	impRetCFDIDividendos.MontISRAcredRetExtranjero, impRetCFDIDividendos.MontRetExtDivExt, impRetCFDIDividendos.TipoSocDistrDiv, impRetCFDIDividendos.MontISRAcredNal,
	impRetCFDIDividendos.MontDivAcumNal, impRetCFDIDividendos.MontDivAcumExt, impRetCFDIDividendos.ProporcionRem
FROM impRetCFDIDividendos 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIDividendosEliminar
GO
CREATE PROCEDURE impRetCFDIDividendosEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIDividendos 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

GO
