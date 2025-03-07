-- INF_SaldosClientes  '20171031', ' ','ZZZ','PES', 1,1

DROP procedure INF_SaldosClientes 
GO
create procedure INF_SaldosClientes
(
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Moneda_Id VarChar(5), 
	@SoloEstaMoneda Bit, 
	@Empresa Int
)
AS

SET NOCOUNT ON
Declare @MonedaBase int = (SELECT  Moneda_Id From genEmpresas where genEmpresas= @Empresa)

DECLARE @pMoneda_id AS INT
SET @pMoneda_id = dbo.FuncFKgenMonedas(@Moneda_Id)


IF (RTRIM(@Moneda_Id) = '')

	SELECT venClientes.Cliente_Id, venClientes.RazonSocial, GenMonedas.Moneda_Id, 
		SUM(venMovimientos.Importe * venTipoMov.Signo) as Monto
	From venMovimientos
	INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	inner join venSubTipoMov on venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
	inner join GenMonedas ON GenMonedas.GenMonedas = conAsientos.Moneda_id
	Where
	conAsientos.Anulado = 0 and  
	conAsientos.Empresa_Id = @Empresa and 
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	conAsientos.Fecha <= @FechaHasta 
	GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial, GenMonedas.Moneda_Id
	Having SUM(venMovimientos.Importe * venTipoMov.Signo) <> 0
	Order by 3,2

ELSE
BEGIN

	Create Table #_TiposCambio
	(Moneda_Id int Not Null,
	Cambio Numeric(17,4) Not Null)


	Insert Into #_TiposCambio
	Select genMonedas, dbo.func_TipoCambioCompra(genMonedas, @FechaHasta, @Empresa) From genMonedas

	SELECT venClientes.Cliente_Id, venClientes.RazonSocial, GenMonedas.Moneda_Id, 
		SUM(venMovimientos.Importe * Cambio.Cambio / CambioMR.Cambio * venTipoMov.Signo) as Monto
	From venMovimientos
	INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN #_TiposCambio AS CambioMR ON CambioMR.Moneda_id = @pMoneda_id
	inner join GenMonedas ON GenMonedas.GenMonedas = @pMoneda_id
	INNER JOIN #_TiposCambio AS Cambio ON Cambio.Moneda_id = conAsientos.Moneda_Id
	Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	conAsientos.Fecha <= @FechaHasta and 
	((GenMonedas.Moneda_id = @Moneda_id and @SoloEstaMoneda=1) OR
		(GenMonedas.Moneda_id = @Moneda_id and @SoloEstaMoneda=1) or (@SoloEstaMoneda=0))

	GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial, GenMonedas.Moneda_Id
	order by 3,2
END
GO
			
	