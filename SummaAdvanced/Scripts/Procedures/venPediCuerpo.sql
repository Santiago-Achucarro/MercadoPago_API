DROP PROCEDURE venPediCuerpoGuardar
GO
CREATE PROCEDURE venPediCuerpoGuardar
(
@pvenPedidos int,
@pRenglon_Pe int,
@pProducto_Id varchar(25) = NULL,
@pMedida_Id varchar(5) = NULL,
@pDeposito_Id varchar(15) = NULL,
@pFactor qCantidadD8,
@pCantidadOriginal qCantidadD8,
@pCantidadPedida qCantidadD8,
@pCantidadRemitida qCantidadD8,
@pCantidadFacturada qCantidadD8,
@pPrecioForm qMonedaD8,
@pPrecioSinIva qMonedaD8,
@pPrecioLista qMonedaD8,
@pPrecioListaForm qMonedaD8,
@pPrecioVenta qCantidadD8,
@pTipoPrecio Char(1),
@pSubTotal qMonedaD2,
@pFechaEntrega qFecha,
@pEspecial Sino,
@pBonificacion qPorcentaje,
@pObservaciones QMemo = NULL,
@pPendiente Sino,
@pReservaMercaderia Sino,
@pCentro1_Id varChar(8) = NUll,
@pCentro2_Id varChar(8) = NUll
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venPediCuerpo WHERE (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe)))
BEGIN 
	UPDATE venPediCuerpo
	SET	Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id),
		Factor = @pFactor,
		CantidadOriginal = @pCantidadOriginal,
		CantidadPedida = @pCantidadPedida,
		CantidadRemitida = @pCantidadRemitida,
		CantidadFacturada = @pCantidadFacturada,
		PrecioForm = @pPrecioForm,
		PrecioSinIva = @pPrecioSinIva,
		PrecioLista = @pPrecioLista,
		PrecioListaForm = @pPrecioListaForm,
		PrecioVenta = @pPrecioVenta,
		TipoPrecio = @pTipoPrecio,
		SubTotal = @pSubTotal,
		FechaEntrega = @pFechaEntrega,
		Especial = @pEspecial,
		Bonificacion = @pBonificacion,
		Observaciones = @pObservaciones,
		Pendiente = @pPendiente,
		ReservaMercaderia = @pReservaMercaderia,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id)
		WHERE (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe)
END 
ELSE 
BEGIN 
	INSERT INTO venPediCuerpo
	(
		venPedidos,
		Renglon_Pe,
		Producto_Id,
		Medida_Id,
		Deposito_Id,
		Factor,
		CantidadOriginal,
		CantidadPedida,
		CantidadRemitida,
		CantidadFacturada,
		PrecioForm,
		PrecioSinIva,
		PrecioLista,
		PrecioListaForm,
		PrecioVenta,
		TipoPrecio,
		SubTotal,
		FechaEntrega,
		Especial,
		Bonificacion,
		Observaciones,
		Pendiente,
		ReservaMercaderia,
		Centro1_Id,
		Centro2_Id
	)
	VALUES 
	(
		@pvenPedidos,
		@pRenglon_Pe,
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkUniMed(@pMedida_Id),
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		@pFactor,
		@pCantidadOriginal,
		@pCantidadPedida,
		@pCantidadRemitida,
		@pCantidadFacturada,
		@pPrecioForm,
		@pPrecioSinIva,
		@pPrecioLista,
		@pPrecioListaForm,
		@pPrecioVenta,
		@pTipoPrecio,
		@pSubTotal,
		@pFechaEntrega,
		@pEspecial,
		@pBonificacion,
		@pObservaciones,
		@pPendiente,
		@pReservaMercaderia,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id)
	)
END 

GO


DROP PROCEDURE venPediCuerpoDatos
GO
CREATE PROCEDURE venPediCuerpoDatos
(
@pvenPedidos int,
@pRenglon_Pe int=null
)
AS
SET NOCOUNT ON

SELECT venPedidos.venPedidos, venPediCuerpo.Renglon_Pe, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,stkProductos.Observaciones as ObservacionesProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	venPediCuerpo.Factor,
	venPediCuerpo.CantidadOriginal, venPediCuerpo.CantidadPedida, venPediCuerpo.CantidadRemitida, venPediCuerpo.CantidadFacturada,
	venPediCuerpo.PrecioForm, venPediCuerpo.PrecioSinIva, stkCondFisVenta.CFVenta_Id, 
	venPediCuerpo.PrecioLista, venPediCuerpo.PrecioListaForm, venPediCuerpo.PrecioVenta, venPediCuerpo.TipoPrecio, venPediCuerpo.SubTotal, venPediCuerpo.FechaEntrega,
	venPediCuerpo.Especial, venPediCuerpo.Bonificacion, venPediCuerpo.Observaciones,
	venPediCuerpo.Pendiente, venPediCuerpo.ReservaMercaderia, concentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	concentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2, ROUND(venPediCuerpo.CantidadPedida * venPediCuerpo.PrecioVenta,2) as SubTotalNeto, 
	ISNULL(venCotizPediCuerpo.Renglon_Co,0) as RenglonReferencia, cast(0 as bit) as Anular,0 as venCotizaciones
FROM venPediCuerpo 
INNER JOIN venPedidos  ON (venPedidos.venPedidos = venPediCuerpo.venPedidos)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = venPediCuerpo.Producto_Id)
LEFT JOIN stkCondFisVenta ON stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id 
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venPediCuerpo.Medida_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = venPediCuerpo.Deposito_Id)
Left Join conCentro1 On conCentro1.conCentro1 = venPediCuerpo.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = venPediCuerpo.Centro2_Id
Left join venCotizPediCuerpo ON  venCotizPediCuerpo.venPedidos = venPediCuerpo.venPedidos and 
								 venCotizPediCuerpo.Renglon_Pe = venPediCuerpo.Renglon_Pe
WHERE (venPediCuerpo.venPedidos = @pvenPedidos)
AND (venPediCuerpo.Renglon_Pe = IsNull(@pRenglon_Pe, venPediCuerpo.Renglon_Pe))
 
RETURN @@Error 

GO


DROP PROCEDURE venPediCuerpoEliminar
GO
CREATE PROCEDURE venPediCuerpoEliminar
(
@pvenPedidos int,
@pRenglon_Pe int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venPediCuerpo 
WHERE (venPedidos = @pvenPedidos)
AND (Renglon_Pe = ISNULL(@pRenglon_Pe, Renglon_Pe))
 
RETURN @@Error 

GO


DROP PROCEDURE venPediCuerpoEntregar
GO

CREATE PROCEDURE venPediCuerpoEntregar
(
@pvenPedidos int,
@pRenglon_Pe int,
@pCantidad qCantidadD8
)
as

UPDATE venPediCuerpo Set CantidadRemitida = CantidadRemitida + @pCantidad
	Where venPedidos = @pvenPedidos And 
		Renglon_Pe = @pRenglon_Pe

UPDATE venPediCuerpo Set Pendiente = Case when CantidadRemitida >= CantidadPedida
	Then 0 else 1 end  
	Where venPedidos = @pvenPedidos And 
		Renglon_Pe = @pRenglon_Pe
		
GO


DROP PROCEDURE venPediCuerpoFacturar
GO

CREATE PROCEDURE venPediCuerpoFacturar
(
@pvenPedidos int,
@pRenglon_Pe int,
@pCantidad qCantidadD8
)
as

UPDATE venPediCuerpo Set CantidadFacturada = CantidadFacturada + @pCantidad
	Where venPedidos = @pvenPedidos And 
		Renglon_Pe = @pRenglon_Pe
GO


DROP PROCEDURE venPediCuerpoRenglon
GO
CREATE PROCEDURE venPediCuerpoRenglon
(
@pvenPedidos int,
@pRenglon_Pe int
)
AS

exec venPediCuerpoDatos @pvenPedidos, @pRenglon_Pe

GO


DROP PROCEDURE venPediCuerpoDesecharPend
GO
CREATE PROCEDURE venPediCuerpoDesecharPend
(
@pvenPedidos int,
@pRenglon_Pe int=null
)

As
-- ver con Fabian porque estaba asi
Update venPediCuerpo Set Pendiente = 0 Where venPedidos = @pvenPedidos And Pendiente = 1 and Renglon_Pe=ISNULL(@pRenglon_Pe, Renglon_Pe)
	/* And ((CantidadPedida > CantidadRemitida And CantidadRemitida = 0) Or
	CantidadRemitida > CantidadFacturada) */

Go
