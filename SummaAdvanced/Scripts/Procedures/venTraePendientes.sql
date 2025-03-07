DROP PROCEDURE venTraePendientes 
GO
CREATE PROCEDURE venTraePendientes (
	@pEmpresa_Id int,
	@Cliente_Id VarChar(15), 
	@Moneda_Id VarChar(3), 
	@Signo Int )

AS
select Cast(0 as bigint) as venMovimientos, 0.00 as Importe, @Moneda_Id as Moneda_Id, @Cliente_Id as Cliente_id, @Signo as Signo

SELECT genMovCuotas.FechaVencimiento, Fecha, venMovimientos.venMovimientos, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) SegmentoStr, genMovCuotas.CuotaNro, 
		genMovCuotas.Importe,
		genMovCuotas.Saldo, genMovCuotas.Saldo*0 as ImporteAplicado
From venMovimientos
Inner join genMovCuotas ON venMovimientos.venMovimientos = genMovCuotas.Asiento_Id
INNER join venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
inner join genMonedas ON genMonedas.genMonedas =  conAsientos.Moneda_Id
INNER Join venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
inner join venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
Where
	conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And
	genMovCuotas.Saldo > 0 and 
	venTipoMov.Signo = @Signo and 
	venClientes.Cliente_Id = @Cliente_Id and 
	genMonedas.Moneda_Id = @Moneda_Id
order by 1, 2
GO
