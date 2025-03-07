DROP PROCEDURE Inf_venRemiFactAsoc 
GO

CREATE PROCEDURE Inf_venRemiFactAsoc 
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@SucursalDesde VarChar(25),
	@SucursalHasta VarChar(25),
	@Empresa_Id Int
)
AS

SELECT distinct genAsiSegmentos.Asiento_Id, conAsientos.Fecha as FechaRemito, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) as Remito,

	dbo.Segmento(genAsiSegmentosF.Segmento_Id, genAsiSegmentosF.Segmento1C, 
	genAsiSegmentosF.Segmento2C,genAsiSegmentosF.Segmento3C, genAsiSegmentosF.Segmento4C, 
	genAsiSegmentosF.Segmento1N, genAsiSegmentosF.Segmento2N, genAsiSegmentosF.Segmento3N, 
	genAsiSegmentosF.Segmento4N) as factura, 
	conAsientosF.Fecha as FechaFactura , 
	venClientes.Cliente_Id, venClientes.RazonSocial
FROM genAsiSegmentos 
INNER JOIN conAsientos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN stkRemitos ON stkRemitos.stkMoviCabe =conAsientos.conAsientos
INNER JOIN venMovStkHist ON venMovStkHist.stkMoviCabe = stkRemitos.stkMoviCabe
INNER JOIN genAsiSegmentos genAsiSegmentosF ON genAsiSegmentosF.Asiento_Id = venMovStkHist.venMovimientos
INNER JOIN conAsientos conAsientosF ON conAsientosF.conAsientos = genAsiSegmentosF.Asiento_Id
INNER JOIN venClientes ON venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE conAsientos.Anulado = 0 AND
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientosF.Fecha between @FechaDesde and @FechaHasta and 
	venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta
order by 2,1
GO