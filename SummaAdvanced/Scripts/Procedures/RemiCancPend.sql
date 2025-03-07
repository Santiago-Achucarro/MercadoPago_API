drop procedure stkRemiCancPend
go
create procedure stkRemiCancPend
@pFechaHasta datetime
as
set nocount on
select @pFechaHasta as FechaHasta
select stkRemiPendFact.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N) as SegmentoSTR, conAsientos.Fecha,
sum(stkMoviCuerpo.CostoUnitario*stkRemiPendFact.CantidadPendiente) as Monto,convert(bit,0) as Marca
from stkRemiPendFact 
inner join stkRemitos on stkRemitos.stkMoviCabe=stkRemiPendFact.stkMoviCabe
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=stkRemiPendFact.stkMoviCabe
inner join stkMoviCuerpo on stkMoviCuerpo.stkMoviCabe=stkRemiPendFact.stkMoviCabe and stkMoviCuerpo.Renglon= stkRemiPendFact.Renglon
inner join conAsientos on conAsientos.conAsientos=stkRemiPendFact.stkMoviCabe
where conAsientos.Fecha<=@pFechaHasta and stkRemiPendFact.CantidadPendiente>0
group by stkRemiPendFact.stkMoviCabe, genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N, conAsientos.Fecha
go
drop procedure stkEliminaRemiPendGuardar
go
create procedure stkEliminaRemiPendGuardar
@pstkMoviCabe bigint,
@pUsuario_Id int
as
set nocount on
insert into stkEliminaRemiPend
(stkMoviCabe, Usuario_Id, Fecha)
values (@pstkMoviCabe,@pUsuario_Id,getdate())
go
