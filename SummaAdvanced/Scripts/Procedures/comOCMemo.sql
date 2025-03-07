DROP PROCEDURE comOCMemoGuardar
GO
CREATE PROCEDURE comOCMemoGuardar
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pDetalle varchar(2000),
@pCuenta_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comOCMemo WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)))
BEGIN 
	UPDATE comOCMemo
	SET		Detalle = @pDetalle,
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id)
	WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)
END 
ELSE 
BEGIN 
	INSERT INTO comOCMemo
	(
		comOrdenComp,
		Renglon_OC,
		Detalle,
		Cuenta_Id
	)
	VALUES 
	(
		@pcomOrdenComp,
		@pRenglon_OC,
		@pDetalle,
		dbo.FuncFKconCuentas(@pCuenta_Id)
	)
END 

GO

DROP PROCEDURE comOCMemoDatos
GO
CREATE PROCEDURE comOCMemoDatos
(
@pcomOrdenComp int,
@pRenglon_OC int= null
)
AS
SET NOCOUNT ON 

SELECT comOCMemo.comOrdenComp, comOCMemo.Renglon_OC, comOCMemo.Detalle,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, 
	comOCCuerpo.Cantidad, comOCCuerpo.Cantidad_Recibida, comOcCuerpo.Cantidad_Embarcada,
	comOCCuerpo.Cantidad_Facturada, comOCCuerpo.Fecha_Entrega, comOCCuerpo.Precio, comOCCuerpo.Pendiente,
	comOCCuerpo.Cantidad_Creditos, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	comOCCuerpo.CantidadConsignada, cast(0 as bit) as Marca, comOCCuerpo.Observaciones
FROM comOCMemo 
INNER JOIN comOCCuerpo  ON (comOCCuerpo.comOrdenComp = comOCMemo.comOrdenComp) AND (comOCCuerpo.Renglon_OC = comOCMemo.Renglon_OC)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comOCMemo.Cuenta_Id)
INNER JOIN comOrdenComp  ON (comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOCCuerpo.Medida_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comOCCuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comOCCuerpo.Centro2_Id)
WHERE (comOCMemo.comOrdenComp = @pcomOrdenComp)
AND (comOCMemo.Renglon_OC = isNull(@pRenglon_OC,comOCMemo.Renglon_oc))
 
 RETURN @@Error 

GO

DROP PROCEDURE comOCMemoEliminar
GO
CREATE PROCEDURE comOCMemoEliminar
(
@pcomOrdenComp int,
@pRenglon_OC int= NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comOCMemo 
WHERE (comOrdenComp = @pcomOrdenComp)
AND (comOCMemo.Renglon_OC = isNull(@pRenglon_OC,comOCMemo.Renglon_oc))
 
 RETURN @@Error 

GO

GO
