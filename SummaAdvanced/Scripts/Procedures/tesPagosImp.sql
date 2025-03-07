-- tesPagosImpDatos 1, 'TES',0,0,0,0,'E','0001',' ',' ','IMPLQ',2,0,0,0,'0001',' ',' ',' '

DROP PROCEDURE tesPagosImpDatos
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE tesPagosImpDatos
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
	@SegmentoIMP_Id VarChar(10),
	@SegmentoIMP1N Int,
	@SegmentoIMP2N Int,
	@SegmentoIMP3N Int,
	@SegmentoIMP4N Int,
	@SegmentoIMP1C VarChar(20),
	@SegmentoIMP2C VarChar(20),
	@SegmentoIMP3C VarChar(20),
	@SegmentoIMP4C VarChar(20)

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
		impImpuestos.Impuesto_Id, impImpuestos.Descripcion,
		impLiquidacion.TotalaPagar, 
		impLiquidacion.FechaDesde, impLiquidacion.FechaHasta, impLiquidacion.FechaPago, 
		conAsientos.conAsientos
	FROM impLiquidacion inner join conAsientos ON 
	impLiquidacion.conAsientos = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN impImpuestos ON impImpuestos.impImpuestos = impLiquidacion.Impuesto_Id
	WHERE
		impLiquidacion.tesMovimientos is NULL AND 
		impLiquidacion.SePaga = 1 AND
		impLiquidacion.TotalaPagar > 0 AND 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		genSegmentos.Segmento_Id = @SegmentoIMP_Id and  
		genAsiSegmentos.Segmento1C =@SegmentoIMP1C AND
		genAsiSegmentos.Segmento2C = @SegmentoIMP2C AND
		genAsiSegmentos.Segmento3C = @SegmentoIMP3C AND 
		genAsiSegmentos.Segmento4C = @SegmentoIMP4C AND
		genAsiSegmentos.Segmento1N = @SegmentoIMP1N AND 
		genAsiSegmentos.Segmento2N = @SegmentoIMP2N AND 
		genAsiSegmentos.Segmento3N = @SegmentoIMP3N AND 
		genAsiSegmentos.Segmento4N= @SegmentoIMP4N  AND
		genAsiSegmentos.Empresa_Id = @Empresa_Id


end

else
Begin

	SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
		impImpuestos.Impuesto_Id, impImpuestos.Descripcion,
		impLiquidacion.TotalaPagar, 
		impLiquidacion.FechaDesde, impLiquidacion.FechaHasta, impLiquidacion.FechaPago, 
		conAsientos.conAsientos, 0 as Grupo_Id, 0 as Anio, 0 as Mes, 0 as Quincena, 
		0 as Decena, 0 as Semana, 0 as Vez
	FROM impLiquidacion inner join conAsientos ON 
	impLiquidacion.conAsientos = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN impImpuestos ON impImpuestos.impImpuestos = impLiquidacion.Impuesto_Id
	WHERE
		impLiquidacion.tesMovimientos = @ptesMovimientos
		


end







GO


