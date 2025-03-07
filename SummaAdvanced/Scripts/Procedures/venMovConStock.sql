DROP PROCEDURE venMovConStockGuardar
GO
CREATE PROCEDURE venMovConStockGuardar
(
@pvenMovimientos bigint,
@pListaPrecio_id varchar(5),
@pTipoPrecioForm char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovConStock WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMovConStock
	SET	ListaPrecio_id = dbo.FuncFKvenListasPrecios(@pListaPrecio_id),
		TipoPrecioForm = @pTipoPrecioForm
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMovConStock
	(
		venMovimientos,
		ListaPrecio_id,
		TipoPrecioForm
	)
	VALUES 
	(
		@pvenMovimientos,
		dbo.FuncFKvenListasPrecios(@pListaPrecio_id),
		@pTipoPrecioForm
	)
END 

GO

DROP PROCEDURE venMovConStockDatos
GO
CREATE PROCEDURE venMovConStockDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venMovConStock.venMovimientos, venListasPrecios.ListaPrecio_Id, 
venListasPrecios.Descripcion as DescripcionListasPrecios, venMovConStock.TipoPrecioForm, venListasPrecios.LlevaImpuestoInclu
FROM venMovConStock 
INNER JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venMovConStock.ListaPrecio_Id)
WHERE (venMovimientos = @pvenMovimientos)
/*
SELECT venMovConStockCr.venMovimientos, venMovConStockCr.RenglonCuerpo,
	stkProductos.Producto_Id, 
	stkProductos.Descripcion as DescripcionProductos, stkDepositos.Deposito_Id,
	stkDepositos.Descripcion as DescripcionDepositos, stkUniMed.Medida_Id, 
	stkUniMed.Descripcion as DescripcionUniMed, venMovConStockCr.Factor,
	venMovConStockCr.CantFacturada, venMovConStockCr.CantEntregada, venMovConStockCr.CantPendiente, 
	venMovConStockCr.CantOriginal, stkMedidaAlterna.Medida_Id MedidaAlterna, venMovConStockCr.CantidadAlternaForm,
	venMovConStockCr.TipoPrecio, venMovConStockCr.PrecioForm, 
	venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta, venMovConStockCr.PrecioFormImpuesto,
	venMovConStockCr.PrecioFormImpuestoBon, venMovConStockCr.PrecioFormImpuestoTot,
	venMovConStockCr.ComiPorce, venMovConStockCr.Bonificacion, 
	venMovConStockCr.Observaciones, venMovConStockCr.FechaEntrega
FROM venMovConStockCr 
INNER JOIN venMovConStock  ON venMovConStock.venMovimientos = venMovConStockCr.venMovimientos
INNER JOIN conMovCont  ON (conMovCont.conAsientos = venMovConStockCr.venMovimientos)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = venMovConStockCr.Producto_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = venMovConStockCr.Deposito_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venMovConStockCr.Medida_Id)
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = venMovConStockCr.Medida_Id
WHERE venMovConStockCr.venMovimientos = @pvenMovimientos
*/
exec venMovConStockCrDatos @pvenMovimientos, Null

SELECT venMovConStockCrCtas.venMovimientos, venMovConStockCrCtas.RenglonCuerpo,
	venMovConStockCrCtas.Renglon, conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuentas, 
	conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1, conCentro2.Centro2_Id,
	conCentro2.Descripcion DescripcionCentro2, conMovCont.TipoMov, conMovCont.Clase, 
	conMovCont.Importe ImporteContable, conMovCont.ImporteMonedaOriginal
FROM venMovConStockCrCtas 
INNER JOIN venMovConStockCr ON venMovConStockCr.venMovimientos = venMovConStockCrCtas.venMovimientos AND
	venMovConStockCr.RenglonCuerpo = venMovConStockCrCtas.RenglonCuerpo
INNER JOIN conMovCont ON conMovCont.conAsientos = venMovConStockCrCtas.venMovimientos AND
	conMovCont.Renglon = venMovConStockCrCtas.Renglon
Inner Join conCuentas On conCuentas.conCuentas = conMovCont.Cuenta_Id
Left Join conCentro1 On conCentro1.conCentro1 = conMovCont.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = conMovCont.Centro2_Id
WHERE venMovConStockCrCtas.venMovimientos = @pvenMovimientos
Order By 2,3

RETURN @@Error 


GO

DROP PROCEDURE venMovConStockEliminar
GO
CREATE PROCEDURE venMovConStockEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venMovConStock 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

