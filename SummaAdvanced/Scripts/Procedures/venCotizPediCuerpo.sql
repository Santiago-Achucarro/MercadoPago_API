DROP PROCEDURE venCotizPediCuerpoInsertar
GO
CREATE PROCEDURE venCotizPediCuerpoInsertar
(
@pvenPedidos int,
@pRenglon_Pe int,
@pvenCotizaciones int ,
@pRenglon_Co int ,
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
	INSERT INTO venCotizPediCuerpo
	(
		venPedidos,
		Renglon_Pe,
		venCotizaciones,
		Renglon_Co,
		Cantidad
	)
	VALUES 
	(
		@pvenPedidos,
		@pRenglon_Pe,
		@pvenCotizaciones,
		@pRenglon_Co,
		@pCantidad
	)
GO

DROP PROCEDURE venCotizPediCuerpoDatos
GO
CREATE PROCEDURE venCotizPediCuerpoDatos
(
@pvenPedidos int,
@pRenglon_Pe int = NULL
)
AS
SET NOCOUNT ON 

SELECT venCotizPediCuerpo.venPedidos, venCotizPediCuerpo.Renglon_Pe, venCotizPediCuerpo.venCotizaciones,
	venCotizPediCuerpo.Renglon_Co, venCotizPediCuerpo.Cantidad
FROM venCotizPediCuerpo 
WHERE (venPedidos = @pvenPedidos)
AND (Renglon_Pe = isNull(@pRenglon_Pe,Renglon_Pe))
 
 RETURN @@Error 

GO

DROP PROCEDURE venCotizPediCuerpoEliminar
GO
CREATE PROCEDURE venCotizPediCuerpoEliminar
(
@pvenPedidos int,
@pRenglon_Pe int
)
AS
SET NOCOUNT ON 

DELETE FROM venCotizPediCuerpo 
WHERE (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe)
 
RETURN @@Error 


GO
