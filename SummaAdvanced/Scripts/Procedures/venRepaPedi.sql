DROP PROCEDURE venRepaPediGuardar
GO
CREATE PROCEDURE venRepaPediGuardar
(
@pvenReparto int,
@pRenglon_Rep int,
@pvenPedidos int,
@pRenglon_Pe int,
@pCantidadForm qCantidadD8,
@pCantidadAlternaForm qCantidadD8,
@pRemitido Sino,
@pFacturado Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venRepaPedi 
	WHERE (venReparto = @pvenReparto) AND (Renglon_Rep = @pRenglon_Rep) AND (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe)))
BEGIN 
	UPDATE venRepaPedi
	SET CantidadForm = @pCantidadForm,
		CantidadAlternaForm = @pCantidadAlternaForm,
		Remitido = @pRemitido,
		Facturado = @pFacturado
	WHERE (venReparto = @pvenReparto) AND (Renglon_Rep = @pRenglon_Rep) AND (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe)
END 
ELSE 
BEGIN 
	INSERT INTO venRepaPedi
	(
		venReparto,
		Renglon_Rep,
		venPedidos,
		Renglon_Pe,
		CantidadForm,

		CantidadAlternaForm,

		Remitido,
		Facturado
	)
	VALUES 
	(
		@pvenReparto,
		@pRenglon_Rep,
		@pvenPedidos,
		@pRenglon_Pe,
		@pCantidadForm,
		
		@pCantidadAlternaForm,

		@pRemitido,
		@pFacturado
	)
END 

GO


DROP PROCEDURE venRepaPediDatos
GO
CREATE PROCEDURE venRepaPediDatos
(
@pvenReparto int,
@pRenglon_Rep int
)
AS
SET NOCOUNT ON 

SELECT venRepaPedi.venReparto, venRepaPedi.Renglon_Rep, venRepaPedi.venPedidos, venRepaPedi.Renglon_Pe, 
venRepaPedi.CantidadForm, venRepaPedi.CantidadAlternaForm, venRepaPedi.Remitido, venRepaPedi.Facturado
FROM venRepaPedi 
INNER JOIN venReparto  ON (venReparto.venReparto = venRepaPedi.venReparto)
INNER JOIN venPediCuerpo  ON (venPediCuerpo.venPedidos = venRepaPedi.venPedidos) AND (venPediCuerpo.Renglon_Pe = venRepaPedi.Renglon_Pe)
WHERE (venReparto.venReparto = @pvenReparto)
AND (Renglon_Rep = @pRenglon_Rep)

 
 RETURN @@Error 

GO

DROP PROCEDURE venRepaPediEliminar
GO
CREATE PROCEDURE venRepaPediEliminar
(
@pvenReparto int,
@pRenglon_Rep int = NULL,
@pvenPedidos int = Null,
@pRenglon_Pe int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM venRepaPedi 
WHERE (venReparto = @pvenReparto)
AND (Renglon_Rep = ISNULL(@pRenglon_Rep, Renglon_Rep))
AND (venPedidos = IsNull(@pvenPedidos, venPedidos))
AND (Renglon_Pe = IsNull(@pRenglon_Pe, Renglon_Pe))
 
 RETURN @@Error 

GO

Drop procedure venRepaPediMarcarRemitido
Go
Create procedure venRepaPediMarcarRemitido
(
@pvenReparto int,
@pRenglon_Rep int,
@pvenPedidos int,
@pRenglon_Pe int
)
As
Update venRepaPedi Set Remitido = 1 Where venReparto = @pvenReparto AND Renglon_Rep = @pRenglon_Rep AND 
venPedidos = @pvenPedidos AND Renglon_Pe = @pRenglon_Pe
Go


Drop procedure venRepaPediMarcarFacturado
Go
Create procedure venRepaPediMarcarFacturado
(
@pvenReparto int,
@pRenglon_Rep int,
@pvenPedidos int,
@pRenglon_Pe int
)
As
Update venRepaPedi Set Facturado = 1 Where venReparto = @pvenReparto AND Renglon_Rep = @pRenglon_Rep AND 
venPedidos = @pvenPedidos AND Renglon_Pe = @pRenglon_Pe
Go

DROP PROCEDURE venRepaPediRepXPed
GO
CREATE PROCEDURE venRepaPediRepXPed
(
@pvenPedidos int,
@pRenglon_Pe int
)
AS
SET NOCOUNT ON 

SELECT venRepaPedi.venReparto, venRepaPedi.Renglon_Rep, venRepaPedi.venPedidos, venRepaPedi.Renglon_Pe, 
venRepaPedi.CantidadForm, venRepaPedi.CantidadAlternaForm, venRepaPedi.Remitido, venRepaPedi.Facturado
FROM venRepaPedi 
INNER JOIN venReparto  ON (venReparto.venReparto = venRepaPedi.venReparto)
INNER JOIN venPediCuerpo  ON (venPediCuerpo.venPedidos = venRepaPedi.venPedidos) AND (venPediCuerpo.Renglon_Pe = venRepaPedi.Renglon_Pe)
WHERE venRepaPedi.venPedidos = @pvenPedidos And
venRepaPedi.Renglon_Pe = @pRenglon_Pe
 
RETURN @@Error 

GO

Drop procedure venRepaPediDesMarcarRemitido
Go
Create procedure venRepaPediDesMarcarRemitido
(
@pvenReparto int,
@pvenPedidos int,
@pRenglon_Pe int
)
As
Update venRepaPedi Set Remitido = 0 Where venReparto = @pvenReparto AND
venPedidos = @pvenPedidos AND Renglon_Pe = @pRenglon_Pe
Go


Drop procedure venRepaPediDesMarcarFacturado
Go
Create procedure venRepaPediDesMarcarFacturado
(
@pvenReparto int,
@pvenPedidos int,
@pRenglon_Pe int
)
As
Update venRepaPedi Set Facturado = 0 Where venReparto = @pvenReparto AND
venPedidos = @pvenPedidos AND Renglon_Pe = @pRenglon_Pe
Go