--INF_comUltimasCompras 1, '20100101','20171231',' ','ZZZ',' ','ZZZ'
DROP PROCEDURE INF_comUltimasCompras
GO
CREATE PROCEDURE INF_comUltimasCompras 
(
	@Empresa int,
	@FechaDesde DateTime , 
	@FechaHasta DateTime, 
	@ProveedDesde Char(15),
	@ProveedHasta Char(15),
	@ProductoDesde Char(25),
	@ProductoHasta Char(25)
)
AS

SELECT  stkProductos.Producto_Id, stkProductos.Descripcion, conAsientos.Fecha,
	'OC' Tipo,
	dbo.Segmento(comOCSegmentos.Segmento_Id,
	comOCSegmentos.Segmento1C,comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as Segmento, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial,
	comOCCuerpo.Precio, genMonedas.Moneda_Id, 
	stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.Cantidad, 
	stkUniMed.Medida_Id
From stkMoviCabe
INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
inner join conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
INNER JOIN stkMoviOC ON stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND stkMoviOC.Renglon = stkMoviCuerpo.Renglon
INNER JOIN comOrdenComp ON comOrdenComp.comOrdenComp = stkMoviOC.comOrdenComp
INNER JOIN comOCSegmentos ON comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
INNER JOIN comOCCuerpo ON comOCCuerpo.comOrdenComp = stkMoviOC.comOrdenComp AND comOCCuerpo.Renglon_OC = stkMoviOC.Renglon_OC
INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_Id
Where
	stkMoviCabe.Signo = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between  @FechaDesde And @FechaHasta and
	comProveedores.Proveed_Id between @ProveedDesde And @ProveedHasta and
	stkproductos.Producto_Id BETWEEN @ProductoDesde And @ProductoHasta


UNION ALL
SELECT  stkProductos.Producto_Id, stkProductos.Descripcion, conAsientos.Fecha,
	'FD' Tipo,
	dbo.Segmento(genAsiSegmentos.Segmento_Id,
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Segmento, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial,
	stkMoviCuerpo.PrecioOriginal, genMonedas.Moneda_Id, 
	stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.Cantidad, 
	stkUniMed.Medida_Id
From stkMoviCabe
INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
inner join conAsientos ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
INNER JOIN stkMoviProv ON stkMoviProv.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
INNER JOIN commovprov ON commovprov.commovprov = stkMoviCabe.stkMoviCabe
INNER JOIN genAsiSegmentos ON commovprov.comMovProv = genAsiSegmentos.Asiento_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_Id
Where
	stkMoviCabe.Signo = 1 and 
	conAsientos.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha between  @FechaDesde And @FechaHasta and
	comProveedores.Proveed_Id between @ProveedDesde And @ProveedHasta and
	stkproductos.Producto_Id BETWEEN @ProductoDesde And @ProductoHasta


GO
