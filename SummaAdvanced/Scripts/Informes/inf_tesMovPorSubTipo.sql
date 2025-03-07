drop Procedure Inf_tesMovporSubTipo
go
Create Procedure Inf_tesMovporSubTipo
(
@FechaDesde DateTime,
@FechaHasta DATETIME,
@SubTipoDesde varchar(3),
@SubTipoHasta varchar(3),
@Empresa_Id int
)

as
SELECT tesSubTiposmov.SubTipo_Id, tesSubTiposmov.Descripcion as DescripcionSubTipo,
conAsientos.Fecha, ISNULL(venClientes.RazonSocial,'') RazonSocial,
conAsientos.conAsientos ,dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as segmentostr ,tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera,
case when tesRengMovi.TipomovCont=1 then conMovCont.Importe else 0 end as Debe,
case when tesRengMovi.TipomovCont=2 then conMovCont.Importe else 0 end as Haber,
case when tesRengMovi.TipomovCont=1 then ImporteMonedaOriginal else 0 end as DebeMonedaOriginal,
case when tesRengMovi.TipomovCont=2 then ImporteMonedaOriginal else 0 end as HaberMonedaOriginal,
conCuentas.Cuenta_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id, conasientos.observaciones
from conAsientos INNER JOIN genAsiSegmentos ON
conAsientos.conAsientos =genAsiSegmentos.Asiento_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN tesRengMovi ON
tesRengMovi.tesMovimientos = conMovCont.conASientos and
tesRengMovi.conRenglon = conMovCont.Renglon
INNER JOIN tesIdentifica ON
tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovcont.Cuenta_Id
left JOIN conCentro1 ON
conCentro1.conCentro1 = conMovcont.Centro1_Id
left JOIN conCentro2 ON
conCentro2.conCentro2 = conMovcont.Centro2_Id
inner join tesMovimientos on tesMovimientos.tesMovimientos = conAsientos.conasientos
inner join tesSubTiposmov on tesSubTiposmov.tesSubTiposmov = tesMovimientos.SubTipo_Id
LEFT JOIN (venMovimientos INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades) ON
venMovimientos.venMovimientos = conAsientos.conAsientos
where
conAsientos.Anulado = 0 and
conAsientos.Empresa_Id = @Empresa_id and
conAsientos.Fecha between @FechaDesde and @FechaHasta and
tesSubTiposMov.SubTipo_Id BETWEEN @SubTipoDesde and @SubTipoHasta
order by 1, 3, 4
