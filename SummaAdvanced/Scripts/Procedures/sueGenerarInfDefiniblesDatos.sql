drop procedure sueGenerarInfDefiniblesDatos
go
create procedure sueGenerarInfDefiniblesDatos
(
@pInforme_Id varchar(15),
@pSegmento_Id varchar(5),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
select Informe_Id,Descripcion, LegajoDesde,LegajoHasta,SucursalDesde,SucursalHasta,Centro1Desde,Centro1Hasta,Centro2Desde,Centro2Hasta,
ConvenioDesde,ConvenioHasta,Um,AgrupadoPor,TamanioHoja,AgrupadoPor,Horizontal,AnchoNombre,Empresa_Id,Inactivo,'' as NombreArchivo from sueInfDefinibles
WHERE (Informe_Id = @pInforme_Id)

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
	sueLiquidacion.Descripcion,
	 sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal,
	sueLiquidacion.Periodo_Id, suePeriodicidad.Descripcion as DescripcionPeriodicidad, sueLiquidacion.PorEmpleado, sueLiquidacion.Anio,
	sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Decena,
	sueLiquidacion.Vez
FROM sueLiquidacion 
inner join genAsiSegmentos ON 
sueLiquidacion.sueLiquidacion =  genAsiSegmentos.Asiento_Id
inner join genSegmentos ON  genSegmentos.genSegmentos =  genAsiSegmentos.Segmento_Id
LEFT JOIN conAsientos  ON (conAsientos.conAsientos = sueLiquidacion.sueLiquidacion)
INNER JOIN sueGrupos  ON (sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id)
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

 RETURN @@Error 