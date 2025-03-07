
Drop procedure impRetSuss
Go
--impRetsuss 1, '20220101','20220730'
Create procedure impRetSuss
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As

Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) RetClie
--- "a" es el resultado de una subconsulta así la puedo ordenar por fecha.
Select a.Renglon from (
SELECT '2004'+
		'0100'+
		'          '+
substring(genEmpresas.Cuit,1,2)+SUBSTRING(genEmpresas.Cuit,4,8)+substring(genEmpresas.Cuit,13,1)+
'353'+
'748'+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
+convert(char(10),conasientos.Fecha,103)+'06'+convert(char(10),conasientos.Fecha,103)+
	left(RIGHT('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4)+RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+replicate(' ',16),16)+
	RIGHT(replicate('0',14)+ltrim(rtrim(convert(varchar(14),cast(ISNULL(conMovContPRO.Importe,0) as decimal(14,2)),1))),14)+
    RIGHT(replicate('0',14)+ltrim(rtrim(convert(varchar(14),cast(ISNULL(conMovContPRO.Importe,0) as decimal(14,2)),1))),14)+
	'                         '+	
	'          '+
	'              '+
	'                              ' renglon
	 FROM tesRengMovi 
     Inner Join tesMovimientos on tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
     Inner Join tesidretprov on tesRengMovi.Cartera_Id = tesIdRetProv.Cartera_Id
	 Inner Join tesidentifica on tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica
	 Inner Join conMovcont on conMovcont.conAsientos = tesRengMovi.tesMovimientos and conMovcont.Renglon = tesRengMovi.conRenglon
	 Inner Join tesRengMoviRetProv on tesRengMoviRetProv.tesMovimientos = conMovcont.conAsientos and tesRengMoviRetProv.conRenglon = conMovcont.Renglon
	 Inner Join conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos
	 Inner Join genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
	 Inner Join tesRetProvSegmento on tesRetProvSegmento.tesMovimientos = conasientos.conAsientos And tesRetProvSegmento.conRenglon = conmovcont.Renglon
	 Inner Join comMovprov on tesMovimientos.tesMovimientos = comMovprov.comMovprov
	 Inner Join comProveedores on comMovprov.Proveed_Id = comProveedores.genEntidades
	 Inner Join genEntidades on comProveedores.genEntidades = genEntidades.genEntidades
	 Inner Join comCondFiscal on comProveedores.CondFiscal_Id = comCondFiscal.comCondFiscal
	 Left join tesMoviGravado Servicio on Servicio.tesMovimientos = tesMovimientos.tesMovimientos and Servicio.TipoCtaProv = 2 
	 left join tesMoviGravado Mercaderia on Mercaderia.tesMovimientos = tesMovimientos.tesMovimientos and Mercaderia.TipoCtaProv = 1
	 Inner Join GENEMPRESAS ON GENEMPRESAS.GENEMPRESAS = conAsientos.Empresa_Id
	 Inner Join conMovCont conMovContPRO On conMovContPRO.conAsientos = comMovProv.comMovProv And conMovContPRO.Clase = 'PRO'
	 Where conAsientos.fecha Between @pFechaDesde and @pFechaHasta
	 and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
	 and comMovprov.TipoMov = 'P'
	 and tesIdRetProv.nroressicore = 748
	 and conAsientos.Anulado = 0) a 

	  	 
GO

