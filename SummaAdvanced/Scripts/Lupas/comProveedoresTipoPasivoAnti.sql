IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresTipoPasivoAnti')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresTipoPasivoAnti','Tipos_de_pasivo_de_las_cuentas_anticipos','Proveed_Id,TipoCtaProv,Descripcion','vcomProveedoresTipoPasivoAnti','','','TipoCtaProv','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_de_pasivo_de_las_cuentas_anticipos', CamposSelect='Proveed_Id,TipoCtaProv,Descripcion', FromSelect='vcomProveedoresTipoPasivoAnti', WhereSelect='', OrderByDefault='', CamposClaves='TipoCtaProv', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comProveedoresTipoPasivoAnti'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresTipoPasivoAnti')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivoAnti'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivoAnti'),'Descripcion')

