-- EXEC  inf_proOrdenOrigen ' ','ZZZ', '20190801','20190831',1
DROP PROCEDURE inf_proOrdenOrigen
GO
CREATE PROCEDURE inf_proOrdenOrigen
(
	@CtroProdDesde VarChar(8),
	@CtroProdHasta VarChar(8),
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@Empresa_Id Int
)
AS
SELECT 
dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
		proOrden.FechaEmision, proOrden.FechaNecesidad, 
		proOrden.FechaProduccion,
		stkProductos.Producto_Id, stkProductos.Descripcion , 
		proOrden.CantidadIngresada, stkUniMed.Medida_Id,
		ISNULL(
		dbo.Segmento(proProgramasSegmento.Segmento_Id, 
		proProgramasSegmento.Segmento1C,proProgramasSegmento.Segmento2C,
		proProgramasSegmento.Segmento3C, proProgramasSegmento.Segmento4C,
		proProgramasSegmento.Segmento1N, proProgramasSegmento.Segmento2N,
		proProgramasSegmento.Segmento3N, proProgramasSegmento.Segmento4N) ,
		'NA') 	as Programa, 
		ISNULL(stkProductosC.Producto_Id,' ') Origen, 
		ISNULL(stkProductosC.Descripcion,' ') DescripcionOrigen

from proOrden 
INNER JOIN proOrdenSegmento ON proOrden.proOrden = proOrdenSegmento.proOrden 
INNER JOIN stkProductos ON stkProductos.stkProductos = proOrden.Producto_Id 
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = proOrden.Medida_Id
--INNER JOIN proRecetas ON proRecetas.proRecetas = proOrden.Receta_Id
INNER JOIN proCentroProductivo ON proCentroProductivo.proCentroProductivo = proOrden.CtroProd_Id
left join (proProgramaOrden 
	INNER join proProgramasSegmento ON proProgramaOrden.proProgramas = proProgramasSegmento.proProgramas
	inner join proProgramasCuerpo ON proProgramasCuerpo.proProgramas = proProgramaOrden.proProgramas and
	proProgramasCuerpo.Renglon =  proProgramaOrden.Renglon
	INNER JOIN stkProductos  stkProductosC On stkProductosC.stkProductos = proProgramasCuerpo.Producto_Id	)
	ON proProgramaOrden.proOrden = proOrden.proOrden
WHERE
	proCentroProductivo.CtroProd_Id between @CtroProdDesde and @CtroProdHasta and 
	proOrden.FechaEmision between @FechaDesde and @FechaHasta AND 
	proOrdenSegmento.Empresa_Id =@Empresa_Id
	ORDER BY 1
GO