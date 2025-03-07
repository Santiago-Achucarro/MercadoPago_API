-- exec tesCheqPropImpresion 1,'BNMX3',47,0,999999
Drop procedure tesCheqPropImpresion
Go

Create procedure tesCheqPropImpresion
(
@pEmpresa_Id int,
@pCartera_Id varChar(5),
@pChequera_Id int,
@pNumChequeDesde int,
@pNumChequeHasta int = Null
)
As

Select @pCartera_Id Cartera_Id, '' DescripcionCartera, @pChequera_Id Chequera_Id,
@pNumChequeDesde NumChequeDesde, isNull(@pNumChequeHasta, 0) NumChequeHasta


Select conAsientos.Fecha, tesCheqProp.FechaVencimiento, tesCheqProp.tesCheqProp, conMovCont.ImporteMonedaOriginal Importe, tesCheqProp.aLaOrden
From tesCheqProp
Inner Join tesBPlink On tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesBPlink.tesMovimientos And tesRengMovi.conRenglon = tesBPlink.conRenglon
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner Join conMovCont On conMovCont.conAsientos = tesBPlink.tesMovimientos And conMovCont.Renglon = tesBPlink.conRenglon
Inner Join conAsientos On conAsientos.conAsientos = conMovCont.conAsientos
Where tesBPlink.Secuencia = 1 And conAsientos.Empresa_Id = @pEmpresa_Id And
tesIdentifica.Cartera_Id = @pCartera_Id And tesCheqProp.Chequera_Id = @pChequera_Id And
tesCheqProp.numCheque Between @pNumChequeDesde And IsNull(@pNumChequeHasta, 999999999)
Go