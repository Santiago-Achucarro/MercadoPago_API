DROP PROCEDURE venMovDetalleGuardar
GO
CREATE PROCEDURE venMovDetalleGuardar
(
@pvenMovimientos bigint,
@pconRenglon int,
@pDetalle QMemo,
@pCFVenta_Id varchar(5) = NULL,
@pCantidad qMonedaD8,
@pMedida_Id varchar(5) = NULL,
@pImporteUnitario qMonedaD8,
@pSubTotal qMonedaD2,
@pImporteUnitarioDelImpuesto qMonedaD8, 
@pSubTotalFormImpuesto qMonedaD2,
@pCodigoFiscal VarChar(20) = NULL, 
@pProducto_Id VarChar(25) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovDetalle WHERE (venMovimientos = @pvenMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE venMovDetalle
	SET Detalle = @pDetalle,
		CFVenta_Id = dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		Cantidad = @pCantidad,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		ImporteUnitario = @pImporteUnitario,
		SubTotal = @pSubTotal,
		ImporteUnitarioDelImpuesto = @pImporteUnitarioDelImpuesto,
		SubTotalFormImpuesto = @pSubTotalFormImpuesto,
		CodigoFiscal =@pCodigoFiscal,
		Producto_Id = @pProducto_Id
	WHERE (venMovimientos = @pvenMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO venMovDetalle
	(
		venMovimientos,
		conRenglon,
		Detalle,
		CFVenta_Id,
		Cantidad,
		Medida_Id,
		ImporteUnitario,
		SubTotal,
		ImporteUnitarioDelImpuesto,
		SubTotalFormImpuesto,
		CodigoFiscal, 
		Producto_Id
	)
	VALUES 
	(
		@pvenMovimientos,
		@pconRenglon,
		@pDetalle,
		dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		@pCantidad,
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pImporteUnitario,
		@pSubTotal,
		@pImporteUnitarioDelImpuesto, 
		@pSubTotalFormImpuesto,
		@pCodigoFiscal, 
		@pProducto_Id
	)
END 

GO

DROP PROCEDURE venMovDetalleDatos
GO
CREATE PROCEDURE venMovDetalleDatos
(
@pvenMovimientos bigint,
@pconRenglon int = Null
)
AS
SET NOCOUNT ON 

SELECT venMovDetalle.venMovimientos, venMovDetalle.conRenglon,
	venMovDetalle.Detalle, stkCondFisVenta.CFVenta_Id, stkCondFisVenta.Descripcion as DescripcionCondFisVenta,
	venMovDetalle.Cantidad, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, venMovDetalle.ImporteUnitario,
	venMovDetalle.SubTotal, venMovDetalle.ImporteUnitarioDelImpuesto, venMovDetalle.SubTotalFormImpuesto,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	conMovCont.TipoMov, conMovCont.Clase, conMovCont.Importe as ImporteContable, 
	venMovDetalle.CodigoFiscal, venMovDetalle.Producto_Id, venMoviPredial.CuentaPredial
FROM venMovDetalle 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = venMovDetalle.venMovimientos) AND (conMovCont.Renglon = venMovDetalle.conRenglon)
LEFT JOIN stkCondFisVenta  ON (stkCondFisVenta.stkCondFisVenta = venMovDetalle.CFVenta_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venMovDetalle.Medida_Id)
Left JOIN conCuentas ON conCuentas.conCuentas = conMovCont.cuenta_Id 
Left JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
Left JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
Left JOIN venMoviPredial ON venMoviPredial.venMovimientos = venMovDetalle.venMovimientos and 
						venMoviPredial.conRenglon = venMovDetalle.conRenglon
WHERE venMovDetalle.venMovimientos = @pvenMovimientos
AND venMovDetalle.conRenglon = IsNull(@pconRenglon, venMovDetalle.conRenglon)
 Order By 2
 RETURN @@Error 

GO

DROP PROCEDURE venMovDetalleEliminar
GO
CREATE PROCEDURE venMovDetalleEliminar
(
@pvenMovimientos bigint,
@pconRenglon int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM venMovDetalle 
WHERE (venMovimientos = @pvenMovimientos)
AND (conRenglon = IsNull(@pconRenglon, conRenglon))
 
 RETURN @@Error 

GO

GO
