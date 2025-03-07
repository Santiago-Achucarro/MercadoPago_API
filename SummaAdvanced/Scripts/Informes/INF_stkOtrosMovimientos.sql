-- INF_stkOtrosMovimientos '20180101','20181231', ' ','ZZZZZ',1
DROP PROCEDURE INF_stkOtrosMovimientos
GO
CREATE PROCEDURE INF_stkOtrosMovimientos
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@CausaDesde VarChar(5),
	@CausaHasta VarChar(5),
	@Empresa Int

)
AS

SELECT stkCausasMovi.Causa_Id, stkCausasMovi.Descripcion as DescripcionCausa, 
	conAsientos.Fecha,  stkMoviCabe.stkMoviCabe, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Comprobante, 
	conAsientos.Observaciones, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
	stkUniMed.Medida_Id, stkMoviCuerpo.Cantidad * stkMoviCabe.Signo as Cantidad, 
	stkMoviCuerpo.CostoUnitario, 
	Convert(numeric(18,2), stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario * stkMoviCabe.Signo) as Monto 
	FROM stkMoviCabe INNER JOIN conAsientos ON
	stkMoviCabe.stkMoviCabe = conAsientos.conAsientos 
	INNER JOIn genAsiSegmentos ON 
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN stkMoviCausa ON
	stkMoviCausa.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkCausasMovi ON 
	stkCausasMovi.stkCausasMovi = stkMoviCausa.Causa_Id
	INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
Where
	conAsientos.Anulado = 0 and 
	genAsiSegmentos.Empresa_Id = @Empresa and 
	stkCausasMovi.Causa_Id BETWEEN @CausaDesde And @CausaHasta AND 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
ORDER BY 1, 3
GO
