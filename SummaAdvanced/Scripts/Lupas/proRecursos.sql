IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proRecursos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('proRecursos','Recursos','Recurso_Id,Descripcion,Inactivo,Posteado,Empresa_Id,UsaSubRecurso','proRecursos','','','Recurso_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Recursos', 
	 CamposSelect='Recurso_Id,Descripcion,Inactivo,Posteado,Empresa_Id,UsaSubRecurso', 
	 FromSelect='proRecursos', WhereSelect='', OrderByDefault='', CamposClaves='Recurso_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='proRecursos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proRecursos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecursos'),'Recurso_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecursos'),'Descripcion')
