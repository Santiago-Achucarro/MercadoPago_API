Drop procedure Inf_venAbonos
Go
Create procedure Inf_venAbonos
(
@TipoInforme char(1),
@FechaDesde datetime,
@FechaHasta datetime,
@ClienteDesde varchar(15),
@ClienteHasta varchar(15),
@VendedorDesde varchar(5),
@VendedorHasta varchar(5)
)
As
Select dbo.Segmento(venAbonosSegmentos.Segmento_Id, venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C,
venAbonosSegmentos.Segmento3C, venAbonosSegmentos.Segmento4C, venAbonosSegmentos.Segmento1N, venAbonosSegmentos.Segmento2N,
venAbonosSegmentos.Segmento3N, venAbonosSegmentos.Segmento4N) Abono, venClientes.Cliente_Id, venClientes.RazonSocial,
stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProducto, venMovConStockCr.CantOriginal, venMovConStockCr.PrecioForm,
genMonedas.Moneda_Id,
conAsientos.Fecha, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Factura
From venAbonos
Inner Join venAbonosSegmentos On venAbonosSegmentos.venAbonos = venAbonos.venAbonos
Inner Join venClientes On venClientes.genEntidades = venAbonos.Cliente_Id
--Inner Join venAbonosCuerpo On venAbonosCuerpo.venAbonos = venAbonos.venAbonos
Inner Join venAbonosFacturas On venAbonosFacturas.venAbonos = venAbonos.venAbonos
Inner Join conAsientos On conAsientos.conAsientos = venAbonosFacturas.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join venMovConStockCr On venMovConStockCr.venMovimientos = conasientos.conAsientos
Inner Join stkProductos On stkProductos.stkProductos = venMovConStockCr.Producto_Id
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join venMovimientos On venMovimientos.venMovimientos = conAsientos.conAsientos
Inner Join venVendedores On venVendedores.venVendedores = venMovimientos.Vendedor_Id
Where @TipoInforme = 'F'
And conAsientos.Fecha Between @FechaDesde And @FechaHasta
And venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta
And venVendedores.Vendedor_Id Between @VendedorDesde And @VendedorHasta
Union All
Select dbo.Segmento(venAbonosSegmentos.Segmento_Id, venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C,
venAbonosSegmentos.Segmento3C, venAbonosSegmentos.Segmento4C, venAbonosSegmentos.Segmento1N, venAbonosSegmentos.Segmento2N,
venAbonosSegmentos.Segmento3N, venAbonosSegmentos.Segmento4N) Abono, venClientes.Cliente_Id, venClientes.RazonSocial,
stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProducto, venAbonosCuerpo.CantidadOriginal, venAbonosCuerpo.PrecioListaForm,
genMonedas.Moneda_Id, venAbonos.FechaProxFacturacion, '' Factura
From venAbonos
Inner Join venAbonosSegmentos On venAbonosSegmentos.venAbonos = venAbonos.venAbonos
Inner Join venClientes On venClientes.genEntidades = venAbonos.Cliente_Id
Inner Join venAbonosCuerpo On venAbonosCuerpo.venAbonos = venAbonos.venAbonos
Inner Join stkProductos On stkProductos.stkProductos = venAbonosCuerpo.Producto_Id
Inner Join genMonedas On genMonedas.genMonedas = venAbonos.Moneda_Id
Inner Join venVendedores On venVendedores.venVendedores = venAbonos.Vendedor_Id
Where @TipoInforme = 'P'
And venAbonos.FechaProxFacturacion Between @FechaDesde And @FechaHasta
And venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta
And venVendedores.Vendedor_Id Between @VendedorDesde And @VendedorHasta



