DROP PROCEDURE venPediFacturadosGuardar
GO
CREATE PROCEDURE venPediFacturadosGuardar
(
@pvenMovimientos bigint,
@pvenPedidos int ,
@pImporte qMonedaD2,
@pReparto_Id Int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venPediFacturados WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venPediFacturados
	SET		venPedidos = @pvenPedidos,
		Importe = @pImporte,
		Reparto_Id= @pReparto_Id
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venPediFacturados
	(
		venMovimientos,
		venPedidos,
		Importe,
		Reparto_Id
	)
	VALUES 
	(
		@pvenMovimientos,
		@pvenPedidos,
		@pImporte,
		@pReparto_Id
	)
END 

GO

DROP PROCEDURE venPediFacturadosDatos
GO
CREATE PROCEDURE venPediFacturadosDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venPediFacturados.venMovimientos, venPediFacturados.venPedidos, venPediFacturados.Importe, 
	dbo.Segmento(venPediSegmentos.Segmento_Id,venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N,
	venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) AS PedidoStr, 
	venPediFacturados.Reparto_Id
FROM venPediFacturados 
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = venPediFacturados.venMovimientos)
INNER JOIN venPedidos  ON (venPedidos.venPedidos = venPediFacturados.venPedidos)
INNER JOIN venPediSegmentos ON  venPediSegmentos.venPedidos = venPedidos.venPedidos
WHERE (venPediFacturados.venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO


DROP PROCEDURE venPediFacturadosPediDatos
GO
CREATE PROCEDURE venPediFacturadosPediDatos
(
@pvenPedidos bigint
)
AS
SET NOCOUNT ON 

SELECT venPediFacturados.venMovimientos, venPedidos.venPedidos, venPediFacturados.Importe,
dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS venSegmento
FROM venPediFacturados 
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = venPediFacturados.venMovimientos)
INNER JOIN venPedidos  ON (venPedidos.venPedidos = venPediFacturados.venPedidos)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
WHERE (venPediFacturados.venPedidos = @pvenPedidos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venPediFacturadosEliminar
GO
CREATE PROCEDURE venPediFacturadosEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venPediFacturados 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

GO
