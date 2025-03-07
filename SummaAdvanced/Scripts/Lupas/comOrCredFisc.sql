IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comOrCredFisc')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comOrCredFisc','Origen de Creditos Fiscales','Origen_Id,Descripcion','comOrigenesFiscales','','','Origen_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Origen de Creditos Fiscales', CamposSelect='Origen_Id,Descripcion', FromSelect='comOrigenesFiscales', WhereSelect='', OrderByDefault='', CamposClaves='Origen_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comOrCredFisc'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comOrCredFisc')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOrCredFisc'),'Origen_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOrCredFisc'),'Descripcion')
