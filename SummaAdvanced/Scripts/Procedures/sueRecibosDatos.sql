-- sueRecibosDatos 'SLIQ',2019,9,1,1,' ',' ',' ',' ',1,1
DROP PROCEDURE sueRecibosDatos
GO
CREATE PROCEDURE sueRecibosDatos
(
	@pSegmento_Id VarChar(10),
	@pSegmento1N INT, 
	@pSegmento2N INT, 
	@pSegmento3N INT, 
	@pSegmento4N INT, 
	@pSegmento1C VarChar(25), 
	@pSegmento2C VarChar(25), 
	@pSegmento3C VarChar(25), 
	@pSegmento4C VarChar(25), 
	@Legajo Int ,
	@Empresa_Id Int

)

as

select genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
sueLiquidacion.Descripcion as DescripcionNomina , sueLiquidacion.Anio, sueLiquidacion.Mes, 
sueLiquidacion.Decena, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Vez,
sueGrupos.Grupo_Id, sueGrupos.Descripcion as DescripcionGrupo, 
sueLiquidacion.FechaPago, 
suePersonal.Legajo, suePersonal.ApellidoPaterno +','+ suePersonal.ApellidoMaterno +','+ suePersonal.Nombres as Nombre, 
suePersonal.FechaIngreso, ISNULL(SDI.Valor,0) AS SDI, 
ISNULL(SD.VALOR,0) AS SD, DateDiff(dd, sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal)+1 as DiasPagados, 
SUM(sueTerminada.Importe* sueTerminada.Signo) as Neto
from sueLiquidacion INNER JOIN conAsientos on 
sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
inner join sueTerminada ON sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id  = conAsientos.conAsientos
inner join genSegmentos ON 
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
inner join suePersonal ON 
suePersonal.genEntidades = sueTerminada.legajo
inner join sueGrupos on sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
LEFT JOIN sueLiqPersImportes SDI ON 
	SDI.Legajo = suePersonal.genEntidades and 
	SDI.Importe_Id = 2 and 
	sueLiquidacion.FechaFinal Between SDI.Fecha_Desde AND SDI.Fecha_Hasta
LEFT JOIN sueLiqPersImportes SD ON 
	SD.Legajo = suePersonal.genEntidades and 
	SD.Importe_Id = 1 and 
	sueLiquidacion.FechaFinal Between SD.Fecha_Desde AND SD.Fecha_Hasta

Where
	conAsientos.Anulado = 0 and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N AND
	genAsiSegmentos.Segmento2N = @pSegmento2N AND
	genAsiSegmentos.Segmento3N = @pSegmento3N AND
	genAsiSegmentos.Segmento4N = @pSegmento4N AND
	genAsiSegmentos.Segmento1C = @pSegmento1C AND
	genAsiSegmentos.Segmento2C = @pSegmento2C AND
	genAsiSegmentos.Segmento3C = @pSegmento3C AND
	genAsiSegmentos.Segmento4C = @pSegmento4C AND
	genAsiSegmentos.Empresa_Id = @Empresa_Id  and 
	suePersonal.Legajo =  @Legajo 
GROUP BY sueLiquidacion.Descripcion , sueLiquidacion.Anio, sueLiquidacion.Mes, 
sueLiquidacion.Decena, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Vez,
sueLiquidacion.FechaPago,  suePersonal.Legajo, suePersonal.ApellidoPaterno , suePersonal.ApellidoMaterno , suePersonal.Nombres , 
suePersonal.FechaIngreso, SDI.Valor,SD.VALOR,sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal, 	
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
sueGrupos.Grupo_Id, sueGrupos.Descripcion 




SELECT 	sueConceptos.Concepto_Id, 	sueConceptos.Descripcion, 
		sueTerminada.Dato, sueTerminada.Dato2,
		Case when sueTerminada.IMPORTE*sueTerminada.SIGNO > 0 then sueTerminada.IMPORTE*sueTerminada.SIGNO else 0 end as Percepciones,
		Case when sueTerminada.IMPORTE*sueTerminada.SIGNO < 0 then -sueTerminada.IMPORTE*sueTerminada.SIGNO else 0 end as Deducciones
from sueLiquidacion INNER JOIN conAsientos on 
sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id  = conAsientos.conAsientos
inner join genSegmentos ON 
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN sueTerminada ON
sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion 
inner join suePersonal ON 
suePersonal.genEntidades = sueTerminada.Legajo 
inner join sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
Where
	conAsientos.Anulado = 0 and 
	sueTerminada.Signo != 0 and
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N AND
	genAsiSegmentos.Segmento2N = @pSegmento2N AND
	genAsiSegmentos.Segmento3N = @pSegmento3N AND
	genAsiSegmentos.Segmento4N = @pSegmento4N AND
	genAsiSegmentos.Segmento1C = @pSegmento1C AND
	genAsiSegmentos.Segmento2C = @pSegmento2C AND
	genAsiSegmentos.Segmento3C = @pSegmento3C AND
	genAsiSegmentos.Segmento4C = @pSegmento4C AND
	genAsiSegmentos.Empresa_Id = @Empresa_Id AND
	suePersonal.Legajo  =@Legajo
Order By sueConceptos.Concepto_Id
go

	