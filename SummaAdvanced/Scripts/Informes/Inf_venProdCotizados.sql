DROP PROCEDURE Inf_venProdCotizados
GO
CREATE PROCEDURE Inf_venProdCotizados(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@Resumido Bit,
	@PorFamilia Bit,
	@Empresa_Id Int

)
as

if @Resumido = 1
begin
SELECT venCotizaciones.Fecha, 
	dbo.Segmento(venCotizSegmento.Segmento_Id, venCotizSegmento.Segmento1C, venCotizSegmento.Segmento2C, 
	venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, venCotizSegmento.Segmento1N, 
	venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N ) AS Cotizacion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, 
	venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVendedor,
	SUM(CONVERT(numeric(18,2), venCotizCuerpo.CantidadOriginal*venCotizCuerpo.PrecioVenta)) as SubTotal
FROM venCotizaciones 
INNER JOIN venCotizSegmento ON  venCotizSegmento.venCotizaciones = venCotizaciones.venCotizaciones
INNER JOIN venClientes ON  venClientes.genEntidades = venCotizaciones.Cliente_Id
INNER JOIN venCotizCuerpo ON venCotizCuerpo.Cotizacion_Id = venCotizaciones.venCotizaciones
INNER JOIN stkProductos ON  stkProductos.stkProductos = venCotizCuerpo.Producto_Id 
INNER JOIN stkUniMed ON stkUniMed.stkUniMed =venCotizCuerpo.Medida_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = venCotizaciones.Moneda_Id
LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
inner join venVendedores ON venVendedores.venVendedores = venCotizaciones.Vendedor_Id
WHERE
	venCotizaciones.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
	venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta AND 
	stkProductos.Producto_Id BETWEEN @ProductoDesde And @ProductoHasta AND
	ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde and @FamiliaHasta and 
	venCotizaciones.Empresa_Id = @Empresa_Id and 
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta 
GROUP BY venCotizaciones.Fecha, 
	venCotizSegmento.Segmento_Id, venCotizSegmento.Segmento1C, venCotizSegmento.Segmento2C, 
	venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, venCotizSegmento.Segmento1N, 
	venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N , 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, venVendedores.Vendedor_Id, venVendedores.Nombre 
ORDER BY 1, 2, 7
end
else
if @PorFamilia = 1
begin
SELECT venCotizaciones.Fecha, 
	dbo.Segmento(venCotizSegmento.Segmento_Id, venCotizSegmento.Segmento1C, venCotizSegmento.Segmento2C, 
	venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, venCotizSegmento.Segmento1N, 
	venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N ) AS Cotizacion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, 
	venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVendedor,
	stkFamilias.Familia_Id as Producto_Id, stkFamilias.Descripcion,
	SUM(CONVERT(numeric(18,2), venCotizCuerpo.CantidadOriginal*venCotizCuerpo.PrecioVenta)) as SubTotal
FROM venCotizaciones 
INNER JOIN venCotizSegmento ON  venCotizSegmento.venCotizaciones = venCotizaciones.venCotizaciones
INNER JOIN venClientes ON  venClientes.genEntidades = venCotizaciones.Cliente_Id
INNER JOIN venCotizCuerpo ON venCotizCuerpo.Cotizacion_Id = venCotizaciones.venCotizaciones
INNER JOIN stkProductos ON  stkProductos.stkProductos = venCotizCuerpo.Producto_Id 
INNER JOIN stkUniMed ON stkUniMed.stkUniMed =venCotizCuerpo.Medida_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = venCotizaciones.Moneda_Id
LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
inner join venVendedores ON venVendedores.venVendedores = venCotizaciones.Vendedor_Id
WHERE
	venCotizaciones.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
	venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta AND 
	stkProductos.Producto_Id BETWEEN @ProductoDesde And @ProductoHasta AND
	ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde and @FamiliaHasta and 
	venCotizaciones.Empresa_Id = @Empresa_Id and 
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta 
GROUP BY venCotizaciones.Fecha, 
	venCotizSegmento.Segmento_Id, venCotizSegmento.Segmento1C, venCotizSegmento.Segmento2C, 
	venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, venCotizSegmento.Segmento1N, 
	venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N , 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, 
	venVendedores.Vendedor_Id, venVendedores.Nombre , stkFamilias.Familia_Id , stkFamilias.Descripcion
ORDER BY 1, 2, 7
end
else
begin
SELECT venCotizaciones.Fecha, 
	dbo.Segmento(venCotizSegmento.Segmento_Id, venCotizSegmento.Segmento1C, venCotizSegmento.Segmento2C, 
	venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, venCotizSegmento.Segmento1N, 
	venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N ) AS Cotizacion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, 
	venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVendedor,
	venCotizCuerpo.Renglon_Co, stkProductos.Producto_Id, 
	stkProductos.Descripcion, stkUniMed.Medida_Id, venCotizCuerpo.CantidadOriginal, 
	venCotizCuerpo.PrecioVenta, CONVERT(numeric(18,2), venCotizCuerpo.CantidadOriginal*venCotizCuerpo.PrecioVenta) as SubTotal
FROM venCotizaciones 
INNER JOIN venCotizSegmento ON  venCotizSegmento.venCotizaciones = venCotizaciones.venCotizaciones
INNER JOIN venClientes ON  venClientes.genEntidades = venCotizaciones.Cliente_Id
INNER JOIN venCotizCuerpo ON venCotizCuerpo.Cotizacion_Id = venCotizaciones.venCotizaciones
INNER JOIN stkProductos ON  stkProductos.stkProductos = venCotizCuerpo.Producto_Id 
INNER JOIN stkUniMed ON stkUniMed.stkUniMed =venCotizCuerpo.Medida_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = venCotizaciones.Moneda_Id
LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
inner join venVendedores ON venVendedores.venVendedores = venCotizaciones.Vendedor_Id
WHERE
	venCotizaciones.Fecha BETWEEN @FechaDesde AND @FechaHasta AND 
	venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta AND 
	stkProductos.Producto_Id BETWEEN @ProductoDesde And @ProductoHasta AND
	ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde and @FamiliaHasta and 
	venCotizaciones.Empresa_Id = @Empresa_Id and 
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta 
ORDER BY 1, 2, 7
end
GO
