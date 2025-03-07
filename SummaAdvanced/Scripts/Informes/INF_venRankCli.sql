-- INF_venRankCli '20170101','20180831',1
DROP PROCEDURE INF_venRankCli
GO
CREATE PROCEDURE INF_venRankCli @FechaDesde DateTime, @FechaHasta DateTime, @Empresa int
AS

SELECT genMonedas.genMonedas,
dbo.func_TipoCambio(genMonedas.genMonedas, DATEADD(dd,1,@FechaHasta), @Empresa) as Cambio
INTO #CAMBIO
FROM genMonedas

SELECT venClientes.Cliente_Id, venClientes.RazonSocial, 
	Convert(Numeric(18,2), SUM((venMovimientos.Importe - IsNull(Impuestos.Importe, 0)) * venTipoMov.Signo * #CAMBIO.Cambio )) as Monto
From venMovimientos 
INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
Left Join (Select venMovImpuestos.venMovimientos conAsientos, Sum(Importe) Importe 
	From venMovImpuestos Group By venMovImpuestos.venMovimientos) Impuestos 
		On Impuestos.conAsientos = conAsientos.conAsientos
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
INNER JOIN #CAMBIO ON #CAMBIO.genMonedas = conAsientos.Moneda_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	venSubTipoMov.AfectaEstadistica = 1 and 
	venTipoMov.venTipoMov NOT IN ('N','C','P') and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta 
GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial
ORDER BY 3 DESC
GO
