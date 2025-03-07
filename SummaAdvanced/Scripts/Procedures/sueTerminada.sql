DROP PROCEDURE sueTerminadaGuardar
GO
CREATE PROCEDURE sueTerminadaGuardar
(
@psueLiquidacion bigint,
@pLegajo int,
@pConcepto_Id int,
@pDato QCantidad,
@pDato2 QCantidad,
@pImporte qMonedaD2,
@pSigno smallint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueTerminada WHERE (sueLiquidacion = @psueLiquidacion) AND 
	(Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND (Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id))))
BEGIN 
	UPDATE sueTerminada
	SET		Dato = @pDato,
		Dato2 = @pDato2,
		Importe = @pImporte,
		Signo = @pSigno
	WHERE (sueLiquidacion = @psueLiquidacion) AND (Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND 
		(Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id))
END 
ELSE 
BEGIN 
	INSERT INTO sueTerminada
	(
		sueLiquidacion,
		Legajo,
		Concepto_Id,
		Dato,
		Dato2,
		Importe,
		Signo
	)
	VALUES 
	(
		@psueLiquidacion,
		dbo.FuncFKsuePersonal(@pLegajo),
		dbo.FuncFKsueConceptos(@pConcepto_Id),
		@pDato,
		@pDato2,
		@pImporte,
		@pSigno
	)
END 

GO

DROP PROCEDURE sueTerminadaDatos
GO
CREATE PROCEDURE sueTerminadaDatos
(
@psueLiquidacion bigint,
@pLegajo int = NULL ,
@pConcepto_Id int = NULL
)
AS
SET NOCOUNT ON 

SELECT sueTerminada.sueLiquidacion, suePersonal.Legajo, suePersonal.ApellidoPaterno + ',' +
	suePersonal.ApellidoMaterno +','+ suePersonal.Nombres as DescripcionPersonal, 
	sueConceptos.Concepto_Id, 	sueConceptos.Descripcion as DescripcionConceptos, 
	sueTerminada.Dato, sueTerminada.Dato2, sueTerminada.Importe,
	sueTerminada.Signo
FROM sueTerminada 
INNER JOIN sueLiquidacion  ON (sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion)
INNER JOIN suePersonal  ON (suePersonal.genEntidades = sueTerminada.Legajo)
INNER JOIN sueConceptos  ON (sueConceptos.sueConceptos = sueTerminada.Concepto_Id)
WHERE 
sueLiquidacion.sueLiquidacion = @psueLiquidacion
AND suePersonal.Legajo = ISNULL(@pLegajo,suePersonal.Legajo) 
AND sueConceptos.Concepto_Id = ISNULL(@pConcepto_Id,sueConceptos.Concepto_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE sueTerminadaEliminar
GO
CREATE PROCEDURE sueTerminadaEliminar
(
@psueLiquidacion bigint,
@pLegajo int = NULL,
@pConcepto_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueTerminada 
WHERE 
sueLiquidacion = @psueLiquidacion 
AND Legajo = case when @pLegajo is null then Legajo else dbo.FuncFKsuePersonal(@pLegajo) end
AND Concepto_Id = case when @pConcepto_Id IS NULL THEN Concepto_Id ELSE dbo.FuncFKsueConceptos(@pConcepto_Id) END
 
 RETURN @@Error 

GO

