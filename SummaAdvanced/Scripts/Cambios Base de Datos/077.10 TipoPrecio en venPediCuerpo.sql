Alter table venPediCuerpo Add TipoPrecio Char(1) Null
Go
Update venPediCuerpo Set TipoPrecio = Case When PrecioForm = PrecioLista Then 'L' Else 'M' End
Go
Alter table venPediCuerpo Alter column TipoPrecio Char(1) Not Null
Go

Insert Into genVersion (Version) Values (77.10)
Go

