INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
VALUES('VENTASLISTASPRECIOS', 'RENATRIO','Valor Subtotal Renglon por Atributo N Producto',100,'N' )
go

update genLexico set Descripcion ='Suma Subtotal Renglones por Atributo N Producto' where Funcion = 'SUMATRIO'
go


INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
VALUES('VENTASLISTASPRECIOS', 'RENATRI','Valor Subtotal Renglon por Atributo N Producto / 100 ',100,'N' )
go

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
VALUES('VENTASLISTASPRECIOS', 'RENATRICLIE','Valor Subtotal Renglon por Atributo N del Cliente Indireccion Producto / 100 ',100,'N' )
go

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
VALUES('VENTASLISTASPRECIOS', 'RENATRI1','Valor Subtotal Renglon por Atributo N Producto',100,'N' )
go


INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
VALUES('VENTASLISTASPRECIOS', 'RENATRI1PL','Valor a Precio Lista Renglon por Atributo N Producto/100',100,'N' )
go




Insert into genVersion (Version) Values(1037.00)
GO