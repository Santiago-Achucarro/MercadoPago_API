IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkTiposMov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkTiposMov','Tipo de Movimientos','Tipomov,Descripcion','stkTiposMov','','Tipomov','Tipomov','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo de Movimientos', CamposSelect='Tipomov,Descripcion', FromSelect='stkTiposMov', WhereSelect='', OrderByDefault='Tipomov', CamposClaves='Tipomov', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='stkTiposMov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkTiposMov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkTiposMov'),'Tipomov')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkTiposMov'),'Descripcion')
