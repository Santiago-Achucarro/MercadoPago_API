
Drop procedure impRetTucu
Go
--impRetTucu 1, '20220101','20220731'
Create procedure impRetTucu
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
Select cast(year(conasientos.fecha) as char(4))+Right(replicate('0',2)+cast(Month(conasientos.fecha) as varchar(2)),2)+Right('00'+cast(Day(conasientos.fecha) as varchar(2)),2)+'80'+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
--Case When genAsisegmentos.segmento1c In ('F', 'I') Then (Case genasisegmentos.segmento3c When 'A' Then '01'  Else '06' End) 
--When genAsisegmentos.segmento1c In ('D', 'B') Then (Case genasisegmentos.segmento3c When 'A' Then '02'  Else '07' End)
--When genAsisegmentos.segmento1c In ('R', 'E') Then (Case genasisegmentos.segmento3c When 'A' Then '03' Else '08' End ) 
--Else '09' End + 
'09' +
' ' +
rTrim(genasisegmentos.segmento3c)+Right('0000'+lTrim(rTrim(genAsiSegmentos.Segmento2C)),4) +Right('00000000' + lTrim(rTrim(Convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+
Right(replicate('0',15)+lTrim(rTrim(Convert(varchar(15),cast(isNull(Servicio.Importe,0)+isNull(Mercaderia.importe,0) as decimal(15,2)),1))),15) +
Right(replicate('0',6)+lTrim(rTrim(Convert(varchar(6),cast(isNull(tesRengMoviRetProv.porcentaje,0) as decimal(6,2)),1))),6)+
Right(replicate('0',15)+lTrim(rTrim(Convert(varchar(15),cast(isNull(conMovcont.Importe,0) as decimal(15,2)),1))),15) 
Registro
FROM tesRengMovi 
Inner Join tesMovimientos on tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
Inner Join tesidretprov on tesRengMovi.Cartera_Id = tesIdRetProv.Cartera_Id
Inner Join tesidentifica on tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica
Inner Join conMovcont on conMovcont.conAsientos = tesRengMovi.tesMovimientos and conMovcont.Renglon = tesRengMovi.conRenglon
Inner Join tesRengMoviRetProv on tesRengMoviRetProv.tesMovimientos = conMovcont.conAsientos and tesRengMoviRetProv.conRenglon = conMovcont.Renglon
Inner Join conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos
Inner Join genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
Inner Join comMovprov on tesMovimientos.tesMovimientos = comMovprov.comMovprov
Inner Join comProveedores on comMovprov.Proveed_Id = comProveedores.genEntidades
Inner Join genEntidades on comProveedores.genEntidades = genEntidades.genEntidades
Inner Join comCondFiscal on comProveedores.CondFiscal_Id = comCondFiscal.comCondFiscal
Left join tesMoviGravado Servicio on Servicio.tesMovimientos = tesMovimientos.tesMovimientos and Servicio.TipoCtaProv = 2 
left join tesMoviGravado Mercaderia on Mercaderia.tesMovimientos = tesMovimientos.tesMovimientos and Mercaderia.TipoCtaProv = 1
where conAsientos.fecha between @pFechaDesde and @pFechaHasta
and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
and comMovprov.TipoMov = 'P'
and tesIdRetProv.TipoImpuesto = 1924
and conAsientos.Anulado = 0 And conAsientos.Posteado = 1



Go



