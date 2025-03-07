DROP PROCEDURE stkMoviCuerpoGuardar
GO
CREATE PROCEDURE stkMoviCuerpoGuardar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pFecha qFecha,
@pDeposito_Id varchar(15) = NULL,
@pProducto_Id varchar(25) = NULL,
@pMedida_Id varchar(5) = NULL,
@pFactor qCantidadD8,
@pCantidad qCantidadD8,
@pCantidadForm qCantidadD8,
@pCostoUnitario qMonedaD8,
@pPrecioOriginal qMonedaD8,
@pMedidaAlterna varchar(5) = NULL,
@pCantidadAlternaForm qCantidadD8,
@pObservaciones QMemo = NULL,
@pDescuento qPorcentaje,
@pconRenglonDebe int,
@pconRenglonHaber int
)
AS
-- es siempre insert
/*
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviCuerpo WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE stkMoviCuerpo
	SET		Fecha = @pFecha,
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id),
		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Factor = @pFactor,
		Cantidad = @pCantidad,
		CantidadForm = @pCantidadForm,
		CostoUnitario = @pCostoUnitario,
		PrecioOriginal = @pPrecioOriginal,
		MedidaAlterna = dbo.FuncFKstkUniMed(@pMedidaAlterna),
		CantidadalternaForm = @pCantidadalternaForm,
		Observaciones = @pObservaciones,
		Descuento = @pDescuento,
		conRenglonDebe = @pconRenglonDebe,
		conRenglonHaber = @pconRenglonHaber
	WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)
END 
ELSE 
*/

--BEGIN 
	INSERT INTO stkMoviCuerpo
	(
		stkMoviCabe,
		Renglon,
		Fecha,
		Deposito_Id,
		Producto_Id,
		Medida_Id,
		Factor,
		Cantidad,
		CantidadForm,
		CostoUnitario,
		PrecioOriginal,
		MedidaAlterna,
		CantidadAlternaForm,
		Observaciones,
		Descuento,
		conRenglonDebe,
		conRenglonHaber
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		@pFecha,
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pFactor,
		@pCantidad,
		@pCantidadForm,
		@pCostoUnitario,
		@pPrecioOriginal,
		dbo.FuncFKstkUniMed(@pMedidaAlterna),
		@pCantidadAlternaForm,
		@pObservaciones,
		@pDescuento,
		@pconRenglonDebe,
		@pconRenglonHaber
	)
--END 

GO

DROP PROCEDURE stkMoviCuerpoDatos
GO
CREATE PROCEDURE stkMoviCuerpoDatos
(
@pstkMoviCabe bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

SELECT stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon, 0 RenglonReferencia, stkMoviCuerpo.Fecha,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkMoviCuerpo.Factor, stkMoviCuerpo.Cantidad,
	stkMoviCuerpo.CantidadForm, stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.PrecioOriginal,
	stkMedidaAlterna.Medida_Id MedidaAlterna, stkMedidaAlterna.Descripcion as DescripcionMedidaAlterna,
	stkMoviCuerpo.CantidadAlternaForm,
	stkMoviCuerpo.Observaciones, 0.00 AS Descuento, stkMoviCuerpo.conRenglonDebe, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
	conCentro1Debe.Centro1_id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
	conCentro2Debe.Centro2_id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
	conMovContDebe.Clase as ClaseDebe, conMovContDebe.Importe as ImporteContableDebe, 
	stkMoviCuerpo.conRenglonHaber, 
	conCuentasHaber.Cuenta_id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
	conCentro1Haber.Centro1_id as Centro1Haber, conCentro1Haber.Descripcion as DescripcionCentro1Haber,
	conCentro2Haber.Centro2_id as Centro2Haber, conCentro2Haber.Descripcion as DescripcionCentro2Haber,
	conMovContHaber.Clase as ClaseHaber, conMovContDebe.Importe as ImporteContableHaber, --comDespachos.Despacho_Id
	(Select Top 1 comDespachos.Despacho_Id From stkMoviDespa
		Inner Join comDespachos On comDespachos.comDespachos = stkMoviDespa.Despacho_Id
		Where stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And stkMoviDespa.Renglon = stkMoviCuerpo.Renglon) Despacho_Id
FROM stkMoviCuerpo 
INNER JOIN stkMoviCabe  ON (stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = stkMoviCuerpo.Producto_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = stkMoviCuerpo.stkMoviCabe) AND (conMovCont.Renglon = stkMoviCuerpo.conRenglonDebe)
INNER JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = stkMoviCuerpo.stkMoviCabe) AND (conMovCont2.Renglon = stkMoviCuerpo.conRenglonHaber)
INNER JOIN conMovCont as conMovContDebe ON conMovContDebe.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContDebe.Renglon = stkMoviCuerpo.conRenglonDebe
INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = conMovContDebe.cuenta_id 
LEFT JOIN conCentro1 as conCentro1Debe ON conCentro1Debe.conCentro1 = conMovContDebe.Centro1_id
LEFT  JOIN conCentro2  as conCentro2Debe ON conCentro2Debe.conCentro2 = conMovContDebe.Centro2_id
INNER JOIN conMovCont as conMovContHaber ON conMovContHaber.conAsientos = stkMoviCuerpo.stkMoviCabe And
	conMovContHaber.Renglon = stkMoviCuerpo.conRenglonHaber
INNER JOIN conCuentas as conCuentasHaber ON conCuentasHaber.conCuentas = conMovContHaber.cuenta_id 
LEFT JOIN conCentro1 as conCentro1Haber ON conCentro1Haber.conCentro1 = conMovContHaber.Centro1_id
LEFT JOIN conCentro2  as conCentro2Haber ON conCentro2Haber.conCentro2 = conMovContHaber.Centro2_id
LEFT JOIN stkUniMed stkMedidaAlterna ON stkMedidaAlterna.stkUniMed = stkMoviCuerpo.MedidaAlterna
--Left Join stkMoviDespa On stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And stkMoviDespa.Renglon = stkMoviCuerpo.Renglon
--Left Join comDespachos On comDespachos.comDespachos = stkMoviDespa.Despacho_Id
WHERE (stkMoviCuerpo.stkMoviCabe = @pstkMoviCabe)
AND (stkMoviCuerpo.Renglon = ISNULL(@pRenglon, stkMoviCuerpo.Renglon))
ORDER BY 2 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviCuerpoEliminar
GO
CREATE PROCEDURE stkMoviCuerpoEliminar
(
@pstkMoviCabe bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCuerpo 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO

