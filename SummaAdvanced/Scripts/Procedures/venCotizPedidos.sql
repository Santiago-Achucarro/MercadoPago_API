DROP PROCEDURE venCotizPedidosGuardar
GO
CREATE PROCEDURE venCotizPedidosGuardar
(
@pCotizacion_Id int,
@pPedido_Id int,
@pImporte qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCotizPedidos WHERE (Cotizacion_Id = @pCotizacion_Id) AND (Pedido_Id = @pPedido_Id)))
BEGIN 
	UPDATE venCotizPedidos
	SET		Importe = @pImporte
	WHERE (Cotizacion_Id = @pCotizacion_Id) AND (Pedido_Id = @pPedido_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venCotizPedidos
	(
		Cotizacion_Id,
		Pedido_Id,
		Importe
	)
	VALUES 
	(
		@pCotizacion_Id,
		@pPedido_Id,
		@pImporte
	)
END 

GO

DROP PROCEDURE venCotizPedidosDatos
GO
CREATE PROCEDURE venCotizPedidosDatos
(
@pCotizacion_Id int,
@pPedido_Id int
)
AS
SET NOCOUNT ON 

SELECT venCotizPedidos.Cotizacion_Id, venCotizPedidos.Pedido_Id, venCotizPedidos.Importe
FROM venCotizPedidos 
WHERE (Cotizacion_Id = @pCotizacion_Id)
AND (Pedido_Id = @pPedido_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE venCotizPedidosEliminar
GO
CREATE PROCEDURE venCotizPedidosEliminar
(
@pCotizacion_Id int,
@pPedido_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM venCotizPedidos 
WHERE (Cotizacion_Id = @pCotizacion_Id)
AND (Pedido_Id = @pPedido_Id)
 
 RETURN @@Error 

GO

GO
