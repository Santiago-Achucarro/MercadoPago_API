--select * from sueTerminada



drop procedure sueInfDefiniblesImpresionDatos
go
create procedure sueInfDefiniblesImpresionDatos
(
    @pInforme_Id varchar(15)
)
as

DECLARE @Fecha DATETIME
SET @Fecha= (SELECT GETDATE())

Select Informe_Id, Descripcion as DescripcionInforme, '' as Segmento_Id, 0 as Segmento1N, 0 as Segmento2N, 0 as Segmento3N, 0 as Segmento4N, 
'' as Segmento1C, '' as Segmento2C, '' as Segmento3C, '' as Segmento4C, LegajoDesde, LegajoHasta, SucursalDesde, SucursalHasta, 
ConvenioDesde, ConvenioHasta, Centro1Desde, Centro1Hasta, Centro2Desde, Centro2Hasta,  0 AS Grupo_Id, ' ' as DescripcionGrupo,
0 as Anio, 0 as Mes, 0 as Quincena, 0 Semana, 0 Decena, 0 Vez, 'S' as GenerarBy, @Fecha as FechaDesde, @Fecha as FechaHasta
From sueInfDefinibles
Where Informe_Id = @pInforme_Id
go

-- sueInfDefEmpleadosDatos 2022,1,1,1,1,1,'A','20000101','20220228',0,999999,' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',1

DROP PROCEDURE sueInfDefEmpleadosDatos
GO

CREATE PROCEDURE sueInfDefEmpleadosDatos
(
	@Anio int,
	@Mes int,
	@Quincena int,
	@Vez int,
	@Semana int,
	@Decena int,
	@GeneraBy char(1),
	@FechaDesde datetime,
	@FechaHasta datetime,
	@LegajoDesde Int,
	@LegajoHasta Int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@ConvenioDesde VarChar(5),
	@ConvenioHasta VarChar(5),
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@Empresa_Id Int
)
AS

If @GeneraBy = 'L'
Begin
	SELECT DISTINCT suePersonal.Legajo, suePersonal.Nombres, suePersonal.ApellidoPaterno, 
		suePersonal.ApellidoMaterno
	From sueLiquidacion
	Inner Join conAsientos ON sueLiquidacion.sueLiquidacion = conAsientos.conAsientos 
	Inner Join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	Inner Join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	Inner Join sueTerminada ON sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion
	Inner Join suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
	Inner Join suePersConvenio ON suePersonal.genEntidades = suePersConvenio.Legajo and 
		sueLiquidacion.FechaFinal between suePersConvenio.FechaDesde and suePersConvenio.FechaHasta
	Inner Join sueConvenio ON sueConvenio.sueConvenio = suePersConvenio.Convenio_id
	Inner Join suePersSucursal ON suePersonal.genEntidades = suePersSucursal.Legajo and 
		sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
	Inner Join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	Where
				--genSegmentos.Segmento_Id = @Segmento_Id and 
				--genAsiSegmentos.Segmento1N = @Segmento1N AND 
				--genAsiSegmentos.Segmento2N = @Segmento2N AND 
				--genAsiSegmentos.Segmento3N = @Segmento3N AND 
				--genAsiSegmentos.Segmento4N = @Segmento4N AND 
				--genAsiSegmentos.Segmento1C = @Segmento1C AND 
				--genAsiSegmentos.Segmento2C = @Segmento2C AND 
				--genAsiSegmentos.Segmento3C = @Segmento3C AND 
				--genAsiSegmentos.Segmento4C = @Segmento4C AND
		sueLiquidacion.Anio = @Anio And
		(sueLiquidacion.Mes = @Mes Or @Mes = 0) And
		(sueLiquidacion.Quincena = @Quincena Or @Quincena = 0) And
		(sueLiquidacion.Vez = @Vez Or @Vez = 0) And
		(sueLiquidacion.Semana = @Semana Or @Semana = 0) And
		(sueLiquidacion.Decena = @Decena Or @Decena = 0) And
		genAsiSegmentos.Empresa_Id = @Empresa_Id and 
		suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
		sueConvenio.Convenio_id Between @ConvenioDesde and @ConvenioHasta  AND 
		genSucursalesEmpr.Sucursal Between @SucursalDesde and @SucursalHasta  and 
		Exists(SELECT 1 from suePersContable ,suePersContableDatos, conCentro1, conCentro2 Where
				suePersContable.Legajo = suePersonal.genEntidades and 
				sueLiquidacion.FechaFinal Between suePersContable.FechaDesde and suePersContable.FechaHasta and
				suePersContableDatos.Legajo = suePersContable.Legajo AND 
				suePersContableDatos.FechaDesde = suePersContable.FechaDesde and 
				conCentro1.conCentro1 = suePersContableDatos.Centro1_Id and 
				conCentro2.conCentro2 = suePersContableDatos.Centro2_Id and 
				conCentro1.Centro1_Id BETWEEN @Centro1Desde And @Centro1Hasta and
				conCentro2.Centro2_Id BETWEEN @Centro2Desde And @Centro2Hasta )
	ORDER BY 1
End

If @GeneraBy = 'A'
Begin
	SELECT DISTINCT suePersonal.Legajo, suePersonal.Nombres, suePersonal.ApellidoPaterno, 
		suePersonal.ApellidoMaterno
	From suePersonal
	INNER JOIN suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades And 
			@FechaHasta BETWEEN suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
	INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	Inner join suePersTipoPago On suePersTipoPago.Legajo=suePersonal.genEntidades And
			@FechaHasta BETWEEN suePersTipoPago.FechaDesde And suePersTipoPago.FechaHasta
	Inner join sueTipoPago On suePersTipoPago.TipoPago_Id = sueTipoPago.sueTipoPago
	Where
		suePersonal.Legajo Between @LegajoDesde And @LegajoHasta AND 
		suePersonal.FechaIngreso Between @FechaDesde And @FechaHasta AND 
		ISNULL(suePersonal.Empresa_Id, @Empresa_Id) = @Empresa_Id AND
		genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta 
		

	ORDER BY 1
End

If @GeneraBy = 'B'
Begin
	SELECT DISTINCT suePersonal.Legajo, suePersonal.Nombres, suePersonal.ApellidoPaterno, 
		suePersonal.ApellidoMaterno
	From suePersonal
	INNER JOIN suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades And 
			@FechaHasta BETWEEN suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
	INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	Inner join suePersTipoPago On suePersTipoPago.Legajo=suePersonal.genEntidades And
			@FechaHasta BETWEEN suePersTipoPago.FechaDesde And suePersTipoPago.FechaHasta
	Inner join sueTipoPago On suePersTipoPago.TipoPago_Id = sueTipoPago.sueTipoPago
	Where
		suePersonal.Legajo Between @LegajoDesde And @LegajoHasta AND 
		suePersonal.FechaBaja Between @FechaDesde And @FechaHasta AND 
		ISNULL(suePersonal.Empresa_Id, @Empresa_Id) = @Empresa_Id and 
		genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta 
	
	ORDER BY 1
End
GO

