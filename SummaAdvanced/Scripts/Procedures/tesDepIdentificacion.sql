DROP PROCEDURE tesDepIdentificacionDatos
go

CREATE PROCEDURE tesDepIdentificacionDatos(
	@Empresa_Id Int, 
	@Cartera_id VarChar(5)
)
as

SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	dbo.FechaActual() as Fecha, CAST(0 as bit) as TimbraAhora
from tesIdentifica 
WHERE
tesIdentifica.Cartera_Id = @Cartera_id

SELECT conAsientos.Fecha, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante, 
	tesIdentifica.Cartera_Id, conMovCont.ImporteMonedaOriginal, genMonedas.Moneda_Id, ' ' AS Cliente_Id, 
	tesMovimientos.tesMovimientos, tesRengMovi.Cambio, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, conMovCont.ImporteMonedaOriginal as Saldo
from tesDepoPorIdent 
	inner join  conAsientos ON  conAsientos.conAsientos =tesDepoPorIdent.tesMovimientos
	inner join tesMovimientos ON  tesMovimientos.tesMovimientos = conAsientos.conAsientos
	inner join tesRengMovi ON  tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdentifica ON  tesIdentifica.tesIdentifica =tesRengMovi.Cartera_Id
	INNER JOIN  genAsiSegmentos ON  genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos =genAsiSegmentos.Segmento_Id
	inner join genMonedas ON  genMonedas.genMonedas = tesIdentifica.Moneda_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
				conMovCont.Renglon = tesRengMovi.conRenglon
	LEFT JOIN conAsientos Factura ON  Factura.conAsientos =tesDepoPorIdent.venMovimientos and 
		Factura.Anulado = 0 and 
		Factura.Posteado = 1 

WHERE
	conAsientos.Posteado = 1 AND 
	conAsientos.Anulado= 0 AND 
	conAsientos.Empresa_Id = @Empresa_Id and 
	tesIdentifica.Cartera_Id = @Cartera_id and 
	Factura.conAsientos IS NULL
ORDER BY 1,2


--aplicaciones
select cast (0 as bigint) as tesMovimientos, cast(0 as bigint) as venMovimientos, ' ' as Segmento, 
	convert(datetime,null) as Fecha, 0.00 as Importe, 0.00 as Saldo, cast(0 as smallint) as NroCuota, 0.00 as ImporteAplicado, 
		convert(datetime, null) as FechaVencimiento

