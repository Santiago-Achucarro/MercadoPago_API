Alter table venPediCuerpo Add SubTotal qMonedaD2 Null

Go
Update venPediCuerpo Set SubTotal = PrecioForm * CantidadOriginal * (1 - Bonificacion/100)
Go
Alter table venPediCuerpo Alter column SubTotal qMonedaD2 Not Null
Go

Alter table venPedidos Add SubTotal qMonedaD2 Null
Go
Alter table venPedidos Add SubTotalBonif qMonedaD2 Null
Go
Update venPedidos Set SubTotal = (Select Sum(PrecioForm * CantidadOriginal) From venPediCuerpo Where venPediCuerpo.venPedidos = venPedidos.venPedidos),
		SubTotalBonif = (Select Sum(PrecioForm * CantidadOriginal * (1 - Bonificacion/100)) + 
venPedidos.Bonificacion1 + venPedidos.Bonificacion2 + venPedidos.Bonificacion3 + venPedidos.Bonificacion4 + venPedidos.Bonificacion5 
From venPediCuerpo Where venPediCuerpo.venPedidos = venPedidos.venPedidos)
Go
Alter table venPedidos Alter column SubTotal qMonedaD2 Not Null
Go
Alter table venPedidos Alter column SubTotalBonif qMonedaD2 Not Null
Go


Alter table venMovimientos Add SubTotal qMonedaD2 Null
Go
Alter table venMovimientos Add SubTotalBonif qMonedaD2 Null
Go
Update venMovimientos Set SubTotal = (Select Sum(PrecioForm * CantOriginal) From venMovConStockCr Where venMovConStockCr.venMovimientos = venMovimientos.venMovimientos),
		SubTotalBonif = (Select Sum(PrecioForm * CantOriginal * (1 - Bonificacion/100)) From venMovConStockCr Where venMovConStockCr.venMovimientos = venMovimientos.venMovimientos)
Go

Update venMovimientos Set SubTotal = (Select Sum(SubTotal) From venMovDetalle Where venMovDetalle.venMovimientos = venMovimientos.venMovimientos),
		SubTotalBonif = (Select Sum(SubTotal) From venMovDetalle Where venMovDetalle.venMovimientos = venMovimientos.venMovimientos) Where SubTotal Is Null
Go

Update venMovimientos Set SubTotal = (Select Sum(conMovCont.ImporteMonedaOriginal) From tesRengMovi, conMovCont
		Where venMovimientos.venMovimientos = tesRengMovi.tesMovimientos And tesRengMovi.tesMovimientos = conMovCont.conAsientos And
			tesRengMovi.conRenglon = conMovCont.Renglon And conMovCont.Clase In ('CLI', 'ANTCL')),
		SubTotalBonif = (Select Sum(conMovCont.ImporteMonedaOriginal) From tesRengMovi, conMovCont
		Where venMovimientos.venMovimientos = tesRengMovi.tesMovimientos And tesRengMovi.tesMovimientos = conMovCont.conAsientos And
			tesRengMovi.conRenglon = conMovCont.Renglon And conMovCont.Clase In ('CLI', 'ANTCL')) Where SubTotal Is Null
Go

Update venMovimientos Set SubTotal = 0, SubTotalBonif = 0 Where SubTotal Is Null
Go

Alter table venMovimientos Alter column SubTotal qMonedaD2 Not Null
Go
Alter table venMovimientos Alter column SubTotalBonif qMonedaD2 Not Null
Go


Insert Into genVersion (Version) Values (78.10)
Go
