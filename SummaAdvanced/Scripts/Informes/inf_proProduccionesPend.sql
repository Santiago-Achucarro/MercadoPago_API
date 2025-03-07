-- inf_proProduccionesPend ' ','ZZZ', '20190831',1
DROP PROCEDURE inf_proProduccionesPend
GO
CREATE PROCEDURE inf_proProduccionesPend
(
	@CtroProdDesde VarChar(8),
	@CtroProdHasta VarChar(8),
	@FechaHasta DateTime,
	@Empresa_Id Int
)
AS

SELECT proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DescripcionCP, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	SUM(proOrden.CantidadIngresada) AS CantidadIngresada ,
	Convert(numeric(18,8), SUM((proOrden.Cantidad - proOrden.CantidadTerminada)/ proOrden.Factor)) as Pendiente
	
FROM proCentroProductivo 
--INNER JOIN proRecetas on proRecetas.CtroProd_Id = proCentroProductivo.proCentroProductivo
	--INNER JOIN proOrden ON proOrden.Receta_Id = proRecetas.proRecetas
	INNER JOIN proOrden ON proOrden.CtroProd_Id = proCentroProductivo.proCentroProductivo
	INNER JOIN stkProductos ON stkProductos.stkProductos = proOrden.Producto_Id
	inner join stkUniMed ON stkUniMed.stkUniMed = proOrden.Medida_Id
	INNER JOIN proOrdenSegmento ON proOrden.proOrden = proOrdenSegmento.proOrden
	where
	proOrden.FechaFin IS NULL AND 
	proOrden.Cantidad > proOrden.CantidadTerminada And
	proOrden.FechaNecesidad <= @FechaHasta and 
	proCentroProductivo.CtroProd_Id BETWEEN @CtroProdDesde And @CtroProdHasta AND 
	proOrdenSegmento.Empresa_Id = @Empresa_Id
GROUP BY proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion ,
	stkProductos.Producto_Id, stkProductos.Descripcion
ORDER BY 1,3