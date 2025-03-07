-- INF_stkMercTransImp '20180531',1


DROP PROCEDURE INF_stkMercTransImp
GO
CREATE PROCEDURE INF_stkMercTransImp (
	@FechaHasta DateTime,
	@Empresa int
)

AS



SELECT 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	conAsientos.Fecha, comEmbarques.comEmbarques,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	comEmbCuerpo.Cantidad - ISNULL((SELECT SUM(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo)
		FROM stkMoviCabe INNER JOIN stkMoviOC on
		stkMoviCabe.stkMoviCabe = stkMoviOC.stkMoviCabe and
		stkmovioc.comOrdenComp = comEmbCuerpo.comOrdenComp and 
		stkmovioc.Renglon_OC =comEmbCuerpo.Renglon_OC
		INNER JOIN stkMoviCuerpo ON
		stkMoviCuerpo.stkMoviCabe = stkMoviOC.stkMoviCabe AND
		stkMoviCuerpo.Renglon =stkMoviOC.Renglon
		INNER JOIN conAsientos ON
		conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Empresa_Id = @Empresa and 
			conAsientos.Fecha <= @FechaHasta),0) AS Cantidad ,
	Convert(numeric(18,4),comOCCuerpo.Precio*conAsientos.Cambio) PrecioMonBase, 
	comOCCuerpo.Precio,
	stkUniMed.Medida_Id , Convert(numeric(18,2),
	(comEmbCuerpo.Cantidad - ISNULL((SELECT SUM(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo)
		FROM stkMoviCabe INNER JOIN stkMoviOC on
		stkMoviCabe.stkMoviCabe = stkMoviOC.stkMoviCabe and
		stkmovioc.comOrdenComp = comEmbCuerpo.comOrdenComp and 
		stkmovioc.Renglon_OC =comEmbCuerpo.Renglon_OC
		INNER JOIN stkMoviCuerpo ON
		stkMoviCuerpo.stkMoviCabe = stkMoviOC.stkMoviCabe AND
		stkMoviCuerpo.Renglon =stkMoviOC.Renglon
		INNER JOIN conAsientos ON
		conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Empresa_Id = @Empresa and 
			conAsientos.Fecha <= @FechaHasta),0)) * 	comOCCuerpo.Precio*conAsientos.Cambio) as Monto
FROM
	comEmbarques INNER JOIN comEmbCuerpo ON
	comEmbarques.comEmbarques = comEmbCuerpo.comEmbarques
	INNER JOIN conAsientos ON
	conAsientos.conAsientos =comEmbarques.comEmbarques
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = comEmbarques.comEmbarques
	INNER JOIN comOCArticulo ON
	comOCArticulo.comOrdenComp = comEmbCuerpo.comOrdenComp AND 
	comOCArticulo.Renglon_OC = comEmbCuerpo.Renglon_OC
	INNER JOIN comOCCuerpo ON
	comOCArticulo.comOrdenComp = comOCCuerpo.comOrdenComp AND 
	comOCArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = comOCArticulo.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	WHERE
		conAsientos.Anulado = 0 and 
		conAsientos.Empresa_Id = @Empresa and 
		conAsientos.Fecha <= @FechaHasta  and 

			comEmbCuerpo.Cantidad - ISNULL((SELECT SUM(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo)
		FROM stkMoviCabe INNER JOIN stkMoviOC on
		stkMoviCabe.stkMoviCabe = stkMoviOC.stkMoviCabe and
		stkmovioc.comOrdenComp = comEmbCuerpo.comOrdenComp and 
		stkmovioc.Renglon_OC =comEmbCuerpo.Renglon_OC
		INNER JOIN stkMoviCuerpo ON
		stkMoviCuerpo.stkMoviCabe = stkMoviOC.stkMoviCabe AND
		stkMoviCuerpo.Renglon =stkMoviOC.Renglon
		INNER JOIN conAsientos ON
		conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Empresa_Id = @Empresa and 
			conAsientos.Fecha <= @FechaHasta),0) <> 0
	ORDER BY 1,2,3

go
