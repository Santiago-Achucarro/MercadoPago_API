DROP PROCEDURE sueDatoRetroGuardar
GO
CREATE PROCEDURE sueDatoRetroGuardar
(
@psueLiquidacion bigint,
@pLegajo int,
@pConcepto_Id int,
@pAnioRetro smallint,
@pMesRetro smallint,
@pDato QCantidad,
@pDato2 QCantidad
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueDatoRetro WHERE (sueLiquidacion = @psueLiquidacion) AND (Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND 
(Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id)) AND (AnioRetro = @pAnioRetro) AND (MesRetro = @pMesRetro)))
BEGIN 
	UPDATE sueDatoRetro
	SET		Dato = @pDato,
		Dato2 = @pDato2
	WHERE (sueLiquidacion = @psueLiquidacion) AND (Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND (Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id))
	AND (AnioRetro = @pAnioRetro) AND (MesRetro = @pMesRetro)
END 
ELSE 
BEGIN 
	INSERT INTO sueDatoRetro
	(
		sueLiquidacion,
		Legajo,
		Concepto_Id,
		AnioRetro,
		MesRetro,
		Dato,
		Dato2
	)
	VALUES 
	(
		@psueLiquidacion,
		dbo.FuncFKsuePersonal(@pLegajo),
		dbo.FuncFKsueConceptos(@pConcepto_Id),
		@pAnioRetro,
		@pMesRetro,
		@pDato,
		@pDato2
	)
END 

GO


DROP PROCEDURE sueDatoRetroEliminar
GO
CREATE PROCEDURE sueDatoRetroEliminar
(
@psueLiquidacion bigint,
@pLegajo int,
@pConcepto_Id int = NULL,
@pAnioRetro smallint = NULL,
@pMesRetro smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueDatoRetro 
WHERE (sueLiquidacion = @psueLiquidacion)
AND (Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND 
	(Concepto_Id = ISNULL(dbo.FuncFKsueConceptos(@pConcepto_Id),Concepto_Id))
AND (AnioRetro = ISNULL(@pAnioRetro, AnioRetro))
AND (MesRetro = ISNULL(@pMesRetro, MesRetro))
 
 RETURN @@Error 

GO

DROP PROCEDURE sueDatoRetroDatos
GO
CREATE PROCEDURE sueDatoRetroDatos
(
@psueLiquidacion Bigint,
@pLegajo int,
@pConcepto_Id int
)
as
SELECT sueDatoRetro.sueLiquidacion, suePersonal.Legajo, 
	sueConceptos.Concepto_Id, sueDatoRetro.AnioRetro, 
	sueDatoRetro.MesRetro, sueDatoRetro.Dato
From sueDatoRetro 
	INNER JOIN suePersonal ON suePersonal.genEntidades = sueDatoRetro.Legajo
	INNER JOIN sueConceptos ON sueConceptos.sueConceptos = sueDatoRetro.Concepto_Id
	Where
			sueDatoRetro.sueLiquidacion = @pSueLiquidacion and
			suePersonal.Legajo = @pLegajo and 
			sueConceptos.Concepto_Id = @pConcepto_id
order by 4,5
GO	