-- Inf_venRemiPendFact ' ','ZZZ','','ZZZZZZZZZZZZ',1
DROP Procedure Inf_venRemiPendFact
GO
CREATE Procedure Inf_venRemiPendFact(
	@SucursalDesde VarChar(25),
	@SucursalHasta VarChar(25),
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Empresa_Id int
)
AS
SELECT venClientes.Cliente_Id, venClientes.RazonSocial, 
	genAsiSegmentos.Asiento_Id, conAsientos.Fecha, stkMoviCuerpo.Renglon, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) as Comprobante, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkRemiPendFact.CantidadPendiente , stkMoviCuerpo.Cantidad, 
		stkMoviCuerpo.PrecioOriginal, stkMoviCuerpo.CostoUnitario, 
		ROUND(stkMoviCuerpo.PrecioOriginal*stkMoviCuerpo.Cantidad,2) AS MontoaFactSinIvA,
		ROUND(stkMoviCuerpo.CostoUnitario*stkMoviCuerpo.Cantidad,2) AS CostoTotal
	FROM genAsiSegmentos inner join conAsientos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN stkRemitos ON 
	stkRemitos.stkMoviCabe = conAsientos.conAsientos
	INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = stkRemitos.stkMoviCabe 
	INNER JOIN stkRemiPendFact ON 
	stkRemiPendFact.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
	stkRemiPendFact.Renglon =stkMoviCuerpo.Renglon
	INNER JOIN stkProductos ON 
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	INNER JOIN stkUniMed ON 
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN venClientes ON
	venClientes.genEntidades = stkRemitos.Cliente_Id
	INNER JOIN genSucursalesEmpr ON 
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	where
		conAsientos.Anulado = 0 and 
		conAsientos.Empresa_Id = @Empresa_Id AND 
		stkRemiPendFact.CantidadPendiente > 0 AND 
		genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and
		venClientes.Cliente_Id BETWEEN @ClienteDesde and @ClienteHasta
UNION ALL
SELECT venClientes.Cliente_Id, venClientes.RazonSocial, 
	genAsiSegmentos.Asiento_Id, conAsientos.Fecha, venPediRemitidos.Renglon, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) as Comprobante, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	(venPediCuerpo.CantidadRemitida-venPediCuerpo.CantidadFacturada) CantidadPendiente, 
	stkMoviCuerpo.Cantidad, stkMoviCuerpo.PrecioOriginal, stkMoviCuerpo.CostoUnitario, 
		ROUND(stkMoviCuerpo.PrecioOriginal*stkMoviCuerpo.Cantidad,2) AS MontoaFactSinIvA,
		ROUND(stkMoviCuerpo.CostoUnitario*stkMoviCuerpo.Cantidad,2) AS CostoTotal 
FROM venPedidos 
	INNER JOIN venPediCuerpo ON venPedidos.venPedidos = venPediCuerpo.venPedidos
	INNER JOIN venPediRemitidos ON venPediCuerpo.venPedidos = venPediRemitidos.venPedidos AND
		venPediCuerpo.Renglon_Pe = venPediRemitidos.Renglon_Pe
	INNER JOIN stkMoviCuerpo ON venPediRemitidos.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND	
		venPediRemitidos.Renglon = stkMoviCuerpo.Renglon
	INNER JOIN conAsientos ON venPediRemitidos.stkMoviCabe = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN stkProductos ON 
	stkProductos.stkProductos = venPediCuerpo.Producto_Id
	INNER JOIN stkUniMed ON 
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN venClientes ON
	venClientes.genEntidades = venPedidos.Cliente_Id
	INNER JOIN genSucursalesEmpr ON 
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id AND 
	(venPediCuerpo.CantidadRemitida-venPediCuerpo.CantidadFacturada) > 0 AND 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and
	venClientes.Cliente_Id BETWEEN @ClienteDesde and @ClienteHasta AND
	NOT EXISTS (SELECT 1 FROM venPedidosAnul WHERE venPedidos.venNroPedido = venPedidosAnul.venPedidos)
ORDER BY 1,4