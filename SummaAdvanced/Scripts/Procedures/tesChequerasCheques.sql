Drop procedure tesChequerasChequesDatos
Go
Create procedure tesChequerasChequesDatos
(
@pEmpresa_Id int,
@pCartera_Id varChar(5),
@pChequera_Id int,
@pnumCheque int = Null
)
As
Select @pCartera_Id Cartera_Id, @pChequera_Id Chequera_Id, @pnumCheque numCheque

Select tesCheqProp.numCheque, conAsientos.Fecha, disFormularios.Formulario_Id, disFormularios.Descripcion DescripcionFormulario,
tesChequeras.TipoChequera, conAsientos.Moneda_Id, conMovCont.ImporteMonedaOriginal, genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento
From tesChequeras
Inner Join tesCheqProp On tesCheqProp.Chequera_Id = tesChequeras.Chequera_Id And tesCheqProp.Cartera_Id = tesChequeras.Cartera_Id
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesCheqProp.Cartera_Id
Inner Join tesBPlink On tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesBPlink.tesMovimientos And tesRengMovi.conRenglon = tesBPlink.conRenglon
Inner Join conMovCont On conMovCont.conAsientos = tesRengMovi.tesMovimientos And conMovCont.Renglon = tesBPlink.conRenglon
Inner Join conAsientos On conAsientos.conAsientos = tesBPlink.tesMovimientos And conAsientos.Empresa_Id = tesChequeras.Empresa_Id
Inner Join disFormularios On disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join tesChequerasEstado On tesChequerasEstado.Estado_Id = tesChequeras.Estado_Id
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Where conAsientos.Anulado = 0 And tesChequeras.Empresa_Id = @pEmpresa_Id And tesChequeras.Chequera_Id = @pChequera_Id And
tesCheqProp.numCheque = isNull(@pnumCheque, tesCheqProp.numCheque)
Go




