IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espstkColorTest')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('espstkColorTest','Colores','Color_Id,Descripcion,Inactivo,Posteado','espstkColorTest','','','Color_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Colores', CamposSelect='Color_Id,Descripcion,Inactivo,Posteado', FromSelect='espstkColorTest', WhereSelect='', OrderByDefault='', CamposClaves='Color_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='espstkColorTest'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espstkColorTest')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espstkColorTest'),'Color_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espstkColorTest'),'Descripcion')
