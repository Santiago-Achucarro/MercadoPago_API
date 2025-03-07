IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conOrigAplicReng')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conOrigAplicReng','OrigAplicReng','GrupoOaf_Id,Descripcion','conOrigAplicReng','','','GrupoOaf_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='OrigAplicReng', CamposSelect='GrupoOaf_Id,Descripcion', FromSelect='conOrigAplicReng', WhereSelect='', OrderByDefault='', CamposClaves='GrupoOaf_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conOrigAplicReng'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conOrigAplicReng')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conOrigAplicReng'),'GrupoOaf_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conOrigAplicReng'),'Descripcion')
