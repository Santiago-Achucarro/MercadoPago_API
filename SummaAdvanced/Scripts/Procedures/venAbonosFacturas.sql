DROP PROCEDURE venAbonosFacturasGuardar
GO
CREATE PROCEDURE venAbonosFacturasGuardar
(
@pvenAbonosFacturacion int,
@pvenAbonos int,
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venAbonosFacturas WHERE (venAbonosFacturacion = @pvenAbonosFacturacion) AND (venAbonos = @pvenAbonos)))
BEGIN 
	UPDATE venAbonosFacturas
	SET venMovimientos = @pvenMovimientos
	WHERE (venAbonosFacturacion = @pvenAbonosFacturacion) AND (venAbonos = @pvenAbonos)
END 
ELSE 
BEGIN 
	INSERT INTO venAbonosFacturas
	(
		venAbonosFacturacion,
		venAbonos,
		venMovimientos
	)
	VALUES 
	(
		@pvenAbonosFacturacion,
		@pvenAbonos,
		@pvenMovimientos
	)
END 

GO

DROP PROCEDURE venAbonosFacturasDatos
GO
CREATE PROCEDURE venAbonosFacturasDatos
(
@pvenAbonosFacturacion int,
@pvenAbonos int
)
AS
SET NOCOUNT ON 

SELECT venAbonosFacturacion.venAbonosFacturacion, venAbonos.venAbonos, venAbonosFacturas.venMovimientos
FROM venAbonosFacturas 
INNER JOIN venAbonosFacturacion  ON (venAbonosFacturacion.venAbonosFacturacion = venAbonosFacturas.venAbonosFacturacion)
INNER JOIN venAbonos  ON (venAbonos.venAbonos = venAbonosFacturas.venAbonos)
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = venAbonosFacturas.venMovimientos)
WHERE (venAbonosFacturas.venAbonosFacturacion = @pvenAbonosFacturacion)
AND (venAbonosFacturas.venAbonos = @pvenAbonos)
 
RETURN @@Error 

GO
