-- exec inf_tesCheqPropImpresion 1, 'BNMX1', 14,2,2

Drop procedure inf_tesCheqPropImpresion
Go

Create procedure inf_tesCheqPropImpresion
(
@Empresa_Id int,
@Cartera_Id varChar(5),
@Chequera_Id int,
@NumChequeDesde int,
@NumChequeHasta int = Null,
@ParaAbonoEnCuenta Bit = 0
)
As
Select conAsientos.Fecha, tesCheqProp.FechaVencimiento, tesCheqProp.tesCheqProp, conMovCont.ImporteMonedaOriginal Importe, tesCheqProp.aLaOrden, 
	genMonedas.Moneda_Id, genPaises.CodFiscal Pais_Id, genMonedasBase.Moneda_Id MonedaBase, genPaises.Dominio_Id, genMonedas.Descripcion as DescripcionMoneda
From tesCheqProp
Inner Join tesBPlink On tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesBPlink.tesMovimientos And tesRengMovi.conRenglon = tesBPlink.conRenglon
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner Join conMovCont On conMovCont.conAsientos = tesBPlink.tesMovimientos And conMovCont.Renglon = tesBPlink.conRenglon
Inner Join conAsientos On conAsientos.conAsientos = conMovCont.conAsientos
iNNER JOIN genMonedas ON  genMonedas.genMonedas = tesIdentifica.Moneda_Id
inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
inner join genPaises ON  genPaises.genPaises = genEmpresas.Pais_Id
inner join genMonedas genMonedasBase ON  genMonedasBase.genMonedas = genEmpresas.Moneda_Id
Where tesBPlink.Secuencia = 1 And conAsientos.Empresa_Id = @Empresa_Id And
tesIdentifica.Cartera_Id = @Cartera_Id And tesCheqProp.Chequera_Id = @Chequera_Id And
tesCheqProp.numCheque Between @NumChequeDesde And IsNull(@NumChequeHasta, 999999999999)
Go
