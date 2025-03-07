-- INF_tesTiposCambio '20180101','20180630',' ','zzz',1
DROP PROCEDURE INF_tesTiposCambio
GO

CREATE PROCEDURE INF_tesTiposCambio
(
@FechaDesde DateTime, 
@FechaHasta DateTime, 
@MonedaDesde VarChar(5),
@MonedaHasta VarChar(5),
@Empresa_Id Int
)
AS

SELECT genMonedas.Moneda_Id, genMonedas.Descripcion, 
	genTipoCambio.Fecha, 
	genTipoCambio.CambioCompra, genTipoCambio.CambioVenta
FROM genTipoCambio INNER JOIN genMonedas ON
genTipoCambio.Moneda_Id = genMonedas.genMonedas
WHERE
	genMonedas.Moneda_Id BETWEEN @MonedaDesde AND @MonedaHasta AND 
	genTipoCambio.Fecha BETWEEN @FechaDesde AND @FechaHasta and 
	ISNULL(genTipoCambio.Empresa_Id, @Empresa_Id) = @Empresa_Id
ORDER BY 1, 3
GO
