IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venTipomov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venTipomov','Tipo de Movimiento','venTipoMov,Descripcion','venTipomov','','','venTipoMov','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo de Movimiento', CamposSelect='venTipoMov,Descripcion', FromSelect='venTipomov', WhereSelect='', OrderByDefault='', CamposClaves='venTipoMov', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='venTipomov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venTipomov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venTipomov'),'venTipoMov')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venTipomov'),'Descripcion')
