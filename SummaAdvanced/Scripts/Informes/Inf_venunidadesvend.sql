--Inf_venunidadesvend '20190101','20191231',' ','zzz',' ','zzz',' ','zzz',' ','zzz',' ','zzz','C',0,1
--Inf_venunidadesvend '20190101','20191231',' ','zzz',' ','zzz',' ','zzz',' ','zzz',' ','zzz','V',0,1
--Inf_venunidadesvend '20190101','20191231',' ','zzz',' ','zzz',' ','zzz',' ','zzz',' ','zzz','T',0,1
--Inf_venunidadesvend '20190101','20191231',' ','zzz',' ','zzz',' ','zzz',' ','zzz',' ','zzz','R',0,1
--Inf_venunidadesvend '20190101','20191231',' ','zzz',' ','zzz',' ','zzz',' ','zzz',' ','zzz','Z',0,1

DROP PROCEDURE Inf_venunidadesvend 
GO
CREATE PROCEDURE Inf_venunidadesvend 
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@SucursaDesde VarChar(4),
	@SucursaHasta VarChar(4),
	@RegionDesde VarChar(5),
	@RegionHasta VarChar(5),
	@ZonaDesde VarChar(5),
	@ZonaHasta VarChar(5),
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@DetallarPor Char(1),
	@SoloFacturas Bit,
	@Empresa_Id int)
AS
if @DetallarPor = 'C' OR @DetallarPor = ' '
begin
	SELECT venClientes.Cliente_Id as Entidad, venClientes.RazonSocial as EntidadDescripcion, 
		SUM(venMovConStockCr.CantFacturada*venTipoMov.Signo) AS Unidades 
	FROM venMovimientos INNER JOIN conAsientos ON
		venMovimientos.venMovimientos = conAsientos.conAsientos
		INNER JOIN venMovConStockCr ON 
			venMovConStockCr.venMovimientos = venMovimientos.venMovimientos
		INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
		INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
		INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
		INNER JOIN venClieHabitual ON venMovimientos.Cliente_Id =  venClieHabitual.genEntidades And
			venMovimientos.Sucursal = venClieHabitual.Sucursal
		INNER JOIN venZona ON venClieHabitual.Zona_Id = venZona.venZona
		INNER JOIN venRegion ON venClieHabitual.Region_Id = venRegion.venRegion
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
		inner join venTiposClie ON  venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	WHERE
		conAsientos.Anulado = 0 and
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_id and 
		conAsientos.Fecha between @FechaDesde And @FechaHasta and
		venZona.Zona_Id between @ZonaDesde and @ZonaHasta and 
		venRegion.Region_Id  between @RegionDesde And @RegionHasta and 
		venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta and 
		venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
		genSucursalesEmpr.Sucursal between @SucursaDesde And @SucursaHasta and 
		(@SoloFacturas = 1 or venTipoMov.venTipoMov= 'F')
	GROUP BY venClientes.Cliente_Id ,venClientes.RazonSocial 
	ORDER BY 1
end

if @DetallarPor = 'V'
begin
	SELECT venVendedores.Vendedor_Id as Entidad, venVendedores.Nombre as EntidadDescripcion, 
		SUM(venMovConStockCr.CantFacturada*venTipoMov.Signo) AS Unidades 
	FROM venMovimientos INNER JOIN conAsientos ON
		venMovimientos.venMovimientos = conAsientos.conAsientos
		INNER JOIN venMovConStockCr ON 
			venMovConStockCr.venMovimientos = venMovimientos.venMovimientos
		INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
		INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
		INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
		INNER JOIN venClieHabitual ON venMovimientos.Cliente_Id =  venClieHabitual.genEntidades And
			venMovimientos.Sucursal = venClieHabitual.Sucursal
		INNER JOIN venZona ON venClieHabitual.Zona_Id = venZona.venZona
		INNER JOIN venRegion ON venClieHabitual.Region_Id = venRegion.venRegion
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
		inner join venTiposClie ON  venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	WHERE
		conAsientos.Anulado = 0 and
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_id and 
		conAsientos.Fecha between @FechaDesde And @FechaHasta and
		venZona.Zona_Id between @ZonaDesde and @ZonaHasta and 
		venRegion.Region_Id  between @RegionDesde And @RegionHasta and 
		venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta and 
		venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
		genSucursalesEmpr.Sucursal between @SucursaDesde And @SucursaHasta and 
		(@SoloFacturas = 1 or venTipoMov.venTipoMov= 'F')
	GROUP BY venVendedores.Vendedor_Id ,venVendedores.Nombre
	ORDER BY 1
end

if @DetallarPor = 'R'
begin
	SELECT venRegion.Region_Id as Entidad, venRegion.Descripcion as EntidadDescripcion, 
		SUM(venMovConStockCr.CantFacturada*venTipoMov.Signo) AS Unidades 
	FROM venMovimientos INNER JOIN conAsientos ON
		venMovimientos.venMovimientos = conAsientos.conAsientos
		INNER JOIN venMovConStockCr ON 
			venMovConStockCr.venMovimientos = venMovimientos.venMovimientos
		INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
		INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
		INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
		INNER JOIN venClieHabitual ON venMovimientos.Cliente_Id =  venClieHabitual.genEntidades And
			venMovimientos.Sucursal = venClieHabitual.Sucursal
		INNER JOIN venZona ON venClieHabitual.Zona_Id = venZona.venZona
		INNER JOIN venRegion ON venClieHabitual.Region_Id = venRegion.venRegion
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
		inner join venTiposClie ON  venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	WHERE
		conAsientos.Anulado = 0 and
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_id and 
		conAsientos.Fecha between @FechaDesde And @FechaHasta and
		venZona.Zona_Id between @ZonaDesde and @ZonaHasta and 
		venRegion.Region_Id  between @RegionDesde And @RegionHasta and 
		venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta and 
		venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
		genSucursalesEmpr.Sucursal between @SucursaDesde And @SucursaHasta and 
		(@SoloFacturas = 1 or venTipoMov.venTipoMov= 'F')
	GROUP BY venRegion.Region_id, venRegion.Descripcion
	ORDER BY 1
end

if @DetallarPor = 'Z'
begin
	SELECT venZona.Zona_Id as Entidad, venZona.Descripcion as EntidadDescripcion, 
		SUM(venMovConStockCr.CantFacturada*venTipoMov.Signo) AS Unidades 
	FROM venMovimientos INNER JOIN conAsientos ON
		venMovimientos.venMovimientos = conAsientos.conAsientos
		INNER JOIN venMovConStockCr ON 
			venMovConStockCr.venMovimientos = venMovimientos.venMovimientos
		INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
		INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
		INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
		INNER JOIN venClieHabitual ON venMovimientos.Cliente_Id =  venClieHabitual.genEntidades And
			venMovimientos.Sucursal = venClieHabitual.Sucursal
		INNER JOIN venZona ON venClieHabitual.Zona_Id = venZona.venZona
		INNER JOIN venRegion ON venClieHabitual.Region_Id = venRegion.venRegion
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
		inner join venTiposClie ON  venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	WHERE
		conAsientos.Anulado = 0 and
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_id and 
		conAsientos.Fecha between @FechaDesde And @FechaHasta and
		venZona.Zona_Id between @ZonaDesde and @ZonaHasta and 
		venRegion.Region_Id  between @RegionDesde And @RegionHasta and 
		venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta and 
		venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
		genSucursalesEmpr.Sucursal between @SucursaDesde And @SucursaHasta and 
		(@SoloFacturas = 1 or venTipoMov.venTipoMov= 'F')
	GROUP BY venZona.Zona_Id, venZona.Descripcion
	ORDER BY 1
end


if @DetallarPor = 'T'
begin
	SELECT venTiposClie.TipoClie_Id as Entidad, venTiposClie.Descripcion as EntidadDescripcion, 
		SUM(venMovConStockCr.CantFacturada*venTipoMov.Signo) AS Unidades 
	FROM venMovimientos INNER JOIN conAsientos ON
		venMovimientos.venMovimientos = conAsientos.conAsientos
		INNER JOIN venMovConStockCr ON 
			venMovConStockCr.venMovimientos = venMovimientos.venMovimientos
		INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
		INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
		INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
		INNER JOIN venClieHabitual ON venMovimientos.Cliente_Id =  venClieHabitual.genEntidades And
			venMovimientos.Sucursal = venClieHabitual.Sucursal
		INNER JOIN venZona ON venClieHabitual.Zona_Id = venZona.venZona
		INNER JOIN venRegion ON venClieHabitual.Region_Id = venRegion.venRegion
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
		inner join venTiposClie ON  venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	WHERE
		conAsientos.Anulado = 0 and
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_id and 
		conAsientos.Fecha between @FechaDesde And @FechaHasta and
		venZona.Zona_Id between @ZonaDesde and @ZonaHasta and 
		venRegion.Region_Id  between @RegionDesde And @RegionHasta and 
		venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta and 
		venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
		genSucursalesEmpr.Sucursal between @SucursaDesde And @SucursaHasta and 
		(@SoloFacturas = 1 or venTipoMov.venTipoMov= 'F')
	GROUP BY venTiposClie.TipoClie_Id, venTiposClie.Descripcion
	ORDER BY 1
end

if @DetallarPor = 'S'
begin
	SELECT gensucursalesEmpr.Sucursal as Entidad, gensucursalesEmpr.Descripcion as EntidadDescripcion, 
		SUM(venMovConStockCr.CantFacturada*venTipoMov.Signo) AS Unidades 
	FROM venMovimientos INNER JOIN conAsientos ON
		venMovimientos.venMovimientos = conAsientos.conAsientos
		INNER JOIN venMovConStockCr ON 
			venMovConStockCr.venMovimientos = venMovimientos.venMovimientos
		INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
		INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
		INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
		INNER JOIN venClieHabitual ON venMovimientos.Cliente_Id =  venClieHabitual.genEntidades And
			venMovimientos.Sucursal = venClieHabitual.Sucursal
		INNER JOIN venZona ON venClieHabitual.Zona_Id = venZona.venZona
		INNER JOIN venRegion ON venClieHabitual.Region_Id = venRegion.venRegion
		INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
		inner join venTiposClie ON  venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	WHERE
		conAsientos.Anulado = 0 and
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_id and 
		conAsientos.Fecha between @FechaDesde And @FechaHasta and
		venZona.Zona_Id between @ZonaDesde and @ZonaHasta and 
		venRegion.Region_Id  between @RegionDesde And @RegionHasta and 
		venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta and 
		venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
		genSucursalesEmpr.Sucursal between @SucursaDesde And @SucursaHasta and 
		(@SoloFacturas = 1 or venTipoMov.venTipoMov= 'F')
	GROUP BY gensucursalesEmpr.Sucursal, gensucursalesEmpr.Descripcion
	ORDER BY 1
end
