Insert into genVersion (Version) Values (50.03);
GO

Begin
Alter table venPediCuerpo Add PrecioListaForm qMonedaD8 Null;
End
Go

Begin
Update venPediCuerpo Set PrecioListaForm = PrecioLista;

Alter table venPediCuerpo Alter Column PrecioListaForm qMonedaD8 Not Null;

End

Insert into genVersion (Version) Values (50.02);



