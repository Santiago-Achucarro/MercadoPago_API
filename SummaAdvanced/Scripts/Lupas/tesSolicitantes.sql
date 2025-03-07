IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesSolicitantes')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesSolicitantes','Solictantes','Solicitante_Id,Nombre,Empresa_Id,Inactivo,Posteado','tesSolicitantes','','','Solicitante_Id','Nombre')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Solictantes', CamposSelect='Solicitante_Id,Nombre,Empresa_Id,Inactivo,Posteado', FromSelect='tesSolicitantes', WhereSelect='', OrderByDefault='', CamposClaves='Solicitante_Id', CampoDescripcion='Nombre'
     WHERE Identidad_Id='tesSolicitantes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesSolicitantes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitantes'),'Solicitante_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitantes'),'Nombre')
GO
