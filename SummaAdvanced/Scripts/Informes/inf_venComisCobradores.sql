drop procedure inf_venComisCobradores
go
create procedure inf_venComisCobradores
(
    @CobradorDesde varchar(5),
    @CobradorHasta varchar(5),
    @FechaDesde datetime,
    @FechaHasta datetime,
    @Empresa_Id int
)
as
select venCobradores.Cobrador_Id, dbo.Segmento(Segmento_Id, Segmento1C, Segmento2C, Segmento3C, Segmento4C, Segmento1N, Segmento2N, Segmento3N, Segmento4N) as Asiento,
Fecha, venMovimientos.Importe as Total, round(Importe*venCobradores.Comision/100,2) as Comision, venCobradores.Comision as Porcentaje from venMovimientos
inner join conAsientos on conAsientos.conAsientos=venMovimientos.venMovimientos
inner join venCobradores on venMovimientos.Cobrador_Id=venCobradores.venCobradores
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=conAsientos.conAsientos
inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
inner join venSubTipoMov on venMovimientos.venSubTipoMov_Id=venSubTipoMov.venSubTipoMov
where venMovimientos.venTipoMov = 'C' and 
venSubTipoMov.AfectaComVenta=1 and
venCobradores.Cobrador_Id between @CobradorDesde and @CobradorHasta and
conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and conAsientos.Empresa_Id=@Empresa_Id and conAsientos.Posteado=1 and conAsientos.Anulado=0
go
