-- FM 13/04/2023 13654 Que sea coherente con el resto de los informes y tome el TC del dia siguiente --
-- Además en el caso de no tildar En moneda original, que no salgan las ND/ND x DC --

-- Inf_venSaldosClie '20220310',0,1
-- Inf_venSaldosClie '20180630',1,1

DROP PROCEDURE Inf_venSaldosClie 
GO
CREATE PROCEDURE Inf_venSaldosClie 

(
	@FechaHasta DateTime,
	@EnMonedaOriginal bit, 
	@Empresa Int
)
as

if @EnMonedaOriginal = 1
BEGIN

SELECT venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, 1.0000 as Cambio, sum(venMovimientos.Importe*venTipoMov.Signo) as Saldo
	from venMovimientos 
	INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	inner join venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	WHERE
		conAsientos.Empresa_Id = @Empresa and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		conAsientos.Fecha <= @FechaHasta
		And venSubTipoMov.SubTipoMov_Id Not In ('DDC', 'CDC')
		group by venClientes.Cliente_Id, venClientes.RazonSocial, 
			genMonedas.Moneda_Id
		HAVING sum(venMovimientos.Importe*venTipoMov.Signo)  <> 0
ORDER BY 3,1

END

ELSE

BEGIN 

SELECT Cliente_Id, RazonSocial, Moneda_Id, 1, SUM(Saldo) as Saldo
FROM (

SELECT venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, dbo.func_TipoCambioCompra(conasientos.Moneda_Id, DATEADD(dd,1,@FechaHasta), @Empresa) as Cambio, 
	sum(venMovimientos.Importe*venTipoMov.Signo*
		dbo.func_TipoCambioCompra(conasientos.Moneda_Id,DATEADD(dd,1,@FechaHasta), @Empresa)) as Saldo
	From venMovimientos 
	INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	inner join venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa
	inner join genMonedas ON genMonedas.genMonedas = genEmpresas.Moneda_Id
	WHERE
		conAsientos.Empresa_Id = @Empresa and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		conAsientos.Fecha <= @FechaHasta
		And venSubTipoMov.SubTipoMov_Id Not In ('DDC', 'CDC')
group by venClientes.Cliente_Id, venClientes.RazonSocial, 
			genMonedas.Moneda_Id , conasientos.Moneda_Id) AS XXX
group by Cliente_Id, RazonSocial, Moneda_Id
HAVING SUM(Saldo) <> 0
ORDER BY 3,1

END


	
