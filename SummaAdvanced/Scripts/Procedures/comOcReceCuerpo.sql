DROP PROCEDURE comOcReceCuerpoGuardar
GO
CREATE PROCEDURE comOcReceCuerpoGuardar
(
@pcomOcRecepcion bigint,
@pconRenglon int,
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8,
@pObservaciones QMemo = NULL,
@pCantFactPendiente qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comOcReceCuerpo WHERE (comOcRecepcion = @pcomOcRecepcion) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE comOcReceCuerpo
	SET comOrdenComp = @pcomOrdenComp,
		Renglon_OC = @pRenglon_OC,
		Cantidad = @pCantidad,
		Observaciones = @pObservaciones,
		CantFactPendiente = @pCantFactPendiente
	WHERE comOcRecepcion = @pcomOcRecepcion AND conRenglon = @pconRenglon
END 
ELSE 
BEGIN 
	INSERT INTO comOcReceCuerpo
	(
		comOcRecepcion,
		conRenglon,
		comOrdenComp,
		Renglon_OC,
		Cantidad,
		Observaciones,
		CantFactPendiente
	)
	VALUES 
	(
		@pcomOcRecepcion,
		@pconRenglon,
		@pcomOrdenComp,
		@pRenglon_OC,
		@pCantidad,
		@pObservaciones,
		@pCantFactPendiente
	)
END 

GO

DROP PROCEDURE comOcReceCuerpoDatos
GO
CREATE PROCEDURE comOcReceCuerpoDatos
(
@pcomOcRecepcion bigint,
@pconRenglon int=null
)
AS
SET NOCOUNT ON 

SELECT comOcReceCuerpo.comOcRecepcion as Asiento_Id, comOcReceCuerpo.conRenglon, 
	comOcReceCuerpo.comOrdenComp,comOcReceCuerpo.Renglon_OC, 
	comOCMemo.Detalle,  comOCCuerpo.Cantidad as CantidadOC,
	comOcReceCuerpo.Cantidad, comOcReceCuerpo.Observaciones,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as  DescripcionCuenta, 
	ISNULL(conCentro1.Centro1_Id,'') Centro1_Id, ISNULL(conCentro1.Descripcion,'') as  DescripcionCentro1, 
	ISNULL(conCentro2.Centro2_Id,'') Centro2_Id, ISNULL(conCentro2.Descripcion,'') as  DescripcionCentro2, 
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal, comOcReceCuerpo.CantFactPendiente
FROM comOcReceCuerpo 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = comOcReceCuerpo.comOcRecepcion) AND (conMovCont.Renglon = comOcReceCuerpo.conRenglon)
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_id
LEFT JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_id
INNER JOIN comOCMemo  ON (comOCMemo.comOrdenComp = comOcReceCuerpo.comOrdenComp) AND (comOCMemo.Renglon_OC = comOcReceCuerpo.Renglon_OC)
INNER JOIN comOCCuerpo ON (comOCCuerpo.comOrdenComp = comOcReceCuerpo.comOrdenComp) AND (comOCCuerpo.Renglon_OC = comOcReceCuerpo.Renglon_OC)
WHERE (comOcReceCuerpo.comOcRecepcion = @pcomOcRecepcion)
AND (comOcReceCuerpo.conRenglon = ISNULL(@pconRenglon,comOcReceCuerpo.conRenglon))
 
 RETURN @@Error 

GO


DROP PROCEDURE comOcReceCuerpoDatosPendientes
GO
CREATE PROCEDURE comOcReceCuerpoDatosPendientes
(
@pComOrdenComp int

)
AS
SET NOCOUNT ON 

SELECT comOcCuerpo.comOrdenComp,comOcCuerpo.Renglon_OC, 
	comOCMemo.Detalle,  comOCCuerpo.Cantidad as CantidadOC,
	comOCCuerpo.Cantidad*0 Cantidad, ' ' as Observaciones,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as  DescripcionCuenta, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as  DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as  DescripcionCentro2, 
	comOcCuerpo.Precio
FROM 
comOCMemo
INNER JOIN comOCCuerpo ON comOCCuerpo.comOrdenComp = comOCMemo.comOrdenComp AND comOCCuerpo.Renglon_OC = comOCMemo.Renglon_OC
INNER JOIN conCuentas ON conCuentas.conCuentas = comOCMemo.Cuenta_Id
INNER JOIN conCentro1 ON conCentro1.conCentro1 = comOCCuerpo.Centro1_id
INNER JOIN conCentro2 ON conCentro2.conCentro2 = comOCCuerpo.Centro2_id
WHERE comOcCuerpo.comOrdencomp = @pcomOrdencomp
order by 2 
RETURN @@Error 

GO

DROP PROCEDURE comOcReceCuerpoEliminar
GO
CREATE PROCEDURE comOcReceCuerpoEliminar
(
@pcomOcRecepcion bigint,
@pconRenglon int= NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comOcReceCuerpo 
WHERE (comOcRecepcion = @pcomOcRecepcion)
AND (conRenglon = ISNULL(@pconRenglon,conRenglon))
 
 RETURN @@Error 

GO

Drop Procedure comOcReceCuerpoActuPendiente
Go
Create Procedure comOcReceCuerpoActuPendiente
(
@pcomOcRecepcion bigint,
@pconRenglon int,
@pCantidad qMonedaD8
)
As
Update comOcReceCuerpo Set CantFactPendiente = CantFactPendiente - @pCantidad Where comOcRecepcion = @pcomOcRecepcion And conRenglon = @pconRenglon
Go

