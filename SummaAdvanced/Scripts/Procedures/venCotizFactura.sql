DROP PROCEDURE venCotizFacturaInsertar
GO
CREATE PROCEDURE venCotizFacturaInsertar
(
@pvenMovimientos bigint,
@pvenCotizaciones int
)
AS
SET NOCOUNT ON 
	INSERT INTO venCotizFactura
	(
		venMovimientos,
		venCotizaciones
	)
	VALUES 
	(
		@pvenMovimientos,
		@pvenCotizaciones
	)

GO

DROP PROCEDURE venCotizFacturaDatos
GO
CREATE PROCEDURE venCotizFacturaDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venCotizFactura.venMovimientos, venCotizFactura.venCotizaciones
FROM venCotizFactura 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venCotizFacturaEliminar
GO
CREATE PROCEDURE venCotizFacturaEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venCotizFactura 
WHERE (venMovimientos = @pvenMovimientos)
 
RETURN @@Error 

GO


