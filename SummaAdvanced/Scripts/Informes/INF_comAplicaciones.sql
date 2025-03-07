
-- INF_comAplicaciones  '20211001','20211031',' ','ZZZ',1
DROP Procedure INF_comAplicaciones 
GO
CREATE Procedure INF_comAplicaciones 
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Empresa_Id INT
)
AS

SELECT  comProveedores.Proveed_Id, comProveedores.RazonSocial,
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
	genCancMov.Importe, genCancMov.CuotaNro, genMonedas.Moneda_Id, 
	genCancMov.Importe* conAsientos.Cambio as ImporteBase
	
from genAsiSegmentos INNER JOIN conAsientos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genCancMov ON
genCancMov.Asiento_Id = conAsientos.conAsientos
inner join genAsiSegmentos as genAsiSegmentosF on
genAsiSegmentosF.Asiento_Id = genCancMov.Asiento_Id_Ap
INNER JOIN conAsientos as conAsientosF ON 
conAsientosF.conAsientos = genAsiSegmentosF.Asiento_Id
INNER JOIN comMovProv ON
comMovProv.comMovProv = conAsientosF.conAsientos
INNER JOIN comProveedores ON
comProveedores.genEntidades = commovprov.Proveed_Id
inner join genMonedas on  genMonedas.genMonedas =conAsientos.Moneda_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientosF.Anulado = 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
	genCancMov.FechaAplicacion between @FechaDesde and @FechaHasta
ORDER BY 1, 3, 5
	
