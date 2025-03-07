
-- Inf_comCompSaldo  '20191231','0011','0011',1
DROP PROCEDURE Inf_comCompSaldo 
GO
CREATE PROCEDURE Inf_comCompSaldo
(
	@FechaHasta DateTime, 
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Empresa_Id INT

)
AS

SELECT genMonedas.genMonedas,
dbo.func_TipoCambio(genMonedas.genMonedas, DATEADD(dd,1,@FechaHasta), @Empresa_Id) as Cambio
INTO #CAMBIO
FROM genMonedas


SELECT comProveedores.Proveed_Id , comProveedores.RazonSocial,
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante, 
		conAsientos.Fecha, (commovprov.Saldo +
		ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id = commovprov.commovprov AND 
			genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
			(genCancMov.FechaAplicacion > @FechaHasta or 
			conAsientos.Fecha >@FechaHasta ) 	and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0)+
	ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id_ap = commovprov.commovprov AND 
			genCancMov.Asiento_Id = conAsientos.conAsientos and 
			(genCancMov.FechaAplicacion > @FechaHasta or 
			conAsientos.Fecha >@FechaHasta ) 	and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0))* comMovTipos.Signo * Cambio.Cambio as Saldo, 
			(commovprov.Saldo +
		ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id = commovprov.commovprov AND 
			genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
			(genCancMov.FechaAplicacion > @FechaHasta or 
			conAsientos.Fecha >@FechaHasta ) 	and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0)+
	ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id_ap = commovprov.commovprov AND 
			genCancMov.Asiento_Id = conAsientos.conAsientos and 
			(genCancMov.FechaAplicacion > @FechaHasta or 
			conAsientos.Fecha >@FechaHasta ) and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0))* comMovTipos.Signo as SaldoOri , Cambio.Cambio 

from comMovProv INNER JOIN conAsientos ON
	comMovProv.comMovProv = conAsientos.conAsientos
	inner join comProveedores ON 
	comProveedores.genEntidades = comMovProv.Proveed_Id 
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
	inner join comMovTipos ON
	comMovTipos.TipoMov = comMovProv.TipoMov
	INNER JOIN #CAMBIO Cambio ON 
	Cambio.genMonedas = conAsientos.Moneda_Id
	WHERE
		comMovProv.FacturaTesoreria = 0 and 
		conAsientos.Anulado = 0 AND 
		conAsientos.Posteado = 1 AND 
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and
		conAsientos.Fecha <= @FechaHasta and 
		conAsientos.Empresa_Id = @Empresa_Id and 
		(commovprov.Saldo +
		ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id = commovprov.commovprov AND 
			genCancMov.Asiento_Id_Ap = conAsientos.conAsientos and 
			(genCancMov.FechaAplicacion > @FechaHasta or 
			conAsientos.Fecha >@FechaHasta ) and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0)+
	ISNULL((SELECT SUM(Importe) from genCancMov, conAsientos Where
			genCancMov.Asiento_Id_ap = commovprov.commovprov AND 
			genCancMov.Asiento_Id = conAsientos.conAsientos and 
			(genCancMov.FechaAplicacion > @FechaHasta or 
			conAsientos.Fecha >@FechaHasta ) and 
			conAsientos.Anulado = 0 and 
			conAsientos.Posteado = 1),0)) <> 0
order by 1, 4,3
	
GO