IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueCateNombre')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('sueCateNombre','Nombre Categoria','CateNombre_Id,Descripcion','sueCateNombre','','','CateNombre_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Nombre Categoria', CamposSelect='CateNombre_Id,Descripcion', FromSelect='sueCateNombre', WhereSelect='', OrderByDefault='', CamposClaves='CateNombre_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='sueCateNombre'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueCateNombre')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCateNombre'),'CateNombre_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCateNombre'),'Descripcion')
