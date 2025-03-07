IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkGrupos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkGrupos','Grupos','Grupo_Id,Descripcion,Empresa_Id,Inactivo,Posteado','stkGrupos','','','Grupo_Id','Descripcion','2137')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Grupos', CamposSelect='Grupo_Id,Descripcion,Empresa_Id,Inactivo,Posteado', FromSelect='stkGrupos', WhereSelect='', OrderByDefault='', CamposClaves='Grupo_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario='2137'
     WHERE Identidad_Id='stkGrupos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkGrupos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkGrupos'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkGrupos'),'Descripcion')
