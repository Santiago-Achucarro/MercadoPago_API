--EXEC Inf_venVentasPeriodo '20200401','20200430',' ','ZZZ',' ','ZZZ',' ','ZZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ','V',1,1
--EXEC Inf_venVentasPeriodo '20200101','20200131',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ','C',1,1
--EXEC Inf_venVentasPeriodo '20200101','20200131',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ','V',1,1
--EXEC Inf_venVentasPeriodo '20200401','20200430',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ','Z',1,1
--EXEC Inf_venVentasPeriodo '20200401','20200430',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ','U',1,1
--SELECT * FROM venVendedores
DROP PROCEDURE Inf_venVentasPeriodo
GO
CREATE PROCEDURE Inf_venVentasPeriodo
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@ZonaDesde VarChar(5),
	@ZonaHasta VarChar(5),
	@RegionDesde VarChar(5),
	@RegionHasta VarChar(5),
	@SucursalDesde VarChar(5),
	@SucursalHasta VarChar(5),
	@TipomovDesde Char(1),
	@TipomovHasta Char(1),
	@SubTipomovDesde Char(5),
	@SubTipomovHasta Char(5),
	@TipoRepo Char(1),
	@Resumido bit,
	@Empresa_Id Int
	
)
AS

IF @Resumido = 0
Begin
SELECT case @TipoRepo when 'C' THEN venClientes.Cliente_Id  
	WHEN 'V' THEN venVendedores.Vendedor_Id
	WHEN 'Z' Then venZona.Zona_Id
	WHEN 'R' Then venRegion.Region_Id
	WHEN 'S' Then genSucursalesEmpr.Sucursal 
	WHEN 'T' Then venTipoMov.venTipoMov
	WHEN 'U' Then venSubTipoMov.SubTipoMov_Id 	end as Entidad,
	case @TipoRepo when 'C' THEN venClientes.RazonSocial
	WHEN 'V' THEN venVendedores.Nombre
	WHEN 'Z' Then venZona.Descripcion
	WHEN 'R' Then venRegion.Descripcion
	WHEN 'S' Then genSucursalesEmpr.Descripcion 
	WHEN 'T' Then venTipoMov.Descripcion 
	WHEN 'U' Then venSubTipoMov.Descripcion end as DescripcionEntidad,
venClientes.Cliente_Id, venClientes.RazonSocial, conAsientos.Fecha,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Comprobante,
	Convert(Numeric(18,2),ISNULL((SELECT 
		ROUND(SUM(venMovConStockCr.PrecioForm*venMovConStockCr.CantOriginal),2) 
		FROM venMovConStockCr Where 
			venMovConStockCr.venMovimientos= venMovimientos.venMovimientos),venMovimientos.SubTotal)*venTipomov.Signo) SubTotal, 
	Convert(Numeric(18,2),(ISNULL((SELECT ROUND(SUM(venMovConStockCr.PrecioForm*venMovConStockCr.CantOriginal),2)
			FROM venMovConStockCr Where 
			venMovConStockCr.venMovimientos= venMovimientos.venMovimientos), venMovimientos.SubTotal) 
			- (ISNULL((SELECT ROUND(SUM(venMovConStockCr.PrecioVenta*venMovConStockCr.CantOriginal),2)
			FROM venMovConStockCr Where 
			venMovConStockCr.venMovimientos= venMovimientos.venMovimientos) ,venMovimientos.SubTotalBonif)))*venTipomov.Signo) Bonificaciones,
	Convert(Numeric(18,2),
			ISNULL((SELECT ROUND(SUM(venMovConStockCr.PrecioVenta*venMovConStockCr.CantOriginal),2)
			FROM venMovConStockCr Where 
			venMovConStockCr.venMovimientos= venMovimientos.venMovimientos),venMovimientos.SubTotalBonif ))*venTipoMov.Signo as SubTotalBonif, 
	Convert(Numeric(18,2),(Select Sum(Importe) Importe From venMovImpuestos Where venMovimientos.venMovimientos = venMovImpuestos.venMovimientos)*venTipomov.Signo) Impuestos,
	venMovimientos.Importe*venTipomov.Signo Importe, 
	venVendedores.Vendedor_Id, venVendedores.Nombre, venZona.Zona_Id, venZona.Descripcion as DescripcionZona, 
	venRegion.Region_Id, venRegion.Descripcion as DescripcionRegion, genSucursalesEmpr.Sucursal, 
	genSucursalesEmpr.Descripcion  as DescripcionSucursal, genMonedas.Moneda_Id, conAsientos.Cambio
	FROM venMovimientos 
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
	INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id AND 
		venClieHabitual.Sucursal = venMovimientos.Sucursal
	INNER JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id 
	INNER JOIN venRegion ON venRegion.venRegion = venClieHabitual.Region_Id
	INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	INNER JOIN genMonedas ON genMonedas.genMonedas = conASientos.Moneda_Id

WHERE
	
	venSubTipoMov.AfectaEstadistica = 1 AND 
	venMovimientos.VenTipoMov <> 'C' AND
	conAsientos.Anulado = 0 AND 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id AND 
	venClientes.Cliente_Id Between @ClienteDesde AND @ClienteHasta AND
	conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
	venZona.Zona_Id Between @ZonaDesde and @ZonaHasta and
	venRegion.Region_Id Between @RegionDesde and @RegionHasta and
	genSucursalesEmpr.Sucursal Between @SucursalDesde and @SucursalHasta and 
	venMovimientos.VenTipoMov between @TipomovDesde and @TipomovHasta and
	venSubTipoMov.SubTipoMov_Id between @SubTipomovDesde and @SubTipomovHasta


ORDER BY 1,5,6
end
else
begin
SELECT Entidad, DescripcionEntidad, SUM(SubTotal*cambio) SubTotal, 
	Sum(Bonificaciones*cambio) as Bonificaciones,
	SUM(SubTotal*cambio) -	Sum(Bonificaciones*cambio) as Neto,
	Sum(Impuestos*cambio) Impuestos, 
	SUM(Importe*cambio) as Importe
FROM 
(
SELECT case @TipoRepo when 'C' THEN venClientes.Cliente_Id  
	WHEN 'V' THEN venVendedores.Vendedor_Id
	WHEN 'Z' Then venZona.Zona_Id
	WHEN 'R' Then venRegion.Region_Id
	WHEN 'S' Then genSucursalesEmpr.Sucursal 
	WHEN 'T' Then venTipoMov.venTipoMov
	WHEN 'U' Then venSubTipoMov.SubTipoMov_Id 	end as Entidad,
	case @TipoRepo when 'C' THEN venClientes.RazonSocial
	WHEN 'V' THEN venVendedores.Nombre
	WHEN 'Z' Then venZona.Descripcion
	WHEN 'R' Then venRegion.Descripcion
	WHEN 'S' Then genSucursalesEmpr.Descripcion 
	WHEN 'T' Then venTipoMov.Descripcion 
	WHEN 'U' Then venSubTipoMov.Descripcion end as DescripcionEntidad,
venClientes.Cliente_Id, venClientes.RazonSocial, conAsientos.Fecha,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Comprobante,
	Convert(Numeric(18,2),ISNULL((SELECT 
		ROUND(SUM(venMovConStockCr.PrecioForm*venMovConStockCr.CantOriginal),2) 
		FROM venMovConStockCr Where 
			venMovConStockCr.venMovimientos= venMovimientos.venMovimientos),venMovimientos.SubTotal)*venTipomov.Signo) SubTotal, 
	Convert(Numeric(18,2),(ISNULL((SELECT ROUND(SUM(venMovConStockCr.PrecioForm*venMovConStockCr.CantOriginal),2)
			FROM venMovConStockCr Where 
			venMovConStockCr.venMovimientos= venMovimientos.venMovimientos), venMovimientos.SubTotal) 
			- (ISNULL((SELECT ROUND(SUM(venMovConStockCr.PrecioVenta*venMovConStockCr.CantFacturada),2)
			FROM venMovConStockCr Where 
			venMovConStockCr.venMovimientos= venMovimientos.venMovimientos) ,venMovimientos.SubTotalBonif)))*venTipomov.Signo) Bonificaciones,
	Convert(Numeric(18,2),
			ISNULL((SELECT ROUND(SUM(venMovConStockCr.PrecioVenta*venMovConStockCr.CantFacturada),2)
			FROM venMovConStockCr Where 
			venMovConStockCr.venMovimientos= venMovimientos.venMovimientos),venMovimientos.SubTotalBonif *venTipoMov.Signo)) as SubTotalBonif, 
	Convert(Numeric(18,2),(Select Sum(Importe) Importe From venMovImpuestos Where venMovimientos.venMovimientos = venMovImpuestos.venMovimientos))*venTipomov.Signo Impuestos,
	venMovimientos.Importe*venTipomov.Signo Importe, 
	venVendedores.Vendedor_Id, venVendedores.Nombre, venZona.Zona_Id, venZona.Descripcion as DescripcionZona, 
	venRegion.Region_Id, venRegion.Descripcion as DescripcionRegion, genSucursalesEmpr.Sucursal, 
	genSucursalesEmpr.Descripcion  as DescripcionSucursal, genMonedas.Moneda_Id, conAsientos.Cambio
FROM venMovimientos 
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
	INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id AND 
		venClieHabitual.Sucursal = venMovimientos.Sucursal
	INNER JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id 
	INNER JOIN venRegion ON venRegion.venRegion = venClieHabitual.Region_Id
	INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	INNER JOIN genMonedas ON genMonedas.genMonedas = conASientos.Moneda_Id

WHERE
	
	venSubTipoMov.AfectaEstadistica = 1 AND 
	venMovimientos.VenTipoMov <> 'C' AND
	conAsientos.Anulado = 0 AND 
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @Empresa_Id AND 
	venClientes.Cliente_Id Between @ClienteDesde AND @ClienteHasta AND
	conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
	venZona.Zona_Id Between @ZonaDesde and @ZonaHasta and
	venRegion.Region_Id Between @RegionDesde and @RegionHasta and
	genSucursalesEmpr.Sucursal Between @SucursalDesde and @SucursalHasta and 
	venMovimientos.VenTipoMov between @TipomovDesde and @TipomovHasta and
	venSubTipoMov.SubTipoMov_Id between @SubTipomovDesde and @SubTipomovHasta) AS XXX

GROUP BY Entidad, DescripcionEntidad
ORDER BY 1
end

GO



