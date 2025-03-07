Drop procedure impFacturasCompras
GO
Create procedure impFacturasCompras(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Empresa_Id Int
)
AS

SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) AS Comprobante, 
	comMovProv.Fecha_CCP as Fecha, comMovProv.Importe, comMovProv.ClaveFiscal AS UUID, 
		genMonedas.Moneda_Id, genEntidades.Cuit as RFC
	from comProveedores 
		INNER JOIN comMovProv on comProveedores.genEntidades = comMovProv.Proveed_Id
		INNER JOIN genAsiSegmentos ON  genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
		INNER JOIN conAsientos ON  conAsientos.conAsientos =genAsiSegmentos.Asiento_Id
		INNER JOIN genMonedas ON  genMonedas.genMonedas = conAsientos.Moneda_Id
		INNER JOIN genEntidades ON  genEntidades.genEntidades = comProveedores.genEntidades
where
	comMovProv.ClaveFiscal IS NOT NULL AND 
	comMovProv.ClaveFiscal != ' ' AND 
	conAsientos.Empresa_Id = @Empresa_Id and
	comProveedores.Proveed_Id BETWEEN @ProveedDesde AND @ProveedHasta AND 
	conAsientos.Fecha between @FechaDesde and @FechaHasta
ORDER BY 1,4,3
GO

