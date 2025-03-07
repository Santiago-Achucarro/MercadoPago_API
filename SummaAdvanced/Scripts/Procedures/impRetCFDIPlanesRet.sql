DROP PROCEDURE impRetCFDIPlanesRetGuardar
GO
CREATE PROCEDURE impRetCFDIPlanesRetGuardar
(
@pimpRetencionesCFDI int,
@pSistemaFinanc char(2),
@pMontTotAportAnioInmAnterior numeric(18,4),
@pMontIntRealesDevengAniooInmAnt numeric(18,4),
@pHuboRetirosAnioInmAntPer char(2),
@pMontTotRetiradoAnioInmAntPer numeric(18,4),
@pMontTotExentRetiradoAnioInmAnt numeric(18,4),
@pMontTotExedenteAnioInmAnt numeric(18,4),
@pHuboRetirosAnioInmAnt char(2),
@pMontTotRetiradoAnioInmAnt numeric(18,4)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIPlanesRet WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIPlanesRet
	SET		SistemaFinanc = @pSistemaFinanc,
		MontTotAportAnioInmAnterior = @pMontTotAportAnioInmAnterior,
		MontIntRealesDevengAniooInmAnt = @pMontIntRealesDevengAniooInmAnt,
		HuboRetirosAnioInmAntPer = @pHuboRetirosAnioInmAntPer,
		MontTotRetiradoAnioInmAntPer = @pMontTotRetiradoAnioInmAntPer,
		MontTotExentRetiradoAnioInmAnt = @pMontTotExentRetiradoAnioInmAnt,
		MontTotExedenteAnioInmAnt = @pMontTotExedenteAnioInmAnt,
		HuboRetirosAnioInmAnt = @pHuboRetirosAnioInmAnt,
		MontTotRetiradoAnioInmAnt = @pMontTotRetiradoAnioInmAnt
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIPlanesRet
	(
		impRetencionesCFDI,
		SistemaFinanc,
		MontTotAportAnioInmAnterior,
		MontIntRealesDevengAniooInmAnt,
		HuboRetirosAnioInmAntPer,
		MontTotRetiradoAnioInmAntPer,
		MontTotExentRetiradoAnioInmAnt,
		MontTotExedenteAnioInmAnt,
		HuboRetirosAnioInmAnt,
		MontTotRetiradoAnioInmAnt
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pSistemaFinanc,
		@pMontTotAportAnioInmAnterior,
		@pMontIntRealesDevengAniooInmAnt,
		@pHuboRetirosAnioInmAntPer,
		@pMontTotRetiradoAnioInmAntPer,
		@pMontTotExentRetiradoAnioInmAnt,
		@pMontTotExedenteAnioInmAnt,
		@pHuboRetirosAnioInmAnt,
		@pMontTotRetiradoAnioInmAnt
	)
END 

GO

DROP PROCEDURE impRetCFDIPlanesRetDatos
GO
CREATE PROCEDURE impRetCFDIPlanesRetDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIPlanesRet.impRetencionesCFDI, impRetCFDIPlanesRet.SistemaFinanc, impRetCFDIPlanesRet.MontTotAportAnioInmAnterior,
	impRetCFDIPlanesRet.MontIntRealesDevengAniooInmAnt, impRetCFDIPlanesRet.HuboRetirosAnioInmAntPer, impRetCFDIPlanesRet.MontTotRetiradoAnioInmAntPer, impRetCFDIPlanesRet.MontTotExentRetiradoAnioInmAnt,
	impRetCFDIPlanesRet.MontTotExedenteAnioInmAnt, impRetCFDIPlanesRet.HuboRetirosAnioInmAnt, impRetCFDIPlanesRet.MontTotRetiradoAnioInmAnt
FROM impRetCFDIPlanesRet 

WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIPlanesRetEliminar
GO
CREATE PROCEDURE impRetCFDIPlanesRetEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIPlanesRet 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

GO
