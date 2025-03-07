-- INF_NominaCfdi  0,9999, '20210601','20210630',1


drop PROCEDURE INF_NominaCfdi 
go
CREATE PROCEDURE INF_NominaCfdi 
(
	@LegajoDesde Int, 
	@LegajoHasta Int, 
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@Empresa_Id Int
)
as
SELECT 	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Nomina,
	sueLiquidacion.Descripcion, 
	suePersonal.Legajo as NroEmpleado, suePersonal.ApellidoPaterno +','+
	suePersonal.ApellidoMaterno+','+suePersonal.Nombres Nombre, 
	sueLiquidacion.FechaFinal, sueNominaCfdi.FechaTimbrado, 
	suePersonal.NumeroDoc as Curp,
	SUM(CASE WHEN sueTerminada.Signo = 1 AND SueConceptos.EsExento = 0 THEN sueTerminada.Importe else 0 end) as Sueldo,
	SUM(CASE WHEN sueTerminada.Signo = 1  AND SueConceptos.EsExento = 1 THEN sueTerminada.Importe else 0 end) as SueldoExento,
	SUM(CASE WHEN sueTerminada.Signo = -1 and sueConceptos.TipoDeduccion = '002'  then sueTerminada.Importe else 0 end) as ISPT,
	SUM(CASE WHEN sueTerminada.Signo = -1 and sueConceptos.TipoDeduccion = '001'  then sueTerminada.Importe else 0 end) as IMMS,
	SUM(CASE WHEN sueTerminada.Signo = -1 and sueConceptos.TipoDeduccion NOT IN('001','002')   then sueTerminada.Importe else 0 end) as OTROS, 
	sueNominaCfdi.UUID
from suePersonal inner join sueNominaCfdi ON
	suePersonal.genEntidades= sueNominaCfdi.Legajo
	INNER JOIN sueLiquidacion ON
	sueLiquidacion.sueLiquidacion = sueNominaCfdi.sueLiquidacion 
	INNER JOIN sueterminada ON 
	sueterminada.sueLiquidacion = sueNominaCfdi.sueLiquidacion AND 
	sueterminada.legajo = sueNominaCfdi.Legajo
	INNER JOIN sueConceptos ON
	sueConceptos.sueConceptos = sueterminada.concepto_id
	INNER JOIN conAsientos ON  conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
	INNER JOIN genAsiSegmentos on genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
	Where
		conAsientos.Anulado = 0 and 
		conAsientos.Empresa_Id = @Empresa_Id and
		sueterminada.Signo != 0 and  
		sueNominaCfdi.Anulada = 0 and 
		suepersonal.Legajo between @LegajoDesde and @LegajoHasta and 
		sueLiquidacion.FechaFinal between @FechaDesde And  @FechaHasta
group by suePersonal.Legajo , suePersonal.ApellidoPaterno , 
	suePersonal.ApellidoMaterno, suePersonal.Nombres,
	sueLiquidacion.FechaFinal, sueNominaCfdi.FechaTimbrado, 
	suePersonal.NumeroDoc , 
	sueNominaCfdi.UUID, sueLiquidacion.Descripcion, sueLiquidacion.Semana, 
	genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N
	order by 1,3

GO	

