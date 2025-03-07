

-- Inf_venContribMarg '20210401','20210430',' ','ZZZ',' ','zzz',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ',0,0,1
-- Inf_venContribMarg '20200401','20200430',' ','ZZZ',' ','ZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ',0,1,1
-- Inf_venContribMarg '20200901','20200930',' ','ZZZ',' ','ZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ','T',0,0,1
-- Inf_venContribMarg '20200401','20200430',' ','ZZZ',' ','ZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ',' ','ZZZZ','V',1,1,1

DROP Procedure Inf_venContribMarg
GO
Create Procedure Inf_venContribMarg
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@ProductoDesde VarChar(15),
	@ProductoHasta VarChar(15),
	@SucursalDesde VarChar(15),
	@SucursalHasta VarChar(15),
	@RegionDesde VarChar(5),
	@RegionHasta VarChar(5),
	@ZonaDesde  VarChar(5),
	@ZonaHasta  VarChar(5),
	@VendedorDesde  VarChar(5),
	@VendedorHasta  VarChar(5),
	@TipoDesde VarChar(5),
	@TipoHasta VarChar(5),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@AgruparPor Char(1),
	@Resumido Bit, 
	@PorGrupo Bit,
	@Empresa_Id Int
)
AS

select CASE @AgruparPor 
	WHEN 'C' Then Cliente_Id 
	WHEN 'V' Then Vendedor_Id 
	WHEN 'T' Then Tipo_Id 
	ELSE ' ' END AS Agrupador ,
	CASE @AgruparPor 
	WHEN 'C' Then RazonSocial 
	WHEN 'V' Then Nombre
	WHEN 'T' Then DescripcionTipo
	ELSE ' ' END AS DescripcionAgrupador ,
	Familia_Id,  DescripcionFamilia, 
	case when @PorGrupo=1 then Grupo_Id else ' ' end as Grupo_Id, 
	case when @PorGrupo=1 then DescripcionGrupo else ' ' end as DescripcionGrupo, 
	case when @Resumido=0 then Producto_Id else ' ' end Producto_Id, 
	case when @Resumido=0 then Descripcion else ' ' end Descripcion, 
	case when @Resumido=0 then Medida_Id else ' ' end Medida_Id, 
	case when @Resumido=0 then Clase else ' ' end Clase, 
	Sum(CantidadVenta) CantidadVenta,
	Sum(MontoLista) MontoLista	, 
	Convert(Numeric(18,4),case when sum(CantidadVenta)=0 then 0 else SUM(MontoLista) / SUM(CantidadVenta) end) PPLista, 
	SUM(MontoVenta) AS MontoVenta, 
	Convert(Numeric(18,4),case when Sum(CantidadVenta)=0 then 0 else sum(MontoVenta) / sum(CantidadVenta) end) PPVenta, 

	Convert(Numeric(18,2),case when Sum(Montolista)=0 then 0 else sum(MontoLista-MontoVenta) / sum(MontoLista) end )*100 as PorDto,
	SUM(MontoCosto) AS MontoCosto, 
	Convert(Numeric(18,4),case when sum(CantidadVenta)=0 then 0 else SUM(MontoCosto) / SUM(CantidadVenta) end)  PPCosto, 
	sum(Contribucion) Contribucion, 
	Convert(Numeric(18,2),Case when SUM(MontoVenta)=0 then 0 else (SUM(Contribucion) / sum(MontoVenta) * 100) end ) PorContrib

from (
SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkUniMed.Medida_Id, stkProductos.Clase,
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) as CantidadVenta, 
		Convert(Numeric(18,2),SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * (venMovConStockCr.PrecioLista - 
		CASE WHEN venListasPrecios.LlevaImpuestoInclu = 1 and venMovConStockCr.PrecioForm!=0 THEN
			venMovConStockCr.PrecioLista * ( venMovConStockCr.PrecioFormImpuesto /venMovConStockCr.PrecioForm ) ELSE 0 END  ) / case when venMovConStockCr.Factor!=0 And venSubTipoMov.TipoPrecioForm != 'S' then venMovConStockCr.Factor else 1 end   * conAsientos.Cambio)) as MontoLista,
		Convert(Numeric(18,2),SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio)) as MontoVenta,
		Convert(Numeric(18,2), case when clase in ('E','-') THEN 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * isnull(stkMoviCuerpo.CostoUnitario,0) )ELSE 0 END)  as MontoCosto,
		Convert(Numeric(18,2),case when clase in ('E','-') THEN 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio) ELSE 0 END ) -
		Convert(Numeric(18,2),case when clase in ('E','-') THEN 
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * isnull(stkMoviCuerpo.CostoUnitario,0) ) ELSE 0 END ) as Contribucion,
		ISNULL(stkFamilias.Familia_Id,'') AS Familia_Id, ISNULL(stkFamilias.Descripcion,'') DescripcionFamilia,
		ISNULL(stkGrupos.Grupo_Id,'') AS Grupo_Id, ISNULL(stkGrupos.Descripcion,'')  DescripcionGrupo,
		venClientes.Cliente_Id, venClientes.RazonSocial, venVendedores.Vendedor_Id, venVendedores.Nombre, 
		stkTipos.Tipo_Id, stkTipos.Descripcion as DescripcionTipo
FROM stkProductos INNER JOIN stkUniMed ON 
stkProductos.Medida_Id = stkUniMed.stkUniMed
INNER JOIN venMovConStockCr ON
venMovConStockCr.Producto_Id = stkProductos.stkProductos
INNER JOIN conAsientos ON 
conAsientos.conAsientos =venMovConStockCr.venMovimientos
INNER JOIN venMovimientos ON
venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
INNER JOIN venSubTipoMov ON
venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON
venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genSucursalesEmpr ON
genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER JOIN venClientes ON
venClientes.genEntidades = venMovimientos.Cliente_id
LEFT JOIN (venMovStkHist INNER JOIN  stkMoviCuerpo ON
venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND
venMovStkHist.Renglon = stkMoviCuerpo.Renglon ) ON
venMovConStockCr.venMovimientos = venMovStkHist.venMovimientos and 
venMovConStockCr.RenglonCuerpo =venMovStkHist.RenglonCuerpo
INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id and 
							  venClieHabitual.Sucursal = venMovimientos.Sucursal
INNER JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id
INNER JOIN venRegion ON venRegion.venRegion = venClieHabitual.Region_Id
INNER JOIN venTiposClie ON venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
INNER JOIN venVendedores ON  venVendedores.venVendedores = venMovimientos.Vendedor_Id
INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
LEFT JOIN stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
LEFT JOIN stkGrupos ON  stkGrupos.stkGrupos = stkProductos.Grupo_Id
INNER JOIN venMovConStock ON  venMovConStock.venMovimientos= venMovimientos.venMovimientos
INNER JOIN venListasPrecios ON  venListasPrecios.venListasPrecios = venMovConStock.ListaPrecio_Id
WHERE
	stkProductos.Clase != 'C' AND 
	venSubTipoMov.AfectaEstadistica = 1 and 
	conAsientos.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id AND 
	conAsientos.Fecha Between @FechaDesde and @FechaHasta and
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and 
	stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta and 
	venZona.Zona_Id Between @ZonaDesde and @ZonaHasta and
	venRegion.Region_Id Between @RegionDesde and @RegionHasta and
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and 
	venTiposClie.TipoClie_Id Between @TipoDesde and @TipoHasta and 
	ISNULL(stkFamilias.Familia_Id,'') Between @FamiliaDesde and @FamiliaHasta and 
	ISNULL(stkGrupos.Grupo_Id,'') Between @GrupoDesde and @GrupoHasta 
GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion, 	stkUniMed.Medida_Id, 
	stkProductos.Clase, stkFamilias.Familia_Id, stkFamilias.Descripcion,stkProductos.stkProductos, 
		stkGrupos.Grupo_Id, stkGrupos.Descripcion,
		venClientes.Cliente_Id, venClientes.RazonSocial, venVendedores.Vendedor_Id, venVendedores.Nombre, 
		stkTipos.Tipo_Id, stkTipos.Descripcion 
having SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) <> 0
UNION ALL -- combos

SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkUniMed.Medida_Id, stkProductos.Clase,
		SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) as CantidadVenta, 
		Convert(Numeric(18,2),SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * (venMovConStockCr.PrecioLista - 
		CASE WHEN venListasPrecios.LlevaImpuestoInclu = 1 and venMovConStockCr.PrecioForm!=0  THEN
		venMovConStockCr.PrecioLista * ( venMovConStockCr.PrecioFormImpuesto /venMovConStockCr.PrecioForm) ELSE 0 END )/ case when venMovConStockCr.Factor!=0 then venMovConStockCr.Factor else 1 end   * conAsientos.Cambio)) as MontoLista,
		Convert(Numeric(18,2),SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio)) as MontoVenta,
		Convert(Numeric(18,2), SUM(venTipomov.Signo * isnull(stkMoviCuerpo.Costo,0)))  as MontoCosto,
		Convert(Numeric(18,2),SUM(venMovConStockCr.CantFacturada * venTipomov.Signo * venMovConStockCr.PrecioVenta * conAsientos.Cambio)) -
		Convert(Numeric(18,2), SUM(venTipomov.Signo * isnull(stkMoviCuerpo.Costo,0))) as Contribucion,
		ISNULL(stkFamilias.Familia_Id,'') AS Familia_Id, ISNULL(stkFamilias.Descripcion,'') DescripcionFamilia,
		ISNULL(stkGrupos.Grupo_Id,'') AS Grupo_Id, ISNULL(stkGrupos.Descripcion,'')  DescripcionGrupo,
		venClientes.Cliente_Id, venClientes.RazonSocial, venVendedores.Vendedor_Id, venVendedores.Nombre, 
		stkTipos.Tipo_Id, stkTipos.Descripcion as DescripcionTipo
FROM stkProductos INNER JOIN stkUniMed ON 
stkProductos.Medida_Id = stkUniMed.stkUniMed
INNER JOIN venMovConStockCr ON
venMovConStockCr.Producto_Id = stkProductos.stkProductos
INNER JOIN conAsientos ON 
conAsientos.conAsientos =venMovConStockCr.venMovimientos
INNER JOIN venMovimientos ON
venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
INNER JOIN venSubTipoMov ON
venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON
venTipoMov.venTipoMov = venMovimientos.venTipoMov
inner join genSucursalesEmpr ON
genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER JOIN venClientes ON
venClientes.genEntidades = venMovimientos.Cliente_id
LEFT JOIN (SELECT venMovStkHist.venMovimientos, venMovStkHist.RenglonCuerpo,
SUM(stkMoviCuerpo.Cantidad *  stkMoviCuerpo.CostoUnitario)  as Costo
from venMovStkHist
INNER JOIN  stkMoviCuerpoCombo ON 
venMovStkHist.stkMoviCabe = stkMoviCuerpoCombo.stkMoviCabe  AND
venMovStkHist.Renglon = stkMoviCuerpoCombo.Renglon
inner JOIN stkMoviCuerpo ON
stkMoviCuerpo.stkMoviCabe = stkMoviCuerpoCombo.stkMoviCabeComponente AND
stkMoviCuerpo.Renglon = stkMoviCuerpoCombo.RenglonComponente 
GROUP BY venMovStkHist.venMovimientos, venMovStkHist.RenglonCuerpo ) AS stkMoviCuerpo ON
venMovConStockCr.venMovimientos = stkMoviCuerpo.venMovimientos and 
venMovConStockCr.RenglonCuerpo =stkMoviCuerpo.RenglonCuerpo
INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id and 
							  venClieHabitual.Sucursal = venMovimientos.Sucursal
INNER JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id
INNER JOIN venRegion ON venRegion.venRegion = venClieHabitual.Region_Id
INNER JOIN venTiposClie ON venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
INNER JOIN venVendedores ON  venVendedores.venVendedores = venMovimientos.Vendedor_Id
INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
LEFT JOIN stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
LEFT JOIN stkGrupos ON  stkGrupos.stkGrupos = stkProductos.Grupo_Id
INNER JOIN venMovConStock ON  venMovConStock.venMovimientos= venMovimientos.venMovimientos
INNER JOIN venListasPrecios ON  venListasPrecios.venListasPrecios = venMovConStock.ListaPrecio_Id
WHERE
	stkProductos.Clase = 'C' AND 
	venSubTipoMov.AfectaEstadistica = 1 and 
	conAsientos.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id AND 
	conAsientos.Fecha Between @FechaDesde and @FechaHasta and
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and 
	stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta and 
	venZona.Zona_Id Between @ZonaDesde and @ZonaHasta and
	venRegion.Region_Id Between @RegionDesde and @RegionHasta and
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and 
	venTiposClie.TipoClie_Id Between @TipoDesde and @TipoHasta and 
	ISNULL(stkFamilias.Familia_Id,'') Between @FamiliaDesde and @FamiliaHasta and 
	ISNULL(stkGrupos.Grupo_Id,'') Between @GrupoDesde and @GrupoHasta 
GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion, 	stkUniMed.Medida_Id, 
	stkProductos.Clase, stkFamilias.Familia_Id, stkFamilias.Descripcion,stkProductos.stkProductos, 
		stkGrupos.Grupo_Id, stkGrupos.Descripcion,
		venClientes.Cliente_Id, venClientes.RazonSocial, venVendedores.Vendedor_Id, venVendedores.Nombre, 
		stkTipos.Tipo_Id, stkTipos.Descripcion 
having SUM(venMovConStockCr.CantFacturada * venTipomov.Signo *	(1-venSubTipoMov.EsPorDifPrecio)) <> 0

union all

SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkUniMed.Medida_Id, stkProductos.Clase,
		0 as CantidadVenta, 
		0 as MontoLista,
		0 as MontoVenta,
		SUM(stkMoviCuerpoReva.ImporteAjusteCosto) ,
		-SUM(stkMoviCuerpoReva.ImporteAjusteCosto) as Contribucion,
		ISNULL(stkFamilias.Familia_Id,'') AS Familia_Id, ISNULL(stkFamilias.Descripcion,'') DescripcionFamilia,
		ISNULL(stkGrupos.Grupo_Id,'') AS Grupo_Id, ISNULL(stkGrupos.Descripcion,'')  DescripcionGrupo,
		' ' Cliente_Id, ' ' RazonSocial, ' ' Vendedor_Id, ' ' Nombre, 
		stkTipos.Tipo_Id, stkTipos.Descripcion 
		 from 
		    stkProductos INNER JOIN stkMoviCuerpoReva ON
			stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos 
			INNER JOIN conAsientos AS Revaluo ON 
			stkMoviCuerpoReva.stkMoviCabe = Revaluo.conAsientos 
			INNER JOIN genSucursalesEmpr AS SucReva ON SucReva.genSucursalesEmpr = Revaluo.Sucursal
			INNER JOIN stkUniMed ON  stkUniMed.stkUniMed = stkProductos.Medida_Id
			LEFT JOIN stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
			LEFT JOIN stkGrupos ON  stkGrupos.stkGrupos = stkProductos.Grupo_Id
			INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
			Where
			stkMoviCuerpoReva.ImporteAjusteCosto <> 0 and 
			Revaluo.Anulado = 0 and 
			Revaluo.Posteado = 1 and 
			Revaluo.Empresa_Id = @Empresa_Id and 
			Revaluo.Fecha between @FechaDesde and @FechaHasta and 
			SucReva.Sucursal BETWEEN @SucursalDesde and @SucursalHasta AND 
			@ClienteDesde = ' ' AND 
			stkProductos.Producto_Id between @ProductoDesde and @ProductoHasta and 
			@ZonaDesde =' ' AND 
			@RegionDesde =' ' AND 
			@VendedorDesde =' ' AND 
			@TipoDesde = ' ' AND 
			ISNULL(stkFamilias.Familia_Id,'') Between @FamiliaDesde and @FamiliaHasta and 
			ISNULL(stkGrupos.Grupo_Id,'') Between @GrupoDesde and @GrupoHasta 

GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion, 	stkUniMed.Medida_Id, 
		stkProductos.Clase, stkFamilias.Familia_Id, stkFamilias.Descripcion,stkProductos.stkProductos, 
		stkGrupos.Grupo_Id, stkGrupos.Descripcion, stkTipos.Tipo_Id, stkTipos.Descripcion 
		) as xxx
GROUP BY Familia_Id,  DescripcionFamilia, 
case when @Resumido=0 then Producto_Id else ' ' end ,	case when @Resumido=0 then Descripcion else ' ' end ,
	case when @Resumido=0 then Medida_Id else ' ' end ,	case when @Resumido=0 then Clase else ' ' end , 
	case when @PorGrupo=1 then Grupo_Id else ' ' end , 	case when @PorGrupo=1 then DescripcionGrupo else ' ' end ,
	CASE @AgruparPor 
	WHEN 'C' Then Cliente_Id 
	WHEN 'V' Then Vendedor_Id 
	WHEN 'T' Then Tipo_Id 
	ELSE ' ' END ,
	CASE @AgruparPor 
	WHEN 'C' Then RazonSocial 
	WHEN 'V' Then Nombre
	WHEN 'T' Then DescripcionTipo
	ELSE ' ' END 
HAVING Sum(CantidadVenta) <> 0
ORDER BY 1



GO
