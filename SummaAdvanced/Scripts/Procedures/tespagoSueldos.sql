-- tesPagosSueldosDatos 1, 'TES',0,0,0,0,'E','0001',' ',' ','IMPLQ',2,0,0,0,'0001',' ',' ',' '

DROP PROCEDURE tesPagosSueldosDatos
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE tesPagosSueldosDatos
(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20), 
	@Grupo_Id Int,
	@SegmentoSue_Id VarChar(10),
	@SegmentoSue1N Int,
	@SegmentoSue2N Int,
	@SegmentoSue3N Int,
	@SegmentoSue4N Int,
	@SegmentoSue1C VarChar(20),
	@SegmentoSue2C VarChar(20),
	@SegmentoSue3C VarChar(20),
	@SegmentoSue4C VarChar(20)

)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos from 
	tesMovimientos INNER JOIN genAsiSegmentos ON
	tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )


EXECUTE tesMovimientosDatos @ptesMovimientos

Exec tesRengMoviDHDatos @ptesMovimientos, 1, NULL
Exec tesRengMoviDHDatos @ptesMovimientos, 2, NULL

Exec tesRengConciliacDatos @ptesMovimientos, NULL,1
Exec tesRengConciliacDatos @ptesMovimientos, NULL,2

-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos

Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'

IF (@ptesMovimientos IS NULL)
Begin

	SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
		RTRIM(Str(sueGrupos.Grupo_Id,6)) as Impuesto_Id, sueGrupos.Descripcion,
		suePagosHabi.Importe AS TotalaPagar, 
		sueLiquidacion.FechaInicial FechaDesde, sueLiquidacion.FechaFinal FechaHasta, 
		sueLiquidacion.FechaPago AS FechaPago, 
		conAsientos.conAsientos, sueGrupos.Grupo_Id, sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, 
		sueLiquidacion.Decena, sueLiquidacion.Semana, sueLiquidacion.Vez
	FROM sueLiquidacion inner join conAsientos ON 
	sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN sueGrupos ON sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
	INNER JOIN suePagosHabi ON suePagosHabi.sueLiquidacion = sueLiquidacion.sueLiquidacion
	WHERE
		suePagosHabi.tesMovimientos is NULL AND 
		suePagosHabi.Importe > 0 AND 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		genSegmentos.Segmento_Id = @SegmentoSue_Id and  
		genAsiSegmentos.Segmento1C =@SegmentoSue1C AND
		genAsiSegmentos.Segmento2C = @SegmentoSue2C AND
		genAsiSegmentos.Segmento3C = @SegmentoSue3C AND 
		genAsiSegmentos.Segmento4C = @SegmentoSue4C AND
		genAsiSegmentos.Segmento1N = @SegmentoSue1N AND 
		genAsiSegmentos.Segmento2N = @SegmentoSue2N AND 
		genAsiSegmentos.Segmento3N = @SegmentoSue3N AND 
		genAsiSegmentos.Segmento4N= @SegmentoSue4N  AND
		genAsiSegmentos.Empresa_Id = @Empresa_Id
	UNION ALL -- POR EMPLEADO

	SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
		RTRIM(Str(sueGrupos.Grupo_Id,6)) as Impuesto_Id, sueGrupos.Descripcion,
		sum(suePagosHabiPorEmpleado.Importe) AS TotalaPagar, 
		sueLiquidacion.FechaInicial FechaDesde, sueLiquidacion.FechaFinal FechaHasta, 
		sueLiquidacion.FechaPago AS FechaPago, 
		conAsientos.conAsientos, sueGrupos.Grupo_Id, sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, 
		sueLiquidacion.Decena, sueLiquidacion.Semana, sueLiquidacion.Vez
	FROM sueLiquidacion inner join conAsientos ON 
	sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN sueGrupos ON sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
	INNER JOIN suePagosHabiPorEmpleado ON suePagosHabiPorEmpleado.sueLiquidacion = sueLiquidacion.sueLiquidacion
	WHERE
		suePagosHabiPorEmpleado.tesMovimientos is NULL AND 
		suePagosHabiPorEmpleado.Importe > 0 AND 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		genSegmentos.Segmento_Id = @SegmentoSue_Id and  
		genAsiSegmentos.Segmento1C =@SegmentoSue1C AND
		genAsiSegmentos.Segmento2C = @SegmentoSue2C AND
		genAsiSegmentos.Segmento3C = @SegmentoSue3C AND 
		genAsiSegmentos.Segmento4C = @SegmentoSue4C AND
		genAsiSegmentos.Segmento1N = @SegmentoSue1N AND 
		genAsiSegmentos.Segmento2N = @SegmentoSue2N AND 
		genAsiSegmentos.Segmento3N = @SegmentoSue3N AND 
		genAsiSegmentos.Segmento4N= @SegmentoSue4N  AND
		genAsiSegmentos.Empresa_Id = @Empresa_Id
GROUP BY genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
		sueGrupos.Grupo_Id, sueGrupos.Descripcion,
		sueLiquidacion.FechaInicial , sueLiquidacion.FechaFinal , 
		sueLiquidacion.FechaPago , 
		conAsientos.conAsientos, sueGrupos.Grupo_Id, sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, 
		sueLiquidacion.Decena, sueLiquidacion.Semana, sueLiquidacion.Vez

end

else
Begin

	SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
		' ' as Impuesto_Id, sueGrupos.Descripcion,
		suePagosHabi.Importe AS TotalaPagar, 
		sueLiquidacion.FechaInicial FechaDesde, sueLiquidacion.FechaFinal FechaHasta, 
		sueLiquidacion.FechaPago AS FechaPago, 
		conAsientos.conAsientos, sueGrupos.Grupo_Id, sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, 
		sueLiquidacion.Decena, sueLiquidacion.Semana, sueLiquidacion.Vez
	FROM sueLiquidacion inner join conAsientos ON 
	sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
	INNER JOIN suePagosHabi ON
	suePagosHabi.sueLiquidacion = sueLiquidacion.sueLiquidacion
	INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN sueGrupos ON sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
	WHERE
		suePagosHabi.tesMovimientos = @ptesMovimientos
	UNION ALL -- POR EMPLEADO

	SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
		RTRIM(Str(sueGrupos.Grupo_Id,6)) as Impuesto_Id, sueGrupos.Descripcion,
		SUM(suePagosHabiPorEmpleado.Importe) AS TotalaPagar, 
		sueLiquidacion.FechaInicial FechaDesde, sueLiquidacion.FechaFinal FechaHasta, 
		sueLiquidacion.FechaPago AS FechaPago, 
		conAsientos.conAsientos, sueGrupos.Grupo_Id, sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, 
		sueLiquidacion.Decena, sueLiquidacion.Semana, sueLiquidacion.Vez
	FROM sueLiquidacion inner join conAsientos ON 
	sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
	INNER JOIN suePagosHabiPorEmpleado ON
	suePagosHabiPorEmpleado.sueLiquidacion = sueLiquidacion.sueLiquidacion
	INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN sueGrupos ON sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
	WHERE
		suePagosHabiPorEmpleado.tesMovimientos = @ptesMovimientos
		
	GROUP BY genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
		sueGrupos.Grupo_Id , sueGrupos.Descripcion,
		sueLiquidacion.FechaInicial , sueLiquidacion.FechaFinal , 
		sueLiquidacion.FechaPago , 	conAsientos.conAsientos,
		sueGrupos.Grupo_Id, sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, 
		sueLiquidacion.Decena, sueLiquidacion.Semana, sueLiquidacion.Vez

end
GO




