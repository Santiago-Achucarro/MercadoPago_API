IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesTiposmov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesTiposmov','Tipos de Movimientos de Tesoreria','Tipomov,Descripcion','tesTiposmov','','Tipomov','Tipomov','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos de Movimientos de Tesoreria', CamposSelect='Tipomov,Descripcion', FromSelect='tesTiposmov', WhereSelect='', OrderByDefault='Tipomov', CamposClaves='Tipomov', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='tesTiposmov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesTiposmov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesTiposmov'),'Tipomov')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesTiposmov'),'Descripcion')
