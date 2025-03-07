-- Inf_conEstadoRes  1, '20210101','20211231', '','ZZZ',' ','ZZZ', 'es'
-- Inf_conEstadoRes  1, '20180501','20180531', '1','ZZZ',' ','ZZZ', 'en'
DROP Procedure Inf_conEstadoRes 
GO
Create Procedure Inf_conEstadoRes 
(
@Empresa Int, 
@FechaDesde DateTime, 
@FechaHasta DateTime, 
@Centro1Desde VarChar(8),
@Centro1Hasta VarChar(8),
@Centro2Desde VarChar(8),
@Centro2Hasta VarChar(8),
@Cultura VarChar(5)=null
)
as

Declare @EnOtro bit 
set @EnOtro = (Select dbo.EnOtroLenguaje(@Cultura))

SET Transaction Isolation Level Read Uncommitted

DECLARE @FechaDesdeE DateTime


SET @FechaDesdeE = (
			select min(Fecha_Desde) from conPeriodos inner join genEmpresas ON
			genEmpresas.genEmpresas = conPeriodos.Empresa_Id
			WHERE
			--conPeriodos.Fecha_Desde = genEmpresas.FechaInicioSumma and 
			conPeriodos.Empresa_Id = @Empresa AND 
			conPeriodos.Ejercicio = (select ejercicio from conPeriodos conPeriodos1 
			where
				conPeriodos1.Empresa_Id = @Empresa AND 
				@FechaDesde between conPeriodos1.Fecha_Desde and conPeriodos1.Fecha_Hasta))



PRINT @FechaDesdeE
-- Ingresos

SELECT * INTO #T1  FROM vconMovContRes WHERE FECHA BETWEEN @FechaDesdeE AND @FechaHasta and 
	Empresa_id = @Empresa


-- Ingresos

SELECT 10 AS ORDENTIPO, conAnexosGrupos.Orden , 'V' AS Tipo,
	case when @EnOtro=1 then conAnexosGrupos.Description else conAnexosGrupos.Descripcion end Descripcion,
ISNULL((SELECT SUM(-Monto) 
	from #T1  vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id  BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id  BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as Monto,
		ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #T1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id  BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id  BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as MontoAcum
		,@FechaDesdeE as FechaDesdeE
FROM 
	conAnexosGrupos inner join conAnexosOrigenes ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
where
	conAnexosOrigenes.TipoRubro = 'ING' 
UNION ALL
SELECT 20 AS ORDENTIPO, 1 Orden , 'T' AS Tipo,
	'Total_'+conAnexosOrigenes.Descripcion Descripcion,
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id  BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as  Monto, 
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id  BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as  MontoAcum
		,@FechaDesdeE as FechaDesdeE
FROM conAnexosOrigenes
where
	conAnexosOrigenes.TipoRubro = 'ING'
	
--- Costos

UNION ALL

SELECT 30 AS ORDENTIPO, conAnexosGrupos.Orden , 'V' AS Tipo, 
	case when @EnOtro=1 then conAnexosGrupos.Description else conAnexosGrupos.Descripcion end Descripcion,
ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id  BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id  BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as Monto,
		ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM 
	conAnexosGrupos inner join conAnexosOrigenes ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
where
	conAnexosOrigenes.TipoRubro = 'COS'

UNION ALL
-- Total Costos
SELECT 40 AS ORDENTIPO, 1 Orden , 'T' AS Tipo, 
	'Total_'+ conAnexosOrigenes.Descripcion, 
ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as  Monto, 
		ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id  BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id  BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as  MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM conAnexosOrigenes
where
	conAnexosOrigenes.TipoRubro = 'COS'
-- UTILIDAD (Perdida Bruta)
UNION ALL
select xxx.ORDENTIPO, xxx.Orden,  'T' AS Tipo,  xxx.Descripcion,
	SUM(Monto) as Monto, SUM(MontoAcum) MontoAcum,@FechaDesdeE as FechaDesdeE
from (
-- Utilidad o Perdida Bruta
SELECT 50 AS ORDENTIPO, 1 Orden , 
	'Utilidad_(Perdida)_Bruta' Descripcion, 'T' AS Tipo, 
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as  Monto, 
		ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id  BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as  MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM conAnexosOrigenes
where
	conAnexosOrigenes.TipoRubro in ('COS', 'ING')) as xxx
group by xxx.ORDENTIPO, xxx.Orden,  xxx.Descripcion
-- gastos
UNION ALL
SELECT 60 AS ORDENTIPO, conAnexosGrupos.Orden , 'V' AS Tipo, 
	case when @EnOtro=1 then conAnexosGrupos.Description else conAnexosGrupos.Descripcion end Descripcion,
ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as Monto, 
		ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM 
	conAnexosGrupos inner join conAnexosOrigenes ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
where
	conAnexosOrigenes.TipoRubro = 'GAS'

-- UTILIDAD (Perdida Bruta)
UNION ALL
select xxx.ORDENTIPO, xxx.Orden,  'T' AS Tipo,  xxx.Descripcion, 
	SUM(Monto) as Monto, SUM(MontoAcum) MontoAcum
	,@FechaDesdeE as FechaDesdeE
from (
-- Utilidad o Perdida Operacion
SELECT 70 AS ORDENTIPO, 1 Orden , 
	'Utilidad_(Perdida)_Operacion' Descripcion, 
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as  Monto, 
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as  MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM conAnexosOrigenes
where
	conAnexosOrigenes.TipoRubro in ('COS', 'ING','GAS')) as xxx
group by xxx.ORDENTIPO, xxx.Orden,  xxx.Descripcion

-- Otros Ingresos
UNION ALL
SELECT 80 AS ORDENTIPO, conAnexosGrupos.Orden , 'V' AS Tipo, 
	case when @EnOtro=1 then conAnexosGrupos.Description else conAnexosGrupos.Descripcion end Descripcion,
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as Monto, 
		ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM 
	conAnexosGrupos inner join conAnexosOrigenes ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
where
	conAnexosOrigenes.TipoRubro = 'OI'

UNION ALL
SELECT 90 AS ORDENTIPO, conAnexosGrupos.Orden , 'V' AS Tipo, 
	case when @EnOtro=1 then conAnexosGrupos.Description else conAnexosGrupos.Descripcion end Descripcion,
ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as Monto, 
ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id  BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM 
	conAnexosGrupos inner join conAnexosOrigenes ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
where
	conAnexosOrigenes.TipoRubro = 'OE' and 
	conAnexosOrigenes.Origen = 5



UNION ALL
SELECT 110 AS ORDENTIPO, conAnexosGrupos.Orden , 'V' AS Tipo, 
	case when @EnOtro=1 then conAnexosGrupos.Description else conAnexosGrupos.Descripcion end Descripcion,
ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as Monto, 
ISNULL((SELECT SUM(vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM 
	conAnexosGrupos inner join conAnexosOrigenes ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
where
	conAnexosOrigenes.TipoRubro = 'OE' and 
	conAnexosOrigenes.Origen = 7

UNION ALL
-- Utilidad o Perdida Operacion
select xxx.ORDENTIPO, xxx.Orden,  'T' AS Tipo,  xxx.Descripcion, 
	SUM(Monto) as Monto, SUM(MontoAcum) MontoAcum,@FechaDesdeE as FechaDesdeE
from (
SELECT 100 AS ORDENTIPO, 1 Orden , 
	'Utilidad_(Perdida)_Antes_de_Impuestos' Descripcion, 
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id  BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as  Monto,
		ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as  MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM conAnexosOrigenes
where
	conAnexosOrigenes.TipoRubro in ('COS', 'ING','GAS', 'OI','OE') AND
	conAnexosOrigenes.Origen <> 7)  as xxx
group by xxx.ORDENTIPO, xxx.Orden,  xxx.Descripcion
UNION ALL
-- Impuestos
select xxx.ORDENTIPO, xxx.Orden,  'T' AS Tipo,  xxx.Descripcion, 
	SUM(Monto) as Monto, SUM(MontoAcum) MontoAcum,@FechaDesdeE as FechaDesdeE
from (
SELECT 115 AS ORDENTIPO, 1 Orden , 
	'Impuestos' Descripcion, 
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as  Monto, 
	ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as  MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM conAnexosOrigenes
where
	conAnexosOrigenes.TipoRubro in ('IM') AND
	conAnexosOrigenes.Origen <> 7)  as xxx
group by xxx.ORDENTIPO, xxx.Orden,  xxx.Descripcion
UNION ALL
-- Utilidad o Perdida Operacion
select xxx.ORDENTIPO, xxx.Orden, 'T' AS Tipo,  xxx.Descripcion, 
	SUM(Monto) as Monto, SUM(MontoAcum) as MontoAcum,@FechaDesdeE as FechaDesdeE
from (
SELECT 120 AS ORDENTIPO, 1 Orden , 
	'Utilidad_(Perdida)' Descripcion, 
ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesde And @FechaHasta),0) as  Monto,
		ISNULL((SELECT SUM(-vconMovContRes.Monto) 
	from #t1 vconMovContRes
	INNER JOIN conAnexosGrupos ON
	conAnexosGrupos.Origen = conAnexosOrigenes.Origen 
	INNER JOIN conAnexoGrupoTipos ON
	conAnexoGrupoTipos.GrupoAne_Id = conAnexosGrupos.GrupoAne_Id and
	conAnexoGrupoTipos.Tipo_Id = vconMovContRes.Tipo_Id
	WHERE
		vconMovContRes.Empresa_Id = @Empresa and 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		vconMovContRes.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and 
		vconMovContRes.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta and 
		vconMovContRes.Fecha between @FechaDesdeE And @FechaHasta),0) as  MontoAcum
		,@FechaDesdeE as FechaDesdeE

FROM conAnexosOrigenes
where
	conAnexosOrigenes.TipoRubro in ('COS', 'ING','GAS', 'OI','OE','IM'))  as xxx
group by xxx.ORDENTIPO, xxx.Orden,  xxx.Descripcion
order by 1,2
OPTION	(RECOMPILE)

DROP TABLE #T1 

GO

