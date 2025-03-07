-- Inf_tesIngCobranzas ' ','ZZZ', ' ','ZZZ', ' ','ZZZ',' ','ZZZ',' ','ZZZ','20200401','20200430',1,'Z'
DROP PROCEDURE Inf_tesIngCobranzas
GO

CREATE PROCEDURE Inf_tesIngCobranzas
(
	@SucursalDesde VarChar(5),
	@SucursalHasta VarChar(5),
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@RegionDesde VarChar(5),
	@RegionHasta VarChar(5),
	@ZonaDesde  VarChar(5),
	@ZonaHasta  VarChar(5),
	@CobradorDesde  VarChar(5),
	@CobradorHasta  VarChar(5),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa Int, 
	@AgruparPor Char(1)
)

AS


SELECT	
	CASE @AgruparPor 
	WHEN  'S' THEN genSucursalesEmpr.Sucursal
	WHEN  'C' THEN venClientes.Cliente_Id
	WHEN  'R' THEN venRegion.Region_Id
	WHEN  'Z' THEN venZona.Zona_Id
	WHEN  'O' THEN venCobradores.Cobrador_Id
	WHEN  'T' THEN venTiposClie.TipoClie_Id
	ELSE ' ' END AS Agrupador,

	CASE @AgruparPor 
	WHEN  'S' THEN genSucursalesEmpr.Descripcion
	WHEN  'C' THEN venClientes.RazonSocial
	WHEN  'R' THEN venRegion.Descripcion
	WHEN  'Z' THEN venZona.Descripcion
	WHEN  'O' THEN venCobradores.Nombre
	WHEN  'T' THEN venTiposClie.Descripcion
	ELSE ' ' END AS DescripcionAgrupador,
	
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda,	conAsientos.Fecha ,
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	
	(-conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) as Monto,
	(-conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as MontoBase
FROM tesMovimientos INNER JOIN venMovimientos ON
	tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = venMovimientos.venMovimientos
	inner join genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_Id 
	inner join tesRengMovi ON
	tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos 
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and
	conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN venClientes ON
	venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN tesIdentifica ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN genSucursalesEmpr ON
	genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	INNER JOIN venClieHabitual ON  venClieHabitual.genEntidades = venMovimientos.Cliente_Id and 
								   venClieHabitual.Sucursal = 	venMovimientos.Sucursal
	INNER JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id
	INNER JOIN venRegion ON venRegion.venRegion = venClieHabitual.Region_Id
	INNER JOIN venTiposClie ON venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	LEFT JOIN venCobradores ON venCobradores.venCobradores = venMovimientos.Cobrador_Id
	WHERE
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		-- tesRengMovi.TipomovCont = 2 and 
		tesIdentifica.Cartera_Id IN( 'CLI','ANTCL') AND
		conAsientos.Fecha BETWEEN @FechaDesde and  @FechaHasta AND 
		genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
		conAsientos.Empresa_Id = @Empresa AND
		venClientes.Cliente_Id  between @ClienteDesde and @ClienteHasta and 
		venZona.Zona_Id Between @ZonaDesde and @ZonaHasta and
		venRegion.Region_Id Between @RegionDesde and @RegionHasta and
		venCobradores.Cobrador_Id Between @CobradorDesde and @ClienteHasta

ORDER BY 1,3,5, 6
			


