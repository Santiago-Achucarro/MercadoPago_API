-- conInfDefiniblesMenGenerar 'ANRES',2021,4,' ','ZZZZ',' ','ZZZ',1
-- conInfDefiniblesAcuGenerar 'ER',2019,8,' ','ZZZZ',' ','ZZZ',1
-- conInfDefiniblesAcu1Generar 'ER',2019,9,' ','ZZZZ',' ','ZZZ',1
-- conInfDefiniblesCabecera 'ER',2019,9,' ','ZZZZ',' ','ZZZ',1


DROP PROCEDURE conInfDefiniblesCabecera
GO
CREATE PROCEDURE conInfDefiniblesCabecera
(
	@Informe_Id VarChar(15),
	@Ejercicio Int,
	@PeriodoHasta Int,
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@Empresa_Id Int
)
AS


SELECT conInfDefinibles.Descripcion, 
	(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 1)   as Per01,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 2)   as Per02,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 3)   as Per03,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 4)   as Per04,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 5)   as Per05,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 6)   as Per06,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 7)   as Per07,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 8)   as Per08,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 9)   as Per09,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 10)   as Per10,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 11)   as Per11,
		(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = 12)   as Per12,
		'Audit' Per13, 
		0.00 as Total,
		(SELECT Fecha_Hasta FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = @PeriodoHasta) FechaHasta, 
		conInfDefinibles.Informe_Id, @Ejercicio as Ejercicio, @PeriodoHasta as PeriodoHasta, 
		@Centro1Desde as Centro1Desde, @Centro1Hasta as Centro1Hasta, 
		@Centro2Desde as Centro2Desde, @Centro2Hasta as Centro2Hasta
	from conInfDefinibles 
where Informe_Id= @Informe_Id
GO



DROP PROCEDURE conInfDefiniblesMenGenerar
GO
CREATE PROCEDURE conInfDefiniblesMenGenerar
(
	@Informe_Id VarChar(15),
	@Ejercicio Int,
	@PeriodoHasta Int,
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@Empresa_Id Int
)
AS


select conPeriodos.Ejercicio, conPeriodos.Periodo, vconMovcontRes.* into #TbG 
from vconMovcontRes 
	INNER JOIN conPeriodos ON vconMovcontRes.Fecha between  conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta and 
		conPeriodos.Empresa_Id = vconMovcontRes.Empresa_Id
	where 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Periodo <= @PeriodoHasta and 
		conPeriodos.Empresa_id = @Empresa_Id and 
		Centro1_Id between @Centro1Desde and @Centro1Hasta and 
		Centro2_Id between @Centro2Desde and @Centro2Hasta 


SELECT conInfDefFilas.Fila, conInfDefFilas.Tipo, conInfDefFilas.Nivel, 
	conInfDefFilas.Titulo, conInfDefFilas.InvierteSigno, 
	conInfDefFilas.Fuente, 
	ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 1 ),0) as Per01,

ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 2 ),0) as Per02,
ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 3 ),0) as Per03,
	ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 3 ),0) as Per04,

	ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 3 ),0) as Per05,
				ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 6 ),0)  as Per06,
				ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 7 ),0) as Per07,
				ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 8 ),0)  as Per08,
ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 9 ),0)  as Per09,
				ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 10 ),0) as Per10,
				ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 11 ),0) as Per11,
				ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 12 ),0) as Per12,

				ISNULL((SELECT SUM(#TbG.Debe-#TbG.Haber) 
		from
			#TbG 	INNER JOIN conCuentas ON conCuentas.conCuentas = #TbG.conCuentas
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				conCuentas.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = 13 ),0)  as Per13

from conInfDefinibles 
	INNER JOIN conInfDefFilas ON conInfDefFilas.Informe_Id = conInfDefinibles.conInfDefinibles
WHERE
	conInfDefinibles.Informe_Id = @Informe_Id 
	order by 1

exec conInfDefiniblesCabecera @Informe_Id, @Ejercicio, @PeriodoHAsta, @Centro1Desde, @Centro1Hasta, @Centro2Desde, @Centro2Hasta, @Empresa_Id
Exec Inf_DATOSEMPRESA @Empresa_Id
GO



DROP PROCEDURE conInfDefiniblesAcuGenerar
GO
CREATE PROCEDURE conInfDefiniblesAcuGenerar
(
	@Informe_Id VarChar(15),
	@Ejercicio Int,
	@PeriodoHasta Int,
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@Empresa_Id Int
)
AS
	


	
select conPeriodos.Ejercicio, conPeriodos.Periodo, vconMovcontRes.* into #TbG 
from vconMovcontRes 
	INNER JOIN conPeriodos ON vconMovcontRes.Fecha between  conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta and 
	conPeriodos.Empresa_Id = vconMovcontRes.Empresa_Id
	
	where 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Periodo <= @PeriodoHasta and 
		conPeriodos.Empresa_id = @Empresa_Id and 
		Centro1_Id between @Centro1Desde and @Centro1Hasta and 
		Centro2_Id between @Centro2Desde and @Centro2Hasta 



select conPeriodos.Ejercicio, conPeriodos.Periodo, vconMovcontRes.* into #TbGA 
from vconMovcontRes 
	INNER JOIN conPeriodos ON vconMovcontRes.Fecha between  conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta and 
	conPeriodos.Empresa_Id = vconMovcontRes.Empresa_Id
	where 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		conPeriodos.Ejercicio = @Ejercicio-1 and 
		conPeriodos.Periodo <= @PeriodoHasta and 
		conPeriodos.Empresa_id = @Empresa_Id and 
		Centro1_Id between @Centro1Desde and @Centro1Hasta and 
		Centro2_Id between @Centro2Desde and @Centro2Hasta 


SELECT conInfDefFilas.Fila, conInfDefFilas.Tipo, conInfDefFilas.Nivel, 
	conInfDefFilas.Titulo, conInfDefFilas.InvierteSigno, 
	conInfDefFilas.Fuente, 
	ISNULL((SELECT SUM(DEBE-HABER) 
		from  #TbG
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbG.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
				WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = @PeriodoHasta) ,0) as MesAct,
	
		ISNULL((SELECT SUM(DEBE-HABER) 
		from  #TbGA
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbGA.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbGA.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbGA.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
				WHERE
				#TbGA.Ejercicio = @Ejercicio-1 and 
				#TbGA.Periodo = @PeriodoHasta) ,0) as MesAnt,
				ISNULL((SELECT SUM(DEBE-HABER) 
		from  #TbG
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbG.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
				WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo <= @PeriodoHasta) ,0)  as AcuAct,
	ISNULL((SELECT SUM(DEBE-HABER) 
		from  #TbGA
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbGA.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbGA.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbGA.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
				WHERE
				#TbGA.Ejercicio = @Ejercicio-1 and 
				#TbGA.Periodo = @PeriodoHasta) ,0) as MesAnt,
				ISNULL((SELECT SUM(DEBE-HABER) 
		from  #TbGA
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbGA.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbGA.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbGA.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
				WHERE
				#TbGA.Ejercicio = @Ejercicio-1 and 
				#TbGA.Periodo <= @PeriodoHasta) ,0)  as AcuAnt
from conInfDefinibles 
	INNER JOIN conInfDefFilas ON conInfDefFilas.Informe_Id = conInfDefinibles.conInfDefinibles
WHERE
	conInfDefinibles.Informe_Id = @Informe_Id 
	order by 1

SELECT conInfDefinibles.Descripcion, 
case when @PeriodoHasta = 13 then 'Audit '+str(@Ejercicio,4) else
	(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = @PeriodoHasta)  end as Periodo,
		case when @PeriodoHasta= 13 then 'Audit '+str(@Ejercicio-1,4) else
	(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio-1 and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = @PeriodoHasta)  end as PeriodoAnt,
		(SELECT Fecha_Hasta FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = @PeriodoHasta) FechaHasta, 
		conInfDefinibles.Informe_Id, @Ejercicio as Ejercicio, @PeriodoHasta as PeriodoHasta, 
		@Centro1Desde as Centro1Desde, @Centro1Hasta as Centro1Hasta, 
		@Centro2Desde as Centro2Desde, @Centro2Hasta as Centro2Hasta
	from conInfDefinibles 
where Informe_Id= @Informe_Id

	
GO


DROP PROCEDURE conInfDefiniblesAcu1Generar
GO
CREATE PROCEDURE conInfDefiniblesAcu1Generar
(
	@Informe_Id VarChar(15),
	@Ejercicio Int,
	@PeriodoHasta Int,
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@Empresa_Id Int
)
AS
Declare @MesAnt  int	
Declare @EjeAnt  int	
set @MesAnt = @PeriodoHasta-1
set @EjeAnt = @Ejercicio

if @MesAnt = 0
Begin
	set @MesAnt = 12
	set @EjeAnt = @EjeAnt-1
end


select conPeriodos.Ejercicio, conPeriodos.Periodo, vconMovcontRes.* into #TbG 
from vconMovcontRes 
	INNER JOIN conPeriodos ON vconMovcontRes.Fecha between  conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta and 
	conPeriodos.Empresa_Id = vconMovcontRes.Empresa_Id
	where 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Periodo <= @PeriodoHasta and 
		conPeriodos.Empresa_id = @Empresa_Id and 
		Centro1_Id between @Centro1Desde and @Centro1Hasta and 
		Centro2_Id between @Centro2Desde and @Centro2Hasta 



select conPeriodos.Ejercicio, conPeriodos.Periodo, vconMovcontRes.* into #TbGA 
from vconMovcontRes 
	INNER JOIN conPeriodos ON vconMovcontRes.Fecha between  conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta and 
	conPeriodos.Empresa_Id = vconMovcontRes.Empresa_Id
	where 
		vconMovContRes.Especial NOT IN ('CIR','CCP') AND 
		conPeriodos.Ejercicio = @EjeAnt and 
		conPeriodos.Periodo <= @MesAnt and 
		conPeriodos.Empresa_id = @Empresa_Id and 
		Centro1_Id between @Centro1Desde and @Centro1Hasta and 
		Centro2_Id between @Centro2Desde and @Centro2Hasta 




SELECT conInfDefFilas.Fila, conInfDefFilas.Tipo, conInfDefFilas.Nivel, 
	conInfDefFilas.Titulo, conInfDefFilas.InvierteSigno, 
	conInfDefFilas.Fuente, 
	ISNULL((SELECT SUM(DEBE-HABER) 
		from #TbG 
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbG.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo = @PeriodoHasta ),0) as MesAct,

	ISNULL((SELECT SUM(DEBE-HABER) 
		from #TbGa 
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbGa.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbGa.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbGa.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbGa.Ejercicio = @EjeAnt and 
				#TbGa.Periodo = @MesAnt ),0) as MesAnt,

	ISNULL((SELECT SUM(DEBE-HABER) 
		from #TbG 
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbG.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbG.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbG.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbG.Ejercicio = @Ejercicio and 
				#TbG.Periodo <= @PeriodoHasta ),0)  as AcuAct,
	ISNULL((SELECT SUM(DEBE-HABER) 
		from #TbGa 
			INNER JOIN conInfDefCuentas ON
				conInfDefCuentas.Informe_Id = conInfDefFilas.Informe_Id and 
				conInfDefCuentas.Fila = conInfDefFilas.Fila and 
				#TbGa.Cuenta_Id Between conInfDefCuentas.CuentaDesde and conInfDefCuentas.CuentaHasta and 
				#TbGa.Centro1_Id  Between conInfDefFilas.Centro1Desde and conInfDefFilas.Centro1Hasta and 
				#TbGa.Centro2_Id  Between conInfDefFilas.Centro2Desde and conInfDefFilas.Centro2Hasta 
			WHERE
				#TbGa.Ejercicio = @EjeAnt and 
				#TbGa.Periodo <= @MesAnt ),0) as AcuAnt
from conInfDefinibles 
	INNER JOIN conInfDefFilas ON conInfDefFilas.Informe_Id = conInfDefinibles.conInfDefinibles
WHERE
	conInfDefinibles.Informe_Id = @Informe_Id 
	order by 1


SELECT conInfDefinibles.Descripcion, 
case when @PeriodoHasta = 13 then 'Audit '+str(@Ejercicio,4) else
	(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = @PeriodoHasta)  end as Periodo,
		case when @MesAnt= 13 then 'Audit '+str(@EjeAnt,4) else
	(SELECT LEFT(DateName(MONTH,Fecha_Desde),3)+' '+
		Substring(DateName(Year, Fecha_Desde),3,2) 
		FROM conPeriodos where
		conPeriodos.Ejercicio = @EjeAnt and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = @MesAnt)  end as PeriodoAnt,
		(SELECT Fecha_Hasta FROM conPeriodos where
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and
		conPeriodos.Periodo = @PeriodoHasta) FechaHasta, 
		conInfDefinibles.Informe_Id, @Ejercicio as Ejercicio, @PeriodoHasta as PeriodoHasta, 
		
		@Centro1Desde as Centro1Desde, @Centro1Hasta as Centro1Hasta, 
		@Centro2Desde as Centro2Desde, @Centro2Hasta as Centro2Hasta
	from conInfDefinibles 
where Informe_Id= @Informe_Id
GO
	
GO



