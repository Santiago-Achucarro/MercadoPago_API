-- inf_proProduccionesPeriodo ' ','ZZZ', '20190801', '20190831','P',1
-- inf_proProduccionesPeriodo ' ','ZZZ', '20190801', '20190831','C',1

DROP PROCEDURE inf_proProduccionesPeriodo
GO
CREATE PROCEDURE inf_proProduccionesPeriodo
(
	@CtroProdDesde VarChar(8),
	@CtroProdHasta VarChar(8),
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@ConsOProd Char(1),
	@Empresa_Id Int
)
AS

SELECT proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DescripcionCP, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	SUM(stkMoviCuerpo.Cantidad) AS Cantidad,	stkUniMed.Medida_Id
	
FROM proCentroProductivo 
--INNER JOIN proRecetas on proRecetas.CtroProd_Id = proCentroProductivo.proCentroProductivo
	INNER JOIN proOrden ON proOrden.CtroProd_Id = proCentroProductivo.proCentroProductivo
	INNER JOIN proMovCierreOrden ON proMovCierreOrden.proOrden = proOrden.proOrden
	INNER JOIN proOrdenStock ON proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
	INNER JOIN stkMoviCabe ON stkMoviCabe.stkMoviCabe = proOrdenStock.stkMoviCabe
	INNER JOIN conAsientos ON conAsientos.conAsientos= stkMoviCabe.stkMoviCabe
	INNER JOIN stkMoviCuerpo  on stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	inner join stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
	where
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1  and 
	conAsientos.Fecha between @FechaDesde and  @FechaHasta and 
	proCentroProductivo.CtroProd_Id BETWEEN @CtroProdDesde And @CtroProdHasta AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	stkMoviCabe.Signo = case when @ConsOProd = 'C' Then -1 else 1 end
GROUP BY proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion ,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
		stkUnimed.Medida_Id
ORDER BY 1,3