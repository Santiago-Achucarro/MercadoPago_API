DROP PROCEDURE venCanjeNotasGuardar
GO
CREATE PROCEDURE venCanjeNotasGuardar
(
@pvenMovimientos bigint,
@pvenMovimientosNC bigint,
@pvenMovimientosFC bigint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCanjeNotas WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venCanjeNotas
	SET		venMovimientosNC = @pvenMovimientosNC,
		venMovimientosFC = @pvenMovimientosFC
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venCanjeNotas
	(
		venMovimientos,
		venMovimientosNC,
		venMovimientosFC
	)
	VALUES 
	(
		@pvenMovimientos,
		@pvenMovimientosNC,
		@pvenMovimientosFC
	)
END 

GO

DROP PROCEDURE venCanjeNotasDatos
GO
CREATE PROCEDURE venCanjeNotasDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venCanjeNotas.venMovimientos, venCanjeNotas.venMovimientosNC, venCanjeNotas.venMovimientosFC
FROM venCanjeNotas 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venCanjeNotasEliminar
GO
CREATE PROCEDURE venCanjeNotasEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venCanjeNotas 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

