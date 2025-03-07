-- Inf_venVentasProductoResGru  '20200301','20200331',' ','ZZZ',' ','ZZZZ',' ','ZZZ',1,'C',' ','zzz',' ','zzz',' ','ZZZ'
-- Inf_venVentasProductoResGru  '20200301','20200331',' ','ZZZ',' ','ZZZZ',' ','ZZZ',1,'V',' ','zzz',' ','zzz',' ','ZZZ'
DROP Procedure Inf_venVentasProductoResGru
GO

Create Procedure Inf_venVentasProductoResGru
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@SucursalDesde VarChar(25),
	@SucursalHasta VarChar(25),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa_Id Int, 
	@Agrupador Char(1) = ' ',
	@VendedorDesde varchar(5),
	@VendedorHasta varchar(5),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15)
)
AS

begin
 
if @Agrupador != 'V' AND @Agrupador != 'C'

SELECT ' ' Agrupador, ' ' DescripcionAgrupador,
	ISNULL(stkGrupos.Grupo_id,' ') AS Familia_Id, ISNULL(stkGrupos.Descripcion,' ') AS DescripcionFamilia,
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) as Cantidad, 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio) as Monto,
		case when SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) <> 0 THEN
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio) /
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
GROUP BY stkGrupos.Grupo_Id, stkGrupos.Descripcion
ORDER BY 1,3


if @Agrupador = 'C'

SELECT venClientes.Cliente_Id Agrupador, venClientes.RazonSocial DescripcionAgrupador,
	ISNULL(stkGrupos.Grupo_id,' ') AS Familia_Id, ISNULL(stkGrupos.Descripcion,' ') AS DescripcionFamilia,
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) as Cantidad, 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio) as Monto,
		case when SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) <> 0 THEN
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio) /
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
stkGrupos.Grupo_Id, stkGrupos.Descripcion
ORDER BY 1,3, 5

if @Agrupador = 'V'

SELECT venVendedores.Vendedor_Id Agrupador, venVendedores.Nombre DescripcionAgrupador,
	ISNULL(stkGrupos.Grupo_id,' ') AS Familia_Id, ISNULL(stkGrupos.Descripcion,' ') AS DescripcionFamilia,
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) as Cantidad, 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio) as Monto,
		case when SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) <> 0 THEN
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio) /
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
	stkGrupos.Grupo_Id, stkGrupos.Descripcion
ORDER BY 1,3, 5

end




GO
