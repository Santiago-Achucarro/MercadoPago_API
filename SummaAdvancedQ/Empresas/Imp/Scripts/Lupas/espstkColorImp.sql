
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espstkColorImp')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('espstkColorImp','Colores','','espstkColorImp','','','','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Colores', CamposSelect='', FromSelect='espstkColorImp', WhereSelect='', OrderByDefault='', CamposClaves='', CampoDescripcion=''
     WHERE Identidad_Id='espstkColorImp'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espstkColorImp')
End
