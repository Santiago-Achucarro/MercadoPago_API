DROP PROCEDURE venMovConStockCrCtasGuardar
GO
CREATE PROCEDURE venMovConStockCrCtasGuardar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int,
@pRenglon int
)
AS
SET NOCOUNT ON 

	INSERT INTO venMovConStockCrCtas
	(
		venMovimientos,
		RenglonCuerpo,
		Renglon
	)
	VALUES 
	(
		@pvenMovimientos,
		@pRenglonCuerpo,
		@pRenglon
	)

GO

DROP PROCEDURE venMovConStockCrCtasEliminar
GO
CREATE PROCEDURE venMovConStockCrCtasEliminar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int = null,
@pRenglon int = null
)
AS
SET NOCOUNT ON 

DELETE FROM venMovConStockCrCtas 
WHERE venMovimientos = @pvenMovimientos
AND RenglonCuerpo = IsNull(@pRenglonCuerpo, RenglonCuerpo)
AND Renglon = IsNull(@pRenglon, Renglon)
 
 RETURN @@Error 

GO

