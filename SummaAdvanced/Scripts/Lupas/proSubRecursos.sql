IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proSubRecursos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('proSubRecursos','SubRecursos','SubRecurso_Id,Descripcion,Recurso_Id,Inactivo','vproSubRecursos','','','SubRecurso_Id','Descripcion','9130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SubRecursos', 
	 CamposSelect='SubRecurso_Id,Descripcion,Recurso_Id,Inactivo', 
	 FromSelect='vproSubRecursos', WhereSelect='', OrderByDefault='', CamposClaves='SubRecurso_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '9130'
     WHERE Identidad_Id='proSubRecursos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proSubRecursos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proSubRecursos'),'SubRecurso_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proSubRecursos'),'Descripcion')
