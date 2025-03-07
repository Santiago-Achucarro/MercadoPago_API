--- venGraVentas '20180101','20190930',1
--- venGraVentas '20190101','20190930',1
--- venGraVentas '20190401','20190430',1
DROP PROCEDURE venGraVentas
GO
CREATE PROCEDURE venGraVentas
(
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@Empresa_Id Int	
)


as

SELECT @FechaDesde as FechaDesde, @FechaHasta FechaHasta

IF month(@FechaDesde) =month(@FechaHasta) and 
	year(@FechaDesde) =year(@FechaHasta) 

SELECT STR(day(conAsientos.Fecha),2) as Periodo, 
	'Ventas' as Serie,
	Convert(Numeric(18,2),SUM(venTipoMov.Signo * venMovimientos.Importe * conAsientos.Cambio)) AS Monto
FROM conAsientos INNER JOIN venMovimientos ON 
	conAsientos.conAsientos =venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipomov
	INNER JOIN venSubTipomov ON 
	venSubTipomov.venSubTipomov = venMovimientos.venSubTipoMov_Id
WHERE
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id AND
	conAsientos.Fecha between @FechaDesde And  @FechaHasta and
	venSubTipomov.AfectaEstadistica = 1
	GROUP BY day(conAsientos.Fecha)
UNION ALL
SELECT STR(day(conAsientos.Fecha),2) as Periodo, 
	'Cobranza' as Serie,
	Convert(Numeric(18,2),SUM(-venTipoMov.Signo * venMovimientos.Importe * conAsientos.Cambio)) AS Monto
FROM conAsientos INNER JOIN venMovimientos ON 
	conAsientos.conAsientos =venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipomov
	INNER JOIN venSubTipomov ON 
	venSubTipomov.venSubTipomov = venMovimientos.venSubTipoMov_Id
WHERE
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id AND
	conAsientos.Fecha between @FechaDesde And  @FechaHasta and
	venTipoMov.venTipoMov IN('C' ,'N')
	GROUP BY day(conAsientos.Fecha)
UNION ALL
SELECT STR(day(venpedidos.Fecha),2) as Periodo, 
	'Pedidos' as Serie,
	Convert(Numeric(18,2),SUM(venPedidos.ImporteTotal * dbo.func_TipoCambio(venPedidos.Moneda_Id, venPedidos.Fecha, venPedidos.Empresa_Id) )) AS Monto
FROM venPedidos 
WHERE
	venpedidos.Estado != 'R' AND 
	venpedidos.Posteado = 1 and
	venpedidos.Empresa_Id = @Empresa_Id AND
	venpedidos.Fecha between @FechaDesde And  @FechaHasta 
	GROUP BY day(venpedidos.Fecha)


ORDER BY 1,2

ELSE
begin
IF datediff(MONTH,@FechaDesde,@FechaHasta) < 12
 begin
SELECT STR(year(conAsientos.Fecha),4)+'-'+STR(month(conAsientos.Fecha),2) as Periodo, 
	'Ventas' as Serie,
	Convert(Numeric(18,2),SUM(venTipoMov.Signo * venMovimientos.Importe * conAsientos.Cambio)) AS Monto
FROM conAsientos INNER JOIN venMovimientos ON 
	conAsientos.conAsientos =venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipomov
	INNER JOIN venSubTipomov ON 
	venSubTipomov.venSubTipomov = venMovimientos.venSubTipoMov_Id
WHERE
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id AND
	conAsientos.Fecha between @FechaDesde And  @FechaHasta and
	venSubTipomov.AfectaEstadistica = 1
	GROUP BY year(conAsientos.Fecha),month(conAsientos.Fecha) 
UNION ALL
SELECT STR(year(conAsientos.Fecha),4)+'-'+STR(month(conAsientos.Fecha),2) as Periodo, 
	'Cobranza' as Serie,
	Convert(Numeric(18,2),SUM(-venTipoMov.Signo * venMovimientos.Importe * conAsientos.Cambio)) AS Monto
FROM conAsientos INNER JOIN venMovimientos ON 
	conAsientos.conAsientos =venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipomov
	INNER JOIN venSubTipomov ON 
	venSubTipomov.venSubTipomov = venMovimientos.venSubTipoMov_Id
WHERE
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id AND
	conAsientos.Fecha between @FechaDesde And  @FechaHasta and
	venTipoMov.venTipoMov IN('C' ,'N')
	GROUP BY year(conAsientos.Fecha),month(conAsientos.Fecha) 
UNION ALL
SELECT STR(year(venPedidos.Fecha),4)+'-'+STR(month(venPedidos.Fecha),2) as Periodo, 
	'Pedidos' as Serie,
	Convert(Numeric(18,2),SUM(venPedidos.ImporteTotal * venpedidos.Cambio)) AS Monto
FROM venPedidos 
WHERE
	venpedidos.Estado != 'R' AND 
	venpedidos.Posteado = 1 and
	venpedidos.Empresa_Id = @Empresa_Id AND
	venpedidos.Fecha between @FechaDesde And  @FechaHasta 
	GROUP BY year(venPedidos.Fecha), month(venPedidos.Fecha)

ORDER BY 1,2


 end
else

SELECT STR(year(conAsientos.Fecha),4) as Periodo, 
	'Ventas' as Serie,
	Convert(Numeric(18,2), SUM(venTipoMov.Signo * venMovimientos.Importe * conAsientos.Cambio)) AS Monto
FROM conAsientos INNER JOIN venMovimientos ON 
	conAsientos.conAsientos =venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipomov
	INNER JOIN venSubTipomov ON 
	venSubTipomov.venSubTipomov = venMovimientos.venSubTipoMov_Id
WHERE
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id AND
	conAsientos.Fecha between @FechaDesde And  @FechaHasta and
	venSubTipomov.AfectaEstadistica = 1
	GROUP BY year(conAsientos.Fecha)
UNION ALL
SELECT STR(year(conAsientos.Fecha),4) as Periodo, 
	'Cobranza' as Serie,
	Convert(Numeric(18,2), SUM(-venTipoMov.Signo * venMovimientos.Importe * conAsientos.Cambio)) AS Monto
FROM conAsientos INNER JOIN venMovimientos ON 
	conAsientos.conAsientos =venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipomov
	INNER JOIN venSubTipomov ON 
	venSubTipomov.venSubTipomov = venMovimientos.venSubTipoMov_Id
WHERE
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id AND
	conAsientos.Fecha between @FechaDesde And  @FechaHasta and
	venTipoMov.venTipoMov IN('C' ,'N')
	GROUP BY year(conAsientos.Fecha)
UNION ALL
SELECT STR(year(venPedidos.Fecha),4) as Periodo, 
	'Pedidos' as Serie,
	Convert(Numeric(18,2),SUM(venPedidos.ImporteTotal * venpedidos.Cambio)) AS Monto
FROM venPedidos 
WHERE
	venpedidos.Estado != 'R' AND 
	venpedidos.Posteado = 1 and
	venpedidos.Empresa_Id = @Empresa_Id AND
	venpedidos.Fecha between @FechaDesde And  @FechaHasta 
	GROUP BY year(venPedidos.Fecha)
ORDER BY 1,2

end
	