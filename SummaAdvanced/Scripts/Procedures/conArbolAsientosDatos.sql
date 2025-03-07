-- conArbolAsientosDatos 2019,12,1
-- conArbolAsientosSFDatos 2019,12,1,' ','zzz',' ','zzz'


DROP Procedure conArbolAsientosDatos
go
CREATE Procedure conArbolAsientosDatos
(
	@Ejercicio int, 
	@PeriodoHasta smallint,
	@Empresa Int,
	@Centro1Desde varchar(8),
	@Centro1Hasta varchar(8),
	@Centro2Desde varchar(8),
	@Centro2Hasta varchar(8)
)
AS

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
select conPeriodos.Ejercicio, conPeriodos.Periodo, vconMovcontRes.* into #Tb1
from vconMovcontRes 
	INNER JOIN conPeriodos ON vconMovcontRes.Fecha between  conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta
		 AND conPeriodos.Empresa_Id = vconMovcontRes.Empresa_Id
	where 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Periodo <= @PeriodoHasta and 
		conPeriodos.Empresa_id = @Empresa and 
		Centro1_Id between @Centro1Desde and @Centro1Hasta and 
		Centro2_Id between @Centro2Desde and @Centro2Hasta 


select conPeriodos.Ejercicio, @PeriodoHasta AS Periodo, 'E' AS Tipo, @centro1Desde as Centro1Desde, @Centro1Hasta as Centro1Hasta, @Centro2Desde as Centro2Desde, @Centro2Hasta as Centro2Hasta
from conPeriodos 
where
Ejercicio = @Ejercicio AND 
Empresa_Id = @Empresa and 
conPeriodos.Periodo <= @PeriodoHasta
GROUP BY conPeriodos.Ejercicio
select xxx.Orden, xxx.Cuenta_Id, ISNULL(concuentas1.concuentas,0) hijo, 
	xxx.Descripcion, xxx.Nivel, xxx.Imputable, ISNULL(concuentas2.concuentas,-1) as Padre, 
	xxx.PER01, xxx.PER02, xxx.PER03, xxx.PER04, xxx.PER05, xxx.PER06, 
	xxx.PER07, xxx.PER08, xxx.PER09, xxx.PER10, xxx.PER11, xxx.PER12, 
	xxx.PER13, 
	xxx.PER01 + xxx.PER02 + xxx.PER03 + xxx.PER04 + xxx.PER05 + xxx.PER06 + 
	xxx.PER07 + xxx.PER08 + xxx.PER09 + xxx.PER10 + xxx.PER11 + xxx.PER12 +
	xxx.PER13 as Total 
from 
(
SELECT 1 as Orden, conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Nivel, conCuentas.Imputable, 
		(SELECT Max(vcuentasRango.Cuenta_Id) from vcuentasRango
			Where
				conCuentas.Cuenta_Id > vcuentasRango.Cuenta_Id and 
				conCuentas.Cuenta_Id < vcuentasRango.CuentaHasta) as Padre, 
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 1 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER01 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 2 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER02 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 3 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER03 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 4 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER04 ,
						
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 5 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER05 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 6 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER06 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 7 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER07 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 8 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER08 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 9 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER09 ,
				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 10 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER10 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 11 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER11 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 12 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER12 ,
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 13 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER13, 
	0.00 as Total
from conCuentas INNER JOIN conRubros ON
conCuentas.Rubro_Id = conRubros.Rubro_Id

Where
	conRubros.Tipo = 'ING'
UNION ALL -- COSTO DE VENTAS

SELECT 2 as Orden, conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Nivel, conCuentas.Imputable, 
		(SELECT Max(vcuentasRango.Cuenta_Id) from vcuentasRango Where
			conCuentas.Cuenta_Id > vcuentasRango.Cuenta_Id and 
				conCuentas.Cuenta_Id < vcuentasRango.CuentaHasta) as Padre, 
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 1 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER01 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 2 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER02 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 3 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER03 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 4 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER04 ,
						
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 5 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER05 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 6 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER06 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 7 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER07 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 8 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER08 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 9 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER09 ,
				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 10 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER10 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 11 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER11 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 12 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER12 ,
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 13 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER13, 0.00 AS TOTAL

from conCuentas INNER JOIN conRubros ON
conCuentas.Rubro_Id = conRubros.Rubro_Id

Where
	conRubros.Tipo = 'COS'

UNION ALL -- RESULTADO BRUTO
SELECT 3 AS Orden, ' ' Cuenta_Id, 'Resultado Bruto' Descripcion , 1 Nivel ,0 Imputable , NULL Padre,
	 0,0,0,0,0,0,0,0,0,0,0,0, 0,0

UNION ALL -- GASTOS

SELECT 4 as Orden, conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Nivel, conCuentas.Imputable, 
		(SELECT Max(vcuentasRango.Cuenta_Id) from vcuentasRango Where
			conCuentas.Cuenta_Id > vcuentasRango.Cuenta_Id and 
				conCuentas.Cuenta_Id < vcuentasRango.CuentaHasta) as Padre, 
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 1 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER01 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 2 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER02 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 3 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER03 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 4 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER04 ,
						
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 5 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER05 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 6 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER06 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 7 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER07 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 8 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER08 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 9 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER09 ,
				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 10 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER10 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 11 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER11 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 12 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER12 ,
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 13 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER13, 0.00 AS TOTAL
from conCuentas INNER JOIN conRubros ON
conCuentas.Rubro_Id = conRubros.Rubro_Id

Where
	conRubros.Tipo = 'GAS'
UNION ALL -- RESULTADO OPERACION
SELECT 5 AS Orden, ' ' Cuenta_Id, 'Resultado Operacion' Descripcion , 1 Nivel ,0 Imputable , NULL Padre,
	 0,0,0,0,0,0,0,0,0,0,0,0, 0,0

UNION ALL -- OTROS INGRESOS

SELECT 6 as Orden, conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Nivel, conCuentas.Imputable, 
		(SELECT Max(vcuentasRango.Cuenta_Id) from vcuentasRango Where
			conCuentas.Cuenta_Id > vcuentasRango.Cuenta_Id and 
				conCuentas.Cuenta_Id < vcuentasRango.CuentaHasta) as Padre, 
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 1 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER01 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 2 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER02 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 3 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER03 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 4 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER04 ,
						
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 5 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER05 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 6 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER06 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 7 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER07 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 8 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER08 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 9 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER09 ,
				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 10 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER10 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 11 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER11 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 12 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER12 ,
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 13 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER13, 0.00 AS TOTAL

from conCuentas INNER JOIN conRubros ON
conCuentas.Rubro_Id = conRubros.Rubro_Id

Where
	conRubros.Tipo = 'OI'

UNION ALL -- OTROS EGRESOS

SELECT 7 as Orden, conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Nivel, conCuentas.Imputable, 
		(SELECT Max(vcuentasRango.Cuenta_Id) from vcuentasRango Where
			conCuentas.Cuenta_Id > vcuentasRango.Cuenta_Id and 
				conCuentas.Cuenta_Id < vcuentasRango.CuentaHasta) as Padre, 
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 1 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER01 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 2 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER02 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 3 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER03 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 4 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER04 ,
						
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 5 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER05 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 6 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER06 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 7 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER07 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 8 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER08 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 9 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER09 ,
				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 10 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER10 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 11 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER11 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 12 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER12 ,
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 13 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER13, 0.00 AS TOTAL

from conCuentas INNER JOIN conRubros ON
conCuentas.Rubro_Id = conRubros.Rubro_Id
Where
	conRubros.Tipo = 'OE'
UNION ALL -- Resultado Ejericio
SELECT 9 AS Orden, ' ' Cuenta_Id, 'Resultado Ejericio' Descripcion , 1 Nivel ,0 Imputable , NULL Padre,
	 0,0,0,0,0,0,0,0,0,0,0,0, 0,0

) as xxx
LEFT join conCuentas conCuentas1 ON 
conCuentas1.Cuenta_Id = xxx.Cuenta_Id
LEFT join conCuentas conCuentas2 ON 
conCuentas2.Cuenta_Id = xxx.Padre
order by 1,2
OPTION	(RECOMPILE)


SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion,  ' ' Formulario_Id , 	
	' ' as Detalle, ' ' as Centro1_Id, ' ' as Centro2_Id,
	0.00 as Debe, 0.00 as Haber
from conCuentas
Where 1 = 2


SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	getDate() as Fecha,
	' ' Segmento , 
	' ' AS Entidad, ' ' as Detalle,  ' ' as Centro1_Id, ' ' as Centro2_Id,
		0.00 as Debe, 0.00 as Haber, ' ' as Observaciones
from conCuentas
Where 1 = 2

-- para los parametros

SELECT conCuentas.Cuenta_Id, 0 AS Ejercicio, 0 as Periodo, ' ' as Formulario_Id,	
	' ' Centro1_Id, ' ' Centro2_Id
from conCuentas
Where 1 = 2

GO

DROP PROCEDURE conResumenDatos
GO

CREATE PROCEDURE conResumenDatos(
	@Cuenta_Id VarChar(25),
	@Ejercicio int, 
	@Periodo Int,
	@Empresa Int
	)
as

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

Select @Cuenta_Id AS Cuenta_Id, @Ejercicio Ejercicio,  @Periodo Periodo

select concuentas.Cuenta_Id, conCuentas.Descripcion, disFormularios.Formulario_id, 
	conCentro1.Centro1_Id, conCentro2.Centro2_Id,
	disFormularios.Descripcion as Detalle, 
		sum(case when conMovCont.Tipomov = 1 then conMovCont.Importe else 0 end) as Debe,
		sum(case when conMovCont.Tipomov = 2 then conMovCont.Importe else 0 end) as Haber
from conAsientos INNER JOIN conMovCont ON 
	conAsientos.conAsientos = conMovCont.conASientos 
	INNER JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN  conCentro1 ON conCentro1.conCentro1 = isnull(conMovCont.centro1_id, 1)
	INNER JOIN  conCentro2 ON conCentro2.conCentro2 = isnull(conMovCont.centro2_id, 1)
	INNER JOIN conPeriodos ON  conAsientos.Fecha between conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conCuentas.Cuenta_Id = @Cuenta_Id and
	conAsientos.Empresa_Id = @Empresa and 
	conPeriodos.Ejercicio = @Ejercicio and 
	conPeriodos.Empresa_Id = @Empresa and 
	conPeriodos.Periodo = @Periodo 
GROUP BY concuentas.Cuenta_Id, conCuentas.Descripcion, disFormularios.Formulario_id, 
	conCentro1.Centro1_Id, conCentro2.Centro2_Id,
	disFormularios.Descripcion , conMovCont.Tipomov
	order by 4,5,3
GO



DROP PROCEDURE conDetalleDatos
GO

CREATE PROCEDURE conDetalleDatos(
	@Cuenta_Id VarChar(25),
	@Centro1_Id VarChar(8),
	@Centro2_Id VarChar(8),
	@Formulario_Id VarChar(30),
	@Ejercicio int, 
	@Periodo Int,
	@Empresa Int
	)
as

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

Select @Cuenta_Id AS Cuenta_Id, @Centro1_Id as Centro1_Id, @Centro2_Id as Centro2_Id,
	@Formulario_Id  Formulario_Id, @Ejercicio Ejercicio,  @Periodo Periodo 

select concuentas.Cuenta_Id, conCuentas.Descripcion,conAsientos.Fecha,
	conCentro1.Centro1_Id, conCentro2.Centro2_Id,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C , 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) AS Segmento,
	ISNULL(venClientes.Cliente_Id, comProveedores.Proveed_Id) as Entidad,
	ISNULL(venClientes.RazonSocial, comProveedores.RazonSocial) as Detalle, 
	conAsientos.Observaciones,
		sum(case when conMovCont.Tipomov = 1 then conMovCont.Importe else 0 end) as Debe,
		sum(case when conMovCont.Tipomov = 2 then conMovCont.Importe else 0 end) as Haber
from conAsientos INNER JOIN conMovCont ON 
	conAsientos.conAsientos = conMovCont.conASientos 
	INNER JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN  conCentro1 ON conCentro1.conCentro1 = isnull(conMovCont.centro1_id, 1)
	INNER JOIN  conCentro2 ON conCentro2.conCentro2 = isnull(conMovCont.centro2_id, 1)
	INNER JOIN conPeriodos ON  conAsientos.Fecha between conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta and
		conPeriodos.Empresa_Id = conAsientos.Empresa_Id
	INNER JOIN genAsiSegmentos ON  genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	LEFT JOIN (venMovimientos INNER JOIN venClientes ON 
		venMovimientos.Cliente_Id = venClientes.genEntidades) ON 
		venMovimientos.venMovimientos = conAsientos.conAsientos
	LEFT JOIN (commovprov INNER JOIN comProveedores ON 
		comMovprov.Proveed_Id = comProveedores.genEntidades) ON 
		comMovprov.comMovprov = conAsientos.conAsientos
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa and 
	conCuentas.Cuenta_Id = @Cuenta_Id and
	conPeriodos.Ejercicio = @Ejercicio and 
	conPeriodos.Periodo = @Periodo  and 
	conperiodos.Empresa_Id = conAsientos.Empresa_Id and 
	conCentro1.Centro1_Id = @Centro1_Id and 
	conCentro2.Centro2_Id = @Centro2_Id and 
	disFormularios.Formulario_Id = @Formulario_Id
GROUP BY concuentas.Cuenta_Id, conCuentas.Descripcion, disFormularios.Formulario_id, 
	conCentro1.Centro1_Id, conCentro2.Centro2_Id,
	disFormularios.Descripcion , conMovCont.Tipomov,
	conAsientos.Fecha, genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C , 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N, venClientes.Cliente_Id, comProveedores.Proveed_Id,
		venClientes.RazonSocial, comProveedores.RazonSocial,
	conAsientos.Observaciones
	order by 4,5,3
GO


DROP Procedure conArbolAsientosSFDatos
GO

CREATE Procedure conArbolAsientosSFDatos
(
	@Ejercicio int, 
	@PeriodoHasta smallint,
	@Empresa Int,
	@Centro1Desde varchar(8),
	@Centro1Hasta varchar(8),
	@Centro2Desde varchar(8),
	@Centro2Hasta varchar(8)
)
AS

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

select conPeriodos.Ejercicio, conPeriodos.Periodo, vconMovcontRes.* into #Tb1
from vconMovcontRes 
	INNER JOIN conPeriodos ON vconMovcontRes.Fecha between  conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta
	AND conPeriodos.Empresa_Id = vconMovcontRes.Empresa_Id
	where 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Periodo <= @PeriodoHasta and 
		conPeriodos.Empresa_id = @Empresa and 
		Centro1_Id between @Centro1Desde and @Centro1Hasta and 
		Centro2_Id between @Centro2Desde and @Centro2Hasta 


select conPeriodos.Ejercicio, @PeriodoHasta AS Periodo, 'B' AS Tipo, @centro1Desde as Centro1Desde, @Centro1Hasta as Centro1Hasta, @Centro2Desde as Centro2Desde, @Centro2Hasta as Centro2Hasta
from conPeriodos 
where
Ejercicio = @Ejercicio AND 
conPeriodos.Empresa_Id = @Empresa and 
conPeriodos.Periodo <= @PeriodoHasta
GROUP BY conPeriodos.Ejercicio
select xxx.Orden, xxx.Cuenta_Id, ISNULL(concuentas1.concuentas,0) hijo, 
	xxx.Descripcion, xxx.Nivel, Cast(xxx.Imputable as Int) Imputable, ISNULL(concuentas2.concuentas,-1) as Padre, 
	xxx.PER01, xxx.PER02, xxx.PER03, xxx.PER04, xxx.PER05, xxx.PER06, 
	xxx.PER07, xxx.PER08, xxx.PER09, xxx.PER10, xxx.PER11, xxx.PER12, 
	xxx.PER13, 
	xxx.PER01 + xxx.PER02 + xxx.PER03 + xxx.PER04 + xxx.PER05 + xxx.PER06 + 
	xxx.PER07 + xxx.PER08 + xxx.PER09 + xxx.PER10 + xxx.PER11 + xxx.PER12 +
	xxx.PER13 as Total 
from 
(
SELECT 1 as Orden, conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Nivel, conCuentas.Imputable, 
		(SELECT Max(vcuentasRango.Cuenta_Id) from vcuentasRango
			Where
				conCuentas.Cuenta_Id > vcuentasRango.Cuenta_Id and 
				conCuentas.Cuenta_Id < vcuentasRango.CuentaHasta) as Padre, 
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 1 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER01 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 2 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER02 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 3 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER03 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 4 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER04 ,
						
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 5 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER05 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 6 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER06 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 7 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER07 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 8 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER08 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 9 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER09 ,
				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 10 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER10 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 11 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER11 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 12 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER12 ,
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 13 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER13, 0.00 AS TOTAL

from conCuentas INNER JOIN conRubros ON
conCuentas.Rubro_Id = conRubros.Rubro_Id

Where
	conRubros.Tipo = 'ACT'
UNION ALL
SELECT 2 as Orden, conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Nivel, conCuentas.Imputable, 
		(SELECT Max(vcuentasRango.Cuenta_Id) from vcuentasRango
			Where
				conCuentas.Cuenta_Id > vcuentasRango.Cuenta_Id and 
				conCuentas.Cuenta_Id < vcuentasRango.CuentaHasta) as Padre, 
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 1 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER01 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 2 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER02 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 3 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER03 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 4 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER04 ,
						
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 5 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER05 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 6 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER06 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 7 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER07 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 8 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER08 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 9 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER09 ,
				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 10 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER10 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 11 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER11 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 12 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER12 ,
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 13 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER13, 0.00 AS TOTAL

from conCuentas INNER JOIN conRubros ON
conCuentas.Rubro_Id = conRubros.Rubro_Id

Where
	conRubros.Tipo = 'PAS'
UNION ALL
SELECT 3 as Orden, conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	conCuentas.Nivel, conCuentas.Imputable, 
		(SELECT Max(vcuentasRango.Cuenta_Id) from vcuentasRango
			Where
				conCuentas.Cuenta_Id > vcuentasRango.Cuenta_Id and 
				conCuentas.Cuenta_Id < vcuentasRango.CuentaHasta) as Padre, 
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 1 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER01 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 2 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER02 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 3 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER03 ,
		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 4 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER04 ,
						
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 5 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER05 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 6 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER06 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 7 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER07 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 8 and
			#Tb1.Ejercicio = @Ejercicio ),0)  AS PER08 ,

				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 9 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER09 ,
				ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 10 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER10 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 11 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER11 ,

		ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 12 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER12 ,
ISNULL((SELECT sum(DEBE-HABER)
			from #Tb1
			WHERE
			#Tb1.conCuentas = conCuentas.conCuentas AND 
			#Tb1.Periodo = 13 and
			#Tb1.Ejercicio = @Ejercicio ),0) AS PER13, 0.00 AS TOTAL

from conCuentas INNER JOIN conRubros ON
conCuentas.Rubro_Id = conRubros.Rubro_Id

Where
	conRubros.Tipo = 'CAP'
) as xxx
LEFT join conCuentas conCuentas1 ON 
conCuentas1.Cuenta_Id = xxx.Cuenta_Id
LEFT join conCuentas conCuentas2 ON 
conCuentas2.Cuenta_Id = xxx.Padre
order by 1,2
OPTION	(RECOMPILE)


SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion,  ' ' Formulario_Id , 	
	' ' as Detalle, ' ' as Centro1_Id, ' ' as Centro2_Id,
	0.00 as Debe, 0.00 as Haber
from conCuentas
Where 1 = 2


GO



