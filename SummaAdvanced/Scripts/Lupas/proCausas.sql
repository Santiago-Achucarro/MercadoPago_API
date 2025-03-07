IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proCausas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('proCausas','Causas','Causa_Id,Descripcion,Inactivo,Posteado','proCausas','','','Causa_Id','Descripcion','9160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Causas', CamposSelect='Causa_Id,Descripcion,Inactivo,Posteado', FromSelect='proCausas', WhereSelect='', OrderByDefault='', CamposClaves='Causa_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '9160'
     WHERE Identidad_Id='proCausas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proCausas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proCausas'),'Causa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proCausas'),'Descripcion')
