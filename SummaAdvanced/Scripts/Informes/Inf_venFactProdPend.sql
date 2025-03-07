-- Inf_venFactProdPend ' ','ZZZ', 1
DROP Procedure Inf_venFactProdPend
GO
CREATE Procedure Inf_venFactProdPend(
	@SucursalDesde VarChar(25),
	@SucursalHasta VarChar(25),
	@Empresa_Id int
)

AS

SELECT  genAsiSegmentos.Asiento_Id, conAsientos.Fecha, venMovConStockCr.RenglonCuerpo, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) as Comprobante, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	venMovConStockCr.CantPendiente , venMovConStockCr.CantFacturada
	FROM genAsiSegmentos inner join conAsientos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN venMovimientos ON 
	venMovimientos.venMovimientos = conAsientos.conAsientos
	INNER JOIN venMovConStockCr ON 
	venMovConStockCr.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN stkProductos ON 
	stkProductos.stkProductos = venMovConStockCr.Producto_Id
	INNER JOIN stkUniMed ON 
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN venClientes ON
	venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN genSucursalesEmpr ON 
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	where
		venMovimientos.venTipoMov = 'F' AND 
		conAsientos.Anulado = 0 and 
		conAsientos.Empresa_Id = @Empresa_Id AND 
		venMovConStockCr.CantPendiente > 0 AND 
		genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta
order by 2,3