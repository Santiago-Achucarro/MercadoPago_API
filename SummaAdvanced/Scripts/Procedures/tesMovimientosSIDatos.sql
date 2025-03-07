-- tesMovimientosSIDatos 'BX475', 1
DROP Procedure tesMovimientosSIDatos
GO
CREATE Procedure tesMovimientosSIDatos
(
	@Cartera_Id Varchar(5), 
	@Empresa Int
)

AS

Select @Cartera_Id as Cartera_Id

SELECT conAsientos.conAsientos, genSegmentos.Segmento_Id,
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
conAsientos.Fecha
From conAsientos INNER JOIN genAsiSegmentos ON 
conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos
INNER JOIN tesSubTiposMov ON  tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id
WHERE
	tesSubTiposMov.SubTipo_Id = 'AIB' AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa and 
	exists(select 1 from tesRengMovi , tesIdentifica WHERE
		tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos and 
		tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica and
		tesIdentifica.Cartera_Id = @Cartera_Id)


GO


