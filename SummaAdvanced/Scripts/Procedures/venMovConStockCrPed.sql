DROP PROCEDURE venMovConStockCrPedGuardar
GO
CREATE PROCEDURE venMovConStockCrPedGuardar
(
@pvenPedidos int,
@pRenglon_Pe int,
@pvenMovimientos bigint,
@pRenglonCuerpo int,
@pvenReparto int = Null
)
AS
INSERT INTO venMovConStockCrPed
(
	venPedidos,
	Renglon_Pe,
	venMovimientos,
	RenglonCuerpo,
	venReparto
)
VALUES 
(
	@pvenPedidos,
	@pRenglon_Pe,
	@pvenMovimientos,
	@pRenglonCuerpo,
	@pvenReparto
)
GO

DROP PROCEDURE venMovConStockCrPedDatos
GO
CREATE PROCEDURE venMovConStockCrPedDatos
(
@pvenPedidos int = NUll,
@pRenglon_Pe int = NUll,
@pvenMovimientos bigint = NUll,
@pRenglonCuerpo int = NUll
)
AS
SET NOCOUNT ON 

SELECT venMovConStockCrPed.venPedidos, venMovConStockCrPed.Renglon_Pe, venMovConStockCrPed.venMovimientos,
	venMovConStockCrPed.RenglonCuerpo, venMovConStockCrPed.venReparto, dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N,
venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) Pedido, dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N,
venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) Reparto
FROM venMovConStockCrPed 
INNER JOIN venPediCuerpo ON venPediCuerpo.venPedidos = venMovConStockCrPed.venPedidos AND venPediCuerpo.Renglon_Pe = venMovConStockCrPed.Renglon_Pe
INNER JOIN venMovConStockCr ON venMovConStockCr.venMovimientos = venMovConStockCrPed.venMovimientos AND venMovConStockCr.RenglonCuerpo = venMovConStockCrPed.RenglonCuerpo
Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venMovConStockCrPed.venPedidos
Left Join venRepaSegmentos On venRepaSegmentos.venReparto = venMovConStockCrPed.venReparto
WHERE venMovConStockCrPed.venPedidos = IsNull(@pvenPedidos, venMovConStockCrPed.venPedidos)
AND venMovConStockCrPed.Renglon_Pe = IsNull(@pRenglon_Pe, venMovConStockCrPed.Renglon_Pe)
AND venMovConStockCrPed.venMovimientos = IsNull(@pvenMovimientos, venMovConStockCrPed.venMovimientos)
AND venMovConStockCrPed.RenglonCuerpo = IsNull(@pRenglonCuerpo, venMovConStockCrPed.RenglonCuerpo)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovConStockCrPedEliminar
GO
CREATE PROCEDURE venMovConStockCrPedEliminar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM venMovConStockCrPed 
WHERE venMovimientos = @pvenMovimientos
AND RenglonCuerpo = isNull(@pRenglonCuerpo, RenglonCuerpo)
 
RETURN @@Error 

GO
