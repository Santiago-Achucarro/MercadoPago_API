DROP PROCEDURE wooOrdenesVenMovimientosGuardar
GO
CREATE PROCEDURE wooOrdenesVenMovimientosGuardar
(
@pvenMovimientos bigint,
@pwooOrden int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM wooOrdenesVenMovimientos WHERE wooOrdenesVenMovimientos.venMovimientos=@pvenMovimientos))
BEGIN 
	UPDATE wooOrdenesVenMovimientos
	SET		
		wooOrden = @pwooOrden
	WHERE venMovimientos = @pvenMovimientos
END 
ELSE 
BEGIN 
	INSERT INTO wooOrdenesVenMovimientos
	(
		venMovimientos,
		wooOrden
	)
	VALUES 
	(
		@pvenMovimientos,
		@pwooOrden
	)
END 

GO

DROP PROCEDURE wooOrdenesVenMovimientosDatos
GO
CREATE PROCEDURE wooOrdenesVenMovimientosDatos
(
    @pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT wooOrdenesVenMovimientos.venMovimientos, wooOrdenesVenMovimientos.wooOrden
FROM wooOrdenesVenMovimientos 
LEFT JOIN venMovimientos  ON (venMovimientos.venMovimientos = wooOrdenesVenMovimientos.venMovimientos)
WHERE  venMovimientos.venMovimientos = @pvenMovimientos
RETURN @@Error 

GO

DROP PROCEDURE wooOrdenesVenMovimientosEliminar
GO
CREATE PROCEDURE wooOrdenesVenMovimientosEliminar
(
    @pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM wooOrdenesVenMovimientos 
WHERE  venMovimientos=@pvenMovimientos
 RETURN @@Error 

GO

GO
