-- inf_venLimiteCredito ' ','ZZZ',' ','ZZ',1,1,1
DROP PROCEDURE inf_venLimiteCredito
GO

CREATE PROCEDURE inf_venLimiteCredito
(
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@Empresa_Id Int, 
	@SoloConCredito Bit,
	@SoloExcedido Bit
)
AS

SELECT genMonedas.genMonedas,
dbo.func_TipoCambio(genMonedas.genMonedas, DATEADD(dd,1,dbo.FechaActual()), @Empresa_Id) as Cambio
INTO #CAMBIO
FROM genMonedas

SELECT Cliente_Id, RazonSocial, LimiteCredito, Moneda_Id, CondPagoCli_Id, DescripcionCP, 
	LimiteCredito, Saldo, LimiteCredito-Saldo as Disponible
FROM (
SELECT venClientes.Cliente_Id, venClientes.RazonSocial, 
	venClientes.LimiteCredito, genMonedas.Moneda_Id, 
	venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCP, 
	ISNULL((SELECT SUM(venMovimientos.Saldo* venTipoMov.Signo * Cambio.Cambio)
	from venMovimientos INNER JOIN venTipoMov ON 
		venMovimientos.venTipoMov = venTipoMov.venTipoMov and 
		venMovimientos.Cliente_id = venClientes.genEntidades
		INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
		INNER JOIN #CAMBIO AS Cambio ON Cambio.genMonedas = conAsientos.Moneda_Id
		Where
			conAsientos.Posteado = 1 and 
			conAsientos.Anulado = 0),0) / Cambio.Cambio as Saldo 
	
FROM venClientes INNER JOIN venClieHabitual ON
	venClientes.genEntidades = venClieHabitual.genEntidades AND
	venClientes.SucursalPredeter = venClieHabitual.Sucursal
	INNER JOIN genMonedas ON  genMonedas.genMonedas = venClientes.MonedaLimCred
	INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = @Empresa_Id
	INNER JOIN venVendedores ON venVendedores.venVendedores = venClieHabitual.Vendedor_Id
	INNER JOIN #CAMBIO Cambio ON Cambio.genMonedas = venclientes.MonedaLimCred
	INNER JOIN venCondPago ON venCondPago.venCondPago = venClieHabitual.CondPagoCli_Id
WHERE
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	ISNULL(venClientes.Empresa_Id,@Empresa_Id) = @Empresa_Id ) as XXX
WHERE
	(@SoloConCredito = 0 OR LimiteCredito > 0 ) AND 
	(@SoloExcedido = 0 OR Saldo  > LimiteCredito)
ORDER BY 1

GO
	

	
