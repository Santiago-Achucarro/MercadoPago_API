-- inf_proEficiencia ' ','ZZZ', '20190801', '20190831',1


DROP PROCEDURE inf_proEficiencia
GO
CREATE PROCEDURE inf_proEficiencia
(
	@CtroProdDesde VarChar(8),
	@CtroProdHasta VarChar(8),
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@Empresa_Id Int
)
AS

SELECT proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DescripcionCP, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	SUM(proOrden.Cantidad) as Programado,
	SUM(proOrden.CantidadTerminada) AS Terminado,	stkUniMed.Medida_Id
	
FROM proCentroProductivo 
--INNER JOIN proRecetas on proRecetas.CtroProd_Id = proCentroProductivo.proCentroProductivo
--	INNER JOIN proOrden ON proOrden.Receta_Id = proRecetas.proRecetas
	INNER JOIN proOrden on proOrden.CtroProd_Id = proCentroProductivo.proCentroProductivo
	INNER JOIN stkProductos ON stkProductos.stkProductos = proOrden.Producto_Id
	inner join stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN proOrdenSegmento ON proOrdenSegmento.proOrden = proOrden.proOrden
	where
	proOrden.FechaNecesidad between @FechaDesde and  @FechaHasta and 
	proCentroProductivo.CtroProd_Id BETWEEN @CtroProdDesde And @CtroProdHasta AND 
	proOrdenSegmento.Empresa_Id = @Empresa_Id  and 
	proOrden.Anulado = 0 
GROUP BY proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion ,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
		stkUnimed.Medida_Id
ORDER BY 1,3