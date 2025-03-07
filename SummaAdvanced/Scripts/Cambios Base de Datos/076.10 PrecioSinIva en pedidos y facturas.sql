Alter table venPediCuerpo Add PrecioSinIva qMonedaD8 Null
Go
Update venPediCuerpo Set PrecioSinIva = PrecioForm
Go
Alter table venPediCuerpo Alter column PrecioSinIva qMonedaD8 Not Null
Go

Alter table venMovConStockCr Add PrecioSinIva qMonedaD8 Null
Go
Update venMovConStockCr Set PrecioSinIva = PrecioForm
Go
Alter table venMovConStockCr Alter column PrecioSinIva qMonedaD8 Not Null
Go

Insert into genVersion (Version) Values (76.10)
Go
