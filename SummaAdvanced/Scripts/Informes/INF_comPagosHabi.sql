DROP PROCEDURE INF_comPagosHabi
GO
CREATE PROCEDURE INF_comPagosHabi(
	@FechaHasta DateTime, 
	@ProveedorDesde VarChar(15),
	@ProveedorHasta VarChar(15),
	@Empresa Int
)

AS

SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,  genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,  
	genAsiSegmentos.Segmento4N) as Comprobante, 
	comPagosHabilitados.FechaHabilitacion, conAsientos.Fecha,
		genMonedas.Moneda_Id,
		comMovProv.Importe, comPagosHabilitados.ImporteHabilitado, 
		genAsiSegmentos.Segmento1N as Folio, 
		genMovCuotas.FechaVencimiento, 		genUsuarios.Usuario_Id 
	FROM comMovProv INNER JOIN conAsientos ON 
		comMovProv.comMovProv = conAsientos.conAsientos
		INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		INNER JOIN comPagosHabilitados ON
		comPagosHabilitados.comMovProv = comMovProv.comMovProv 
		INNER JOIn comProveedores ON
		comProveedores.genEntidades = comMovProv.Proveed_Id
		INNER JOIN genMonedas ON 
		conAsientos.Moneda_Id = genMonedas.genMonedas
		INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comPagosHabilitados.Usuario_Id
		inner join genMovCuotas on genMovCuotas.Asiento_Id = comPagosHabilitados.comMovProv and 
		genMovCuotas.CuotaNro = comPagosHabilitados.CuotaNro
	Where
			genAsiSegmentos.Empresa_Id = @Empresa and
			comPagosHabilitados.FechaHabilitacion <= @FechaHasta and 
			comPagosHabilitados.tesMovimientos IS NULL and 
			comProveedores.Proveed_Id BETWEEN @ProveedorDesde And  @ProveedorHasta AND 
			commovprov.Saldo > 0 
UNION ALL

SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial,
	'ANTICIPO' as Comprobante, 
		comPagosAnticipo.FechaPago, comPagosAnticipo.FechaPago AS Fecha,
		genMonedas.Moneda_Id,
		comPagosAnticipo.Importe, comPagosAnticipo.Importe ImporteHabilitado, 
		0 as Folio, comPagosAnticipo.FechaPago, genUsuarios.Usuario_Id 
	FROM comPagosAnticipo INNER JOIn comProveedores ON
		comProveedores.genEntidades = comPagosAnticipo.Proveed_Id
		INNER JOIN genMonedas ON 
		comPagosAnticipo.Moneda_Id = genMonedas.genMonedas
		INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comPagosAnticipo.Usuario_Id
	Where
			comPagosAnticipo.Empresa_Id = @Empresa and
			comPagosAnticipo.FechaPago <= @FechaHasta and 
			comPagosAnticipo.tesMovimientos IS NULL AND 
			comProveedores.Proveed_Id BETWEEN @ProveedorDesde And  @ProveedorHasta
ORDER BY 1, 4, 3
GO	