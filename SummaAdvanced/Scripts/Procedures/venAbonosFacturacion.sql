--Exec venAbonosFacturacionDatos 1, 'CICLOABONO', 8, 0, 0, 0, '1030', '', '', ''

Drop procedure venAbonosFacturacionDatos
GO

Create procedure venAbonosFacturacionDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
As

Declare @lAbonoFacturacion int
Select @lAbonoFacturacion = venAbonosFacturacion.venAbonosFacturacion 
From venAbonosFacturacion
Inner Join venAbonosFactuSegmentos On venAbonosFactuSegmentos.venAbonosFacturacion = venAbonosFacturacion.venAbonosFacturacion
Where
	venAbonosFactuSegmentos.Empresa_id = @pEmpresa_Id and 
	venAbonosFactuSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	venAbonosFactuSegmentos.Segmento1N = @pSegmento1N and 
	venAbonosFactuSegmentos.Segmento2N = @pSegmento2N and 
	venAbonosFactuSegmentos.Segmento3N = @pSegmento3N and 
	venAbonosFactuSegmentos.Segmento4N = @pSegmento4N and 
	venAbonosFactuSegmentos.Segmento1C = @pSegmento1C and 
	venAbonosFactuSegmentos.Segmento2C = @pSegmento2C and 
	venAbonosFactuSegmentos.Segmento3C = @pSegmento3C and 
	venAbonosFactuSegmentos.Segmento4C = @pSegmento4C

Select venAbonosFacturacion.venAbonosFacturacion, genSegmentos.Segmento_Id, venAbonosFactuSegmentos.Segmento1C, venAbonosFactuSegmentos.Segmento2C,
venAbonosFactuSegmentos.Segmento3C, venAbonosFactuSegmentos.Segmento4C, venAbonosFactuSegmentos.Segmento1N, venAbonosFactuSegmentos.Segmento2N,
venAbonosFactuSegmentos.Segmento3N, venAbonosFactuSegmentos.Segmento4N,
FechaDesde, FechaHasta, FechaEmision, isNull(venAbonosFacturacion.ClienteDesde, '') ClienteDesde, isNull(venClientesD.RazonSocial, '') ClienteDesdeDescripcion, 
isNull(venAbonosFacturacion.ClienteHasta, '') ClienteHasta, isNull(venClientesD.RazonSocial, '') ClienteHastaDescripcion, 
isNull(VendedorDesde, '') VendedorDesde, isNull(venVendedoresD.Nombre, '') VendedorDesdeDescripcion, 
isNull(VendedorHasta, '') VendedorHasta, isNull(venVendedoresH.Nombre, '') VendedorHastaDescripcion, 
isNull(MonedaDesde, '') MonedaDesde, isNull(genMonedasD.Descripcion, '') MonedaDesdeDescripcion, 
isNull(MonedaHasta, '') MonedaHasta, isNull(genMonedasH.Descripcion, '') MonedaHastaDescripcion
From venAbonosFacturacion
Left Join venClientes venClientesD On venClientesD.Cliente_Id = venAbonosFacturacion.ClienteDesde
Left Join venClientes venClientesH On venClientesH.Cliente_Id = venAbonosFacturacion.ClienteHasta
Left Join venVendedores venVendedoresD On venVendedoresD.Vendedor_Id = venAbonosFacturacion.VendedorDesde
Left Join venVendedores venVendedoresH On venVendedoresH.Vendedor_Id = venAbonosFacturacion.VendedorDesde
Left Join genMonedas genMonedasD On genMonedasD.Moneda_Id = venAbonosFacturacion.MonedaDesde
Left Join genMonedas genMonedasH On genMonedasH.Moneda_Id = venAbonosFacturacion.MonedaDesde
Inner Join venAbonosFactuSegmentos On venAbonosFactuSegmentos.venAbonosFacturacion = venAbonosFacturacion.venAbonosFacturacion
Inner Join genSegmentos On genSegmentos.genSegmentos = venAbonosFactuSegmentos.Segmento_Id
Where venAbonosFacturacion.venAbonosFacturacion = @lAbonoFacturacion


Select venAbonos.venAbonos, venMovConStockCr.RenglonCuerpo Renglon, dbo.Segmento(venAbonosSegmentos.Segmento_Id, venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C,
	venAbonosSegmentos.Segmento2C, venAbonosSegmentos.Segmento4C, venAbonosSegmentos.Segmento1N, venAbonosSegmentos.Segmento2N,
	venAbonosSegmentos.Segmento3N, venAbonosSegmentos.Segmento4N) Abono, genSegmentos.Segmento_Id,
	venAbonosSegmentos.Segmento1N, venAbonosSegmentos.Segmento2N, venAbonosSegmentos.Segmento3N, venAbonosSegmentos.Segmento4N, 
	venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C, venAbonosSegmentos.Segmento3C, venAbonosSegmentos.Segmento4C,venSubTipoMov.SubTipoMov_Id,
	venClientes.Cliente_Id, venAbonos.Sucursal, venClientes.RazonSocial, genMonedas.Moneda_Id, MoneFactu.Moneda_Id MonedaFacturacion,
	venCondPago.CondPagoCli_Id, venListasPrecios.ListaPrecio_Id, venVendedores.Vendedor_Id, venFormaEntrega.FormaEntrega_Id,
	venAbonos.Observaciones, venAbonos.Dato1, venAbonos.Dato2, venAbonos.Dato3, 
	venMovConStockCr.CantOriginal CantidadOriginal, stkUniMed.Medida_Id, venMovConStockCr.Factor, venListasPrecProd.PrecioLista,
	stkProductos.Producto_Id, venMovConStockCr.Observaciones ObservacionRen, stkCondFisVenta.CFVenta_Id, venAbonos.FechaProxFacturacion, 
	dbo.Segmento(dbo.funcFKgenSegmentos('FC'), genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Factura
From venAbonosFacturas
Inner Join venAbonos On venAbonos.venAbonos = venAbonosFacturas.venAbonos
Inner Join venMovConStockCr On venMovConStockCr.venMovimientos = venAbonosFacturas.venMovimientos
Inner Join venAbonosSegmentos On venAbonosSegmentos.venAbonos = venAbonos.venAbonos
Inner Join genSegmentos On genSegmentos.genSegmentos = venAbonosSegmentos.Segmento_Id
Inner Join venClientes On venClientes.genEntidades = venAbonos.Cliente_Id
Inner Join venClieHabitual On venClieHabitual.genEntidades = venAbonos.Cliente_Id And venClieHabitual.Sucursal = venAbonos.Sucursal
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venAbonos.SubTipoMov_Id
Inner Join genMonedas On genMonedas.genMonedas = venAbonos.Moneda_Id
Inner Join genMonedas MoneFactu On MoneFactu.genMonedas = venAbonos.MonedaFacturacion
Inner Join venCondPago On venCondPago.venCondPago = venAbonos.CondPagoCli_Id
Inner Join venListasPrecios On venListasPrecios.venListasPrecios = venAbonos.ListaPrecio_Id
Inner Join venVendedores On venVendedores.venVendedores = venAbonos.Vendedor_Id
Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venAbonos.FormaEntrega_Id
Inner Join stkUniMed On stkUniMed.stkUniMed = venMovConStockCr.Medida_Id
Inner Join venListasPrecProd On venListasPrecProd.ListaPrecio_Id = venAbonos.ListaPrecio_Id And venListasPrecProd.Producto_Id = venMovConStockCr.Producto_Id
Inner Join stkProductos On stkProductos.stkProductos = venMovConStockCr.Producto_Id
Inner Join stkCondFisVenta On stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venAbonosFacturas.venMovimientos
Where venAbonosFacturas.venAbonosFacturacion = @lAbonoFacturacion
Order By 1, 2

Select Distinct Case When MoneFactu.genMonedas <> genEmpresas.Moneda_Id Then MoneFactu.Moneda_Id Else MoneAbono.Moneda_Id End Moneda_Id,
Case When MoneFactu.genMonedas <> genEmpresas.Moneda_Id Then MoneFactu.Descripcion Else MoneAbono.Descripcion End DecripcionMoneda,
dbo.func_TipoCambio(Case When MoneFactu.genMonedas <> genEmpresas.Moneda_Id Then MoneFactu.genMonedas Else MoneAbono.genMonedas End, dbo.FechaActual(),
venAbonos.Empresa_Id) Cambio
From venAbonosFacturas
Inner Join venAbonos On venAbonos.venAbonos = venAbonosFacturas.venAbonos
Inner Join genMonedas MoneAbono On MoneAbono.genMonedas = venAbonos.Moneda_Id
Inner Join genMonedas MoneFactu On MoneFactu.genMonedas = venAbonos.MonedaFacturacion
Inner Join conAsientos On conAsientos.conAsientos = venAbonosFacturas.venMovimientos
Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
Where venAbonosFacturas.venAbonosFacturacion = @lAbonoFacturacion

Go

Drop procedure venAbonosFacturacionCalcular
GO

Create procedure venAbonosFacturacionCalcular
(
@pEmpresa_Id int, 
@pFechaDesde datetime,
@pFechaHasta datetime,
@pClienteDesde varchar(15),
@pClienteHasta varchar(15),
@pVendedorDesde varchar(5),
@pVendedorHasta varchar(5),
@pMonedaDesde varchar(3),
@pMonedaHasta varchar(3)
)
As
Select 0 venAbonosFacturacion, '' Segmento_Id, 
'' Segmento1C, '' Segmento2C, '' Segmento3C, '' Segmento4C, 0 Segmento1N, 0 Segmento2N, 0 Segmento3N, 0 Segmento4N,
@pFechaDesde FechaDesde, @pFechaHasta FechaHasta, dbo.FechaActual() FechaEmision, 
@pClienteDesde ClienteDesde, '' ClienteDesdeDescripcion, @pClienteHasta ClienteHasta, '' ClienteHastaDescripcion,
@pVendedorDesde VendedorDesde, '' VendedorDesdeDescripcion, @pVendedorHasta VendedorHasta, '' VendedorHastaDescripcion, 
@pMonedaDesde MonedaDesde, '' MonedaDesdeDescripcion, @pMonedaHasta MonedaHasta, '' MonedaHastaDescripcion

Select venAbonos.venAbonos, venAbonosCuerpo.Renglon, dbo.Segmento(venAbonosSegmentos.Segmento_Id, venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C,
	venAbonosSegmentos.Segmento2C, venAbonosSegmentos.Segmento4C, venAbonosSegmentos.Segmento1N, venAbonosSegmentos.Segmento2N,
	venAbonosSegmentos.Segmento3N, venAbonosSegmentos.Segmento4N) Abono, genSegmentos.Segmento_Id,
	venAbonosSegmentos.Segmento1N, venAbonosSegmentos.Segmento2N, venAbonosSegmentos.Segmento3N, venAbonosSegmentos.Segmento4N, 
	venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C, venAbonosSegmentos.Segmento3C, venAbonosSegmentos.Segmento4C,venSubTipoMov.SubTipoMov_Id,
	venClientes.Cliente_Id, venAbonos.Sucursal, venClientes.RazonSocial, genMonedas.Moneda_Id, MoneFactu.Moneda_Id MonedaFacturacion,
	venCondPago.CondPagoCli_Id, venListasPrecios.ListaPrecio_Id, venVendedores.Vendedor_Id, venFormaEntrega.FormaEntrega_Id,
	venAbonos.Observaciones, venAbonos.Dato1, venAbonos.Dato2, venAbonos.Dato3, 
	venAbonosCuerpo.CantidadOriginal, stkUniMed.Medida_Id, venAbonosCuerpo.Factor, venListasPrecProd.PrecioLista,
	stkProductos.Producto_Id, venAbonos.Observaciones ObservacionRen, stkCondFisVenta.CFVenta_Id, venAbonos.FechaProxFacturacion, '' Factura
From venAbonos
Inner Join venAbonosCuerpo On venAbonosCuerpo.venAbonos = venAbonos.venAbonos
Inner Join venAbonosSegmentos On venAbonosSegmentos.venAbonos = venAbonos.venAbonos
Inner Join genSegmentos On genSegmentos.genSegmentos = venAbonosSegmentos.Segmento_Id
Inner Join venClientes On venClientes.genEntidades = venAbonos.Cliente_Id
Inner Join venClieHabitual On venClieHabitual.genEntidades = venAbonos.Cliente_Id And venClieHabitual.Sucursal = venAbonos.Sucursal
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venAbonos.SubTipoMov_Id
Inner Join genMonedas On genMonedas.genMonedas = venAbonos.Moneda_Id
Inner Join genMonedas MoneFactu On MoneFactu.genMonedas = venAbonos.MonedaFacturacion
Inner Join venCondPago On venCondPago.venCondPago = venAbonos.CondPagoCli_Id
Inner Join venListasPrecios On venListasPrecios.venListasPrecios = venAbonos.ListaPrecio_Id
Inner Join venVendedores On venVendedores.venVendedores = venAbonos.Vendedor_Id
Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venAbonos.FormaEntrega_Id
Inner Join stkUniMed On stkUniMed.stkUniMed = venAbonosCuerpo.Medida_Id
Inner Join venListasPrecProd On venListasPrecProd.ListaPrecio_Id = venAbonos.ListaPrecio_Id And venListasPrecProd.Producto_Id = venAbonosCuerpo.Producto_Id
Inner Join stkProductos On stkProductos.stkProductos = venAbonosCuerpo.Producto_Id
Inner Join stkCondFisVenta On stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id
Where venAbonos.FechaProxFacturacion Between @pFechaDesde And @pFechaHasta And venAbonos.FechaProxFacturacion <= venAbonos.FechaFin And
venClientes.Cliente_Id Between @pClienteDesde And @pClienteHasta And
venVendedores.Vendedor_Id Between @pVendedorDesde And @pVendedorHasta And
MoneFactu.Moneda_Id Between @pMonedaDesde And @pMonedaHasta And venAbonos.Inactivo = 0
Order By 1, 2

Select Distinct Case When MoneFactu.genMonedas <> genEmpresas.Moneda_Id Then MoneFactu.Moneda_Id Else MoneAbono.Moneda_Id End Moneda_Id,
Case When MoneFactu.genMonedas <> genEmpresas.Moneda_Id Then MoneFactu.Descripcion Else MoneAbono.Descripcion End DecripcionMoneda, 
dbo.func_TipoCambio(Case When MoneFactu.genMonedas <> genEmpresas.Moneda_Id Then MoneFactu.genMonedas Else MoneAbono.genMonedas End, dbo.FechaActual(), 
venAbonos.Empresa_Id) Cambio
From venAbonos
Inner Join venAbonosCuerpo On venAbonosCuerpo.venAbonos = venAbonos.venAbonos
Inner Join venClientes On venClientes.genEntidades = venAbonos.Cliente_Id
Inner Join venVendedores On venVendedores.venVendedores = venAbonos.Vendedor_Id
Inner Join genMonedas MoneFactu On MoneFactu.genMonedas = venAbonos.MonedaFacturacion
Inner Join genMonedas MoneAbono On MoneAbono.genMonedas = venAbonos.Moneda_Id
Inner Join genEmpresas On genEmpresas.genEmpresas = venAbonos.Empresa_Id
Where venAbonos.FechaProxFacturacion Between @pFechaDesde And @pFechaHasta And venAbonos.FechaProxFacturacion <= venAbonos.FechaFin And
venClientes.Cliente_Id Between @pClienteDesde And @pClienteHasta And
venVendedores.Vendedor_Id Between @pVendedorDesde And @pVendedorHasta And
MoneFactu.Moneda_Id Between @pMonedaDesde And @pMonedaHasta And
(MoneFactu.genMonedas <> genEmpresas.Moneda_Id Or MoneAbono.genMonedas <> genEmpresas.Moneda_Id) And venAbonos.Inactivo = 0

Go

DROP PROCEDURE venAbonosFacturacionGuardar
GO
CREATE PROCEDURE venAbonosFacturacionGuardar
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pFechaDesde datetime,
@pFechaHasta datetime,
@pFechaEmision datetime,
@pClienteDesde varchar(15),
@pClienteHasta varchar(15),
@pVendedorDesde varchar(5),
@pVendedorHasta varchar(5),
@pMonedaDesde varchar(3),
@pMonedaHasta varchar(3)
)

As 

Declare @lIdentity int = (Select venAbonosFacturacion
 from venAbonosFactuSegmentos
 Where
	venAbonosFactuSegmentos.Empresa_id = @pEmpresa_Id and 
	venAbonosFactuSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	venAbonosFactuSegmentos.Segmento1N = @pSegmento1N and 
	venAbonosFactuSegmentos.Segmento2N = @pSegmento2N and 
	venAbonosFactuSegmentos.Segmento3N = @pSegmento3N and 
	venAbonosFactuSegmentos.Segmento4N = @pSegmento4N and 
	venAbonosFactuSegmentos.Segmento1C = @pSegmento1C and 
	venAbonosFactuSegmentos.Segmento2C = @pSegmento2C and 
	venAbonosFactuSegmentos.Segmento3C = @pSegmento3C and 
	venAbonosFactuSegmentos.Segmento4C = @pSegmento4C )

IF (@lIdentity IS NOT NULL)
BEGIN 
	UPDATE venAbonosFacturacion
	SET FechaDesde = @pFechaDesde, FechaHasta = @pFechaHasta, FechaEmision = @pFechaEmision, 
	ClienteDesde = @pClienteDesde, ClienteHasta = @pClienteHasta, VendedorDesde = @pVendedorDesde, VendedorHasta = @pVendedorHasta,
	MonedaDesde = @pMonedaDesde, MonedaHasta = @pMonedaHasta
END
ELSE
BEGIN
	Insert Into venAbonosFacturacion (
	FechaDesde, 
	FechaHasta, 
	FechaEmision, 
	ClienteDesde, 
	ClienteHasta,
	VendedorDesde, 
	VendedorHasta, 
	MonedaDesde,
	MonedaHasta
	)
	Values
	(
	@pFechaDesde, 
	@pFechaHasta, 
	@pFechaEmision, 
	@pClienteDesde,
	@pClienteHasta,
	@pVendedorDesde, 
	@pVendedorHasta, 
	@pMonedaDesde,
	@pMonedaHasta
	)
	SET @lIdentity =  Cast(SCOPE_IDENTITY() as int) 
END
Select @lIdentity as RetVal
Go

