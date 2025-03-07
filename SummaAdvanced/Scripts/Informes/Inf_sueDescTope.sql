-- Inf_sueDescTope  0,9999,0,99999,'20190930',' ','zzzz',1
drop PROCEDURE Inf_sueDescTope 
go
CREATE PROCEDURE Inf_sueDescTope 
(
	@LegajoDesde Int,
	@LegajoHasta Int,
	@ConceptoDesde Int,
	@ConceptoHasta Int,
	@Fecha DateTime, 
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@Empresa_Id int

)

as


SELECT Concepto_Id, Descripcion, Fecha,Comprobamte, 
	Legajo, Nombre, MontoTope, Descuento, 
	MontoTope-Descuento as Saldo
FROM (

SELECT sueConceptos.Concepto_Id, sueConceptos.Descripcion, 
	sueConcAcum.Fecha,
	dbo.Segmento(sueConcAcumSegmento.Segmento_Id, sueConcAcumSegmento.Segmento1C,
	sueConcAcumSegmento.Segmento2C, sueConcAcumSegmento.Segmento3C, sueConcAcumSegmento.Segmento4C,
	sueConcAcumSegmento.Segmento1N, sueConcAcumSegmento.Segmento2N, sueConcAcumSegmento.Segmento3N,
	sueConcAcumSegmento.Segmento4N) AS Comprobamte,
	suePersonal.Legajo, suePersonal.ApellidoPaterno +','+suePersonal.ApellidoMaterno+','+
			suePersonal.Nombres as Nombre,
		sueConcAcum.MontoTope, 
		sueConcAcum.Acumulado -
		ISNULL((SELECT SUM(sueConcDescuento.Monto) 
			FROM sueConcDescuento, sueLiquidacion, conAsientos
			WHERE
				sueConcDescuento.sueLiquidacion = sueLiquidacion.sueLiquidacion AND 
				conAsientos.conAsientos = sueLiquidacion.sueLiquidacion and 
				conAsientos.Anulado = 0 and 
				sueConcDescuento.sueConcAcum = sueConcAcum.sueConcAcum and 
				sueLiquidacion.FechaFinal > @Fecha),0) as Descuento
	from sueConcAcum 
		INNER JOIN sueConceptos ON sueConcAcum.Concepto_Id = sueConceptos.sueConceptos
		INNER JOIN suePersonal ON  suePersonal.genEntidades = sueConcAcum.Legajo
		INNER JOIN suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
		INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
		INNER JOIN sueConcAcumSegmento ON
			sueConcAcumSegmento.sueConcAcum = sueConcAcum.sueConcAcum
		Where
			sueConcAcum.Fecha <= @Fecha and 
			ISNULL(suePersonal.Empresa_Id,@Empresa_Id) = @Empresa_Id and 
			sueConceptos.Concepto_Id BETWEEN @ConceptoDesde and @ConceptoHasta and 
			suePersonal.Legajo BETWEEN @LegajoDesde And @LegajoHasta  and 
			genSucursalesEmpr.Sucursal Between @SucursalDesde And @SucursalHasta) AS XXX
ORDER BY 1, 3, 5
			
			
			