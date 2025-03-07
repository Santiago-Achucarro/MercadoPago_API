-- Inf_VentaXCliente '20190901', '20190930',' ','ZZZZ', 1
DROP PROCEDURE Inf_VentaXCliente
GO
CREATE PROCEDURE Inf_VentaXCliente
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Empresa_Id Int,
	@ConImpuestos bit,
	@TipoMovDesde Char(1),
	@TipoMovHasta Char(1)
)

as

SELECT venClientes.Cliente_Id, venClientes.RazonSocial,
dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Comprobante, 
	conAsientos.Fecha, genMonedas.Moneda_Id, 
	(venMovimientos.Importe- case when @ConImpuestos=1 then 0 else ISNULL(Impuestos.importe,0) end)*venTipomov.Signo as TotalOrignal, 
	Convert(Numeric(18,2),(venMovimientos.Importe - ISNULL(Impuestos.importe,0) *conAsientos.Cambio*venTipomov.Signo)) AS SubtotalBase,
	Convert(Numeric(18,2),ISNULL(Impuestos.importe,0) *conAsientos.Cambio*venTipomov.Signo) AS ImpuestosBase,
	Convert(Numeric(18,2),(venMovimientos.Importe - case when @ConImpuestos=1 then 0 else ISNULL(Impuestos.importe,0) end) *conAsientos.Cambio*venTipomov.Signo) AS TotalBase,
	venClieHabitual.NombreFantasia, venClieHabitual.Sucursal
FROM genAsiSegmentos inner join conAsientos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN venMovimientos ON 
	venMovimientos.venMovimientos = conAsientos.conAsientos
	INNER JOIN venClientes ON 
	venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN venTipoMov on 
	venTipoMov.venTipoMov = venMovimientos.venTipomov
	INNER JOIN genMonedas ON 
	genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join venSubTipoMov on venMovimientos.venSubTipoMov_Id = venSubTipoMov.venSubTipoMov
	Left Join (Select venMovImpuestos.venMovimientos conAsientos, Sum(Importe) Importe 
	From venMovImpuestos Group By venMovImpuestos.venMovimientos) Impuestos 
		On Impuestos.conAsientos = conAsientos.conAsientos
	inner join venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_id and 
		venClieHabitual.Sucursal = venMovimientos.Sucursal
	Where
		venSubTipoMov.AfectaEstadistica = 1 and 
		conAsientos.Posteado = 1 and 
		conAsientos.Anulado = 0 and 
		venTipoMov.venTipoMov <> 'C' AND 
		conAsientos.Fecha between @FechaDesde And @FechaHasta And
		conAsientos.Empresa_Id = @Empresa_Id and 
		venClientes.Cliente_Id BETWEEN @ClienteDesde And @ClienteHasta AND 
		venTipoMov.venTipoMov between @TipoMovDesde and @TipoMovHasta
	ORDER BY 1,3