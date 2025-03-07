DROP PROCEDURE sueTerminadaRetroGuardar
GO
CREATE PROCEDURE sueTerminadaRetroGuardar
(
@psueLiquidacion bigint,
@pLegajo int,
@pConcepto_Id int,
@pAnioRetro int,
@pMesRetro int,
@pImporte qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueTerminadaRetro WHERE (sueLiquidacion = @psueLiquidacion) AND 
	(Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND 
	(Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id)) AND 
	(AnioRetro = @pAnioRetro) AND 
	(MesRetro = @pMesRetro)))
BEGIN 
	UPDATE sueTerminadaRetro
	SET		Importe = @pImporte
	WHERE (sueLiquidacion = @psueLiquidacion) AND 
		(Legajo =  dbo.FuncFKsuePersonal(@pLegajo)) AND 
		(Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id)) AND 
		(AnioRetro = @pAnioRetro) AND 
		(MesRetro = @pMesRetro)
END 
ELSE 
BEGIN 
	INSERT INTO sueTerminadaRetro
	(
		sueLiquidacion,
		Legajo,
		Concepto_Id,
		AnioRetro,
		MesRetro,
		Importe
	)
	VALUES 
	(
		@psueLiquidacion,
		dbo.FuncFKsuePersonal(@pLegajo),
		dbo.FuncFKsueConceptos(@pConcepto_Id),
		@pAnioRetro,
		@pMesRetro,
		@pImporte
	)
END 

GO

DROP PROCEDURE sueTerminadaRetroDatos
GO
CREATE PROCEDURE sueTerminadaRetroDatos
(
@psueLiquidacion bigint,
@pLegajo int,
@pConcepto_Id int,
@pAnioRetro int,
@pMesRetro int
)
AS
SET NOCOUNT ON 

SELECT sueTerminada.sueLiquidacion, suePersonal.Legajo, sueConceptos.Concepto_Id, 
	sueTerminadaRetro.AnioRetro, sueTerminadaRetro.MesRetro, sueTerminadaRetro.Importe
FROM sueTerminadaRetro 
INNER JOIN sueTerminada  ON (sueTerminada.sueLiquidacion = sueTerminadaRetro.sueLiquidacion) AND 
	(sueTerminada.Legajo = sueTerminadaRetro.Legajo) AND 
	(sueTerminada.Concepto_Id = sueTerminadaRetro.Concepto_Id)
INNER JOIN suePersonal ON  suePersonal.genEntidades = sueTerminada.Legajo 
INNER JOIN sueConceptos ON  sueConceptos.sueConceptos = sueTerminada.Concepto_Id
WHERE (sueTerminada.sueLiquidacion = @psueLiquidacion)
AND (suePersonal.Legajo = @pLegajo)
AND (sueConceptos.Concepto_Id = @pConcepto_Id)
AND (AnioRetro = @pAnioRetro)
AND (MesRetro = @pMesRetro)
 
 RETURN @@Error 

GO

DROP PROCEDURE sueTerminadaRetroEliminar
GO
CREATE PROCEDURE sueTerminadaRetroEliminar
(
@psueLiquidacion bigint,
@pLegajo INT = NULL,
@pConcepto_Id int = NULL,
@pAnioRetro int = NULL,
@pMesRetro int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueTerminadaRetro 
WHERE 
(sueLiquidacion = @psueLiquidacion)
AND Legajo = case when @pLegajo is null then Legajo else dbo.FuncFKsuePersonal(@pLegajo) end
AND Concepto_Id = case when @pConcepto_Id IS NULL THEN Concepto_Id ELSE dbo.FuncFKsueConceptos(@pConcepto_Id) END
AND (AnioRetro = ISNULL(@pAnioRetro, AnioRetro))
AND (MesRetro = ISNULL(@pMesRetro, MesRetro))
 
 RETURN @@Error 

GO

GO
