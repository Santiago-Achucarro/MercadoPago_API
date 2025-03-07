IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comTipoPermiRI')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comTipoPermiRI','comTipoPermiRI','TipoPermiRI_Id,Descripcion,TipoRI,EsquemaAuto_Id,Inactivo,Posteado','vcomTipoPermiRI','','','TipoPermiRI_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='comTipoPermiRI', CamposSelect='TipoPermiRI_Id,Descripcion,TipoRI,EsquemaAuto_Id,Inactivo,Posteado', FromSelect='vcomTipoPermiRI', WhereSelect='', OrderByDefault='', CamposClaves='TipoPermiRI_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comTipoPermiRI'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comTipoPermiRI')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'TipoPermiRI_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'TipoRI')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'EsquemaAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'Posteado')
