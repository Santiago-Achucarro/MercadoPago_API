
--sueArchivoTxtObtenerEmple 1,9999,'S','20190101','20211031', 1230,' ','zzz', 1,'','5'
--sueArchivoTxtObtenerEmple 1,9999,'A','20190101','20191031', 10626, 1
--sueArchivoTxtObtenerEmple 1,9999,'B','20190101','20191031', 10626, 1



DROP PROCEDURE sueArchivoTxtObtenerEmple
GO
CREATE PROCEDURE sueArchivoTxtObtenerEmple

(
	@LegajoDesde int, 
	@LegajaHasta Int,
	@Tipo Char(1),
	@FechaDesde DateTime,
	@FechaHasta DateTime, 
	@Anio int,
	@Mes int,
	@Quincena int,
	@Vez int,
	@Semana int,
	@Decena int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@TipoPagoDesde Varchar(5),
	@TipoPagoHasta Varchar(5),
	@Empresa Int
	
)
as

if @Tipo = 'S'
BEGIN
	Select distinct suePersonal.Legajo 
	From suePersonal
	Inner join sueTerminada ON sueTerminada.Legajo = suePersonal.genEntidades 
	Inner join sueLiquidacion ON sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion 
	INNER JOIN conAsientos ON conAsientos.conAsientos =sueLiquidacion.sueLiquidacion 
	Inner join suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades And 
			sueLiquidacion.FechaFinal BETWEEN suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
	INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	Inner join suePersTipoPago On suePersTipoPago.Legajo=suePersonal.genEntidades And
			sueLiquidacion.FechaFinal BETWEEN suePersTipoPago.FechaDesde And suePersTipoPago.FechaHasta
	Inner join sueTipoPago On suePersTipoPago.TipoPago_Id= sueTipoPago.sueTipoPago
	Where
	conAsientos.Anulado = 0 And 
	--conAsientos.Posteado = 1 AND no pongo el posteado porque se pone recien al habilitar el pago
	--sueLiquidacion.sueLiquidacion = @sueLiquidacion and 
	sueLiquidacion.Anio = @Anio And
	(sueLiquidacion.Mes = @Mes Or @Mes = 0) And
	(sueLiquidacion.Quincena = @Quincena Or @Quincena = 0) And
	(sueLiquidacion.Vez = @Vez Or @Vez = 0) And
	(sueLiquidacion.Semana = @Semana Or @Semana = 0) And
	(sueLiquidacion.Decena = @Decena Or @Decena = 0) And
	suePersonal.Legajo Between @LegajoDesde And @LegajaHasta And 
	conAsientos.Empresa_Id = @Empresa And 
	genSucursalesEmpr.Sucursal BETWEEN @SucursalDesde And @SucursalHasta And
	sueTipoPago.TipoPago_Id BETWEEN @TipoPagoDesde And @TipoPagoHasta

	ORDER BY 1
END

if @Tipo = 'A'
BEGIN
	Select suePersonal.Legajo 
	From suePersonal 
	INNER JOIN suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades And 
			@FechaHasta BETWEEN suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
	INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	Inner join suePersTipoPago On suePersTipoPago.Legajo=suePersonal.Legajo And
			@FechaHasta BETWEEN suePersTipoPago.FechaDesde And suePersTipoPago.FechaHasta
	Inner join sueTipoPago On suePersTipoPago.TipoPago_Id = sueTipoPago.sueTipoPago
	WHERE
	suePersonal.Legajo Between @LegajoDesde And @LegajaHasta AND 
	suePersonal.FechaIngreso Between @FechaDesde And @FechaHasta AND 
	ISNULL(suePersonal.Empresa_Id, @Empresa) = @Empresa And 
	genSucursalesEmpr.Sucursal BETWEEN @SucursalDesde And @SucursalHasta And
	sueTipoPago.TipoPago_Id BETWEEN @TipoPagoDesde And @TipoPagoHasta
	ORDER BY 1
END

if @Tipo = 'B'
BEGIN
	Select suePersonal.Legajo 
	From suePersonal
	INNER JOIN suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades And 
			@FechaHasta BETWEEN suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
	INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	Inner join suePersTipoPago on suePersTipoPago.Legajo=suePersonal.Legajo and
			@FechaHasta BETWEEN suePersTipoPago.FechaDesde and suePersTipoPago.FechaHasta
	Inner join sueTipoPago on suePersTipoPago.TipoPago_Id= sueTipoPago.sueTipoPago
	WHERE
	suePersonal.Legajo  Between @LegajoDesde And @LegajaHasta And 
	suePersonal.FechaBaja Between @FechaDesde And @FechaHasta And 
	ISNULL(suePersonal.Empresa_id, @Empresa)  = @Empresa And 
	genSucursalesEmpr.Sucursal BETWEEN @SucursalDesde And @SucursalHasta And
	sueTipoPago.TipoPago_Id BETWEEN @TipoPagoDesde And @TipoPagoHasta
	ORDER BY 1
END

GO
