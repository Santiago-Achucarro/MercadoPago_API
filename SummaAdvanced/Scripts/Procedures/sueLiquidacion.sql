
DROP PROCEDURE sueLiquidacionGuardar
GO
CREATE PROCEDURE sueLiquidacionGuardar
(
@psueLiquidacion Bigint,
@pGrupo_Id int,
@pDescripcion varchar(100),
@pFechaPago qFecha =null,
@pFechaDeposito qFecha = NULL,
@pPeriodoDeposito varchar(20) = NULL,
@pCtaSueldosAPagar varchar(25),
@pFechaInicial qFecha = NULL,
@pFechaFinal qFecha = NULL,
@pPeriodo_Id char(1) = NULL,
@pPorEmpleado Sino,
@pAnio int,
@pMes int,
@pQuincena int,
@pSemana int,
@pDecena int,
@pVez int,
@pFechaContabilizacion qFecha=null
)
AS
SET NOCOUNT ON 

IF (EXISTS (SELECT 1 FROM sueLiquidacion WHERE sueLiquidacion.sueLiquidacion=@psueLiquidacion))
BEGIN 
	UPDATE sueLiquidacion
	SET	
		Grupo_Id = dbo.FuncFKsueGrupos(@pGrupo_Id),
		Descripcion = @pDescripcion,
		FechaPago = @pFechaPago,
		FechaDeposito = @pFechaDeposito,
		PeriodoDeposito = @pPeriodoDeposito,
		CtaSueldosAPagar = dbo.FuncFKconCuentas(@pCtaSueldosAPagar),
		FechaInicial = @pFechaInicial,
		FechaFinal = @pFechaFinal,
		Periodo_Id = @pPeriodo_Id,
		PorEmpleado = @pPorEmpleado,
		Anio = @pAnio,
		Mes = @pMes,
		Quincena = @pQuincena,
		Semana = @pSemana,
		Decena = @pDecena,
		Vez = @pVez,
		FechaContabilizacion = @pFechaContabilizacion
	WHERE 
	sueLiquidacion=@psueLiquidacion
END 
ELSE 
BEGIN 
	INSERT INTO sueLiquidacion
	(
		sueLiquidacion,
		Grupo_Id,
		Descripcion,
		FechaPago,
		FechaDeposito,
		PeriodoDeposito,
		CtaSueldosAPagar,
		FechaInicial,
		FechaFinal,
		Periodo_Id,
		PorEmpleado,
		Anio,
		Mes,
		Quincena,
		Semana,
		Decena,
		Vez,
		FechaContabilizacion
	)
	VALUES 
	(
		@psueLiquidacion,
		dbo.FuncFKsueGrupos(@pGrupo_Id),
		@pDescripcion,
		@pFechaPago,
		@pFechaDeposito,
		@pPeriodoDeposito,
		dbo.FuncFKconCuentas(@pCtaSueldosAPagar),
		@pFechaInicial,
		@pFechaFinal,
		@pPeriodo_Id,
		@pPorEmpleado,
		@pAnio,
		@pMes,
		@pQuincena,
		@pSemana,
		@pDecena,
		@pVez,
		@pFechaContabilizacion
	)
	
END 
Select @psueLiquidacion as RetVal 

GO

DROP PROCEDURE sueLiquidacionDatos
GO
CREATE PROCEDURE sueLiquidacionDatos
(
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pFechaDesde DateTime = null,
@pFechaHasta DateTime = null,
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
declare @sueLiquidacion bigint 
SET @sueLiquidacion = (select Asiento_Id 
	from  genAsiSegmentos
	where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento1C=@pSegmento1C and
Segmento2N=@pSegmento2N and Segmento2C=@pSegmento2C and
Segmento3N=@pSegmento3N and Segmento3C=@pSegmento3C and
Segmento4N= @pSegmento4N and Segmento4C= @pSegmento4C and
Empresa_Id=@pEmpresa_Id
)
SELECT sueLiquidacion.sueLiquidacion, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	sueGrupos.Grupo_Id, sueGrupos.Descripcion as DescripcionGrupos,
	sueLiquidacion.Descripcion, sueLiquidacion.FechaPago, sueLiquidacion.FechaDeposito, sueLiquidacion.PeriodoDeposito,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal,
	sueLiquidacion.Periodo_Id, suePeriodicidad.Descripcion as DescripcionPeriodicidad, sueLiquidacion.PorEmpleado, sueLiquidacion.Anio,
	sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Decena,
	sueLiquidacion.Vez, sueLiquidacion.FechaContabilizacion, ' ' SegundoPlano, 
	@pFechaDesde FechaDesde, @pFechaHasta FechaHasta
FROM sueLiquidacion 
inner join genAsiSegmentos ON 
sueLiquidacion.sueLiquidacion =  genAsiSegmentos.Asiento_Id
inner join genSegmentos ON  genSegmentos.genSegmentos =  genAsiSegmentos.Segmento_Id
LEFT JOIN conAsientos  ON (conAsientos.conAsientos = sueLiquidacion.sueLiquidacion)
INNER JOIN sueGrupos  ON (sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id)
INNER JOIN conCuentas  ON (conCuentas.conCuentas = sueLiquidacion.CtaSueldosAPagar)
LEFT JOIN suePeriodicidad  ON (suePeriodicidad.Periodo_Id = sueLiquidacion.Periodo_Id)
WHERE  
genSegmentos.Segmento_Id=@pSegmento_Id and
genAsiSegmentos.Segmento1N=@pSegmento1N and 
genAsiSegmentos.Segmento1C=@pSegmento1C and
genAsiSegmentos.Segmento2N=@pSegmento2N and 
genAsiSegmentos.Segmento2C=@pSegmento2C and
genAsiSegmentos.Segmento3N=@pSegmento3N and 
genAsiSegmentos.Segmento3C=@pSegmento3C and
genAsiSegmentos.Segmento4N= @pSegmento4N and 
genAsiSegmentos.Segmento4C= @pSegmento4C and
genAsiSegmentos.Empresa_Id=@pEmpresa_Id

  
 Exec genAtributosGeneralesIdentityDatos @sueLiquidacion, 'sueLiquidacion'
 RETURN @@Error 

GO

DROP PROCEDURE sueLiquidacionEliminar
GO
CREATE PROCEDURE sueLiquidacionEliminar
(
@psueLiquidacion bigint
)
AS
SET NOCOUNT ON 

DELETE FROM sueLiquidacion 
WHERE  sueLiquidacion=@psueLiquidacion
 RETURN @@Error 

GO


-- sueLiquidacionGenerarDatos 'NQ',0,0,0,0,' ',' ',' ',' ',1
DROP PROCEDURE sueLiquidacionGenerarDatos
GO
CREATE PROCEDURE sueLiquidacionGenerarDatos
(
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int,
@LegajoDesde Int, 
@LegajoHasta Int, 
@SucursalDesde VarChar(4),
@SucursalHasta VarChar(4),
@TipoLiq char(1),
@pPeriodo_Id char(1) = Null,
@pFechaDesde DateTime,
@pFechaHasta DateTime,
@pCentro1Desde varchar(8),
@pCentro1Hasta varchar(8),
@pConvenioDesde varchar(5),
@pConvenioHasta varchar(5),
@pTipoPagoDesde varchar(5),
@pTipoPagoHasta varchar(5)
)
AS
SET NOCOUNT ON 
declare @sueLiquidacion bigint 
SET @sueLiquidacion = (select Asiento_Id
	from  genAsiSegmentos
	where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento1C=@pSegmento1C and
Segmento2N=@pSegmento2N and Segmento2C=@pSegmento2C and
Segmento3N=@pSegmento3N and Segmento3C=@pSegmento3C and
Segmento4N= @pSegmento4N and Segmento4C= @pSegmento4C and
Empresa_Id=@pEmpresa_Id
)
SELECT sueLiquidacion.sueLiquidacion, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	sueGrupos.Grupo_Id, sueGrupos.Descripcion as DescripcionGrupos,
	sueLiquidacion.Descripcion, sueLiquidacion.FechaPago, sueLiquidacion.FechaDeposito, sueLiquidacion.PeriodoDeposito,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal, Cast(1 as bit) TodosLosPeriodos,
	sueLiquidacion.Periodo_Id, suePeriodicidad.Descripcion as DescripcionPeriodicidad, sueLiquidacion.PorEmpleado, sueLiquidacion.Anio,
	sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Decena,
	sueLiquidacion.Vez, sueLiquidacion.FechaContabilizacion, 
	@LegajoDesde LegajoDesde , @LegajoHasta LegajoHasta, 
	@SucursalDesde SucursalDesde, @SucursalHasta  SucursalHasta , @TipoLiq as TipoLiq, 
	0 as RegistroActual, ' ' Mensaje, ' ' Condicion,(cast( 1 as bit)) as DescargarWS,
	sueLiquidacion.FechaInicial FechaDesde, sueLiquidacion.FechaFinal FechaHasta,
	@pCentro1Desde Centro1Desde, @pCentro1Hasta Centro1Hasta, @pConvenioDesde ConvenioDesde, @pConvenioHasta ConvenioHasta,
	@pTipoPagoDesde TipoPagoDesde, @pTipoPagoHasta TipoPagoHasta
FROM sueLiquidacion 
Inner join genAsiSegmentos ON sueLiquidacion.sueLiquidacion =  genAsiSegmentos.Asiento_Id
Inner join genSegmentos ON  genSegmentos.genSegmentos =  genAsiSegmentos.Segmento_Id
LEFT JOIN conAsientos ON (conAsientos.conAsientos = sueLiquidacion.sueLiquidacion)
INNER JOIN sueGrupos ON (sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id)
INNER JOIN conCuentas ON (conCuentas.conCuentas = sueLiquidacion.CtaSueldosAPagar)
LEFT JOIN suePeriodicidad ON (suePeriodicidad.Periodo_Id = sueLiquidacion.Periodo_Id)
WHERE  
genSegmentos.Segmento_Id=@pSegmento_Id and
genAsiSegmentos.Segmento1N=@pSegmento1N and 
genAsiSegmentos.Segmento1C=@pSegmento1C and
genAsiSegmentos.Segmento2N=@pSegmento2N and 
genAsiSegmentos.Segmento2C=@pSegmento2C and
genAsiSegmentos.Segmento3N=@pSegmento3N and 
genAsiSegmentos.Segmento3C=@pSegmento3C and
genAsiSegmentos.Segmento4N= @pSegmento4N and 
genAsiSegmentos.Segmento4C= @pSegmento4C and
genAsiSegmentos.Empresa_Id=@pEmpresa_Id

  
Exec genAtributosGeneralesIdentityDatos @sueLiquidacion, 'sueLiquidacion'


SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno+
	case when suePersonal.ApellidoMaterno =' ' then '' else	
		',' +suePersonal.ApellidoMaterno end +
		' ,'+ suePersonal.Nombres as ApellidoPaterno
, suePersonal.FechaIngreso
From sueLiquidacion 
Inner join sueGrupos ON sueLiquidacion.Grupo_Id = sueGrupos.sueGrupos
INNER JOIN sueCategorias ON sueCategorias.Periodo_Id = IsNull(@pPeriodo_Id, sueCategorias.Periodo_Id)
INNER JOIN suePersCatego ON suePersCatego.Categoria_Id = sueCategorias.sueCategorias and 
	sueLiquidacion.FechaFinal BETWEEN suePersCatego.FechaDesde and suePersCatego.FechaHasta
INNER JOIN suePersonal ON suePersonal.genEntidades = suePersCatego.Legajo
INNER JOIN suePersSucursal on suePersSucursal.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal BETWEEN suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = sueLiquidacion.sueLiquidacion 
Inner join genSegmentos on genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join (suePersConvenio Inner Join sueConvenio On sueConvenio.sueConvenio = suePersConvenio.Convenio_Id) On suePersConvenio.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal BETWEEN suePersConvenio.FechaDesde and suePersConvenio.FechaHasta
Inner Join (suePersTipoPago Inner Join sueTipoPago On sueTipoPago.sueTipoPago = suePersTipoPago.TipoPago_Id) On suePersTipoPago.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal BETWEEN suePersTipoPago.FechaDesde and suePersConvenio.FechaHasta
Where
	genSegmentos.Segmento_Id=@pSegmento_Id and
	genAsiSegmentos.Segmento1N=@pSegmento1N and 
	genAsiSegmentos.Segmento1C=@pSegmento1C and
	genAsiSegmentos.Segmento2N=@pSegmento2N and 
	genAsiSegmentos.Segmento2C=@pSegmento2C and
	genAsiSegmentos.Segmento3N=@pSegmento3N and 
	genAsiSegmentos.Segmento3C=@pSegmento3C and
	genAsiSegmentos.Segmento4N= @pSegmento4N and 
	genAsiSegmentos.Segmento4C= @pSegmento4C and
	genAsiSegmentos.Empresa_Id=@pEmpresa_Id and 
	suePersonal.Empresa_Id=@pEmpresa_Id and
	suePersonal.Inactivo = 0 and 
	suePersonal.Posteado = 1 and
	suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	((@TipoLiq = 'N' and  suePersonal.FechaIngreso <= sueLiquidacion.FechaFinal and 
		( suePersonal.FechaBaja Is null or  suePersonal.FechaBaja > sueLiquidacion.FechaFinal)) or
		(@TipoLiq = 'F' and suePersonal.FechaBaja between @pFechaDesde and @pFechaHasta) or
		@TipoLiq = 'V' and EXISTS(SELECT 1 FROM sueVacTomadas WHERE sueVacTomadas.Legajo = suePersonal.genEntidades AND
			sueVacTomadas.FechaDesde BETWEEN @pFechaDesde and @pFechaHasta)) And
	sueConvenio.Convenio_Id Between @pConvenioDesde And @pConvenioHasta And
	sueTipoPago.TipoPago_Id Between @pTipoPagoDesde And @pTipoPagoHasta And
	suePersonal.genEntidades In (Select suePersContable.Legajo From suePersContable 
		Inner Join suePersContableDatos On suePersContableDatos.Legajo = suePersContable.Legajo And suePersContableDatos.FechaDesde = suePersContable.FechaDesde
		Inner Join conCentro1 On conCentro1.conCentro1 = suePersContableDatos.Centro1_Id
		Where suePersContable.Legajo = suePersonal.genEntidades And sueLiquidacion.FechaFinal Between suePersContable.FechaDesde And suePersContable.FechaHasta And
		conCentro1.Centro1_Id Between @pCentro1Desde And @pCentro1Hasta)
ORDER BY 1


 RETURN @@Error 

GO



DROP PROCEDURE sueLiquidacionNeto
GO
CREATE PROCEDURE sueLiquidacionNeto
(
	@pSueLiquidacion bigint
)
AS

SELECT SUM(sueTerminada.Importe*sueTerminada.Signo) as Monto
From sueTerminada 
Where
	sueTerminada.sueLiquidacion = @pSueLiquidacion
GO

DROP PROCEDURE sueLiquidacionMarcaPorEmple
GO

CREATE PROCEDURE sueLiquidacionMarcaPorEmple
(
	@pSueLiquidacion BigInt, 
	@pPorEmpleado Bit
)
as

Update sueLiquidacion SET PorEmpleado = @pPorEmpleado 
	Where sueLiquidacion = @pSueLiquidacion
GO




DROP PROCEDURE sueLiquidacionIntDatos
GO
CREATE PROCEDURE sueLiquidacionIntDatos
(
	@sueLiquidacion bigint 
)
AS

DECLARE @pSegmento_Id varchar(10)
DECLARE @pSegmento1N int
DECLARE  @pSegmento2N int
DECLARE @pSegmento3N int
DECLARE @pSegmento4N int
DECLARE @pSegmento1C varchar(20)
DECLARE @pSegmento2C varchar(20)
DECLARE @pSegmento3C varchar(20)
DECLARE @pSegmento4C varchar(20)
DECLARE  @pEmpresa_Id int

SELECT @pSegmento_Id = genSegmentos.Segmento_Id,
	@pSegmento1N = genAsiSegmentos.Segmento1N,
	@pSegmento2N = genAsiSegmentos.Segmento2N,
	@pSegmento3N = genAsiSegmentos.Segmento3N,
	@pSegmento4N = genAsiSegmentos.Segmento4N,
	@pSegmento1C = genAsiSegmentos.Segmento1C,
	@pSegmento2C = genAsiSegmentos.Segmento2C,
	@pSegmento3C = genAsiSegmentos.Segmento3C,
	@pSegmento4C = genAsiSegmentos.Segmento4C,
	@pEmpresa_Id = genAsiSegmentos.Empresa_Id
FROM genAsiSegmentos inner join genSegmentos ON
genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
INNER JOIN sueLiquidacion ON
sueLiquidacion.sueLiquidacion = genAsiSegmentos.Asiento_Id
where
sueLiquidacion.sueLiquidacion  = @sueLiquidacion

exec sueLiquidacionDatos @pSegmento_Id, @pSegmento1N,@pSegmento2N,@pSegmento3N,@pSegmento4N,
	@pSegmento1C,@pSegmento2C,@pSegmento3C,@pSegmento4C,NULL, NULL, @pEmpresa_Id

GO

