
-- Inf_sueDetAsiConc '20190901','20190930',0,99999, 0,99999,' ','zzzz',1

DROP PROCEDURE Inf_sueDetAsiConc
GO
CREATE PROCEDURE Inf_sueDetAsiConc

(
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@ConceptoDesde Int, 
	@ConceptoHasta int,
	@LegajoDesde Int,
	@LegajoHasta Int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@Empresa_Id Int
	
)

as


SELECT 	suePersonal.Legajo, suePersonal.ApellidoPaterno +','+suePersonal.ApellidoMaterno+','+
		suePersonal.Nombres as Nombre,
		sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConc, 
		conCuentasDebe.Cuenta_Id CuentaDebe, conCuentasDebe.Descripcion as DescripcionCtaDebe ,
		conCentro1Debe.Centro1_Id Centro1_IdDebe, conCentro2Debe.Centro2_Id Centro2_IdDebe,
		conCuentasHaber.Cuenta_Id CuentaHaber, conCuentasHaber.Descripcion as DescripcionCtaHaber ,
		conCentro1Haber.Centro1_Id Centro1_IdHaber, conCentro2Haber.Centro2_Id Centro2_IdHaber,
		conAsientos.conAsientos, 
		dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) as Nomina,
		CASE WHEN  sueMovContDebe.Importe <=  Abs(sueMovContHaber.Importe) 
		THEN sueMovContDebe.Importe ELSE sueMovContHaber.Importe END 	as Importe 
		From sueLiquidacion INNER JOIN sueMovCont sueMovContDebe ON
			sueLiquidacion.sueLiquidacion = sueMovContDebe.sueLiquidacion and
			sueMovContDebe.Importe > 0 
			INNER JOIN sueMovCont sueMovContHaber ON
			sueMovContHaber.sueLiquidacion = sueMovContDebe.sueLiquidacion and 
			sueMovContHaber.Legajo = sueMovContDebe.Legajo AND 
			sueMovContHaber.Concepto_Id = sueMovContDebe.Concepto_Id AND 
			sueMovContHaber.Importe < 0
			INNER JOIN conAsientos ON 
				conAsientos.conAsientos = sueLiquidacion.sueLiquidacion 
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
			inner join sueConceptos ON
			sueConceptos.sueConceptos = sueMovContDebe.Concepto_Id
			inner join suePersonal ON
			suePersonal.genEntidades = sueMovContDebe.Legajo
			Inner join suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
			inner join conCuentas conCuentasDebe ON conCuentasDebe.conCuentas = sueMovContDebe.Cuenta_Id
			left join conCentro1 conCentro1Debe ON conCentro1Debe.conCentro1 = sueMovContDebe.Centro1_Id
			left join conCentro2 conCentro2Debe ON conCentro2Debe.conCentro2 = sueMovContDebe.Centro2_Id
			inner join conCuentas conCuentasHaber ON conCuentasHaber.conCuentas = sueMovContHaber.Cuenta_Id
			left join conCentro1 conCentro1Haber ON conCentro1Haber.conCentro1 = sueMovContHaber.Centro1_Id
			left join conCentro2 conCentro2Haber ON conCentro2Haber.conCentro2 = sueMovContHaber.Centro2_Id
			Where
				conAsientos.Anulado = 0 and
				sueConceptos.Concepto_Id BETWEEN @ConceptoDesde and @ConceptoHasta and 
				suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
				genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
				genAsiSegmentos.Empresa_Id = @Empresa_Id and 
				conAsientos.Fecha Between @FechaDesde and @FechaHasta
		ORDER BY 1,3,4,6,7
