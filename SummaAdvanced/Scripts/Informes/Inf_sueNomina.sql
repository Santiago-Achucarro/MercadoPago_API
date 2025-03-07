--select * from sueLiquidacion

-- Inf_sueNomina 'SLIQ',2022,1,2,8,' ',' ',' ',' ',1,0,9999,' ','ZZZ',' ','ZZZ',' ','ZZ',0

-- select * from sueTerminada where sueLiquidacion = 461064

DROP PROCEDURE Inf_sueNomina
GO
CREATE PROCEDURE Inf_sueNomina
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
	@Empresa_Id Int,
	@LegajoDesde Int,
	@LegajoHasta Int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4), 
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@pConAportes Bit 
)

as

SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) AS Nomina,
		sueLiquidacion.Descripcion AS DescripcionN, 
		suePersonal.Legajo, suePersonal.ApellidoPaterno +','+suePersonal.ApellidoMaterno+','+
			suePersonal.Nombres as Nombre,
		sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConc, 
		sueTerminada.Dato as Cantidad,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo >0 then
			sueTerminada.Importe * sueTerminada.Signo*suePersContableDatos.Porcentaje/100 else 0 end  ) as Percepciones,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo <0 then
			-sueTerminada.Importe * sueTerminada.Signo*suePersContableDatos.Porcentaje/100 else 0 end ) as Deducciones,
		SUM(Case when sueTerminada.Signo =0 then
			sueTerminada.Importe*suePersContableDatos.Porcentaje/100 else 0 end ) as Aportes,
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
			INNER JOIN suePersContable ON
					suePersContable.Legajo = suePersonal.genEntidades AND 
					sueLiquidacion.FechaFinal between suePersContable.FechaDesde and  suePersContable.FechaHasta
			INNER JOIN suePersContableDatos ON  suePersContableDatos.Legajo = suePersContable.Legajo AND
					suePersContableDatos.FechaDesde =suePersContable.FechaDesde 
			LEFT JOIN  conCentro1 ON  conCentro1.conCentro1 = suePersContableDatos.Centro1_Id
			LEFT JOIN  conCentro2 ON  conCentro2.conCentro2 = suePersContableDatos.Centro2_Id
			Where
			conAsientos.Anulado = 0 and 
				suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
				genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
				genSegmentos.Segmento_Id = @Segmento_Id and 
				genAsiSegmentos.Segmento1N = @Segmento1N and
				genAsiSegmentos.Segmento2N = @Segmento2N and
				genAsiSegmentos.Segmento3N = @Segmento3N and
				genAsiSegmentos.Segmento4N = @Segmento4N and
				genAsiSegmentos.Segmento1C = @Segmento1C and
				genAsiSegmentos.Segmento2C = @Segmento2C and
				genAsiSegmentos.Segmento3C = @Segmento3C and
				genAsiSegmentos.Segmento4C = @Segmento4C and
				genAsiSegmentos.Empresa_Id = @Empresa_Id and 
				(sueterminada.Signo != 0 or @pConAportes=1) and 
				isNull(conCentro1.Centro1_Id,'') BETWEEN @Centro1Desde AND @Centro1Hasta AND 
				isNull(conCentro2.Centro2_Id,'') BETWEEN @Centro2Desde AND @Centro2Hasta 
GROUP BY genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N,
		sueLiquidacion.Descripcion , 
		suePersonal.Legajo, suePersonal.ApellidoPaterno , suePersonal.ApellidoMaterno ,
			suePersonal.Nombres , sueConceptos.Concepto_Id, sueConceptos.Descripcion ,sueTerminada.Dato , 
			genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion
		ORDER BY 3,5
GO
