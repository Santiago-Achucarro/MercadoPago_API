-- exec impCalularDatos @Impuesto_Id='IVA',@FechaDesde='20190801 00:00:00',@FechaHasta='20190831 00:00:00',@Empresa_Id=1
	drop PROCEDURE impCalularDatos
go
CREATE PROCEDURE impCalularDatos
(
	@Impuesto_Id VarChar(5), 
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id int
)
as
DECLARE @FechainiEje DATETIME

SET @FechainiEje = (SELECT Fecha_Desde From conPeriodos WHERE
	conPeriodos.Periodo = 1 AND 
	conPeriodos.Empresa_Id = @Empresa_Id AND 
	conPeriodos.Ejercicio = (SELECT Ejercicio from conPeriodos conPeriodos1 where
		@FechaDesde between conPeriodos1.Fecha_Desde and conPeriodos1.Fecha_Hasta AND 
		conPeriodos1.Empresa_Id = @Empresa_Id ))
		
	

SELECT Impuesto_id, Descripcion, @FechaDesde as FechaDesde, 
	@FechaHasta  FechaHasta  
from impImpuestos

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	impFormulas.Detalle,
	case when SUM(conmovcont.Importe * (-2*conMovCont.Tipomov+3)) < 0 then 
	-SUM(conmovcont.Importe * (-2*conMovCont.Tipomov+3)) else 0 end as Debe,
	case when SUM(conmovcont.Importe * (-2*conMovCont.Tipomov+3)) > 0 then 
	SUM(conmovcont.Importe * (-2*conMovCont.Tipomov+3)) else 0 end as Haber
from impFormulas inner join impImpuestos on 
impFormulas.impImpuestos = impImpuestos.impImpuestos
INNER JOIN conCuentas ON 
conCuentas.conCuentas = impFormulas.Cuenta_Id
INNER JOIN conMovCont ON 
		conMovCont.Cuenta_Id = conCuentas.conCuentas
INNER JOIN conAsientos ON 
	conAsientos.conAsientos = conMovCont.conAsientos 
	INNER JOIN genEmpresas ON
genEmpresas.genEmpresas = conAsientos.Empresa_Id
LEFT JOIN conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
WHERE
	impImpuestos.Impuesto_Id = @Impuesto_Id and 
	(conAsientos.Fecha >= genEmpresas.FechaInicioSumma  or
		conAsientosCon.conAsientos IS Not NULL) AND
		conAsientos.Especial NOT IN ('CCP','CIR') AND 
	conAsientos.Anulado = 0 AND 
	conAsientos.Posteado = 1 AND 
	conAsientos.Empresa_Id = @Empresa_Id AND 
	conAsientos.Fecha BETWEEN Case impFormulas.DebeHaberAmbos When  'A' THEN @FechainiEje ELSE @FechaDesde END AND @FechaHasta and 
	conMovCont.Tipomov = CASE impFormulas.DebeHaberAmbos  WHEN 'A' THEN conMovCont.Tipomov 
		WHEN 'D' THEN 1 ELSE 2 END
group by conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	impFormulas.Detalle
GO