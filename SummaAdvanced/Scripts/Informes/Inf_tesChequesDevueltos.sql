-- Inf_tesChequesDevueltos ' ','ZZZ', ' ','ZZZ', '20180630',1
DROP PROCEDURE Inf_tesChequesDevueltos
GO

CREATE PROCEDURE Inf_tesChequesDevueltos
(
	@CarteraDesde VarChar(5),
	@CarteraHasta VarChar(5),
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Fecha DateTime, 
	@Empresa Int
)

AS

SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, 
	tesCheqTerceros.numCheque, tesBancos.Banco_Id, tesCheqTerceros.FechaVencimiento as Fecha,
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	tesBancos.Descripcion as DescripcionBanco, conMovCont.ImporteMonedaOriginal as Monto
FROM tesIdentifica INNER JOIN tesRengMovi ON
	tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	inner join tesCTlink ON
	tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos AND 
	tesCTlink.conRenglon = tesRengMovi.conRenglon
	inner join genMonedas ON
	genMonedas.genMonedas = tesIdentifica.Moneda_Id 
	INNER JOIN tesCheqTerceros ON
	tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros
	inner join tesBancos ON 
	tesBancos.tesBancos = tesCheqTerceros.Banco_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = tesRengMovi.tesMovimientos and
	conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = tesRengMovi.tesMovimientos
	LEFT JOIN venClientes ON
	venClientes.genEntidades = tesCheqTerceros.Cliente_Id
	WHERE
		tesCTlink.Estado_Id = 'R' AND 
		conAsientos.Fecha <= @Fecha and conAsientos.Anulado = 0 And
		tesIdentifica.Cartera_Id between @CarteraDesde and @CarteraHasta and 
		conAsientos.Empresa_Id = @Empresa AND
		ISNULL(venClientes.Cliente_Id, ' ') between @ClienteDesde and @ClienteHasta and 
		NOT EXISTS(SELECT 1 from tesCTlink T1, conAsientos A1 WHERE
			tesCTlink.tesCheqTerceros = T1.tesCheqTerceros AND 
			tesCTlink.Secuencia < T1.Secuencia AND 
			A1.conAsientos = T1.tesMovimientos AND 
			A1.Fecha <= @Fecha And A1.Anulado = 0)



