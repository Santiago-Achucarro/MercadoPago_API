-- Inf_conEvoPatne '20180630', 1
DROP PROCEDURE Inf_conEvoPatne
GO
CREATE PROCEDURE Inf_conEvoPatne
(
	@FechaHasta Datetime, 
	@Empresa_Id Int
)
AS
DECLARE @FechaDesde DateTime 

SET @FechaDesde = (SELECT MIN(conPeriodos.Fecha_Desde) 
		From conPeriodos INNER JOIN conPeriodos conPeriodos1 ON
		conPeriodos.Ejercicio = conPeriodos1.Ejercicio 
		WHERE
			 @FechaHasta Between conPeriodos1.Fecha_Desde And conPeriodos1.Fecha_Hasta)

Select 1 AS ORDEN, 'Saldos AL '+ CONVERT(CHAR(10),@FechaDesde) AS Leyenda,
	case when conTiposContables.Rubro_Balance = 'APORT' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Aumentos, 
	case when conTiposContables.Rubro_Balance In( 'CAPIT', 'CAPV') THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Capital, 
	case when conTiposContables.Rubro_Balance = 'RESAC' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResNoAsi, 
	case when conTiposContables.Rubro_Balance = 'RESLE' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResLegal, 
	case when conTiposContables.Rubro_Balance = 'SEPN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Resultados, 
	case when conTiposContables.Rubro_Balance = 'PART' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Participacion, 
	case when conTiposContables.Rubro_Balance = 'RTEN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResPorTenencia,
	case when conTiposContables.Rubro_Balance = 'DINV' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as DeInversiones,
	case when conTiposContables.Rubro_Balance = 'OBLIG' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Obligaciones
	FROM conasientos INNER JOIN conmovcont ON
		conasientos.conAsientos = conmovcont.conAsientos
		INNER JOIN conCuentas ON
		conCuentas.conCuentas = conmovcont.Cuenta_Id
		INNER JOIN conTiposContables ON
		conTiposContables.Tipo_Id =conCuentas.Tipo_Id
		INNER JOIN conRubros ON
		conRubros.Rubro_Id = conCuentas.Rubro_Id
		WHERE 
		conAsientos.Fecha between @FechaDesde And @FechaHasta AND 
		conRubros.Tipo = 'CAP' 
		and conasientos.Especial = 'APE' 
		GROUP BY conTiposContables.Rubro_Balance
UNION ALL
	Select 2 AS ORDEN, 'Aplicación de la Utilidad del Ejercicio' AS Leyenda,
	case when conTiposContables.Rubro_Balance = 'APORT' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Aumentos, 
	case when conTiposContables.Rubro_Balance In( 'CAPIT', 'CAPV') THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Capital, 
	case when conTiposContables.Rubro_Balance = 'RESAC' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResNoAsi, 
	case when conTiposContables.Rubro_Balance = 'RESLE' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResLegal, 
	case when conTiposContables.Rubro_Balance = 'SEPN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Resultados, 
	case when conTiposContables.Rubro_Balance = 'PART' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Participacion, 
	case when conTiposContables.Rubro_Balance = 'RTEN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResPorTenencia,
	case when conTiposContables.Rubro_Balance = 'DINV' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as DeInversiones,
	case when conTiposContables.Rubro_Balance = 'OBLIG' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Obligaciones
	FROM conasientos INNER JOIN conmovcont ON
		conasientos.conAsientos = conmovcont.conAsientos
		INNER JOIN conCuentas ON
		conCuentas.conCuentas = conmovcont.Cuenta_Id
		INNER JOIN conTiposContables ON
		conTiposContables.Tipo_Id =conCuentas.Tipo_Id
		INNER JOIN conRubros ON
		conRubros.Rubro_Id = conCuentas.Rubro_Id
		WHERE 
		conTiposContables.Rubro_Balance = 'RESAC' AND 
		conAsientos.Fecha between @FechaDesde And @FechaHasta AND 
		conRubros.Tipo = 'CAP' 
		GROUP BY conTiposContables.Rubro_Balance

UNION ALL
	Select 3 AS ORDEN, 'Aumento de Capital Social' AS Leyenda,
	case when conTiposContables.Rubro_Balance = 'APORT' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Aumentos, 
	case when conTiposContables.Rubro_Balance In( 'CAPIT', 'CAPV') THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Capital, 
	case when conTiposContables.Rubro_Balance = 'RESAC' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResNoAsi, 
	case when conTiposContables.Rubro_Balance = 'RESLE' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResLegal, 
	case when conTiposContables.Rubro_Balance = 'SEPN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Resultados, 
	case when conTiposContables.Rubro_Balance = 'PART' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Participacion, 
	case when conTiposContables.Rubro_Balance = 'RTEN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResPorTenencia,
	case when conTiposContables.Rubro_Balance = 'DINV' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as DeInversiones,
	case when conTiposContables.Rubro_Balance = 'OBLIG' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Obligaciones
	FROM conasientos INNER JOIN conmovcont ON
		conasientos.conAsientos = conmovcont.conAsientos
		INNER JOIN conCuentas ON
		conCuentas.conCuentas = conmovcont.Cuenta_Id
		INNER JOIN conTiposContables ON
		conTiposContables.Tipo_Id =conCuentas.Tipo_Id
		INNER JOIN conRubros ON
		conRubros.Rubro_Id = conCuentas.Rubro_Id
		WHERE 
		conTiposContables.Rubro_Balance In( 'CAPIT', 'CAPV') AND 
		conAsientos.Fecha between @FechaDesde And @FechaHasta AND 
		conRubros.Tipo = 'CAP' 
		GROUP BY conTiposContables.Rubro_Balance
UNION ALL
	Select 4 AS ORDEN, 'Aportaciones para Futuros Aumentos' AS Leyenda,
	case when conTiposContables.Rubro_Balance = 'APORT' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Aumentos, 
	case when conTiposContables.Rubro_Balance In( 'CAPIT', 'CAPV') THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Capital, 
	case when conTiposContables.Rubro_Balance = 'RESAC' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResNoAsi, 
	case when conTiposContables.Rubro_Balance = 'RESLE' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResLegal, 
	case when conTiposContables.Rubro_Balance = 'SEPN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Resultados, 
	case when conTiposContables.Rubro_Balance = 'PART' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Participacion, 
	case when conTiposContables.Rubro_Balance = 'RTEN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResPorTenencia,
	case when conTiposContables.Rubro_Balance = 'DINV' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as DeInversiones,
	case when conTiposContables.Rubro_Balance = 'OBLIG' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Obligaciones
	FROM conasientos INNER JOIN conmovcont ON
		conasientos.conAsientos = conmovcont.conAsientos
		INNER JOIN conCuentas ON
		conCuentas.conCuentas = conmovcont.Cuenta_Id
		INNER JOIN conTiposContables ON
		conTiposContables.Tipo_Id =conCuentas.Tipo_Id
		INNER JOIN conRubros ON
		conRubros.Rubro_Id = conCuentas.Rubro_Id
		WHERE 
		conTiposContables.Rubro_Balance = 'APORT' AND 
		conAsientos.Fecha between @FechaDesde And @FechaHasta AND 
		conRubros.Tipo = 'CAP' 
		GROUP BY conTiposContables.Rubro_Balance

UNION ALL
	Select 5 AS ORDEN, 'Variación Reserva Legal' AS Leyenda,
	case when conTiposContables.Rubro_Balance = 'APORT' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Aumentos, 
	case when conTiposContables.Rubro_Balance In( 'CAPIT', 'CAPV') THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Capital, 
	case when conTiposContables.Rubro_Balance = 'RESAC' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResNoAsi, 
	case when conTiposContables.Rubro_Balance = 'RESLE' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResLegal, 
	case when conTiposContables.Rubro_Balance = 'SEPN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Resultados, 
	case when conTiposContables.Rubro_Balance = 'PART' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Participacion, 
	case when conTiposContables.Rubro_Balance = 'RTEN' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as ResPorTenencia,
	case when conTiposContables.Rubro_Balance = 'DINV' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as DeInversiones,
	case when conTiposContables.Rubro_Balance = 'OBLIG' THEN 
		SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) ELSE 0 END as Obligaciones
	FROM conasientos INNER JOIN conmovcont ON
		conasientos.conAsientos = conmovcont.conAsientos
		INNER JOIN conCuentas ON
		conCuentas.conCuentas = conmovcont.Cuenta_Id
		INNER JOIN conTiposContables ON
		conTiposContables.Tipo_Id =conCuentas.Tipo_Id
		INNER JOIN conRubros ON
		conRubros.Rubro_Id = conCuentas.Rubro_Id
		WHERE 
		conTiposContables.Rubro_Balance = 'RESLE'  AND 
		conAsientos.Fecha between @FechaDesde And @FechaHasta AND 
		conRubros.Tipo = 'CAP' 
		GROUP BY conTiposContables.Rubro_Balance

UNION ALL
	Select 6 AS ORDEN, 'Utilidad (Perdida) Neta del Ejercicio' AS Leyenda,
	0 as Aumentos, 
	0 as Capital, 
	0 as ResNoAsi, 
	0 as ResLegal, 
	SUM(-conmovcont.IMPORTE * (-2*conmovcont.Tipomov+3)) as Resultados, 
	0 as Participacion, 
	0 as ResPorTenencia,
	0 as DeInversiones,
	0 as Obligaciones
	FROM conasientos INNER JOIN conmovcont ON
		conasientos.conAsientos = conmovcont.conAsientos
		INNER JOIN conCuentas ON
		conCuentas.conCuentas = conmovcont.Cuenta_Id
		INNER JOIN conTiposContables ON
		conTiposContables.Tipo_Id =conCuentas.Tipo_Id
		INNER JOIN conRubros ON
		conRubros.Rubro_Id = conCuentas.Rubro_Id
		WHERE 
		conAsientos.Fecha between @FechaDesde And @FechaHasta AND 
		conRubros.Tipo IN('ING' ,'GAS', 'COS', 'OI','OE')
		GROUP BY conTiposContables.Rubro_Balance


GO		