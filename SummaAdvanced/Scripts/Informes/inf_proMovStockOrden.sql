
-- EXEC  inf_proMovStockOrden  '20190801','20190831','PORD','0001',' ',' ',' ',1,0,0,0,9999999, 1
DROP PROCEDURE inf_proMovStockOrden
GO
CREATE PROCEDURE inf_proMovStockOrden
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@Segmento_Id VarChar(10),
	@Segmento1C VarChar(25),
	@Segmento2C VarChar(25),
	@Segmento3C VarChar(25),
	@Segmento4C VarChar(25),
	@Segmento1N INT,
	@Segmento2N INT,
	@Segmento3N INT,
	@Segmento4N INT,
	@Segmento1NHasta INT,
	@Empresa_Id Int
)
AS
SELECT 
dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
		dbo.Segmento(genAsiSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Cierre,
		dbo.Segmento(genAsiSegmentosS.Segmento_Id, 
		genAsiSegmentosS.Segmento1C,genAsiSegmentosS.Segmento2C,
		genAsiSegmentosS.Segmento3C, genAsiSegmentosS.Segmento4C,
		genAsiSegmentosS.Segmento1N, genAsiSegmentosS.Segmento2N,
		genAsiSegmentosS.Segmento3N, genAsiSegmentosS.Segmento4N) as MovStock, 
		stkProductos.Producto_Id, stkProductos.Descripcion, 
			case when stkMoviCabe.Signo = 1 then stkmovicuerpo.CantidadForm else 0 end as Entrada,
			case when stkMoviCabe.Signo = -1 then stkmovicuerpo.CantidadForm else 0 end as Salida,
			stkUniMed.Medida_Id, stkMoviCuerpo.CostoUnitario, conAsientos.Fecha
From proOrden INNER JOIN proOrdenSegmento ON
proOrden.proOrden = proOrdenSegmento.proOrden 
INNER JOIN proMovCierreOrden on
	proMovCierreOrden.proOrden = proOrden.proOrden
inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id=proMovCierreOrden.proMovCierreOrden
INNER JOIN proOrdenStock ON
	proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN genAsiSegmentos genAsiSegmentosS On 
	genAsiSegmentoss.Asiento_Id = proOrdenStock.stkMoviCabe
INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkMoviCabe ON
	stkMoviCabe.stkMoviCabe = proOrdenStock.stkMoviCabe
inner join conAsientos ON
conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
INNER JOIN stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = proOrdenSegmento.Segmento_Id
WHERE
	proOrden.FechaEmision between @FechaDesde and @FechaHasta AND 
	proOrdenSegmento.Empresa_Id =@Empresa_Id and 
	genSegmentos.Segmento_Id = @Segmento_Id and
	proOrdenSegmento.Segmento1C = @Segmento1C and 
	proOrdenSegmento.Segmento2C = @Segmento2C and 
	proOrdenSegmento.Segmento3C = @Segmento3C and 
	proOrdenSegmento.Segmento4C = @Segmento4C and 
	proOrdenSegmento.Segmento1N BETWEEN @Segmento1N and @Segmento1NHasta AND
	proOrdenSegmento.Segmento2N  = @Segmento2N and
	proOrdenSegmento.Segmento3N  = @Segmento3N and
	proOrdenSegmento.Segmento4N  = @Segmento4N and
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 

	ORDER BY 1,2,3
GO



