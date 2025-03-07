
-- Inf_sueSubMayor '20190901','20190930',0,99999,' ','zzzz',1

DROP PROCEDURE Inf_sueSubMayor
GO
CREATE PROCEDURE Inf_sueSubMayor

(
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@LegajoDesde Int,
	@LegajoHasta Int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@Empresa_Id Int
	
)

as

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCta ,
		conCentro1.Centro1_Id, conCentro2.Centro2_Id,
		conAsientos.conAsientos, 
		dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) as Nomina,
		suePersonal.Legajo, suePersonal.ApellidoPaterno +','+suePersonal.ApellidoMaterno+','+
			suePersonal.Nombres as Nombre,
			/* sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConc, */ 
			case when SUM(sueMovCont.Importe) > 0 then SUM(sueMovCont.Importe) else 0 end as Debe,
			case when SUM(sueMovCont.Importe) < 0 then -SUM(sueMovCont.Importe) else 0  end as Haber
		
		From sueLiquidacion INNER JOIN sueMovCont ON
			sueLiquidacion.sueLiquidacion = sueMovCont.sueLiquidacion
			INNER JOIN conAsientos ON 
				conAsientos.conAsientos = sueLiquidacion.sueLiquidacion 
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
			inner join sueConceptos ON
			sueConceptos.sueConceptos = sueMovCont.Concepto_Id
			inner join suePersonal ON
			suePersonal.genEntidades = sueMovCont.Legajo
			Inner join suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
			inner join conCuentas ON conCuentas.conCuentas = sueMovCont.Cuenta_Id
			left join conCentro1 ON conCentro1.conCentro1 = sueMovCont.Centro1_Id
			left join conCentro2 ON conCentro2.conCentro2 = sueMovCont.Centro2_Id
			Where
				conAsientos.Anulado = 0 and
				suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
				genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
				genAsiSegmentos.Empresa_Id = @Empresa_Id and 
				conAsientos.Fecha Between @FechaDesde and @FechaHasta
GROUP BY conAsientos.conAsientos, 
		genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N,
		suePersonal.Legajo, suePersonal.ApellidoPaterno ,suePersonal.ApellidoMaterno,
			suePersonal.Nombres , conCuentas.Cuenta_Id, conCuentas.Descripcion ,
			conCentro1.Centro1_Id, conCentro2.Centro2_Id
		ORDER BY 1,3,4,6,7
