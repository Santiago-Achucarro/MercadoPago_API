DROP PROCEDURE proOrdenPedidoGuardar
GO
CREATE PROCEDURE proOrdenPedidoGuardar
(
@pproOrden int,
@pvenPedidos int,
@pRenglon_Pe int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proOrdenPedido 
	WHERE (proOrden = @pproOrden)))
BEGIN 
	UPDATE proOrdenPedido
	SET		venPedidos = @pvenPedidos, 
			Renglon_Pe = @pRenglon_Pe
	WHERE (proOrden = @pproOrden)
END 
ELSE 
BEGIN 
	INSERT INTO proOrdenPedido
	(
		proOrden,
		venPedidos,
		Renglon_Pe
	)
	VALUES 
	(
		@pproOrden,
		@pvenPedidos,
		@pRenglon_Pe
	)
END 

GO


DROP PROCEDURE proOrdenPedidoDatos
GO
CREATE PROCEDURE proOrdenPedidoDatos
(
@pproOrden int
)
AS
SET NOCOUNT ON 

SELECT proOrdenPedido.proOrden, proOrdenPedido.venPedidos, proOrdenPedido.Renglon_Pe
FROM proOrdenPedido 
INNER JOIN venPediCuerpo  ON (venPediCuerpo.venPedidos = proOrdenPedido.venPedidos) AND (venPediCuerpo.Renglon_Pe = proOrdenPedido.Renglon_Pe)
WHERE (proOrdenPedido.proOrden = @pproOrden)

 
 RETURN @@Error 

GO
