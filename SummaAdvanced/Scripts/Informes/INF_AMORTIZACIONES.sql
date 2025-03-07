-- INF_AMORTIZACIONES '20200101','20200131','CD',' ','ZZZZZ',' ','ZZZZZZZ', 0,1
-- INF_AMORTIZACIONES '20181101','20181130','BU',' ','ZZZZZ',' ','ZZZZZZZ', 1, 1
-- INF_AMORTIZACIONES '20181001','20181031','BU',' ','ZZZZZ',' ','ZZZZZZZ', 1, 1
DROP PROCEDURE INF_AMORTIZACIONES
GO

CREATE PROCEDURE INF_AMORTIZACIONES(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Tipo VarChar(2),
	@RubroDesde VarChar(5),
	@RubroHasta VarChar(5),
	@ActivoDesde VarChar(15),
	@ActivoHasta VarChar(15),
	@pDetallado Bit,
	@Empresa_Id Int
)

as

SELECT AfiRubros.Rubro_Id, AfiRubros.Descripcion as DescripcionRubro,
	afiActivoFijo.ActivoFijo_id,  afiActivoFijo.Descripcion, 
		afiActivoFijo.FechaAlta, 
			case When AfiActivoFijo.FechaAlta< @FechaDesde then  afiActivoFijo.ValorInicialSI else 0 end +
			ISNULL((SELECT SUM(conMovCont.importe*(-2*conMovCont.Tipomov+3))
				from conAsientos INNER JOIN conMovCont ON
					conAsientos.conAsientos = conMovCont.conAsientos 
					INNER JOIN AfiMovimientos ON
					conMovCont.Clase = 'VO' AND 
					AfiMovimientos.conAsientos = conMovCont.conAsientos and 
					AfiMovimientos.Renglon = conMovCont.Renglon  and 
					AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo
					Where
						conAsientos.Anulado = 0 and
						conAsientos.Fecha <= @FechaDesde),0) +
				CASE WHEN afiActivoFijo.ValorInicialSI = 0 THEN
			ISNULL((SELECT SUM(conMovCont.importe*(-2*conMovCont.Tipomov+3))
				from conAsientos INNER JOIN conMovCont ON
					conAsientos.conAsientos = conMovCont.conAsientos 
					INNER JOIN AfiConMovCont ON
					AfiConMovCont.conAsientos = conMovCont.conAsientos and 
					AfiConMovCont.Renglon = conMovCont.Renglon  and 
					AfiConMovCont.ActivoFijo_Id = afiActivoFijo.AfiActivoFijo
					Where
						conAsientos.Anulado = 0 and
						conAsientos.Fecha <= @FechaDesde),0) ELSE 0 END ValorInicial, 
	case When AfiActivoFijo.FechaAlta>= @FechaDesde then  afiActivoFijo.ValorInicialSI else 0 end +
			ISNULL((SELECT SUM(conMovCont.importe)
				from conAsientos INNER JOIN conMovCont ON
					conAsientos.conAsientos = conMovCont.conAsientos 
					INNER JOIN AfiMovimientos ON
					conMovCont.Clase = 'VO' AND 
					AfiMovimientos.conAsientos = conMovCont.conAsientos and 
					AfiMovimientos.Renglon = conMovCont.Renglon  and 
					AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo
					Where
						conMovCont.TipoMov = 1 and 
						conAsientos.Anulado = 0 and
						conAsientos.Fecha between @FechaDesde And  @FechaHasta ),0) + 
						CASE WHEN afiActivoFijo.ValorInicialSI = 0 THEN 
						ISNULL((SELECT SUM(conMovCont.importe*(-2*conMovCont.Tipomov+3))
				from conAsientos INNER JOIN conMovCont ON
					conAsientos.conAsientos = conMovCont.conAsientos 
					INNER JOIN AfiConMovCont ON
					AfiConMovCont.conAsientos = conMovCont.conAsientos and 
					AfiConMovCont.Renglon = conMovCont.Renglon  and 
					AfiConMovCont.ActivoFijo_Id = afiActivoFijo.AfiActivoFijo
					Where
						conAsientos.Anulado = 0 and
						conAsientos.Fecha between @FechaDesde And  @FechaHasta ),0) ELSE 0 END	as Altas, 
	ISNULL((SELECT SUM(conMovCont.importe)
				from conAsientos INNER JOIN conMovCont ON
					conAsientos.conAsientos = conMovCont.conAsientos 
					INNER JOIN AfiMovimientos ON
					conMovCont.Clase = 'VO' AND 
					AfiMovimientos.conAsientos = conMovCont.conAsientos and 
					AfiMovimientos.Renglon = conMovCont.Renglon  and 
					AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo
					Where
						conMovCont.TipoMov = 2 and 
						conAsientos.Anulado = 0 and
						conAsientos.Fecha between @FechaDesde And  @FechaHasta ),0) as Bajas, 
			afiActivoFijo.AmortAcumSI -
			ISNULL((SELECT SUM(conMovCont.importe*(-2*conMovCont.Tipomov+3))
				from conAsientos INNER JOIN conMovCont ON
					conAsientos.conAsientos = conMovCont.conAsientos 
					INNER JOIN AfiMovimientos ON
					conMovCont.Clase = 'AM' AND 
					AfiMovimientos.conAsientos = conMovCont.conAsientos and 
					AfiMovimientos.Renglon = conMovCont.Renglon  and 
					AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo
					Where
						conAsientos.Anulado = 0 and
						conAsientos.Fecha <= @FechaDesde),0) AmorAcum, 

			ISNULL((SELECT SUM(conMovCont.importe)
				from conAsientos INNER JOIN conMovCont ON
					conAsientos.conAsientos = conMovCont.conAsientos 
					INNER JOIN AfiMovimientos ON
					conMovCont.Clase = 'AM' AND 
					AfiMovimientos.conAsientos = conMovCont.conAsientos and 
					AfiMovimientos.Renglon = conMovCont.Renglon  and 
					AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo
					Where
						conMovCont.TipoMov = 2 and 
						conAsientos.Anulado = 0 and
						conAsientos.Fecha between @FechaDesde and @FechaHasta),0)  as Aumentos,
						ISNULL((SELECT SUM(conMovCont.importe)
				from conAsientos INNER JOIN conMovCont ON
					conAsientos.conAsientos = conMovCont.conAsientos 
					INNER JOIN AfiMovimientos ON
					conMovCont.Clase = 'AM' AND 
					AfiMovimientos.conAsientos = conMovCont.conAsientos and 
					AfiMovimientos.Renglon = conMovCont.Renglon  and 
					AfiMovimientos.AfiActivoFijo = afiActivoFijo.AfiActivoFijo
					Where
						conMovCont.TipoMov = 1 and 
						conAsientos.Anulado = 0 and
						conAsientos.Fecha between @FechaDesde and @FechaHasta),0)  as Disminuciones
				INTO #AfiCalc
from  afiActivoFijo inner join AfiRubros on
	afiActivoFijo.Rubro_Id = AfiRubros.AfiRubros
	where
		AfiActivoFijo.Empresa_Id = @Empresa_Id and 
		AfiActivoFijo.FechaAlta <= @FechaHasta and 
		AfiActivoFijo.ActivoFijo_Id between @ActivoDesde And @ActivoHasta and 
		AfiRubros.Rubro_Id between @RubroDesde And  @RubroHasta and 
		AfiActivoFijo.Tipo = @Tipo and 
		(AfiActivoFijo.FechaBaja IS NULL OR AfiActivoFijo.FechaBaja >= @FechaDesde)

if (@pDetallado = 1)
	SELECT Rubro_Id, DescripcionRubro, ActivoFijo_Id, Descripcion, FechaAlta,
		ValorInicial, Altas, Bajas, ValorInicial + Altas - Bajas as TotalVI,
		AmorAcum, Aumentos, Disminuciones,  AmorAcum +  Aumentos - Disminuciones AS TotalAM, 
		(ValorInicial + Altas - Bajas) - (AmorAcum +  Aumentos - Disminuciones) AS Neto
	FROM #AfiCalc
	order by 1,3
else
	SELECT Rubro_Id, DescripcionRubro, 
		SUM(ValorInicial) AS ValorInicial, SUM(Altas) as Altas, SUM(Bajas) AS Bajas, 
		SUM(ValorInicial + Altas - Bajas) as TotalVI,
		SUM(AmorAcum) AS AmorAcum, SUM(Aumentos) AS Aumentos, SUM(Disminuciones) AS Disminuciones,  
		SUM(AmorAcum +  Aumentos - Disminuciones) AS TotalAM, 
		SUM((ValorInicial + Altas - Bajas) - (AmorAcum +  Aumentos - Disminuciones)) AS Neto
	FROM #AfiCalc
	GROUP BY Rubro_Id, DescripcionRubro
	order by 1


