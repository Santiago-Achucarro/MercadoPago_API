drop procedure inf_tesIdentifica
go
create procedure inf_tesIdentifica
(
@CarteraDesde varchar(5),
@CarteraHasta varchar(5),
@FechaDesde datetime,
@FechaHasta datetime,
@Empresa_Id int,
@MonedaOrig bit
)
as
set nocount on
select @FechaDesde-1 as Fecha, 'Saldo Inicial' as SegmentoSTR, tesIdentifica.Cartera_Id,
tesIdentifica.Descripcion as DescripcionCartera, 0 as conRenglon,0 as Debe,0 as Haber,
sum(case when @MonedaOrig=1 then conMovCont.ImporteMonedaOriginal else conMovCont.Importe end*(-2*conMovCont.TipoMov+3)) as Saldo,'' as Cuenta, ''as DescripcionCuenta,
''as Centro1, '' as Centro2,'' as Destinatario,'' as Usuario from tesRengMovi
inner join conMovCont on conMovCont.conAsientos=tesRengMovi.tesMovimientos 
AND conMovCont.Renglon=tesRengMovi.conRenglon
inner join tesIdentifica on tesRengMovi.Cartera_Id=tesIdentifica.tesIdentifica
inner join conAsientos on conAsientos.conAsientos=conMovCont.conAsientos
where tesIdentifica.Cartera_Id between @CarteraDesde and @CarteraHasta and 
conAsientos.Fecha<@FechaDesde and conAsientos.Empresa_Id=@Empresa_Id and conAsientos.Anulado=0
group by tesIdentifica.Cartera_Id, tesIdentifica.Descripcion
union all
select conAsientos.Fecha,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
genAsiSegmentos.Segmento4C,genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N) AS SegmentoSTR,
tesIdentifica.Cartera_Id,tesIdentifica.Descripcion, tesRengMovi.conRenglon,
case when conMovCont.TipoMov=1 then (case when @MonedaOrig=1 then conMovCont.ImporteMonedaOriginal else conMovCont.Importe end) else 0 end as Debe,
case when conMovCont.TipoMov=2 then (case when @MonedaOrig=1 then conMovCont.ImporteMonedaOriginal else conMovCont.Importe end) else 0 end as Haber,
(case when @MonedaOrig=1 then conMovCont.ImporteMonedaOriginal else conMovCont.Importe end)*(-2*conMovCont.TipoMov+3) as Saldo, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, conCentro1.Centro1_Id,conCentro2.Centro2_Id,
isnull(ISNULL(comProveedores.RazonSocial,venClientes.RazonSocial),conAsientos.Observaciones) as Destinatario,
genUsuarios.Usuario_Id
from tesMovimientos
RIGHT join tesRengMovi on tesRengMovi.tesMovimientos=tesMovimientos.tesMovimientos
inner join conAsientos on conAsientos=tesMovimientos.tesMovimientos
inner join tesIdentifica on tesIdentifica.tesIdentifica=tesRengMovi.Cartera_Id
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=conAsientos.conAsientos
inner join conMovCont on conMovCont.conAsientos=conAsientos.conAsientos and conMovCont.Renglon=tesRengMovi.conRenglon
inner join conCuentas on conCuentas.conCuentas=conMovCont.Cuenta_Id
left join conCentro1 on conCentro1.conCentro1=conMovCont.Centro1_Id
left join conCentro2 on conCentro2.conCentro2=conMovCont.Centro2_Id
left join (comMovProv inner join comProveedores on comMovProv.Proveed_Id=comProveedores.genEntidades) on comMovProv.comMovProv=conAsientos.conAsientos
left join (venMovimientos inner join venClientes on venMovimientos.Cliente_Id= venClientes.genEntidades) on venMovimientos.venMovimientos=conAsientos.conAsientos
left join genUsuarios on genUsuarios.genUsuarios=conAsientos.conAsientos


where (conAsientos.Fecha between @FechaDesde and @FechaHasta) and
(tesIdentifica.Cartera_Id between @CarteraDesde and @CarteraHasta) and
conAsientos.Empresa_Id=@Empresa_Id and
conAsientos.Anulado=0
order by 3,1
go
