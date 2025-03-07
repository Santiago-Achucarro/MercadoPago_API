DROP PROCEDURE INF_tesTalonarios
GO
CREATE PROCEDURE INF_tesTalonarios (
@SucursalDesde Char(4),
@SucursalHasta Char(4))
AS
SELECT tesTalonarios.Sucursal, tesTalonarios.Desde,
tesTalonarios.Hasta, venCobradores.Cobrador_Id, venCobradores.Nombre
FROM tesTalonarios
INNER JOIN tesTalonCobrador ON tesTalonarios.Sucursal = tesTalonCobrador.Sucursal AND
	tesTalonarios.Desde = tesTalonCobrador.Desde
INNER JOIN venCobradores ON tesTalonCobrador.Cobrador_Id = venCobradores.venCobradores
WHERE tesTalonarios.Sucursal >= @SucursalDesde AND 
tesTalonarios.Sucursal <= @SucursalHasta
ORDER BY 1

