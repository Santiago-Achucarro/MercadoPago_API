IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conGruposCont')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conGruposCont','Grupos_de_Centros','Grupo_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conGruposCont','','Grupo_Id','Grupo_Id','Descripcion','3135')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Grupos_de_Centros', CamposSelect='Grupo_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='conGruposCont', WhereSelect='', OrderByDefault='Grupo_Id', CamposClaves='Grupo_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '3135'
     WHERE Identidad_Id='conGruposCont'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conGruposCont')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conGruposCont'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conGruposCont'),'Descripcion')
