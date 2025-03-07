---  Inf_proTrabajosCP '  ','zzzz', '20190801', '20190831', 1
DROP PROCEDURE Inf_proTrabajosCP
GO

CREATE PROCEDURE Inf_proTrabajosCP
(
	@CtroProdDesde_Id VarChar(8),
	@CtroProdHasta_Id VarChar(8),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id Int

)

AS

SELECT proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DescripcionCentroProd, 
	dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	proOrden.CantidadIngresada , stkUniMed.Medida_Id,
	proOrden.FechaNecesidad , 
	Convert(Numeric(18,8),proOrden.CantidadTerminada / proOrden.Factor) as Terminados 
FROM proCentroProductivo 
--INNER JOIN proRecetas ON proRecetas.CtroProd_Id = proCentroProductivo.proCentroProductivo
--INNER JOIN proOrden ON proOrden.Receta_Id = proRecetas.proRecetas
INNER JOIN proOrden ON proOrden.CtroProd_Id = proCentroProductivo.proCentroProductivo
INNER JOIN stkProductos ON stkProductos.stkProductos = proOrden.Producto_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = proOrden.Medida_Id
INNER JOIN proOrdenSegmento ON proOrdenSegmento.proOrden = proOrden.proOrden
Where
	proOrdenSegmento.Empresa_Id = @Empresa_Id and
	proCentroProductivo.CtroProd_Id BETWEEN @CtroProdDesde_Id and @CtroProdHasta_Id and
	proOrden.FechaNecesidad between @FechaDesde And @FechaHasta
ORDER BY 1, 3
GO