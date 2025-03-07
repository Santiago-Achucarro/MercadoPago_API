DROP PROCEDURE venMovimientosMetodoPagoGuardar
GO
CREATE PROCEDURE venMovimientosMetodoPagoGuardar
(
@pvenMovimientos bigint,
@pMetodoPago varchar(50) = NULL,
@pCuentaPago varchar(150) = NULL, 
@pNMetodoPago VarChar(3) = NULL, 
@pUsoCfdi VarChar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovimientosMetodoPago WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMovimientosMetodoPago
	SET		MetodoPago = @pMetodoPago,
		CuentaPago = @pCuentaPago, 
		NMetodoPago = @pNMetodoPago, 
		UsoCfdi = @pUsoCfdi
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMovimientosMetodoPago
	(
		venMovimientos,
		MetodoPago,
		CuentaPago, 
		NMetodoPago,
		UsoCfdi
	)
	VALUES 
	(
		@pvenMovimientos,
		@pMetodoPago,
		@pCuentaPago, 
		@pNMetodoPago, 
		@pUsoCfdi
	)
END 

GO

DROP PROCEDURE venMovimientosMetodoPagoDatos
GO
CREATE PROCEDURE venMovimientosMetodoPagoDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venMovimientosMetodoPago.venMovimientos, venMovimientosMetodoPago.MetodoPago, venMovimientosMetodoPago.CuentaPago, 
	venMovimientosMetodoPago.NMetodoPago, venMovimientosMetodoPago.UsoCfdi
FROM venMovimientosMetodoPago 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovimientosMetodoPagoEliminar
GO
CREATE PROCEDURE venMovimientosMetodoPagoEliminar
(
@pvenMovimientos bigint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venMovimientosMetodoPago 
WHERE (venMovimientos = ISNULL(@pvenMovimientos, venMovimientos))
 
 RETURN @@Error 

GO

