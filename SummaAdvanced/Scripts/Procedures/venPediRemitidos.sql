DROP PROCEDURE venPediRemitidosGuardar
GO
CREATE PROCEDURE venPediRemitidosGuardar
(
@pvenPedidos int,
@pRenglon_Pe int,
@pRenglon int,
@pstkMoviCabe bigint,
@pvenReparto int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venPediRemitidos WHERE (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe) AND 
(Renglon = @pRenglon) AND (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE venPediRemitidos
	SET		venReparto = @pvenReparto
	WHERE (venPedidos = @pvenPedidos) AND (Renglon_Pe = @pRenglon_Pe) AND (Renglon = @pRenglon) AND (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO venPediRemitidos
	(
		venPedidos,
		Renglon_Pe,
		Renglon,
		stkMoviCabe,
		venReparto
	)
	VALUES 
	(
		@pvenPedidos,
		@pRenglon_Pe,
		@pRenglon,
		@pstkMoviCabe,
		@pvenReparto
	)
END 

GO

DROP PROCEDURE venPediRemitidosDatos
GO
CREATE PROCEDURE venPediRemitidosDatos
(
@pvenPedidos int,
@pRenglon_Pe int,
@pRenglon int,
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

SELECT venPediRemitidos.venPedidos, venPediRemitidos.Renglon_Pe, venPediRemitidos.stkMoviCabe,
	venPediRemitidos.Renglon, venPediRemitidos.venReparto
FROM venPediRemitidos 
INNER JOIN venPediCuerpo  ON (venPediCuerpo.venPedidos = venPediRemitidos.venPedidos) AND (venPediCuerpo.Renglon_Pe = venPediRemitidos.Renglon_Pe)
INNER JOIN stkMoviCuerpo  ON (stkMoviCuerpo.stkMoviCabe = venPediRemitidos.stkMoviCabe) AND (stkMoviCuerpo.Renglon = venPediRemitidos.Renglon)
LEFT JOIN venReparto  ON (venReparto.venReparto = venPediRemitidos.venReparto)
WHERE venPediRemitidos.venPedidos = @pvenPedidos
AND venPediRemitidos.Renglon_Pe = @pRenglon_Pe
AND venPediRemitidos.Renglon = @pRenglon
AND venPediRemitidos.stkMoviCabe = @pstkMoviCabe
 
 RETURN @@Error 

GO

DROP PROCEDURE venPediRemitidosEliminar
GO
CREATE PROCEDURE venPediRemitidosEliminar
(
@pvenPedidos int,
@pRenglon_Pe int,
@pRenglon int,
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venPediRemitidos 
WHERE (venPedidos = @pvenPedidos)
AND (Renglon_Pe = @pRenglon_Pe)
AND (Renglon = @pRenglon)
AND (stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO

