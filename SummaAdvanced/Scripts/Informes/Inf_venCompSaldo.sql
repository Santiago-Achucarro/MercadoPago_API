
-- Inf_venCompSaldo  '20200731','00348 BAUCOM','00348 BAUCOM',1
DROP PROCEDURE Inf_venCompSaldo 
GO
CREATE PROCEDURE Inf_venCompSaldo 
(
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Empresa_Id INT

)
AS

SELECT genMonedas.genMonedas,
dbo.func_TipoCambio(genMonedas.genMonedas, DATEADD(dd,1,@FechaHasta), @Empresa_Id) as Cambio
INTO #CAMBIO
FROM genMonedas



SELECT venClientes.Cliente_Id , venClientes.RazonSocial,
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante, 
		venMovimientos.Importe as MontoOriginal,
		conAsientos.Fecha, (venMovimientos.Saldo +
		ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id = venMovimientos.venMovimientos AND 
			genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
			genCancMov.FechaAplicacion > @FechaHasta and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0)+
	ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id_ap = venMovimientos.venMovimientos AND 
			genCancMov.Asiento_Id = conAsientos.conAsientos and 
			genCancMov.FechaAplicacion > @FechaHasta and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0))* venTipoMov.Signo * Cambio.Cambio as Saldo, 
				conAsientos.Fecha, (venMovimientos.Saldo +
		ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id = venMovimientos.venMovimientos AND 
			genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
			genCancMov.FechaAplicacion > @FechaHasta and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0)+
	ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id_ap = venMovimientos.venMovimientos AND 
			genCancMov.Asiento_Id = conAsientos.conAsientos and 
			genCancMov.FechaAplicacion > @FechaHasta and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0))* venTipoMov.Signo as SaldoOri, 
			genMonedas.Moneda_Id, Cambio.Cambio, 
			(select max(genMovCuotas.FechaVencimiento) from 
				genMovCuotas where
					genMovCuotas.Asiento_Id = venMovimientos.venMovimientos) as FechaVencimiento
from venMovimientos INNER JOIN conAsientos ON
	venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join venClientes ON 
	venClientes.genEntidades = venMovimientos.Cliente_Id
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
	inner join venTipoMov ON
	venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN #CAMBIO Cambio ON 
	Cambio.genMonedas = conAsientos.Moneda_Id
	INNER JOIN genMonedas ON 
	genMonedas.genMonedas =conAsientos.Moneda_Id
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	WHERE
		conAsientos.Anulado = 0 AND 
		conAsientos.Posteado = 1 AND 
		venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and
		conAsientos.Fecha <= @FechaHasta and 
		conAsientos.Empresa_Id = @Empresa_Id and 
		(venMovimientos.Saldo +
		ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id = venMovimientos.venMovimientos AND 
			genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
			genCancMov.FechaAplicacion > @FechaHasta and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0)+
	ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id_ap = venMovimientos.venMovimientos AND 
			genCancMov.Asiento_Id = conAsientos.conAsientos and 
			genCancMov.FechaAplicacion > @FechaHasta and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0)) <> 0
		And SubTipoMov_Id Not In ('DDC', 'CDC')
order by 1, 5,3
	
GO