-- Inf_venVentasProductoRes  '20200301','20200331',' ','ZZZ',' ','ZZZZ',' ','ZZZ',1,' ',' ','zzz',' ','zzz',' ','ZZZ'
-- Inf_venVentasProductoRes  '20200301','20200331',' ','ZZZ',' ','ZZZZ',' ','ZZZ',1,'V',' ','zzz',' ','zzz',' ','ZZZ'
DROP Procedure Inf_venVentasProductoRes
GO

Create Procedure Inf_venVentasProductoRes
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa_Id Int, 
	@Agrupador Char(1) = ' ',
	@VendedorDesde varchar(5),
	@VendedorHasta varchar(5),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@EnMonedaOriginal bit

)
AS

begin
 
if @Agrupador != 'V' AND @Agrupador != 'C'

SELECT genMonedas.Moneda_Id,' ' Agrupador, ' ' DescripcionAgrupador,
	ISNULL(stkFamilias.Familia_Id,'NA') AS Familia_Id, ISNULL(stkFamilias.Descripcion,' ') AS DescripcionFamilia,
	ISNULL(stkGrupos.Grupo_Id,'NA') AS Grupo_Id, ISNULL(stkGrupos.Descripcion,' ') AS DescripcionGrupo,
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) as Cantidad, 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * case when @EnMonedaOriginal=1 then 1 else conAsientos.Cambio end) as Monto,
		case when SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) <> 0 THEN
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * case when @EnMonedaOriginal=1 then 1 else conAsientos.Cambio end) /
			SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) ELSE 0 END AS PrecioPromedio
FROM stkProductos 
INNER JOIN stkUniMed ON stkProductos.Medida_Id = stkUniMed.stkUniMed
INNER JOIN venMovConStockCr ON venMovConStockCr.Producto_Id = stkProductos.stkProductos
INNER JOIN conAsientos ON conAsientos.conAsientos =venMovConStockCr.venMovimientos
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_id 
Inner Join venVendedores On venVendedores.venVendedores = venMovimientos.Vendedor_Id
left join stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
left join stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = @Empresa_Id 
INNER JOIN genMonedas ON genMonedas.genMonedas = case when @EnMonedaOriginal=0 THEN genEmpresas.Moneda_Id else conAsientos.Moneda_Id end 

WHERE
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde And @VendedorHasta And
	venSubTipoMov.AfectaEstadistica = 1 and 
	conAsientos.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id AND 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta and 
	ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde and @FamiliaHasta and
	ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @GrupoDesde and @GrupoHasta 
GROUP BY stkFamilias.Familia_Id, stkFamilias.Descripcion, stkGrupos.Grupo_Id, stkGrupos.Descripcion,genMonedas.Moneda_Id
ORDER BY 1,2,4, 6


if @Agrupador = 'C'

SELECT genMonedas.Moneda_Id,venClientes.Cliente_Id Agrupador, venClientes.RazonSocial DescripcionAgrupador,
	ISNULL(stkFamilias.Familia_Id,'NA') AS Familia_Id, ISNULL(stkFamilias.Descripcion,' ') AS DescripcionFamilia,
	ISNULL(stkGrupos.Grupo_Id,'NA') AS Grupo_Id, ISNULL(stkGrupos.Descripcion,' ') AS DescripcionGrupo,
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) as Cantidad, 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * case when @EnMonedaOriginal=1 then 1 else conAsientos.Cambio end) as Monto,
		case when SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) <> 0 THEN
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * case when @EnMonedaOriginal=1 then 1 else conAsientos.Cambio end) /
			SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) ELSE 0 END AS PrecioPromedio,
			Max(venVendedores.Vendedor_Id) as Vendedor_Id
FROM stkProductos 
INNER JOIN stkUniMed ON stkProductos.Medida_Id = stkUniMed.stkUniMed
INNER JOIN venMovConStockCr ON venMovConStockCr.Producto_Id = stkProductos.stkProductos
INNER JOIN conAsientos ON conAsientos.conAsientos =venMovConStockCr.venMovimientos
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_id 
Inner Join venVendedores On venVendedores.venVendedores = venMovimientos.Vendedor_Id
left join stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
left join stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = @Empresa_Id 
INNER JOIN genMonedas ON genMonedas.genMonedas = case when @EnMonedaOriginal=0 THEN genEmpresas.Moneda_Id else conAsientos.Moneda_Id end 

WHERE
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde And @VendedorHasta And
	venSubTipoMov.AfectaEstadistica = 1 and 
	conAsientos.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id AND 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta and 
	ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde and @FamiliaHasta and
	ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @GrupoDesde and @GrupoHasta 
GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial, 
stkFamilias.Familia_Id, stkFamilias.Descripcion, stkGrupos.Grupo_Id, stkGrupos.Descripcion,genMonedas.Moneda_Id
ORDER BY 1,2,4, 6

if @Agrupador = 'V'

SELECT genMonedas.Moneda_Id,venVendedores.Vendedor_Id Agrupador, venVendedores.Nombre DescripcionAgrupador,
	ISNULL(stkFamilias.Familia_Id,'NA') AS Familia_Id, ISNULL(stkFamilias.Descripcion,' ') AS DescripcionFamilia,
	ISNULL(stkGrupos.Grupo_Id,'NA') AS Grupo_Id, ISNULL(stkGrupos.Descripcion,' ') AS DescripcionGrupo,
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) as Cantidad, 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * case when @EnMonedaOriginal=1 then 1 else conAsientos.Cambio end) as Monto,
		case when SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) <> 0 THEN
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * case when @EnMonedaOriginal=1 then 1 else conAsientos.Cambio end) /
			SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) ELSE 0 END AS PrecioPromedio
FROM stkProductos 
INNER JOIN stkUniMed ON stkProductos.Medida_Id = stkUniMed.stkUniMed
INNER JOIN venMovConStockCr ON venMovConStockCr.Producto_Id = stkProductos.stkProductos
INNER JOIN conAsientos ON conAsientos.conAsientos =venMovConStockCr.venMovimientos
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_id 
INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
left join stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
left join stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id and 
	ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde and @FamiliaHasta and
	ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @GrupoDesde and @GrupoHasta 
INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = @Empresa_Id 
INNER JOIN genMonedas ON genMonedas.genMonedas = case when @EnMonedaOriginal=0 THEN genEmpresas.Moneda_Id else conAsientos.Moneda_Id end 

WHERE
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde And @VendedorHasta And
	venSubTipoMov.AfectaEstadistica = 1 and 
	conAsientos.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id AND 
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta
GROUP BY venVendedores.Vendedor_Id, venVendedores.Nombre,
	stkFamilias.Familia_Id, stkFamilias.Descripcion, stkGrupos.Grupo_Id, stkGrupos.Descripcion,genMonedas.Moneda_Id
ORDER BY 1,2,4, 6

end




GO
