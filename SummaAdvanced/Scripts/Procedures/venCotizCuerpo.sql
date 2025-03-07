DROP PROCEDURE venCotizCuerpoGuardar
GO
CREATE PROCEDURE venCotizCuerpoGuardar
(
@pCotizacion_Id int,
@pRenglon_Co int,
@pProducto_Id varchar(25) = NULL,
@pMedida_Id varchar(5) = NULL,
@pDeposito_Id varchar(15) = NULL,
@pFactor qCantidadD8,
@pCantidadOriginal qCantidadD8,
@pCantidadPedida qCantidadD8,
@pCantidadRemitida qCantidadD8,
@pCantidadFacturada qCantidadD8,
@pPrecioForm qMonedaD8,
@pPrecioLista qMonedaD8,
@pPrecioVenta qCantidadD8,
@pFechaEntrega qFecha,
@pEspecial Sino,
@pBonificacion qPorcentaje,
@pObservaciones QMemo = NULL,
@pPendiente Sino,
@pReservaMercaderia Sino,
@pPrecioListaForm qMonedaD8,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL, 
@pTipoPrecio Char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCotizCuerpo WHERE (Cotizacion_Id = @pCotizacion_Id) AND (Renglon_Co = @pRenglon_Co)))
BEGIN 
	UPDATE venCotizCuerpo
	SET		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id),
		Factor = @pFactor,
		CantidadOriginal = @pCantidadOriginal,
		CantidadPedida = @pCantidadPedida,
		CantidadRemitida = @pCantidadRemitida,
		CantidadFacturada = @pCantidadFacturada,
		PrecioForm = @pPrecioForm,
		PrecioLista = @pPrecioLista,
		PrecioVenta = @pPrecioVenta,
		FechaEntrega = @pFechaEntrega,
		Especial = @pEspecial,
		Bonificacion = @pBonificacion,
		Observaciones = @pObservaciones,
		Pendiente = @pPendiente,
		ReservaMercaderia = @pReservaMercaderia,
		PrecioListaForm = @pPrecioListaForm,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id), 
		TipoPrecio = @pTipoPrecio
	WHERE (Cotizacion_Id = @pCotizacion_Id) AND (Renglon_Co = @pRenglon_Co)
END 
ELSE 
BEGIN 
	INSERT INTO venCotizCuerpo
	(
		Cotizacion_Id,
		Renglon_Co,
		Producto_Id,
		Medida_Id,
		Deposito_Id,
		Factor,
		CantidadOriginal,
		CantidadPedida,
		CantidadRemitida,
		CantidadFacturada,
		PrecioForm,
		PrecioLista,
		PrecioVenta,
		FechaEntrega,
		Especial,
		Bonificacion,
		Observaciones,
		Pendiente,
		ReservaMercaderia,
		PrecioListaForm,
		Centro1_Id,
		Centro2_Id,
		TipoPrecio
	)
	VALUES 
	(
		@pCotizacion_Id,
		@pRenglon_Co,
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkUniMed(@pMedida_Id),
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		@pFactor,
		@pCantidadOriginal,
		@pCantidadPedida,
		@pCantidadRemitida,
		@pCantidadFacturada,
		@pPrecioForm,
		@pPrecioLista,
		@pPrecioVenta,
		@pFechaEntrega,
		@pEspecial,
		@pBonificacion,
		@pObservaciones,
		@pPendiente,
		@pReservaMercaderia,
		@pPrecioListaForm,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pTipoPrecio
	)
END 

GO

DROP PROCEDURE venCotizCuerpoDatos
GO
CREATE PROCEDURE venCotizCuerpoDatos
(
@pCotizacion_Id int,
@pRenglon_Co int=null
)
AS
SET NOCOUNT ON 

SELECT venCotizCuerpo.Cotizacion_Id, venCotizCuerpo.Renglon_Co, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito, venCotizCuerpo.Factor, 
venCotizCuerpo.CantidadOriginal, venCotizCuerpo.CantidadPedida,	venCotizCuerpo.CantidadRemitida, venCotizCuerpo.CantidadFacturada, 
venCotizCuerpo.PrecioForm, venCotizCuerpo.PrecioLista, venCotizCuerpo.PrecioVenta, venCotizCuerpo.FechaEntrega, 
venCotizCuerpo.Especial, venCotizCuerpo.Bonificacion, venCotizCuerpo.Observaciones, venCotizCuerpo.Pendiente, 
venCotizCuerpo.ReservaMercaderia, venCotizCuerpo.PrecioListaForm, conCentro1.Centro1_Id, 
conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
Round(venCotizCuerpo.PrecioForm * venCotizCuerpo.CantidadOriginal,2) as SubTotal, 
Round(venCotizCuerpo.PrecioVenta * venCotizCuerpo.CantidadPedida,2) as SubTotalNeto, venCotizCuerpo.TipoPrecio
FROM venCotizCuerpo 
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = venCotizCuerpo.Centro1_Id)
left join conCentro2 on conCentro2.conCentro2=venCotizCuerpo.Centro2_Id
left join stkProductos on stkProductos=venCotizCuerpo.Producto_Id
left join stkDepositos on stkDepositos.stkDepositos= venCotizCuerpo.Deposito_Id
left join stkUniMed on stkUniMed.stkUniMed=venCotizCuerpo.Medida_Id
WHERE (Cotizacion_Id = @pCotizacion_Id)
AND (Renglon_Co =isnull( @pRenglon_Co,Renglon_Co))
 
 RETURN @@Error 

GO

DROP PROCEDURE venCotizCuerpoEliminar
GO
CREATE PROCEDURE venCotizCuerpoEliminar
(
@pCotizacion_Id int,
@pRenglon_Co int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCotizCuerpo 
WHERE (Cotizacion_Id = @pCotizacion_Id)
AND (Renglon_Co = ISNULL(@pRenglon_Co, Renglon_Co))
 
 RETURN @@Error 

GO

DROP PROCEDURE venCotizCuerpoSumaCant
GO
CREATE PROCEDURE venCotizCuerpoSumaCant
(
@pCotizacion_Id int,
@pRenglon_Co int ,
@pCantidad Numeric(18,2)
)
AS
SET NOCOUNT ON 

Update venCotizCuerpo  set CantidadFacturada = CantidadFacturada + @pCantidad
WHERE (Cotizacion_Id = @pCotizacion_Id)
AND (Renglon_Co = @pRenglon_Co)
 
 RETURN @@Error 

GO

DROP PROCEDURE venCotizCuerpoTienePend
GO
CREATE PROCEDURE venCotizCuerpoTienePend
(
@pCotizacion_Id int
)
AS
SET NOCOUNT ON 

select COUNT(1) as Cantidad  from venCotizCuerpo  
WHERE (Cotizacion_Id = @pCotizacion_Id) and 
CantidadFacturada < CantidadPedida

 
 RETURN @@Error 

GO







