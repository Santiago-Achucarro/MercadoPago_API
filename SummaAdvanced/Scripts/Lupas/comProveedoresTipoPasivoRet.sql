IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresTipoPasivoRet')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresTipoPasivoRet','Tipo de Cuenta Pasivo','TipoCtaProv,Descripcion','vcomProveedoresTipoPasivoRet','','TipoCtaProv','TipoCtaProv','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo de Cuenta Pasivo', CamposSelect='TipoCtaProv,Descripcion', FromSelect='vcomProveedoresTipoPasivoRet', WhereSelect='', OrderByDefault='TipoCtaProv', CamposClaves='TipoCtaProv', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comProveedoresTipoPasivoRet'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresTipoPasivoret')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivoRet'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivoret'),'Descripcion')
