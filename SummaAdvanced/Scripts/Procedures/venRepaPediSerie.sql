DROP PROCEDURE venRepaPediSerieGuardar
GO
CREATE PROCEDURE venRepaPediSerieGuardar
(
@pvenReparto int,
@pRenglon_Rep int,
@pvenPedidos int,
@pRenglon_Pe int,
@pSerie varchar(25),
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venRepaPediSerie WHERE (venReparto = @pvenReparto) AND (Renglon_Rep = @pRenglon_Rep) AND (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe) AND (Serie = @pSerie)))
BEGIN 
	UPDATE venRepaPediSerie
	SET		Cantidad = @pCantidad
	WHERE (venReparto = @pvenReparto) AND (Renglon_Rep = @pRenglon_Rep) AND (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe) AND (Serie = @pSerie)
END 
ELSE 
BEGIN 
	INSERT INTO venRepaPediSerie
	(
		venReparto,
		Renglon_Rep,
		venPedidos,
		Renglon_Pe,
		Serie,
		Cantidad
	)
	VALUES 
	(
		@pvenReparto,
		@pRenglon_Rep,
		@pvenPedidos,
		@pRenglon_Pe,
		@pSerie,
		@pCantidad
	)
END 

GO

DROP PROCEDURE venRepaPediSerieDatos
GO
CREATE PROCEDURE venRepaPediSerieDatos
(
@pvenReparto int,
@pRenglon_Rep int=NULL,
@pvenPedidos int=NULL,
@pRenglon_Pe int=NULL,
@pSerie varchar(25)=NULL
)
AS
SET NOCOUNT ON 

SELECT venRepaPediSerie.venReparto, venRepaPediSerie.Renglon_Rep, venRepaPediSerie.venPedidos, 
	venRepaPediSerie.Renglon_Pe, 
	venRepaPediSerie.Serie, isnull(venRepaPediSerieUbi.Cantidad, venRepaPediSerie.Cantidad) as Cantidad, 
		stkSerieVencimiento.Vencimiento, stkUbicaciones.Ubicacion_Id, Cast(0 As Numeric(18,8)) Existencia, Cast(0 As bit) Marcado
FROM 
venRepaPediSerie 
INNER JOIN venReparto ON venReparto.venReparto = venRepaPediSerie.venReparto
INNER JOIN venPediCuerpo ON venPediCuerpo.venPedidos = venRepaPediSerie.venPedidos and 
							venPediCuerpo.Renglon_Pe = venRepaPediSerie.Renglon_pe
LEFT JOIN stkSerieVencimiento ON stkSerieVencimiento.Serie = venRepaPediSerie.Serie and 
					stkSerieVencimiento.Empresa_Id = venReparto.Empresa_Id and
					stkSerieVencimiento.Producto_Id = venPediCuerpo.Producto_Id
LEFT JOIN (venRepaPediSerieUbi INNER JOIN  stkUbicaciones ON 
	venRepaPediSerieUbi.Ubicacion_Id =  stkUbicaciones.stkUbicaciones ) ON
	venRepaPediSerieUbi.venReparto = venRepaPediSerie.venReparto and 
	venRepaPediSerieUbi.Renglon_Rep = venRepaPediSerie.Renglon_Rep and 
	venRepaPediSerieUbi.venPedidos = venRepaPediSerie.venPedidos and 
	venRepaPediSerieUbi.Renglon_Pe = venRepaPediSerie.Renglon_Pe and 
	venRepaPediSerieUbi.Serie = venRepaPediSerie.Serie
WHERE 
(venRepaPediSerie.venReparto = @pvenReparto)
AND (venRepaPediSerie.Renglon_Rep = ISNULL(@pRenglon_Rep,venRepaPediSerie.Renglon_Rep))
AND (venRepaPediSerie.venPedidos = ISNULL(@pvenPedidos,venRepaPediSerie.venPedidos))
AND (venRepaPediSerie.Renglon_Pe = ISNULL(@pRenglon_Pe,venRepaPediSerie.Renglon_Pe))
AND (venRepaPediSerie.Serie = ISNULL(@pSerie,venRepaPediSerie.Serie))
 
RETURN @@Error 

GO

DROP PROCEDURE venRepaPediSerieEliminar
GO
CREATE PROCEDURE venRepaPediSerieEliminar
(
@pvenReparto int,
@pRenglon_Rep int =NULL,
@pvenPedidos int=NULL,
@pRenglon_Pe int=NULL,
@pSerie varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venRepaPediSerie 
WHERE (venReparto = @pvenReparto)
AND (Renglon_Rep = ISNULL(@pRenglon_Rep,Renglon_Rep))
AND (venPedidos = ISNULL(@pvenPedidos,venPedidos))
AND (Renglon_Pe = ISNULL(@pRenglon_Pe,Renglon_Pe))
AND (Serie = ISNULL(@pSerie, Serie))
 
 RETURN @@Error 

GO

GO
