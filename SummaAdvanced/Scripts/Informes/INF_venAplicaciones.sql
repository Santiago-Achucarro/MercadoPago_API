
-- INF_venAplicaciones  '20180101','20180630',' ','ZZZ',1
DROP Procedure INF_venAplicaciones 
GO
CREATE Procedure INF_venAplicaciones 
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Empresa_Id INT
)
AS

SELECT  venClientes.Cliente_Id, venClientes.RazonSocial,
	genAsiSegmentos.Asiento_Id, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) as ComprobantePag, 
	genCancMov.FechaAplicacion,
	genAsiSegmentosf.Asiento_Id as Asiento_idf, 
	dbo.Segmento(genAsiSegmentosF.Segmento_Id, genAsiSegmentosF.Segmento1C,
	genAsiSegmentosF.Segmento2C,genAsiSegmentosF.Segmento3C,genAsiSegmentosF.Segmento4C,
	genAsiSegmentosF.Segmento1N,	genAsiSegmentosF.Segmento2N,genAsiSegmentosF.Segmento3N,
	genAsiSegmentosF.Segmento4N) as ComprobanteFact, 
	genCancMov.Importe, genCancMov.CuotaNro
	
from genAsiSegmentos INNER JOIN conAsientos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genCancMov ON
genCancMov.Asiento_Id_Ap = conAsientos.conAsientos
inner join genAsiSegmentos as genAsiSegmentosF on
genAsiSegmentosF.Asiento_Id = genCancMov.Asiento_Id
INNER JOIN conAsientos as conAsientosF ON 
conAsientosF.conAsientos = genAsiSegmentosF.Asiento_Id
INNER JOIN venMovimientos ON
venMovimientos.venMovimientos = conAsientosF.conAsientos
INNER JOIN venClientes ON
venClientes.genEntidades = venMovimientos.Cliente_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientosF.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and 
	genCancMov.FechaAplicacion between @FechaDesde and @FechaHasta
ORDER BY 1, 3, 5
	
