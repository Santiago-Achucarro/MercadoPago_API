-- inf_venAnaMora '20200701','20200731',' ','ZZZ',' ','ZZ',' ','ZZ','EC',1
DROP PROCEDURE inf_venAnaMora
GO

CREATE PROCEDURE inf_venAnaMora
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@CobradorDesde VarChar(5),
	@CobradorHasta VarChar(5),
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@Tipo Char(2),
	@Empresa_Id Int
)
AS


SELECT Cliente_Id, RazonSocial, FechaCobranza, Cobranza, 
		Vendedor_Id, DescripcionVendedor, Cobrador_Id, DescripcionCobrador, 
		TotalCobrado, 
		Convert(Numeric(18,2),round(SUM(case @Tipo when 'FC' THEN EmisCobra 
		when 'FV' THEN EmisValor 
		when 'VC' THEN VencCobra
		ELSE VencValor
		END * ImporteValor/TotalCobrado * Aplicado / TotalCobrado),2)) as Dias
FROM (
SELECT venClientes.Cliente_Id, venClientes.RazonSocial, conAsientos.Fecha as FechaCobranza, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N
	) as Cobranza, 
	venVendedores.Vendedor_Id, venVendedores.Nombre as DescripcionVendedor, 
	venCobradores.Cobrador_Id, venCobradores.Nombre as DescripcionCobrador,
	AsiFactura.Fecha as FechaFactura, 	genMovCuotas.FechaVencimiento, 
	DATEDIFF(dd, AsiFactura.Fecha, conAsientos.Fecha) as EmisCobra,
	DATEDIFF(dd, AsiFactura.Fecha, ISNULL(tesCheqTerceros.FechaVencimiento, conAsientos.Fecha)) as EmisValor,
	DATEDIFF(dd, genMovCuotas.FechaVencimiento, conAsientos.Fecha) as VencCobra,
	DATEDIFF(dd, genMovCuotas.FechaVencimiento, ISNULL(tesCheqTerceros.FechaVencimiento, conAsientos.Fecha)) as VencValor,
	genCancMov.Importe*conAsientos.Cambio Aplicado, conMovCont.Importe as ImporteValor,  
	Cobranza.Importe*conAsientos.Cambio as TotalCobrado
FROM venMovimientos 
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN venCobradores ON venCobradores.venCobradores = venMovimientos.Cobrador_Id
	INNER JOIN genMovCuotas as Cobranza ON Cobranza.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN genCancMov ON  genCancMov.Asiento_Id_Ap = Cobranza.Asiento_Id and 
			genCancMov.CuotaNro = Cobranza.CuotaNro
	INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = genCancMov.Asiento_Id and
		genCancMov.CuotaNro = genMovCuotas.CuotaNro
	INNER JOIN conAsientos as AsiFactura ON  AsiFactura.conAsientos = genMovCuotas.Asiento_Id
	INNER JOIN venMovimientos as Factura ON  Factura.venMovimientos = genMovCuotas.Asiento_Id
	INNER JOIN venVendedores ON venVendedores.venVendedores = Factura.Vendedor_Id
	INNER JOIN tesRengMovi ON  tesRengMovi.tesMovimientos = conAsientos.conAsientos
	INNER JOIN conMovCont ON  conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
							  conMovCont.Renglon = 	tesRengMovi.conRenglon
	LEFT JOIN (tesCTlink INNER JOIN tesCheqTerceros ON tesCTlink.tesCheqTerceros = tesCheqTerceros.tesCheqTerceros) ON 
		tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos and 
		tesCTlink.conRenglon = tesRengMovi.conRenglon
WHERE
	tesRengMovi.TipomovCont  =  1 and 
	venMovimientos.venTipoMov = 'C' and 
	conAsientos.Fecha BETWEEN @FechaDesde AND @FechaHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
	venCobradores.Cobrador_Id Between @CobradorDesde and @CobradorHasta and 
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	AsiFactura.Anulado = 0 and 
	AsiFactura.Posteado = 1 ) AS XXX
GROUP BY Cliente_Id, RazonSocial, FechaCobranza, Cobranza, 
		Vendedor_Id, DescripcionVendedor, Cobrador_Id, DescripcionCobrador, 
		TotalCobrado
ORDER BY 1,2,3

GO
	

	
