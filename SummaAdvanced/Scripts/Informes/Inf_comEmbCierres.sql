-- Inf_comEmbCierres '20210401','20210430',1
-- Inf_comEmbCierres '20210512','20210512',1
DROP PROCEDURE Inf_comEmbCierres
GO

CREATE PROCEDURE Inf_comEmbCierres(
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@Empresa_Id Int
)

AS

SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) AS Embarque, 
	genAsiSegmentosR.Asiento_id,
	dbo.Segmento(genAsiSegmentosR.Segmento_Id, genAsiSegmentosR.Segmento1C,
	genAsiSegmentosR.Segmento2C, genAsiSegmentosR.Segmento3C, genAsiSegmentosR.Segmento4C,
	genAsiSegmentosR.Segmento1N, genAsiSegmentosR.Segmento2N, genAsiSegmentosR.Segmento3N,
	genAsiSegmentosR.Segmento4N) AS Revaluo, 
	conAsientos.Fecha, genMonedas.Moneda_Id,comEmbAsiCierre.Cambio,
	ISNULL((select SUM(Importe*(-2*Tipomov+3))  from conMovCont where
		conMovCont.conAsientos =conAsientos.conAsientos and 
		conMovCont.TipoMov = 1 AND
		conMovCont.Clase IN( 'RVCNT','RVOTR')),0) as PerdidaCamb,
	ISNULL((select SUM(Importe*(-2*Tipomov+3))  from conMovCont where
		conMovCont.conAsientos =conAsientos.conAsientos and 
		conMovCont.TipoMov = 2 AND
		conMovCont.Clase IN( 'RVCNT','RVOTR')),0) as UtilidadCamb,
		ISNULL((select SUM(Importe*(-2*Tipomov+3))  from conMovCont, conCuentas 
		where
		conMovCont.conAsientos =conAsientos.conAsientos and 
		conCuentas.conCuentas = conMovCont.Cuenta_Id and 
		conCuentas.Cuenta_Id NOT LIKE '1%' AND 
		conMovCont.Clase ='RV'),0) as COSTO,
		ISNULL((select SUM(Importe*(-2*Tipomov+3))  from conMovCont, conCuentas 
		where
		conMovCont.conAsientos =conAsientos.conAsientos and 
		conCuentas.conCuentas = conMovCont.Cuenta_Id and 
		conCuentas.Cuenta_Id LIKE '1%' AND 
		conMovCont.Clase ='RV'),0) as INVENTARIO

from comEmbAsiCierre 
INNER JOIN genAsiSegmentos ON  genAsiSegmentos.Asiento_Id = comEmbAsiCierre.comEmbarques
INNER JOIN genAsiSegmentos genAsiSegmentosR ON  genAsiSegmentosR.Asiento_Id = comEmbAsiCierre.stkMoviCabe
INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentosR.Asiento_Id
INNER JOIN conAsientos  conAsientosE on  conAsientosE.conAsientos = comEmbAsiCierre.comEmbarques
inner join genMonedas ON  genMonedas.genMonedas = conAsientosE.Moneda_Id

WHERE
	conAsientos.Empresa_Id = @Empresa_Id AND 
	conAsientos.Fecha Between @FechaDesde and @FechaHasta
	ORDER BY 1,2
GO


	
	