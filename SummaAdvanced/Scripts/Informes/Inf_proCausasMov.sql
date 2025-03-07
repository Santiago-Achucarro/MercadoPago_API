-- Inf_proCausasMov ' ', 'ZZZ','20190801','20190831',1
drop Procedure Inf_proCausasMov
go
CREATE Procedure Inf_proCausasMov
(
	@CausaDesde VarChar(5),
	@CausaHasta VarChar(5),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id int
)
AS

SELECT 
proCausas.Causa_Id, proCausas.Descripcion as DescripcionCausa, 
conAsientos.Fecha,
dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
		stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProd,
		proOrden.Cantidad - proOrden.CantidadTerminada as Cantidad , 
		stkUniMed.Medida_Id
from proOrden INNER JOIN proOrdenSegmento ON
proOrden.proOrden = proOrdenSegmento.proOrden
inner join proMovCierreOrden ON
proMovCierreOrden.proOrden = proOrden.proOrden
inner join  proCausas ON
proCausas.proCausas = proMovCierreOrden.Causa_Id
INNER JOIN conAsientos ON
conAsientos.conAsientos =  proMovCierreOrden.proMovCierreOrden
INNER JOIN genAsiSegmentos on
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN stkProductos on 
stkProductos.stkProductos = proOrden.Producto_Id
INNER JOIN stkUniMed ON 
stkUniMed.stkUniMed = stkProductos.Medida_Id
WHERE
	conAsientos.Anulado = 0 AND 
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	proCausas.Causa_Id between @CausaDesde and @CausaHasta
	ORDER BY 1,2
GO
