
-- proOrdenesLimpiar '20190831',' ','ZZZ',1
DROP PROCEDURE proOrdenesLimpiar
GO
CREATE PROCEDURE proOrdenesLimpiar
(
	@FechaHasta DateTime, 
	@CtroProdDesde VarChar(8),
	@CtroProdHasta VarChar(8),
	@Empresa_Id Int

)
AS

SELECT @FechaHasta as FechaHasta, @CtroProdDesde  as CtroProdDesde, 
	@CtroProdHasta  as CtroProdHasta


Select proOrden.proOrden, dbo.Segmento(proOrdenSegmento.Segmento_Id,
	proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, 
		proOrdenSegmento.Segmento4C, proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N, 
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden, 
		proOrden.FechaEmision, proOrden.FechaNecesidad, 
		stkProductos.Producto_Id, stkProductos.Descripcion, proOrden.Cantidad,
		proOrden.CantidadTerminada, 
		CAST(0 as bit) as Marca
From proOrden 
INNER JOIN stkProductos ON proOrden.Producto_Id =  stkProductos.stkProductos
INNER JOIN proOrdenSegmento ON proOrdenSegmento.proOrden = proOrden.proOrden
INNER JOIN proRecetas ON proRecetas.proRecetas = proOrden.Receta_Id
INNER JOIN proCentroProductivo ON proCentroProductivo.proCentroProductivo =  proOrden.CtroProd_Id
Where
	proCentroProductivo.CtroProd_Id BETWEEN @CtroProdDesde And @CtroProdHasta AND
	proOrdenSegmento.Empresa_Id = @Empresa_Id and 
	proOrden.FechaFin IS NULL AND 
	proOrden.FechaNecesidad <= @FechaHasta
order by 2

GO
	