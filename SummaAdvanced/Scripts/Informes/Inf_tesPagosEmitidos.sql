-- Inf_tesPagosEmitidos ' ','ZZZ', ' ','ZZZ', '20180101','20180630',1
DROP PROCEDURE Inf_tesPagosEmitidos
GO

CREATE PROCEDURE Inf_tesPagosEmitidos
(
	@SucursalDesde VarChar(5),
	@SucursalHasta VarChar(5),
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa Int
)

AS

SELECT	genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSuc, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda,	
	conAsientos.Fecha , tesSubTiposMov.SubTipo_Id, 
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) as Monto,
	(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as MontoBase
FROM tesMovimientos 
	INNER JOIN comMovProv ON tesMovimientos.tesMovimientos = comMovProv.comMovProv
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
	inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id 
	inner join tesRengMovi ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos 
	INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_Id
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	INNER JOIN tesSubTiposMov ON tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id	
	WHERE
		tesIdentifica.Cartera_Id = 'PRO' AND
		conAsientos.Fecha BETWEEN @FechaDesde and  @FechaHasta AND conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
		genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
		conAsientos.Empresa_Id = @Empresa AND
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta
ORDER BY 1,3,5, 6
			


