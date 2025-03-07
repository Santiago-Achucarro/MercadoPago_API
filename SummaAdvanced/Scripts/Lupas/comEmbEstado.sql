IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comEmbEstado')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comEmbEstado','Estados Embarques','Estado_Id,Descripcion','comEmbEstado','','Estado_Id','Estado_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estados Embarques', CamposSelect='Estado_Id,Descripcion', FromSelect='comEmbEstado', WhereSelect='', OrderByDefault='Estado_Id', CamposClaves='Estado_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comEmbEstado'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comEmbEstado')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comEmbEstado'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comEmbEstado'),'Descripcion')
