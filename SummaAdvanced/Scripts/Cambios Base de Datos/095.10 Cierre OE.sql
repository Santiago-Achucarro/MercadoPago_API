Alter table stkMoviCuerpoReva Add ImporteAjusteCosto qMonedaD2 Null
Go
Update stkMoviCuerpoReva Set ImporteAjusteCosto = 0
Go
Alter table stkMoviCuerpoReva Alter column ImporteAjusteCosto qMonedaD2 Not Null
Go

Insert Into genVersion (Version) Values (95.10)
Go

