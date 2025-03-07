drop PROCEDURE sueCierrePendientes
go
create PROCEDURE sueCierrePendientes
(
@pUltimoCierre DATETIME,
@pProximoCierre DATETIME,
@pEmpresa_Id int
)
as
select @pUltimoCierre as UltimoCierre, @pProximoCierre as ProximoCierre, @pEmpresa_Id as Empresa_Id
select sueLiquidacion.sueLiquidacion, conAsientos.Fecha, conAsientos.Posteado, conAsientos.Anulado,
dbo.Segmento(genSegmentos.genSegmentos,genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Segmento
from sueLiquidacion 
inner join conAsientos on conAsientos.conAsientos=sueLiquidacion.sueLiquidacion 
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=conAsientos.conAsientos
inner join genSegmentos on genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id
where conAsientos.Posteado=0 and conAsientos.Fecha BETWEEN @pUltimoCierre and @pProximoCierre and conAsientos.Empresa_Id=@pEmpresa_Id and not conAsientos.Anulado=1
go

drop Procedure sueCierreDatos
go
create Procedure sueCierreDatos
(
    @pEmpresa_Id int
)
as
SELECT FechaCierreSueldos as UltimoCierre, 
conPeriodos.Fecha_Hasta as ProximoCierre
FROM genEmpresas 
INNER JOIN conPeriodos on
genEmpresas.genEmpresas = conPeriodos.Empresa_Id and 
DATEADD(dd,1,FechaCierreSueldos) between conPeriodos.Fecha_Desde And conPeriodos.Fecha_Hasta
Where
	genEmpresas.genEmpresas = @pEmpresa_Id
    go
