delete from genlexico where funcion ='COEFICIENTE' and SetFunciones ='TESRETENCIONES'
Go
delete from genlexico where funcion ='EXENCION' and SetFunciones ='TESRETENCIONES'
Go
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('TESRETENCIONES', 'COEFICIENTE', 'Devuelve el coeficiente del proveedor en Jurisdicción', 123, 'N')
Go
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('TESRETENCIONES', 'EXENCION', 'Devuelve el Porcentaje de Excención', 123, 'N')
Go
Insert into genVersion (Version) Values (1100.25)
GO