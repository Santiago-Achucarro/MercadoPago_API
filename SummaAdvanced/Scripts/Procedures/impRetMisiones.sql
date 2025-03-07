DROP PROCEDURE impRetMisiones
GO
CREATE PROCEDURE impRetMisiones
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
SELECT @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
SELECT REPLACE(CONVERT(CHAR(10),conAsientos.Fecha,103),'/','-')+','+
genEntidades.Cuit+','+
rTrim(genasisegmentos.segmento3c)+Right('0000'+lTrim(rTrim(genAsiSegmentos.Segmento2C)),4) +Right('00000000' + lTrim(rTrim(Convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+','+
Right(replicate('0',15)+lTrim(rTrim(Convert(varchar(15),cast(isNull(Servicio.Importe,0)+isNull(Mercaderia.importe,0) as decimal(15,2)),1))),15)+','+
Right(replicate('0',4)+lTrim(rTrim(Convert(varchar(6),cast(isNull(tesRengMoviRetProv.porcentaje,0) as decimal(4,1)),1))),4) Registro
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
WHERE conAsientos.fecha BETWEEN @pFechaDesde and @pFechaHasta
and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
and comMovprov.TipoMov = 'P'
and tesIdRetProv.TipoImpuesto = 1914
and conAsientos.Anulado = 0 And conAsientos.Posteado = 1
GO
