DROP PROCEDURE venMovConStockCrGuardar
GO
CREATE PROCEDURE venMovConStockCrGuardar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int,
@pProducto_Id varchar(25) = NULL,
@pDeposito_Id varchar(15) = NULL,
@pMedida_Id varchar(5) = NULL,
@pFactor qCantidadD8,
@pCantFacturada qCantidadD8,
@pCantEntregada qCantidadD8,
@pCantPendiente qCantidadD8,
@pCantOriginal qCantidadD8,
@pMedidaAlterna varChar(5) = Null,
@pCantidadAlternaForm qCantidadD8,
@pTipoPrecio char(1),
@pPrecioForm qMonedaD8,
@pPrecioSinIva qMonedaD8,
@pPrecioLista qMonedaD8,
@pPrecioVenta qMonedaD8,
@pPrecioFormImpuesto qMonedaD8,
@pPrecioFormImpuestoBon qMonedaD8,
@pPrecioFormImpuestoTot qMonedaD8,
@pComiPorce qPorcentaje,
@pBonificacion qPorcentaje,
@pObservaciones QMemo = NULL,
@pFechaEntrega qFecha,
@pSubTotal qMonedaD2,
@pSubTotalFormImpuesto qMonedaD2,
@pCentro1_Id varChar(8) = NUll,
@pCentro2_Id varChar(8) = NUll,
@pCantEntregadaForm QCantidadD8 
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovConStockCr WHERE (venMovimientos = @pvenMovimientos) AND (RenglonCuerpo = @pRenglonCuerpo)))
BEGIN 
	UPDATE venMovConStockCr
	SET		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id),
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Factor = @pFactor,
		CantFacturada = @pCantFacturada,
		CantEntregada = @pCantEntregada,
		CantPendiente = @pCantPendiente,
		CantOriginal = @pCantOriginal,
		MedidaAlterna = dbo.FuncFKstkUniMed(@pMedidaAlterna),
		CantidadAlternaForm = @pCantidadAlternaForm,
		TipoPrecio = @pTipoPrecio,
		PrecioForm = @pPrecioForm,
		PrecioSinIva = @pPrecioSinIva,
		PrecioLista = @pPrecioLista,
		PrecioVenta = @pPrecioVenta,
		PrecioFormImpuesto = @pPrecioFormImpuesto,
		PrecioFormImpuestoBon = @pPrecioFormImpuestoBon,
		PrecioFormImpuestoTot = @pPrecioFormImpuestoTot,
		ComiPorce = @pComiPorce,
		Bonificacion = @pBonificacion,
		Observaciones = @pObservaciones,
		FechaEntrega = @pFechaEntrega,
		SubTotal = @pSubTotal,
		SubTotalFormImpuesto = @pSubTotalFormImpuesto,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id), 
		CantEntregadaForm = @pCantEntregadaForm
	WHERE (venMovimientos = @pvenMovimientos) AND (RenglonCuerpo = @pRenglonCuerpo)
END 
ELSE 
BEGIN 
	INSERT INTO venMovConStockCr
	(
		venMovimientos,
		RenglonCuerpo,
		Producto_Id,
		Deposito_Id,
		Medida_Id,
		Factor,
		CantFacturada,
		CantEntregada,
		CantPendiente,
		CantOriginal,
		MedidaAlterna,
		CantidadAlternaForm,
		TipoPrecio,
		PrecioForm,
		PrecioSinIva,
		PrecioLista,
		PrecioVenta,
		PrecioFormImpuesto,
		PrecioFormImpuestoBon,
		PrecioFormImpuestoTot,
		ComiPorce,
		Bonificacion,
		Observaciones,
		FechaEntrega,
		SubTotal,
		SubTotalFormImpuesto,
		Centro1_Id,
		Centro2_Id,
		CantEntregadaForm
	)
	VALUES 
	(
		@pvenMovimientos,
		@pRenglonCuerpo,
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pFactor,
		@pCantFacturada,
		@pCantEntregada,
		@pCantPendiente,
		@pCantOriginal,
		dbo.FuncFKstkUniMed(@pMedidaAlterna),
		@pCantidadAlternaForm,
		@pTipoPrecio,
		@pPrecioForm,
		@pPrecioSinIva,
		@pPrecioLista,
		@pPrecioVenta,
		@pPrecioFormImpuesto,
		@pPrecioFormImpuestoBon,
		@pPrecioFormImpuestoTot,
		@pComiPorce,
		@pBonificacion,
		@pObservaciones,
		@pFechaEntrega,
		@pSubTotal,
		@pSubTotalFormImpuesto,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id), 
		@pCantEntregadaForm
	)
END 

GO

Drop Procedure venMovConStockCrDatos
Go
Create Procedure venMovConStockCrDatos
(
@pvenMovimientos bigint,
@pRenglonCuerpo int = Null
)
As
SELECT venMovConStockCr.venMovimientos, venMovConStockCr.RenglonCuerpo, venMovConStockCr.RenglonCuerpo * 0 RenglonReferencia,
	stkProductos.Producto_Id, stkCondFisVenta.CFVenta_Id,
	stkProductos.Descripcion as DescripcionProductos, stkDepositos.Deposito_Id,
	stkDepositos.Descripcion as DescripcionDepositos, stkUniMed.Medida_Id, 
	stkUniMed.Descripcion as DescripcionUniMed, venMovConStockCr.Factor,
	venMovConStockCr.CantFacturada, venMovConStockCr.CantEntregada, venMovConStockCr.CantPendiente, 
	venMovConStockCr.CantOriginal, stkMedidaAlterna.Medida_Id MedidaAlterna, venMovConStockCr.CantidadAlternaForm,
	venMovConStockCr.TipoPrecio, venMovConStockCr.PrecioForm, venMovConStockCr.PrecioSinIva,
	venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta, venMovConStockCr.PrecioFormImpuesto,
	venMovConStockCr.PrecioFormImpuestoBon, venMovConStockCr.PrecioFormImpuestoTot,
	venMovConStockCr.ComiPorce, venMovConStockCr.Bonificacion, venMovConStockCr.SubTotal, venMovConStockCr.SubTotalFormImpuesto,
	venMovConStockCr.Observaciones, venMovConStockCr.FechaEntrega, 
	venMovimientosCRExpMx.CantidadAduana ,venMovimientosCRExpMx.UnidadAduana ,
	venMovimientosCRExpMx.ValorUnitarioAduana ,venMovimientosCRExpMx.ValorDolares, concentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	concentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2, comDespachos.Despacho_Id, 
	venMovConStockCr.CantEntregadaForm
FROM venMovConStockCr 
INNER JOIN venMovConStock  ON venMovConStock.venMovimientos = venMovConStockCr.venMovimientos
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = venMovConStockCr.Producto_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = venMovConStockCr.Deposito_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venMovConStockCr.Medida_Id)
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = venMovConStockCr.Medida_Id
Left Join stkCondFisVenta On stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id
Left outer join venMovimientosCRExpMx ON 
	venMovimientosCRExpMx.venMovimientos = venMovConStockCr.venMovimientos AND 
	venMovimientosCRExpMx.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
Left Join conCentro1 On conCentro1.conCentro1 = venMovConStockCr.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = venMovConStockCr.Centro2_Id
Left Join (Select venMovStkHist.venMovimientos, venMovStkHist.RenglonCuerpo, stkMoviDespa.stkMoviCabe, stkMoviDespa.Renglon, Min(stkMoviDespa.Despacho_Id) Despacho_Id
From venMovStkHist 
	Inner Join stkMoviDespa On stkMoviDespa.stkMoviCabe = venMovStkHist.stkMoviCabe And stkMoviDespa.Renglon = venMovStkHist.Renglon
Group by venMovStkHist.venMovimientos, venMovStkHist.RenglonCuerpo, stkMoviDespa.stkMoviCabe, stkMoviDespa.Renglon
) venMovStkHistDespa
On venMovStkHistDespa.venMovimientos = venMovConStockCr.venMovimientos And venMovStkHistDespa.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
Left Join comDespachos On comDespachos.comDespachos = venMovStkHistDespa.Despacho_Id
WHERE 
venMovConStockCr.venMovimientos = @pvenMovimientos And
venMovConStockCr.RenglonCuerpo = IsNull(@pRenglonCuerpo, venMovConStockCr.RenglonCuerpo)
Order By 2
GO

DROP PROCEDURE venMovConStockCrEliminar
GO
CREATE PROCEDURE venMovConStockCrEliminar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM venMovConStockCr 
WHERE venMovimientos = @pvenMovimientos
AND RenglonCuerpo = IsNull(@pRenglonCuerpo, RenglonCuerpo)
 
RETURN @@Error 

GO

DROP PROCEDURE venMovConStockCrCantPendiente
GO
CREATE PROCEDURE venMovConStockCrCantPendiente
(
@pvenMovimientos bigint,
@pRenglonCuerpo int ,
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 

UPDATE venMovConStockCr  SET CantPendiente =  CantPendiente - @pCantidad
	WHERE venMovimientos = @pvenMovimientos AND RenglonCuerpo = @pRenglonCuerpo
 
RETURN @@Error 

GO
