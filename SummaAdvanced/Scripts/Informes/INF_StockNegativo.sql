-- inf_Stocknegativo ' ','ZZZZZ', 1

DROP PROCEDURE INF_StockNegativo 
GO
CREATE PROCEDURE INF_StockNegativo (
@DepositoDesde VarChar(5),
@DepositoHasta VarChar(5),
@Empresa Int)

AS

SELECT stkDepositos.Deposito_id, stkDepositos.Descripcion as DescripcionDeposito,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
	stkExistencia.Cantidad
from stkProductos INNER JOIN stkExistencia ON
stkProductos.stkProductos = stkExistencia.Producto_id
INNER JOIN stkDepositos ON
stkDepositos.stkDepositos = stkExistencia.Deposito_id
WHERE
stkDepositos.Deposito_Id between @DepositoDesde and @DepositoHasta and 
stkExistencia.Empresa_Id = @Empresa 
and stkExistencia.Cantidad < 0

ORDER BY 1,3

GO