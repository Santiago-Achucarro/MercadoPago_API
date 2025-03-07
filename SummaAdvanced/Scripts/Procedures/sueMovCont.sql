DROP PROCEDURE sueMovContGuardar
GO
CREATE PROCEDURE sueMovContGuardar
(
@psueLiquidacion bigint,
@pLegajo int,
@pConcepto_Id int,
@pCuenta_Id varchar(25),
@pCentro1_Id varchar(8),
@pCentro2_Id varchar(8),
@pImporte qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueMovCont WHERE 
	(Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND 
	(Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id)) AND
	(Cuenta_Id =  dbo.FuncFKconCuentas(@pCuenta_Id)) AND 
	(Centro1_Id = dbo.FuncFkConCentro1(@pCentro1_Id)) AND 
	(Centro2_Id = dbo.FuncFkConCentro2(@pCentro2_Id)) AND 
	(sueLiquidacion = @psueLiquidacion)))

BEGIN 
	UPDATE sueMovCont
	SET		Importe = Importe+ @pImporte
	WHERE 
	(Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND 
	(Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id)) AND
	(Cuenta_Id =  dbo.FuncFKconCuentas(@pCuenta_Id)) AND 
	(Centro1_Id = dbo.FuncFkConCentro1(@pCentro1_Id)) AND 
	(Centro2_Id = dbo.FuncFkConCentro2(@pCentro2_Id)) AND 
	(sueLiquidacion = @psueLiquidacion)
END 
ELSE 
BEGIN 
	INSERT INTO sueMovCont
	(
		Legajo,
		Concepto_Id,
		Cuenta_Id,
		Centro1_Id,
		Centro2_Id,
		sueLiquidacion,
		Importe
	)
	VALUES 
	(
		dbo.FuncFKsuePersonal(@pLegajo),
		dbo.FuncFKsueConceptos(@pConcepto_Id),
		dbo.FuncFKconCuentas(@pCuenta_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@psueLiquidacion,
		@pImporte
	)
END 

GO

DROP PROCEDURE sueMovContDatos
GO
CREATE PROCEDURE sueMovContDatos
(
@psueLiquidacion bigint,
@pLegajo int = null,
@pConcepto_Id int = null,
@pCuenta_Id varchar(25) = null,
@pCentro1_Id varchar(8) = null,
@pCentro2_Id varchar(8) = null
)
AS
SET NOCOUNT ON 

SELECT sueMovCont.sueLiquidacion ,
	suePersonal.Legajo, suePersonal.ApellidoPaterno+','+suePersonal.ApellidoMaterno+','+
		suePersonal.Nombres as DescripcionLegajo,
	sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConcepto, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	sueMovCont.Importe
FROM sueMovCont 
INNER JOIN conCuentas  ON (conCuentas.conCuentas = sueMovCont.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = sueMovCont.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = sueMovCont.Centro2_Id)
INNER JOIN suePersonal ON (suePersonal.genEntidades = sueMovCont.Legajo)
INNER JOIN sueConceptos ON (sueConceptos.sueConceptos = sueMovCont.Concepto_Id)
WHERE 
(sueMovCont.sueLiquidacion = @psueLiquidacion)
and (suePersonal.Legajo = ISNULL(@pLegajo,suePersonal.Legajo))
AND (sueConceptos.Concepto_Id = ISNULL(@pConcepto_Id,sueConceptos.Concepto_Id))
AND (concuentas.Cuenta_Id = ISNULL(@pCuenta_Id,concuentas.Cuenta_Id))
AND (conCentro1.Centro1_Id = ISNULL(@pCentro1_Id,conCentro1.Centro1_Id))
AND (conCentro2.Centro2_Id = ISNULL(@pCentro2_Id,conCentro2.Centro2_Id))
ORDER BY 1,2,4
 
RETURN @@Error 

GO

DROP PROCEDURE sueMovContEliminar
GO
CREATE PROCEDURE sueMovContEliminar
(
@psueLiquidacion bigint,
@pLegajo int = null,
@pConcepto_Id int = null,
@pCuenta_Id varchar(25) = null,
@pCentro1_Id varchar(8) = null,
@pCentro2_Id varchar(8) = null
)
AS
SET NOCOUNT ON 

DELETE FROM sueMovCont 
WHERE 
sueLiquidacion = @psueLiquidacion and
Exists(select 1 from suePersonal where
	suePersonal.genEntidades = sueMovCont.Legajo and 
	suePersonal.Legajo = ISNULL(@pLegajo,suePersonal.Legajo)) AND 
Exists(SELECT 1 from sueConceptos WHERE 
	sueConceptos.sueConceptos = sueMovCont.Concepto_id and 
	sueConceptos.Concepto_Id = ISNULL(@pConcepto_Id, sueConceptos.Concepto_Id)) AND 
Exists(SELECT 1 FROM conCuentas WHERE
	conCuentas.conCuentas= sueMovCont.Cuenta_Id and 
	conCuentas.Cuenta_Id = ISNULL(@pCuenta_Id, conCuentas.Cuenta_Id)) AND
Exists(SELECT 1 from conCentro1 WHERE
	conCentro1.conCentro1= sueMovCont.Centro1_Id AND
	conCentro1.Centro1_Id = ISNULL(@pCentro1_Id,conCentro1.Centro1_Id)) AND 
Exists(SELECT 1 from conCentro2 WHERE
	conCentro2.conCentro2= sueMovCont.Centro2_Id AND
	conCentro2.Centro2_Id = ISNULL(@pCentro2_Id,conCentro2.Centro2_Id))

 RETURN @@Error 

 GO


GO

GO
