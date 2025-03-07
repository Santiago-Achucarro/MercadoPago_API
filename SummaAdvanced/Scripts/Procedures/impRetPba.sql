Drop procedure impRetPba
Go
--impRetPba 1, '20220413','20220413'
Create procedure impRetPba
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As

Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta
--- "a" es el resultado de una subconsulta así la puedo ordenar por fecha.
Select a.Renglon from (
SELECT ltrim(rtrim(genEntidades.Cuit))+convert(char(10),conasientos.Fecha,103)+genAsiSegmentos.Segmento4C+
	 genAsiSegmentos.Segmento2C +RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+
	 RIGHT(replicate('0',11)+ltrim(rtrim(convert(varchar(11),cast(ISNULL(conmovcont.Importe,0) as decimal(11,2)),1))),11)+'A' renglon
	 FROM tesRengMovi 
     INNER JOIN tesMovimientos on tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
     INNER JOIN tesidretprov on tesRengMovi.Cartera_Id = tesIdRetProv.Cartera_Id
	 INNER JOIN tesidentifica on tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica
	 INNER JOIN conMovcont on conMovcont.conAsientos = tesRengMovi.tesMovimientos and conMovcont.Renglon = tesRengMovi.conRenglon
	 INNER JOIN tesRengMoviRetProv on tesRengMoviRetProv.tesMovimientos = conMovcont.conAsientos and tesRengMoviRetProv.conRenglon = conMovcont.Renglon
	 INNER JOIN conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos
	 INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
	 INNER JOIN comMovprov on tesMovimientos.tesMovimientos = comMovprov.comMovprov
	 INNER JOIN comProveedores on comMovprov.Proveed_Id = comProveedores.genEntidades
	 INNER JOIN genEntidades on comProveedores.genEntidades = genEntidades.genEntidades
	 INNER JOIN comCondFiscal on comProveedores.CondFiscal_Id = comCondFiscal.comCondFiscal
	 Left join tesMoviGravado Servicio on Servicio.tesMovimientos = tesMovimientos.tesMovimientos and Servicio.TipoCtaProv = 2 
	 left join tesMoviGravado Mercaderia on Mercaderia.tesMovimientos = tesMovimientos.tesMovimientos and Mercaderia.TipoCtaProv = 1
	 where conAsientos.fecha between @pFechaDesde and @pFechaHasta
	 and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
	 and comMovprov.TipoMov = 'P'
	 and tesIdRetProv.TipoImpuesto = 1902
	 and conAsientos.Anulado = 0) a 

	  	 
GO