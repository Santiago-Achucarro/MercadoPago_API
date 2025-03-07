DROP PROCEDURE venRepaUbicacionInsertar
GO
CREATE PROCEDURE venRepaUbicacionInsertar
(
@pvenReparto int,
@pRenglon_Rep int,
@pvenPedidos int,
@pRenglon_Pe int,
@pUbicacion_Id varchar(25),
@pCantidadForm qCantidadD8,
@pCantidadAlternaForm qCantidadD8
)
AS
	INSERT INTO venRepaUbicacion
	(
		venReparto,
		Renglon_Rep,
		venPedidos,
		Renglon_Pe,
		Ubicacion_Id,
		CantidadForm,
		CantidadAlternaForm
	)
	VALUES 
	(
		@pvenReparto,
		@pRenglon_Rep,
		@pvenPedidos,
		@pRenglon_Pe,
		dbo.FuncFKstkUbicaciones(@pUbicacion_Id),
		@pCantidadForm,
		@pCantidadAlternaForm
	)

GO

DROP PROCEDURE venRepaUbicacionDatos
GO
CREATE PROCEDURE venRepaUbicacionDatos
(
@pvenReparto int,
@pRenglon_Rep int = null,
@pvenPedidos int= null,
@pRenglon_Pe int= null,
@pUbicacion_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

SELECT venRepaUbicacion.venReparto, venRepaUbicacion.Renglon_Rep, venRepaUbicacion.venPedidos, 
	venRepaUbicacion.Renglon_Pe, stkUbicaciones.Ubicacion_Id, venRepaUbicacion.CantidadForm as Cantidad,
	venRepaUbicacion.CantidadAlternaForm as CantidadAlterna, Cast(0 As Numeric(18,8)) Existencia, Cast(0 As Numeric(18,8)) ExistenciaAlterna
FROM venRepaUbicacion 
INNER JOIN venRepaPedi  ON (venRepaPedi.venReparto = venRepaUbicacion.venReparto) AND (venRepaPedi.Renglon_Rep = venRepaUbicacion.Renglon_Rep) AND (venRepaPedi.venPedidos = venRepaUbicacion.venPedidos) AND (venRepaPedi.Renglon_Pe = venRepaUbicacion.Renglon_Pe)
INNER JOIN stkUbicaciones  ON (stkUbicaciones.stkUbicaciones = venRepaUbicacion.Ubicacion_Id)
WHERE (venRepaPedi.venReparto = @pvenReparto)
AND (venRepaPedi.Renglon_Rep = isnull(@pRenglon_Rep,venRepaPedi.Renglon_Rep))
AND (venRepaPedi.venPedidos = isnull(@pvenPedidos,venRepaPedi.venPedidos))
AND (venRepaPedi.Renglon_Pe = isnull(@pRenglon_Pe,venRepaPedi.Renglon_Pe))
AND (stkUbicaciones.Ubicacion_Id = isnull(@pUbicacion_Id,stkUbicaciones.Ubicacion_Id))
 
RETURN @@Error 

GO

DROP PROCEDURE venRepaUbicacionEliminar
GO
CREATE PROCEDURE venRepaUbicacionEliminar
(
@pvenReparto int,
@pRenglon_Rep int = NULL,
@pvenPedidos int = NULL ,
@pRenglon_Pe int = NULL,
@pUbicacion_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venRepaUbicacion 
WHERE venReparto = @pvenReparto
AND Renglon_Rep = isnull(@pRenglon_Rep,Renglon_Rep )
AND venPedidos = isnull(@pvenPedidos,venPedidos)
AND Renglon_Pe = isnull(@pRenglon_Pe,Renglon_Pe)
AND (@pUbicacion_Id IS NULL OR  Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id))
 
RETURN @@Error 

GO

