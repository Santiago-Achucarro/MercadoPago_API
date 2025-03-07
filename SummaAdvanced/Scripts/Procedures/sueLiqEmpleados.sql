-- sueLiqEmpleados 'SLIQ',2020,1,1,1,' ',' ',' ',' ',1, 1,1,' ','ZZZ',1
DROP Procedure sueLiqEmpleados
GO
CREATE Procedure sueLiqEmpleados
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
@TipoLiq char(1)
)
AS

SELECT sueLiquidacion.sueLiquidacion, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	sueGrupos.Grupo_Id, sueGrupos.Descripcion as DescripcionGrupos,
	sueLiquidacion.Descripcion, sueLiquidacion.FechaPago, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, 
	sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal,
	sueLiquidacion.Periodo_Id, suePeriodicidad.Descripcion as DescripcionPeriodicidad, 
	sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Decena,
	sueLiquidacion.Vez, 
	@LegajoDesde LegajoDesde , @LegajoHasta LegajoHasta, 
	@SucursalDesde SucursalDesde, @SucursalHasta SucursalHasta , @TipoLiq  as TipoLiq 
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


SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno, suePersonal.FechaIngreso
from sueLiquidacion inner join sueGrupos ON
sueLiquidacion.Grupo_Id = sueGrupos.sueGrupos
INNER JOIN sueCategorias ON
sueCategorias.Periodo_Id = sueGrupos.Periodo_Id
INNER JOIN suePersCatego ON
	suePersCatego.Categoria_Id = sueCategorias.sueCategorias and 
	sueLiquidacion.FechaFinal BETWEEN suePersCatego.FechaDesde and suePersCatego.FechaHasta
INNER JOIN suePersonal ON
suePersonal.genEntidades =	suePersCatego.Legajo
INNER JOIN suePersSucursal on 
suePersSucursal.Legajo = suePersonal.genEntidades  and 
sueLiquidacion.FechaFinal BETWEEN suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr ON 
genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = sueLiquidacion.sueLiquidacion 
inner join genSegmentos on genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
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
	suePersonal.Empresa_Id = @pEmpresa_Id and 
	suePersonal.Inactivo = 0 and 
	suePersonal.Posteado = 1 and
	suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	((@TipoLiq= 'N' and  suePersonal.FechaIngreso <= sueLiquidacion.FechaFinal and 
		( suePersonal.FechaBaja Is null or  suePersonal.FechaBaja > sueLiquidacion.FechaFinal)) or
		(@TipoLiq= 'F' and suePersonal.FechaBaja between sueLiquidacion.FechaInicial and sueLiquidacion.FechaFinal))
order by 1
GO

-- sueLiqEmpleadosEliminarDatos 'SLIQ',2021,9,36,1,' ',' ',' ',' ',4, 3002,3002,' ','ZZZ','N'
DROP Procedure sueLiqEmpleadosEliminarDatos
GO
CREATE Procedure sueLiqEmpleadosEliminarDatos
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
@TipoLiq CHAR(1)
)
AS

SELECT sueLiquidacion.sueLiquidacion, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	sueGrupos.Grupo_Id, sueGrupos.Descripcion as DescripcionGrupos,
	sueLiquidacion.Descripcion, sueLiquidacion.FechaPago, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, 
	sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal,
	sueLiquidacion.Periodo_Id, suePeriodicidad.Descripcion as DescripcionPeriodicidad, 
	sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Decena,
	sueLiquidacion.Vez, 
	@LegajoDesde LegajoDesde , @LegajoHasta LegajoHasta, 
	@SucursalDesde SucursalDesde, @SucursalHasta SucursalHasta , @TipoLiq  as TipoLiq 
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

SELECT DISTINCT suePersonal.Legajo, suePersonal.ApellidoPaterno, suePersonal.FechaIngreso 
FROM sueLiquidacion
INNER JOIN sueTerminada ON sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
INNER JOIN suePersonal ON sueTerminada.Legajo = suePersonal.genEntidades
INNER JOIN suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades  and 
	sueLiquidacion.FechaFinal BETWEEN suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = sueLiquidacion.sueLiquidacion 
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE genSegmentos.Segmento_Id=@pSegmento_Id and
	genAsiSegmentos.Segmento1N=@pSegmento1N and 
	genAsiSegmentos.Segmento1C=@pSegmento1C and
	genAsiSegmentos.Segmento2N=@pSegmento2N and 
	genAsiSegmentos.Segmento2C=@pSegmento2C and
	genAsiSegmentos.Segmento3N=@pSegmento3N and 
	genAsiSegmentos.Segmento3C=@pSegmento3C and
	genAsiSegmentos.Segmento4N= @pSegmento4N and 
	genAsiSegmentos.Segmento4C= @pSegmento4C and
	genAsiSegmentos.Empresa_Id=@pEmpresa_Id and 
	suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta 
ORDER BY 1
GO

/*SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno, suePersonal.FechaIngreso
from sueLiquidacion inner join sueGrupos ON
sueLiquidacion.Grupo_Id = sueGrupos.sueGrupos
INNER JOIN sueCategorias ON
sueCategorias.Periodo_Id = sueGrupos.Periodo_Id
INNER JOIN suePersCatego ON
	suePersCatego.Categoria_Id = sueCategorias.sueCategorias and 
	sueLiquidacion.FechaFinal BETWEEN suePersCatego.FechaDesde and suePersCatego.FechaHasta
INNER JOIN suePersonal ON
suePersonal.genEntidades =	suePersCatego.Legajo
INNER JOIN suePersSucursal on 
suePersSucursal.Legajo = suePersonal.genEntidades  and 
sueLiquidacion.FechaFinal BETWEEN suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr ON 
genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = sueLiquidacion.sueLiquidacion 
inner join genSegmentos on genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Where
	Exists(select 1 from sueTerminada where
		sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion and 
		sueTerminada.Legajo = suePersonal.genEntidades) and 
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
	suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta 
order by 1
GO*/






