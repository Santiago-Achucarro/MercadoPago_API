IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espstkTalleKSK')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('espstkTalleKSK','Talles','Talle_Id,Descripcion,Posteado,Inactivo','espstkTalleTest','','','Talle_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Talles', CamposSelect='Talle_Id,Descripcion,Posteado,Inactivo', FromSelect='espstkTalleTest', WhereSelect='', OrderByDefault='', CamposClaves='Talle_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='espstkTalleKSK'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espstkTalleKSK')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espstkTalleKSK'),'Talle_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espstkTalleKSK'),'Descripcion')
