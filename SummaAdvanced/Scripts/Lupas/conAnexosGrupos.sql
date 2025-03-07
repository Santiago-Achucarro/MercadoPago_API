IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAnexosGrupos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conAnexosGrupos','Anexos Grupos','GrupoAne_Id,Descripcion,Origen,DescripcionOrigen,TipoRubro','vconAnexosGrupos','','','GrupoAne_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Anexos Grupos', CamposSelect='GrupoAne_Id,Descripcion,Origen,DescripcionOrigen,TipoRubro', FromSelect='vconAnexosGrupos', WhereSelect='', OrderByDefault='', CamposClaves='GrupoAne_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conAnexosGrupos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAnexosGrupos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'GrupoAne_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'Origen')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'DescripcionOrigen')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'TipoRubro')
