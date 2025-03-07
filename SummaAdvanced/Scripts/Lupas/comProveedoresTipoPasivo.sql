IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresTipoPasivo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresTipoPasivo','Tipo de Cuenta Pasivo','TipoCtaProv,Descripcion','comProveedoresTipoPasivo','','Descripcion','TipoCtaProv','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo de Cuenta Pasivo', CamposSelect='TipoCtaProv,Descripcion', FromSelect='comProveedoresTipoPasivo', WhereSelect='', OrderByDefault='Descripcion', CamposClaves='TipoCtaProv', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comProveedoresTipoPasivo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresTipoPasivo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivo'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivo'),'Descripcion')
