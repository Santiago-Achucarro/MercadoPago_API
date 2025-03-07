
-- inf_venMovimientosXSubTipoMov 'FCSTK','FCSTK', '20200401','20200430',0
-- inf_venMovimientosXSubTipoMov 'FCSTK','FCSTK', '20200401','20200430',1
drop procedure inf_venMovimientosXSubTipoMov
go
create procedure inf_venMovimientosXSubTipoMov
(
@venSubTipoMovDesde varchar(5),
@venSubTipoMovHasta varchar(5),
@FechaDesde datetime,
@FechaHasta datetime,
@Detallado sino,
@Empresa_Id Int
)
as
if @Detallado=1
begin
--Detallado
select dbo.Segmento(Segmento_Id,Segmento1C,Segmento2C,Segmento3C,Segmento4C,Segmento1N,Segmento2N,Segmento3N,Segmento4N) as SegmentoSTR ,
venClientes.Cliente_Id, venClientes.RazonSocial as RazonSocialCliente, conAsientos.Fecha, venSubTipoMov.SubTipoMov_Id,
venSubTipoMov.Descripcion as DescripcionSubTipoMov, venMovimientos.Importe * conAsientos.Cambio Importe
From venMovimientos
inner join conAsientos on venMovimientos=conAsientos 
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=venMovimientos
inner join venSubTipoMov on venMovimientos.venSubTipoMov_Id= venSubTipoMov.venSubTipoMov
inner join venClientes on venMovimientos.Cliente_Id= venClientes.genEntidades
inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
where 
SubTipoMov_Id between @venSubTipoMovDesde and @venSubTipoMovHasta and 
conAsientos.Fecha between @FechaDesde and @FechaHasta and 
conAsientos.Anulado = 0 and 
conAsientos.Posteado=1 and 
conAsientos.Empresa_Id = @Empresa_Id
end
else
begin
--Resumen
select 
venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov, sum(Importe*venTipoMov.Signo * conAsientos.Cambio) as Importe
from venMovimientos
inner join venSubTipoMov on venMovimientos.venSubTipoMov_Id= venSubTipoMov.venSubTipoMov
inner join conAsientos on venMovimientos=conAsientos 
inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
where 
SubTipoMov_Id between @venSubTipoMovDesde and @venSubTipoMovHasta and 
conAsientos.Fecha between @FechaDesde and @FechaHasta and 
conAsientos.Anulado = 0 and 
conAsientos.Posteado=1 and
conAsientos.Empresa_Id = @Empresa_Id
group by venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion 
end
go