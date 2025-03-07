IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espstkTallerImp')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('espstkTallerImp','Talles','Talle_Id,Descripcion,Inactivo,Posteado','espstkTalleImp','','','Talle_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Talles', CamposSelect='Talle_Id,Descripcion,Inactivo,Posteado', FromSelect='espstkTalleImp', WhereSelect='', OrderByDefault='', CamposClaves='Talle_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='espstkTallerImp'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espstkTallerImp')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espstkTallerImp'),'Talle_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espstkTallerImp'),'Descripcion')
