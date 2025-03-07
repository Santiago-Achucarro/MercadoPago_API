IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genLetraCompras')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genLetraCompras','Letras Compras','Valor,Descripcion','vgenLetraCompras','','','Valor','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Letras Compras', CamposSelect='Valor,Descripcion', FromSelect='vgenLetraCompras', WhereSelect='', OrderByDefault='', CamposClaves='Valor', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genLetraCompras'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genLetraCompras')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLetraCompras'),'Valor')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLetraCompras'),'Descripcion')
