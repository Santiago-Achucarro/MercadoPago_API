-- INF_stkRemiPendFact '20180731', 1
DROP PROCEDURE INF_stkRemiPendFact
GO
CREATE PROCEDURE INF_stkRemiPendFact
(
	@FechaHasta DateTime, 
	@Empresa_Id Int
)
AS

SELECT  genAsiSegmentos.Asiento_Id, conAsientos.Fecha, stkMoviCuerpo.Renglon, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) as Comprobante, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkMoviCuerpo.Cantidad,
	stkRemiPendFact.CantidadPendiente -
	ISNULL((select  Cantidad FROM venMovStkHist, conAsientos as Factura	
		WHERE
			venMovStkHist.stkMoviCabe = stkRemiPendFact.stkMoviCabe and 
			venMovStkHist.Renglon =stkRemiPendFact.Renglon and 
			Factura.conAsientos = venMovStkHist.venMovimientos AND 
			Factura.Anulado = 0 AND 
			Factura.Fecha > @FechaHasta),0) as CantidadPendiente,
	
	stkMoviCuerpo.CostoUnitario, 
	Convert(numeric(18,2), 	(stkRemiPendFact.CantidadPendiente -
		ISNULL((select Cantidad FROM venMovStkHist, conAsientos as Factura	
		WHERE
			venMovStkHist.stkMoviCabe = stkRemiPendFact.stkMoviCabe and 
			venMovStkHist.Renglon =stkRemiPendFact.Renglon and 
			Factura.conAsientos = venMovStkHist.venMovimientos AND 
			Factura.Anulado = 0 AND 
			Factura.Fecha > @FechaHasta),0))  *stkMoviCuerpo.CostoUnitario) AS Total
	FROM genAsiSegmentos 
	inner join conAsientos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN stkRemitos ON stkRemitos.stkMoviCabe = conAsientos.conAsientos
	INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkRemitos.stkMoviCabe 
	INNER JOIN stkRemiPendFact ON stkRemiPendFact.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
		stkRemiPendFact.Renglon =stkMoviCuerpo.Renglon
	INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN venClientes ON venClientes.genEntidades = stkRemitos.Cliente_Id
	INNER JOIN genSucursalesEmpr ON 
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	where
		conAsientos.Anulado = 0 and 
		conAsientos.Empresa_Id = @Empresa_Id AND 
		conAsientos.Fecha <= @FechaHasta AND 
		stkRemiPendFact.CantidadPendiente -
		ISNULL((select  Cantidad FROM venMovStkHist, conAsientos as Factura	
		WHERE
			venMovStkHist.stkMoviCabe = stkRemiPendFact.stkMoviCabe and 
			venMovStkHist.Renglon =stkRemiPendFact.Renglon and 
			Factura.conAsientos = venMovStkHist.venMovimientos AND 
			Factura.Anulado = 0 AND 
			Factura.Fecha > @FechaHasta),0) > 0
		
order by 2,3