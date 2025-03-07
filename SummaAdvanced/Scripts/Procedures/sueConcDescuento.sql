DROP PROCEDURE sueConcDescuentoGuardar
GO
CREATE PROCEDURE sueConcDescuentoGuardar
(
@pLegajo int,
@pConcepto_Id int,
@psueLiquidacion bigint,
@psueConcAcum int,
@pMonto qMonedaD2
)
AS
SET NOCOUNT ON 

Update sueConcAcum Set Acumulado = Acumulado + @pMonto 
Where
	sueConcAcum.Legajo = dbo.FuncFksuePersonal(@pLegajo)
AND sueConcAcum.Concepto_Id = dbo.FuncFksueConceptos(@pConcepto_Id) 
AND sueConcAcum.sueConcAcum = @psueConcAcum

	INSERT INTO sueConcDescuento
	(
		Legajo,
		Concepto_Id,
		sueLiquidacion,
		sueConcAcum,
		Monto
	)
	VALUES 
	(
		dbo.FuncFksuePersonal(@pLegajo),
		dbo.FuncFksueConceptos(@pConcepto_Id),
		@psueLiquidacion,
		@psueConcAcum,
		@pMonto
	)


GO

DROP PROCEDURE sueConcDescuentoDatos
GO
CREATE PROCEDURE sueConcDescuentoDatos
(
@pLegajo int,
@pConcepto_Id int,
@psueLiquidacion bigint,
@psueConcAcum int
)
AS
SET NOCOUNT ON 

SELECT sueConcDescuento.sueLiquidacion, suePersonal.Legajo, 
	sueConceptos.Concepto_Id, sueConcDescuento.Monto, sueConcDescuento.sueConcAcum 
FROM sueConcDescuento 
INNER JOIN sueTerminada  ON (sueTerminada.sueLiquidacion = sueConcDescuento.sueLiquidacion) AND (sueTerminada.Legajo = sueConcDescuento.Legajo) AND (sueTerminada.Concepto_Id = sueConcDescuento.Concepto_Id)
INNER JOIN sueConcAcum  ON (sueConcAcum.sueConcAcum = sueConcDescuento.sueConcAcum)
INNER JOIN suePersonal ON suePersonal.genEntidades = sueConcDescuento.Legajo 
INNER JOIN sueConceptos on  sueConceptos.sueConceptos = sueConcDescuento.Concepto_Id
WHERE (suePersonal.Legajo = @pLegajo)
AND (sueConceptos.Concepto_Id = @pConcepto_Id)
AND (sueConcDescuento.sueLiquidacion = @psueLiquidacion)
AND (sueConcDescuento.sueConcAcum = @psueConcAcum)
 
RETURN @@Error 

GO

DROP PROCEDURE sueConcDescuentoEliminar
GO
CREATE PROCEDURE sueConcDescuentoEliminar
(
@pLegajo int,
@pConcepto_Id int = NULL,
@psueLiquidacion bigint,
@psueConcAcum int = NULL
)
AS
SET NOCOUNT ON 

-- Regreso el Saldo

Update sueConcAcum Set Acumulado = Acumulado -sueConcDescuento.Monto 
from sueConcDescuento 
Where
	sueConcDescuento.sueConcAcum = sueConcAcum.sueConcAcum and 
	(sueConcDescuento.Legajo = dbo.FuncFksuePersonal(@pLegajo))
AND (sueConcDescuento.Concepto_Id = CASE WHEN @pConcepto_Id IS NULL THEN  sueConcDescuento.Concepto_Id ELSE dbo.FuncFksueConceptos(@pConcepto_Id) END)
AND (sueConcDescuento.sueLiquidacion = @psueLiquidacion)
AND (sueConcDescuento.sueConcAcum = ISNULL(@psueConcAcum,sueConcDescuento.sueConcAcum))


DELETE FROM sueConcDescuento 
WHERE (Legajo = dbo.FuncFksuePersonal(@pLegajo))
AND (Concepto_Id = CASE WHEN @pConcepto_Id IS NULL THEN  Concepto_Id ELSE dbo.FuncFksueConceptos(@pConcepto_Id) END)
AND (sueLiquidacion = @psueLiquidacion)
AND (sueConcDescuento.sueConcAcum = ISNULL(@psueConcAcum,sueConcDescuento.sueConcAcum))
 
 RETURN @@Error 

GO

GO
