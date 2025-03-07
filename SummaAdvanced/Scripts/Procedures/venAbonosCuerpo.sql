DROP PROCEDURE venAbonosCuerpoGuardar
GO
CREATE PROCEDURE venAbonosCuerpoGuardar
(
@pvenAbonos int,
@pRenglon int,
@pProducto_Id varchar(25) = NULL,
@pMedida_Id varchar(5) = NULL,
@pFactor qCantidadD8,
@pCantidadOriginal qCantidadD8,
@pCantidad qCantidadD8,
@pPrecioLista qMonedaD8,
@pPrecioListaForm qMonedaD8,
@pTipoPrecioForm char(1),
@pSubTotal qMonedaD8,
@pObservaciones QMemo = NULL,
@pModificaNovedades Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venAbonosCuerpo WHERE (venAbonos = @pvenAbonos) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE venAbonosCuerpo
	SET Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Factor = @pFactor,
		CantidadOriginal = @pCantidadOriginal,
		Cantidad = @pCantidad,
		PrecioLista = @pPrecioLista,
		PrecioListaForm = @pPrecioListaForm,
		TipoPrecioForm = @pTipoPrecioForm,
		SubTotal = @pSubTotal,
		Observaciones = @pObservaciones,
		ModificaNovedades = @pModificaNovedades
	WHERE (venAbonos = @pvenAbonos) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO venAbonosCuerpo
	(
		venAbonos,
		Renglon,
		Producto_Id,
		Medida_Id,
		Factor,
		CantidadOriginal,
		Cantidad,
		PrecioLista,
		PrecioListaForm,
		TipoPrecioForm,
		SubTotal,
		Observaciones,
		ModificaNovedades
	)
	VALUES 
	(
		@pvenAbonos,
		@pRenglon,
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pFactor,
		@pCantidadOriginal,
		@pCantidad,
		@pPrecioLista,
		@pPrecioListaForm,
		@pTipoPrecioForm,
		@pSubTotal,
		@pObservaciones,
		@pModificaNovedades
	)
END 

GO

DROP PROCEDURE venAbonosCuerpoDatos
GO
CREATE PROCEDURE venAbonosCuerpoDatos
(
@pvenAbonos int,
@pRenglon int = Null
)
AS
SET NOCOUNT ON 

SELECT venAbonos.venAbonos, venAbonosCuerpo.Renglon, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, venAbonosCuerpo.Factor, stkCondFisVenta.CFVenta_Id, venAbonosCuerpo.CantidadOriginal,
	venAbonosCuerpo.Cantidad, venAbonosCuerpo.PrecioLista, venAbonosCuerpo.PrecioListaForm, venAbonosCuerpo.TipoPrecioForm,
	venAbonosCuerpo.SubTotal, venAbonosCuerpo.Observaciones, venAbonosCuerpo.ModificaNovedades
FROM venAbonosCuerpo
INNER JOIN venAbonos  ON (venAbonos.venAbonos = venAbonosCuerpo.venAbonos)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = venAbonosCuerpo.Producto_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venAbonosCuerpo.Medida_Id)
LEFT JOIN stkCondFisVenta ON stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id 
WHERE venAbonosCuerpo.venAbonos = @pvenAbonos
AND Renglon = isNull(@pRenglon, Renglon)
 
RETURN @@Error 

GO

DROP PROCEDURE venAbonosCuerpoEliminar
GO
CREATE PROCEDURE venAbonosCuerpoEliminar
(
@pvenAbonos int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venAbonosCuerpo 
WHERE venAbonos = @pvenAbonos
AND Renglon = ISNULL(@pRenglon, Renglon)
 
RETURN @@Error 

GO
