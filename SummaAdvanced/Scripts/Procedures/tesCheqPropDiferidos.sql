Drop procedure tesCheqPropDiferidosDatos
Go
Create procedure tesCheqPropDiferidosDatos
(
@pFechaHasta Datetime,
@pEmpresa_Id Int
)
As

Select @pFechaHasta FechaHasta

Select tesCheqProp.tesCheqProp, tesIdentifica.Cartera_Id, tesIdentifica.Descripcion DescripcionCartera, tesCheqProp.Chequera_Id,
tesCheqProp.FechaVencimiento, tesCheqProp.aLaOrden, tesCheqProp.numCheque, tesCheqProp.Estado_Id, tesCheqProp.SecuenciaActual,
conMovCont.Importe, conMovCont.ImporteMonedaOriginal, conMovCont.TipoMov, tesRengMovi.tesMovimientos, tesRengMovi.conRenglon,
conCentro1.Centro1_Id, conCentro2.Centro2_Id, genMonedas.Moneda_Id
From tesCheqProp
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesCheqProp.Cartera_Id
Inner Join tesBPlink On tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesBPlink.tesMovimientos And
	tesRengMovi.conRenglon = tesBPlink.conRenglon
Inner Join conMovCont On conMovCont.conAsientos = tesRengMovi.tesMovimientos And
	conMovCont.Renglon = tesRengMovi.conRenglon
Inner Join conAsientos On conAsientos.conAsientos = tesRengMovi.tesMovimientos
Inner Join conCuentas On conCuentas.conCuentas = conMovCont.Cuenta_Id
Left Join conCentro1 On conCentro1.conCentro1 = conMovCont.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = conMovCont.Centro2_Id
Inner Join genMonedas On genMonedas.genMonedas = tesIdentifica.Moneda_Id
Where conAsientos.Empresa_Id = @pEmpresa_Id And tesCheqProp.Estado_Id = 'I' And
tesCheqProp.FechaVencimiento <= @pFechaHasta
Order By genMonedas.Moneda_Id, tesIdentifica.Cartera_Id
Go

