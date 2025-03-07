
Drop procedure impRetIvaLimpSeg
Go
--impRetIvaLimpSeg 1, '20220101','20220831'
Create procedure impRetIvaLimpSeg
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As

Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta
--- "a" es el resultado de una subconsulta así la puedo ordenar por fecha.
Select a.Renglon from (
SELECT '0100'+
	   '                                    '+
	   '216'+
	   '831'+
	   convert(char(10),conasientos.Fecha,103)+
	   '01'+
	   '0'+
	   '                              '+
	   RIGHT(replicate('0',14)+ltrim(rtrim(convert(varchar(14),cast(ISNULL(conmovcont.Importe,0) as decimal(14,2)),1))),14)+
	   RIGHT(replicate('0',14)+ltrim(rtrim(convert(varchar(14),cast(ISNULL(Servicio.Importe,0)+ISNULL(Mercaderia.importe,0) as decimal(14,2)),1))),14) +
   	   '0'+
	   '      '+
	   '          '+
	   '06'+
	   convert(char(10),conasientos.Fecha,103)+
	   left(RIGHT('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4)+RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+replicate(' ',24),24)+
       '            '+
	   '            '+
	   --'              '+ -- FM 13217 Le resto 8 lugares para bajar el espacio de 50 a 42
	   '      '+
	   RIGHT(replicate('0',14)+ltrim(rtrim(convert(varchar(14),cast(ISNULL(conMovContPRO.Importe,0) as decimal(14,2)),1))),14)+ -- FM 13217
	   '                              '+
	   substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
	   '                         '+
	   '          '+
	   '              '+
	   ' ' renglon
	 FROM tesRengMovi 
     INNER JOIN tesMovimientos on tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
     INNER JOIN tesidretprov on tesRengMovi.Cartera_Id = tesIdRetProv.Cartera_Id
	 INNER JOIN tesidentifica on tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica
	 INNER JOIN conMovcont on conMovcont.conAsientos = tesRengMovi.tesMovimientos and conMovcont.Renglon = tesRengMovi.conRenglon
	 INNER JOIN tesRengMoviRetProv on tesRengMoviRetProv.tesMovimientos = conMovcont.conAsientos and tesRengMoviRetProv.conRenglon = conMovcont.Renglon
	 INNER JOIN conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos
	 INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
	 inner join tesRetProvSegmento on tesRetProvSegmento.tesMovimientos = conasientos.conAsientos and tesRetProvSegmento.conRenglon = conmovcont.Renglon
	 INNER JOIN comMovprov on tesMovimientos.tesMovimientos = comMovprov.comMovprov
	 Inner Join conMovCont conMovContPRO On conMovContPRO.conAsientos = comMovProv.comMovProv And conMovContPRO.Clase = 'PRO'
	 INNER JOIN comProveedores on comMovprov.Proveed_Id = comProveedores.genEntidades
	 INNER JOIN genEntidades on comProveedores.genEntidades = genEntidades.genEntidades
	 INNER JOIN comCondFiscal on comProveedores.CondFiscal_Id = comCondFiscal.comCondFiscal
	 Left join tesMoviGravado Servicio on Servicio.tesMovimientos = tesMovimientos.tesMovimientos and Servicio.TipoCtaProv = 2 
	 left join tesMoviGravado Mercaderia on Mercaderia.tesMovimientos = tesMovimientos.tesMovimientos and Mercaderia.TipoCtaProv = 1
	 INNER JOIN GENEMPRESAS ON GENEMPRESAS.GENEMPRESAS = conAsientos.Empresa_Id
	 where conAsientos.fecha between @pFechaDesde and @pFechaHasta
	 and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
	 and comMovprov.TipoMov = 'P'
	 and tesIdRetProv.TipoImpuesto In (2101, 2201)
	 and conAsientos.Anulado = 0) a 

	  	 
GO

