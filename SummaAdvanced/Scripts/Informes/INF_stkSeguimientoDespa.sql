-- INF_stkSeguimientoDespa ' ' ,'ZZZZ', '20180101','20181231',1
DROP PROCEDURE INF_stkSeguimientoDespa
GO
CREATE PROCEDURE INF_stkSeguimientoDespa
(
	@DespachoDesde VarChar(20),
	@DespachoHasta VarChar(20),
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@Empresa Int

)
as
SELECT comDespachos.Despacho_Id, 	conAsientos.Fecha,
	comDespachos.Origen, comDespachos.Aduana, 
	comDespachos.Patente, comDespachos.Aduana_Id, comDespachos.Fecha as FechaDesp, 
	comDespachos.Cambio , genMonedas.Moneda_Id,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) AS SegmentoStr, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkUniMed.Medida_Id, stkMoviCuerpo.Cantidad* stkMoviCabe.Signo as Cantidad, 
	stkDepositos.Deposito_Id, stkMoviCuerpo.CostoUnitario, 
	Convert(nUMERIC(18,2),stkMoviCuerpo.CostoUnitario*stkMoviCuerpo.Cantidad* stkMoviCabe.Signo) as Total
	from comDespachos inner join genMonedas ON
	comDespachos.Moneda_Id = genMonedas.genMonedas
	inner join stkMoviDespa ON
	stkMoviDespa.Despacho_Id = comDespachos.comDespachos
	INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = stkMoviDespa.stkMoviCabe AND 
	stkMoviCuerpo.Renglon =stkMoviDespa.Renglon
	inner join stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN stkMoviCabe ON 
	stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
	inner join stkDepositos ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	inner join conAsientos ON
	conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	Where
		comDespachos.Despacho_Id between @DespachoDesde And @DespachoHasta and 
		conAsientos.Fecha between @FechaDesde And @FechaHasta AND 
		genAsiSegmentos.Empresa_Id = @Empresa
Order by 1,2
GO