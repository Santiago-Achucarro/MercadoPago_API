drop procedure inf_venSegSTR
go
create procedure inf_venSegSTR
(
@pFechaHasta datetime
)
as
select genSegmentos.Segmento_Id, genSegmentos.Descripcion, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
MAX(genAsiSegmentos.Segmento1N) , genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N ) as SegmentoSTR
from genAsiSegmentos inner join venMovimientos on genAsiSegmentos.Asiento_Id=venMovimientos.venMovimientos
inner join genSegmentos on genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id
inner join conAsientos on conAsientos.conAsientos=genAsiSegmentos.Asiento_Id
where conAsientos.Fecha<@pFechaHasta
group by genSegmentos.Segmento_Id, genSegmentos.Descripcion, genAsiSegmentos.Segmento_Id,  genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C
order by 1
go