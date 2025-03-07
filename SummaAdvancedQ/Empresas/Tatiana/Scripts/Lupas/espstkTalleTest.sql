IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espstkTalleTest')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('espstkTalleTest','Talles','Talle_Id,Descripcion,Posteado,Inactivo','espstkTalleTest','','','Talle_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Talles', CamposSelect='Talle_Id,Descripcion,Posteado,Inactivo', FromSelect='espstkTalleTest', WhereSelect='', OrderByDefault='', CamposClaves='Talle_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='espstkTalleTest'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espstkTalleTest')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espstkTalleTest'),'Talle_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espstkTalleTest'),'Descripcion')
