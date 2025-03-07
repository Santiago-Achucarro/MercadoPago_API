-- En algunos clientes está la función y en otros no --
Delete From genLexico Where SetFunciones = 'VENTASIMPUESTOS' And Funcion = 'TotFactu'
Go
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'TotFactu', 'Devuelve el Neto gravado más los impuestos IVA', 103, 'N')
Go
Insert into genVersion (Version) Values (1121.10)
GO
