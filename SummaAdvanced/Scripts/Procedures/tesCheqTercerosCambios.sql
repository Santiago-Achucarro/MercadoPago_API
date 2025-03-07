DROP PROCEDURE tesCheqTercerosCambioDatos
GO
CREATE PROCEDURE tesCheqTercerosCambioDatos
(
@FechaVencimiento DATETIME = NULL,
@Banco_Id VARCHAR(3) = NULL,
@numCheque INT = NULL,
@Importe qMonedaD2 = NULL
)
AS
SELECT @FechaVencimiento FechaVencimiento, @Banco_Id Banco_Id, '' DescBanco, @numCheque numCheque, @Importe Importe 

SELECT tesCheqTerceros.FechaVencimiento, tesCheqTerceros.tesCheqTerceros,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, 
tesIdentifica.Cartera_Id, tesIdentifica.Cartera_Id DescCartera, 
tesBancos.Banco_Id, tesBancos.Descripcion DescBanco, tesCheqTerceros.numCheque,
tesCheqTerceros.sucBanco, tesCheqTerceros.Estado_Id, tesCheqTerEstado.Descripcion DescEstado,
conMovCont.Importe, tesCheqTerceros.Empresa_Id, 
tesCheqTerceros.Clearing, tesClearing.Descripcion as DescripcionClearing, 
tesCheqTerceros.SecuenciaActual, tesCheqTerceros.ClearingDias,
tesCheqTerceros.cuentaBanco, CAST(0 AS BIT) Marca
FROM tesCheqTerceros
INNER JOIN tesBancos ON tesCheqTerceros.Banco_Id = tesBancos.tesBancos
INNER JOIN tesCTlink ON tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros
INNER JOIN tesMovimientos ON tesCTlink.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN tesRengMovi ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos AND
	tesCTlink.conRenglon = tesRengMovi.conRenglon
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
INNER JOIN conAsientos ON tesRengMovi.tesMovimientos = conAsientos.conAsientos 
INNER JOIN tesIdentifica ON tesCheqTerceros.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos AND
conMovCont.Renglon = tesRengMovi.conRenglon
INNER JOIN tesCheqTerEstado  ON tesCheqTerEstado.Estado_Id = tesCheqTerceros.Estado_Id
INNER JOIN tesClearing  ON tesClearing.Clearing = tesCheqTerceros.Clearing
WHERE tesBancos.Banco_Id = ISNULL(@Banco_Id,tesBancos.Banco_Id) AND
tesCheqTerceros.FechaVencimiento = ISNULL(@FechaVencimiento,tesCheqTerceros.FechaVencimiento) AND
conMovCont.Importe = ISNULL(@Importe,conMovCont.Importe) AND
tesCheqTerceros.numCheque = ISNULL(@numCheque,tesCheqTerceros.numCheque) AND
tesCheqTerceros.SecuenciaActual = 1
ORDER BY tesCheqTerceros.FechaVencimiento


