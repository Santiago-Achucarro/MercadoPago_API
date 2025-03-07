--inf_tesRetencion1 296191,2
--inf_tesRetencion1 296450,3

--select * from genasisegmentos where segmento1n = 7349 and segmento2c ='0007'

Drop procedure inf_tesRetencion1
GO
Create procedure inf_tesRetencion1
(
@tesMovimientos bigint,
@conRenglon int
)
As
Select  dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) OP, conAsientos.Fecha,
dbo.Segmento(tesRetProvSegmento.Segmento_Id, tesRetProvSegmento.Segmento1C, tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, tesRetProvSegmento.Segmento4C,
	tesRetProvSegmento.Segmento1N, tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, tesRetProvSegmento.Segmento4N) RetNro,
tesIdRetProv.Concepto, tesIdentifica.Descripcion DescripcionCartera,
comProveedores.Proveed_Id, comProveedores.RazonSocial, comProveedores.Direccion1, comProveedores.Direccion2, comProveedores.Localidad,
comCondFiscal.CondFiscal_Id, comCondFiscal.Descripcion DescripcionCondFiscal, comProveedores.IBrutos, genEntidades.Cuit, comProveedores.Ganancias,
comProveedores.IBrutos,
Stuff((
Select '' + a From (
Select ', ' + dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) a
From comPagosHabilitados
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comPagosHabilitados.comMovProv
Where comPagosHabilitados.tesMovimientos = tesMovimientos.tesMovimientos
Union All
Select ', Anticipo' a From comPagosAnticipo
Where comPagosAnticipo.tesMovimientos = tesMovimientos.tesMovimientos
) b
For xml Path ('')), 1,2,'') Comprobantes,
tesRengMoviRetProv.BaseImponible, tesRengMoviRetProv.Porcentaje, conMovCont.Importe, vComMovprov.Importe Total_Pago,Totalpagos.Total_Pagos_Acum, tesidretprov.Minimo,tesRengMoviRetProv.TRet, tPagos.Total_Gravado,tesrengmovi.Cartera_Id
From tesMovimientos
Inner Join comMovProv On comMovProv.comMovProv = tesMovimientos.tesMovimientos
Inner Join conAsientos On conAsientos.conAsientos = tesMovimientos.tesMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join tesRengMoviRetProv On tesRengMoviRetProv.tesMovimientos = tesMovimientos.tesMovimientos 
Inner Join tesRengmovi On tesRengmovi.tesMovimientos = tesRengMoviRetProv.tesMovimientos And tesRengmovi.conRenglon = tesRengMoviRetProv.conRenglon
Inner Join conMovCont On conMovCont.conAsientos = tesMovimientos.tesMovimientos And conMovCont.Renglon = tesRengMoviRetProv.conRenglon
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner Join tesIdRetProv On tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica
Inner Join tesRetProvSegmento On tesRetProvSegmento.tesMovimientos = tesMovimientos.tesMovimientos And tesRetProvSegmento.Segmento_Id = tesIdRetProv.Segmento_Id and 
tesRetProvSegmento.conRenglon = tesrengmovi.conRenglon
Inner Join genEntidades On genEntidades.genEntidades = comMovProv.Proveed_Id
Inner Join comProveedores On comProveedores.genEntidades = comMovProv.Proveed_Id
Inner Join comCondFiscal On comCondFiscal.comCondFiscal = comProveedores.CondFiscal_Id
inner join vcomMovprov on 
vcomMovprov.comMovprov = @tesMovimientos
inner join (select  vtesrengmovi.Cartera_Id, year(conasientos.fecha) anio,month(conasientos.fecha) mes, vcommovprov.proveed_id, sum(tesmovigravado.importe) total_gravado
from vtesrengmovi
inner join conasientos on
vtesrengmovi.tesmovimientos = conasientos.conasientos 
inner join vcommovprov on 
vtesrengmovi.tesmovimientos = vcommovprov.commovprov
inner join tesmovigravado on 
tesmovigravado.tesmovimientos = vtesrengmovi.tesmovimientos
where vtesrengmovi.tipomov <> 1 AND conAsientos.Anulado= 0 
group by  vtesrengmovi.Cartera_Id,year(conasientos.fecha),month(conasientos.fecha), vcommovprov.proveed_id) tPagos on 
tPagos.anio = year(conasientos.fecha) and tpagos.mes = month(conasientos.fecha) and 
tPagos.Cartera_Id = tesIdentifica.Cartera_Id and 
tPagos.Proveed_Id = comProveedores.Proveed_Id
inner join 
(select year(conasientos.fecha) anio,month(conasientos.fecha) mes, vcommovprov.proveed_id,sum(vtesrengmovi.importe*conasientos.Cambio) Total_Pagos_Acum from vtesrengmovi 
inner join conasientos on
vtesrengmovi.tesmovimientos = conasientos.conasientos 
inner join vcommovprov on 
vtesrengmovi.tesmovimientos = vcommovprov.commovprov
inner join tesmovigravado on 
tesmovigravado.tesmovimientos = vtesrengmovi.tesmovimientos
where vtesrengmovi.tipomov = 1 AND conAsientos.Anulado= 0 
group by  year(conasientos.fecha),month(conasientos.fecha), vcommovprov.proveed_id) TotalPagos  on 
tpagos.anio = TotalPagos.anio and tpagos.mes = totalpagos.mes and tpagos.proveed_id = totalpagos.proveed_id
Where tesRengMovi.tesMovimientos = @tesMovimientos And tesRengMovi.conRenglon = @conRenglon
Go