DROP PROCEDURE Inf_SubMayorImp
GO

CREATE PROCEDURE Inf_SubMayorImp
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@CuentaDesde VarChar(15),
	@CuentaHasta VarChar(15),
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@Empresa_Id Int
)
AS

SELECT conCuentas.Cuenta_Id, conAsientos.Fecha, conAsientos.conAsientos,
dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Comprobante, 
	impImpuestos.Impuesto_Id, 
	impImpuestos.Descripcion as DescripcionImp, 
		conCuentas.Descripcion DescripcionCta, 
		ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, 
		ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_Id,
	CASE WHEN conMovCont.TipoMov = 1 then conMovCont.Importe else 0  end as Debe, 
	CASE WHEN conMovCont.TipoMov = 2 then conMovCont.Importe else 0  end as Haber
from impLiquidacion 
INNER JOIN conAsientos ON conAsientos.conAsientos = impLiquidacion.conAsientos 
INNER JOIN genAsiSegmentos ON  genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN impImpuestos ON impImpuestos.impImpuestos = impLiquidacion.Impuesto_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos 
INNER JOIN conCuentas ON  conCuentas.conCuentas  = conMovCont.Cuenta_Id
LEFT JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
WHERE
	conAsientos.Posteado = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Fecha Between @FechaDesde and @FechaHasta and 
	conCuentas.Cuenta_Id Between @CuentaDesde and @CuentaHasta and 
	ISNULL(conCentro1.Centro1_Id,'') BETWEEN @Centro1Desde and @Centro1Hasta and 
	ISNULL(conCentro2.Centro2_Id,'') BETWEEN @Centro2Desde and @Centro2Hasta 
ORDER BY 1,2,3	
GO