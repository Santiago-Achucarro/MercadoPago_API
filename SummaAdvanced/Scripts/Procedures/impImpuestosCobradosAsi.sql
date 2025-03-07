DROP PROCEDURE [dbo].[impImpuestosCobradosAsiDatos]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[impImpuestosCobradosAsiDatos]  
(
 @Empresa Int, 
 @FechaDesde DateTime, 
 @FechaHasta DateTime
)
as

SELECT @FechaDesde as FechaDesde, @FechaHasta  FechaHasta

SELECT Distinct genAsiSegmentos.Asiento_Id , 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C
from venMovImpTraslado INNER JOIN genAsiSegmentos ON
venMovImpTraslado.Asiento_Id = genAsiSegmentos.Asiento_Id
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN conAsientos ON
conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
Where
	conAsientos.Fecha BETWEEN @FechaDesde And @FechaHasta and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa
ORDER BY 1

GO


