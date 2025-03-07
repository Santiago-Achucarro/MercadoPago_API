-- Inf_sueAcumAnual 2020,1,999999, 1,1,1,0
DROP PROCEDURE Inf_sueAcumAnual
GO
-- Inf_sueAcumAnual 2020,0,9999999,1,1,1,0
CREATE PROCEDURE Inf_sueAcumAnual
(
	@Anio Int, 
	@LegajoDesde Int, 
	@LegajoHasta Int,
	@Empresa_Id Int, 
	@Percepciones Bit,
	@Deducciones Bit,
	@Aportes Bit
)
AS


SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno +','+ suePersonal.ApellidoMaterno+',' + 
	suePersonal.Nombres as ApellidoNombre,  ISNULL(convert(varchar,suePersonal.FechaBaja,103),'') FechaBaja, 
	CASE sueConceptos.Signo When 1 THEN '1 Percepciones'  
	WHEN -1 THEN '2 Deducciones'  
	ELSE 'Aportes'  end as Tipo, sueConceptos.Signo,
	sueConceptos.Concepto_Id, sueConceptos.Descripcion , 
	SUM(CASE WHEN sueLiquidacion.mes = 1 then sueTerminada.Importe else 0 end) as Ene, 
	SUM(CASE WHEN sueLiquidacion.mes = 2 then sueTerminada.Importe else 0 end) as Feb,
	SUM(CASE WHEN sueLiquidacion.mes = 3 then sueTerminada.Importe else 0 end) as Mar,
	SUM(CASE WHEN sueLiquidacion.mes = 4 then sueTerminada.Importe else 0 end) as Abr,
	SUM(CASE WHEN sueLiquidacion.mes = 5 then sueTerminada.Importe else 0 end) as May,
	SUM(CASE WHEN sueLiquidacion.mes = 6 then sueTerminada.Importe else 0 end) as Jun,
	SUM(CASE WHEN sueLiquidacion.mes = 7 then sueTerminada.Importe else 0 end) as Jul,
	SUM(CASE WHEN sueLiquidacion.mes = 8 then sueTerminada.Importe else 0 end) as Ago,
	SUM(CASE WHEN sueLiquidacion.mes = 9 then sueTerminada.Importe else 0 end) as Sep,
	SUM(CASE WHEN sueLiquidacion.mes = 10 then sueTerminada.Importe else 0 end) as Oct,
	SUM(CASE WHEN sueLiquidacion.mes = 11 then sueTerminada.Importe else 0 end) as Nov,
	SUM(CASE WHEN sueLiquidacion.mes = 12 then sueTerminada.Importe else 0 end) as Dic,
	SUM(sueTerminada.Importe) as Total

from suePersonal 
INNER JOIN sueTerminada ON sueTerminada.Legajo = suePersonal.genEntidades 
INNER JOIN sueLiquidacion ON sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
INNER JOIN conAsientos ON  conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
INNER JOIN sueConceptos ON  sueConceptos.sueConceptos = sueTerminada.Concepto_Id
WHERE
	sueLiquidacion.Anio = @Anio and 
	suePersonal.Legajo  Between @LegajoDesde AND @LegajoHasta AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	((@Percepciones= 1 AND sueConceptos.Signo = 1) or
	(@Deducciones= 1 AND sueConceptos.Signo = -1) or
	(@Aportes= 1 AND sueConceptos.Signo = 0))
GROUP BY suePersonal.Legajo, suePersonal.ApellidoPaterno , suePersonal.ApellidoMaterno,
	suePersonal.Nombres ,  	sueConceptos.Signo , sueConceptos.Concepto_Id, 
	sueConceptos.Descripcion, suePersonal.FechaBaja
ORDER BY 1,5 desc,6
