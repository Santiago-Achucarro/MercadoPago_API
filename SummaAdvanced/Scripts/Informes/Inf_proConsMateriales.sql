-- EXEC Inf_proConsMateriales ' ','ZZZ',' ','ZZZ',1
DROP PROCEDURE Inf_proConsMateriales
GO
CREATE PROCEDURE Inf_proConsMateriales
(
	@CtroProdDesde VarChar(8),
	@CtroProdHasta VarChar(8),
	@DepositoDesde VarChar(5),
	@DepositoHasta VarChar(5),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id Int
)

AS

Select stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepo, 
	proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DescripcionCentroProd,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	SUM(proOrdenProd.Cantidad* case when proOrdenProd.EntradaSalida='C' THEN 1 ELSE -1 END ) as Cantidad, 
	stkUniMed.Medida_Id
FROM proOrden 
INNER JOIN proOrdenProd ON proOrden.proOrden = proOrdenProd.proOrden
	INNER JOIN stkProductos ON stkProductos.stkProductos = proOrdenProd.Producto_Id 
	inner join stkUniMed ON stkUniMed.stkUniMed = proOrdenProd.Medida_Id
	INNER JOIN stkDepositos ON stkDepositos.stkDepositos = proOrdenProd.Deposito_Id
	--inner join proRecetas ON proRecetas.proRecetas = proOrden.Receta_Id
	--INNER JOIN proCentroProductivo ON proCentroProductivo.proCentroProductivo = proRecetas.CtroProd_Id
	INNER JOIN proCentroProductivo ON proCentroProductivo.proCentroProductivo = proOrden.CtroProd_Id
	INNER JOIN proOrdenSegmento ON proOrdenSegmento.proOrden = proOrden.proOrden
	WHERE
		proOrdenProd.EntradaSalida = 'C' and 
		stkDepositos.Deposito_Id BETWEEN @DepositoDesde AND @DepositoHasta AND
		proCentroProductivo.CtroProd_Id BETWEEN @CtroProdDesde AND @CtroProdHasta AND 
		proOrdenSegmento.Empresa_Id = @Empresa_Id and 
		proOrden.FechaProduccion between @FechaDesde And @FechaHasta
GROUP BY stkDepositos.Deposito_Id, stkDepositos.Descripcion ,
	proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion ,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkUniMed.Medida_Id
HAVING SUM(proOrdenProd.Cantidad* case when proOrdenProd.EntradaSalida='C' THEN 1 ELSE -1 END ) > 0
ORDER BY 1,3,5
GO