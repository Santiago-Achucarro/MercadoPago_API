-- AfiCalcDepre  '20220101','BU', 1
DROP procedure AfiCalcDepre 
GO
create procedure AfiCalcDepre 
(
	@FechaHasta DateTime, 
	@Tipo VarChar(2), 
	@Empresa_id Int
)

as
set transaction isolation level read uncommitted

SELECT afiActivoFijo.AfiActivoFijo, afiActivoFijo.ActivoFijo_Id, 
	AfiActivoFijo.VidaUtilRestante, 
	AfiActivoFijo.ValorInicial - 
		ISNULL((select sum(conMovCont.Importe*(-2*conMovCont.Tipomov+3))
		from  conMovCont INNER join conAsientos ON 
		conMovCont.conAsientos = conAsientos.conAsientos 
		inner join AfiMovimientos on 
		AfiMovimientos.conAsientos = conAsientos.conAsientos  and 
		AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Fecha > @FechaHasta and 
			conMovCont.Clase = 'VO'),0) AS ValorInicial,
		AfiActivoFijo.AmortAcumulada -
		ISNULL((select sum(conMovCont.Importe*(-2*conMovCont.Tipomov+3))
		from  conMovCont INNER join conAsientos ON 
		conMovCont.conAsientos = conAsientos.conAsientos 
		inner join AfiMovimientos on 
		AfiMovimientos.conAsientos = conAsientos.conAsientos  and 
		AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo
		Where
			conAsientos.Anulado = 0 and 
			conAsientos.Fecha > @FechaHasta and 
			conMovCont.Clase = 'AM'),0) AS AmortAcumulada,
	CtaAmortizacion.Cuenta_Id as CtaAmortizacion_Id,
	CtaAmortAcum.Cuenta_Id as CtaAmotrAcum_Id, 
	afiCentros.Centro1_Id, afiCentros.Centro2_Id, AfiCentros.Porcentaje
	into #xxx
from afiActivoFijo 
	inner join conCuentas as CtaAmortAcum on CtaAmortAcum.conCuentas = AfiActivoFijo.CtaAmortAcum_Id
	inner join conCuentas as CtaAmortizacion on CtaAmortizacion.conCuentas = AfiActivoFijo.CtaAmortizacion_Id
	INNER JOIN AfiCentros ON AfiCentros.ActivoFijo_Id = afiActivoFijo.AfiActivoFijo
	
Where
	(FechaBaja IS NULL OR FechaBaja >@FechaHasta) and 
	(FechaIniDepre <= @FechaHasta) AND 
	AfiActivoFijo.Empresa_Id = @Empresa_id and 
	AfiActivoFijo.Tipo = @Tipo and 
	AfiActivoFijo.VidaUtilRestante > 0

SELECT AfiActivoFijo, ActivoFijo_Id, ValorInicial, AmortAcumulada, 
	CONVERT(	numeric(18,2), (ValorInicial - AmortAcumulada) / VidaUtilRestante) as Amortizacion, 
	CtaAmortizacion_Id,  	CtaAmotrAcum_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id, Porcentaje
FROM #xxx AS XXX
inner join conCentro1 on  conCentro1.conCentro1 = xxx.Centro1_Id 
	inner join conCentro2 on  conCentro2.conCentro2 = xxx.Centro2_Id 
WHERE
	ValorInicial > AmortAcumulada 
order by 2	
GO