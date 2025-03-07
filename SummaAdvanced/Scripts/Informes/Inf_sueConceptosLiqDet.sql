-- Inf_sueConceptosLiqDet 'SLIQ',2020,6,0,0,' ',' ',' ',' ',0,9999,' ','ZZZ',0,100,1

DROP PROCEDURE Inf_sueConceptosLiqDet
GO
CREATE PROCEDURE Inf_sueConceptosLiqDet
(
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(25),
	@Segmento2C VarChar(25),
	@Segmento3C VarChar(25),
	@Segmento4C VarChar(25),
	@LegajoDesde Int,
	@LegajoHasta Int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@ConceptoDesde int,
	@ConceptoHasta int,
	@Empresa_Id Int
)

as

SELECT 
		dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) AS Nomina,
		sueLiquidacion.Descripcion AS DescripcionN, 
		sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConc, 
		suePersonal.Legajo, suePersonal.ApellidoPaterno +','+suePersonal.ApellidoMaterno+','+
			suePersonal.Nombres as Nombre,
		SUM(sueTerminada.Dato) as Cantidad,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo >0 then
			sueTerminada.Importe * sueTerminada.Signo else 0 end ) as Percepciones,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo <0 then
			-sueTerminada.Importe * sueTerminada.Signo else 0 end ) as Deducciones,
		SUM(Case when sueTerminada.Signo =0 then
			sueTerminada.Importe else 0 end ) as Aportes,
			genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSuc 
		From sueLiquidacion INNER JOIN sueTerminada ON
			sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
			INNER JOIN conAsientos ON 
				conAsientos.conAsientos = sueLiquidacion.sueLiquidacion 
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
			INNER JOIN genSegmentos ON
			genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id 
			inner join sueConceptos ON
			sueConceptos.sueConceptos = sueTerminada.Concepto_Id
			inner join suePersonal ON
			suePersonal.genEntidades = sueTerminada.Legajo
			Inner join suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
			Where
				conAsientos.Anulado = 0 and
				suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
				genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
				sueConceptos.Concepto_Id between @ConceptoDesde and @ConceptoHasta and
				genSegmentos.Segmento_Id = @Segmento_Id and 
				genAsiSegmentos.Segmento1N = case when @Segmento1N=0 then genAsiSegmentos.Segmento1N else @Segmento1N end and
				genAsiSegmentos.Segmento2N = case when @Segmento2N=0 then genAsiSegmentos.Segmento2N else @Segmento2N end and
				genAsiSegmentos.Segmento3N = case when @Segmento3N=0 then genAsiSegmentos.Segmento3N else @Segmento3N end and
				genAsiSegmentos.Segmento4N = case when @Segmento4N=0 then genAsiSegmentos.Segmento4N else @Segmento4N end and 
				genAsiSegmentos.Segmento1C = @Segmento1C and
				genAsiSegmentos.Segmento2C = @Segmento2C and
				genAsiSegmentos.Segmento3C = @Segmento3C and
				genAsiSegmentos.Segmento4C = @Segmento4C and
				genAsiSegmentos.Empresa_Id = @Empresa_Id
		GROUP BY genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion , 
				sueConceptos.Concepto_Id, sueConceptos.Descripcion , sueLiquidacion.sueLiquidacion, 
				sueLiquidacion.FechaFinal, genSucursalesEmpr.genSucursalesEmpr, 
				suePersonal.Legajo, suePersonal.ApellidoPaterno +','+suePersonal.ApellidoMaterno+','+
				suePersonal.Nombres ,
				genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N, sueLiquidacion.Descripcion 
				
		ORDER BY 1,3,5
