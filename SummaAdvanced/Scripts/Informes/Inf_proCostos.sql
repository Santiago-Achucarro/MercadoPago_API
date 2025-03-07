-- Inf_proCostos ' ', 'ZZZ','20190801','20190831',1
drop Procedure Inf_proCostos
go
CREATE Procedure Inf_proCostos
(
	@ProductoDesde VarChar(5),
	@ProductoHasta VarChar(5),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id int
)
AS

SELECT 
		stkProductos.Producto_Id, stkProductos.Descripcion ,
		isnull((SELECT sum(stkMoviCuerpo.Cantidad) from proMovCierreOrden 
		INNER JOIN proOrden ON	proOrden.proOrden = proMovCierreOrden.proOrden 
		INNER JOIN proOrdenStockCosto on
		proMovCierreOrden.proMovCierreOrden = proOrdenStockCosto.proMovCierreOrden 
		inner join stkMoviCabe on	proOrdenStockCosto.stkMoviCabe = stkMoviCabe.stkMoviCabe
		INNER JOIN conAsientos ON  conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		INNER JOIN stkMoviCuerpo ON
			stkMoviCuerpo.stkMoviCabe = proOrdenStockCosto.stkMoviCabe  and 
			stkMoviCuerpo.Renglon =  proOrdenStockCosto.Renglon and 
			stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1 and 
			stkMoviCabe.Signo = 1 and
			conAsientos.Fecha between @FechaDesde and @FechaHasta and 
			conAsientos.Empresa_Id = @Empresa_Id),0) as Cantidad,
			stkUniMed.Medida_Id, 

		isnull((SELECT sum(stkMoviCuerpo1.Cantidad*stkMoviCuerpo1.CostoUnitario*proOrdenStockCosto.PorcentajeCosto/100) 
		from proMovCierreOrden
		INNER JOIN proOrden ON	proOrden.proOrden = proMovCierreOrden.proOrden 
		INNER JOIN proOrdenStockCosto on
		proMovCierreOrden.proMovCierreOrden = proOrdenStockCosto.proMovCierreOrden 
		inner join stkMoviCabe on	proOrdenStockCosto.stkMoviCabe = stkMoviCabe.stkMoviCabe
		INNER JOIN conAsientos ON  conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		INNER JOIN stkMoviCuerpo ON
			stkMoviCuerpo.stkMoviCabe = proOrdenStockCosto.stkMoviCabe  and 
			stkMoviCuerpo.Renglon =  proOrdenStockCosto.Renglon and 
			stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
		inner join proOrdenStock on
		proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden 
		INNER JOIN stkMoviCabe stkMoviCabe1 ON 
		stkMoviCabe1.stkMoviCabe = proOrdenStock.stkMoviCabe and 
		stkMoviCabe1.Signo = -1 
		INNER JOIN stkMoviCuerpo stkMoviCuerpo1 on
			stkMoviCuerpo1.stkMoviCabe = stkMoviCabe1.stkMoviCabe  
        INNER JOIN conAsientos conAsientos1 on 
		conAsientos1.conAsientos = stkMoviCabe1.stkMoviCabe
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1 and 
			conAsientos1.Anulado = 0 and 
			conAsientos1.Posteado = 1 and 
			stkMoviCabe.Signo = 1 and
			conAsientos1.Fecha between @FechaDesde and @FechaHasta and 
			conAsientos.Fecha between @FechaDesde and @FechaHasta and 
			conAsientos.Empresa_Id = @Empresa_Id),0) as MateriaPrima, 

		isnull((SELECT sum(proMovCierreTrabajos3.Cantidad * proMovCierreTrabajos3.Precio*proOrdenStockCosto.PorcentajeCosto/100) 
		from proMovCierreOrden
		INNER JOIN proOrden ON	proOrden.proOrden = proMovCierreOrden.proOrden 
		INNER JOIN proOrdenStockCosto on
		proMovCierreOrden.proMovCierreOrden = proOrdenStockCosto.proMovCierreOrden 
		inner join stkMoviCabe on	proOrdenStockCosto.stkMoviCabe = stkMoviCabe.stkMoviCabe
		INNER JOIN conAsientos ON  conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		INNER JOIN stkMoviCuerpo ON
			stkMoviCuerpo.stkMoviCabe = proOrdenStockCosto.stkMoviCabe  and 
			stkMoviCuerpo.Renglon =  proOrdenStockCosto.Renglon and 
			stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
			inner join proMovCierreTrabajos3 ON
				proMovCierreTrabajos3.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
			INNER JOIN conAsientos conAsientos1 ON 
			conAsientos1.conAsientos = proMovCierreOrden.proMovCierreOrden
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1 and 
			conAsientos1.Anulado = 0 and 
			conAsientos1.Posteado = 1 and 
			stkMoviCabe.Signo = 1 and
			conAsientos1.Fecha between @FechaDesde and @FechaHasta and 
			conAsientos.Fecha between @FechaDesde and @FechaHasta and 
			conAsientos.Empresa_Id = @Empresa_Id),0) as Trabajo3, 

					isnull((SELECT sum(proMovCierreRecursos.Cantidad*proMovCierreRecursos.Costo*proOrdenStockCosto.PorcentajeCosto/100) 
		from proMovCierreOrden
		INNER JOIN proOrden ON	proOrden.proOrden = proMovCierreOrden.proOrden 
		INNER JOIN proOrdenStockCosto on
		proMovCierreOrden.proMovCierreOrden = proOrdenStockCosto.proMovCierreOrden 
		inner join stkMoviCabe on	proOrdenStockCosto.stkMoviCabe = stkMoviCabe.stkMoviCabe
		INNER JOIN conAsientos ON  conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		INNER JOIN stkMoviCuerpo ON
			stkMoviCuerpo.stkMoviCabe = proOrdenStockCosto.stkMoviCabe  and 
			stkMoviCuerpo.Renglon =  proOrdenStockCosto.Renglon and 
			stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
			inner join proMovCierreRecursos ON
				proMovCierreRecursos.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
			INNER JOIN conAsientos conAsientos1 ON 
			conAsientos1.conAsientos = proMovCierreOrden.proMovCierreOrden
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1 and 
			conAsientos1.Anulado = 0 and 
			conAsientos1.Posteado = 1 and 
			stkMoviCabe.Signo = 1 and
			conAsientos1.Fecha between @FechaDesde and @FechaHasta and 
			conAsientos.Fecha between @FechaDesde and @FechaHasta and 
			conAsientos.Empresa_Id = @Empresa_Id),0) as Recursos

from stkProductos INNER JOIN stkUniMed ON 
stkUniMed.stkUniMed = stkProductos.Medida_Id
WHERE
	stkproductos.Producto_Id between @ProductoDesde And @ProductoHasta and 
		isnull((SELECT sum(stkMoviCuerpo.Cantidad) from proMovCierreOrden 
		INNER JOIN proOrden ON	proOrden.proOrden = proMovCierreOrden.proOrden 
		INNER JOIN proOrdenStockCosto on
		proMovCierreOrden.proMovCierreOrden = proOrdenStockCosto.proMovCierreOrden 
		inner join stkMoviCabe on	proOrdenStockCosto.stkMoviCabe = stkMoviCabe.stkMoviCabe
		INNER JOIN conAsientos ON  conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		INNER JOIN stkMoviCuerpo ON
			stkMoviCuerpo.stkMoviCabe = proOrdenStockCosto.stkMoviCabe  and 
			stkMoviCuerpo.Renglon =  proOrdenStockCosto.Renglon and 
			stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1 and 
			stkMoviCabe.Signo = 1 and
			conAsientos.Fecha between @FechaDesde and @FechaHasta and 
			conAsientos.Empresa_Id = @Empresa_Id),0) > 0
	ORDER BY 1
GO


