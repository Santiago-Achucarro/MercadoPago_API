DROP PROCEDURE venRepaPediSerieUbiInsertar
GO
CREATE PROCEDURE venRepaPediSerieUbiInsertar
(
@pvenReparto int,
@pRenglon_Rep int,
@pvenPedidos int,
@pRenglon_Pe int,
@pSerie varchar(25),
@pUbicacion_Id varchar(25),
@pCantidad qCantidadD8
)
AS
	INSERT INTO venRepaPediSerieUbi
	(
		venReparto,
		Renglon_Rep,
		venPedidos,
		Renglon_Pe,
		Serie,
		Ubicacion_Id,
		Cantidad
	)
	VALUES 
	(
		@pvenReparto,
		@pRenglon_Rep,
		@pvenPedidos,
		@pRenglon_Pe,
		@pSerie,
		dbo.FuncFKstkUbicaciones(@pUbicacion_Id),
		@pCantidad
	)

GO

DROP PROCEDURE venRepaPediSerieUbiDatos
GO
CREATE PROCEDURE venRepaPediSerieUbiDatos
(
@pvenReparto int,
@pRenglon_Rep int=null,
@pvenPedidos int=null,
@pRenglon_Pe int=null,
@pSerie varchar(25)=null,
@pUbicacion_Id varchar(25)= null
)
AS
SET NOCOUNT ON 

SELECT venRepaPediSerieUbi.venReparto, venRepaPediSerieUbi.Renglon_Rep, venRepaPediSerieUbi.venPedidos, venRepaPediSerieUbi.Renglon_Pe,
	venRepaPediSerieUbi.Serie, stkUbicaciones.Ubicacion_Id, venRepaPediSerieUbi.Cantidad
FROM venRepaPediSerieUbi 
INNER JOIN venRepaPediSerie  ON (venRepaPediSerie.venReparto = venRepaPediSerieUbi.venReparto) AND (venRepaPediSerie.Renglon_Rep = venRepaPediSerieUbi.Renglon_Rep) AND (venRepaPediSerie.venPedidos = venRepaPediSerieUbi.venPedidos) AND (venRepaPediSerie.Renglon_Pe = venRepaPediSerieUbi.Renglon_Pe) AND (venRepaPediSerie.Serie = venRepaPediSerieUbi.Serie)
INNER JOIN stkUbicaciones  ON (stkUbicaciones.stkUbicaciones = venRepaPediSerieUbi.Ubicacion_Id)
WHERE (venRepaPediSerie.venReparto = @pvenReparto)
AND venRepaPediSerie.Renglon_Rep = ISNULL(@pRenglon_Rep,venRepaPediSerie.Renglon_Rep)
AND venRepaPediSerie.venPedidos = ISNULL(@pvenPedidos,venRepaPediSerie.venPedidos)
AND venRepaPediSerie.Renglon_Pe = ISNULL(@pRenglon_Pe,venRepaPediSerie.Renglon_Pe)
AND venRepaPediSerie.Serie = ISNULL(@pSerie,venRepaPediSerie.Serie)
AND stkUbicaciones.Ubicacion_Id = ISNULL(@pUbicacion_Id,stkUbicaciones.Ubicacion_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE venRepaPediSerieUbiEliminar
GO
CREATE PROCEDURE venRepaPediSerieUbiEliminar
(
@pvenReparto int,
@pRenglon_Rep int = null,
@pvenPedidos int= null,
@pRenglon_Pe int= null,
@pSerie varchar(25)= null,
@pUbicacion_Id varchar(25)= null
)
AS
SET NOCOUNT ON 

DELETE FROM venRepaPediSerieUbi 
WHERE (venReparto = @pvenReparto)
AND Renglon_Rep = ISNULL(@pRenglon_Rep,Renglon_Rep)
AND venPedidos = ISNULL(@pvenPedidos,venPedidos)
AND Renglon_Pe = ISNULL(@pRenglon_Pe,Renglon_Pe)
AND Serie = ISNULL(@pSerie,Serie)
AND (@pUbicacion_Id IS NULL OR Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id))
 
RETURN @@Error 

GO

GO
