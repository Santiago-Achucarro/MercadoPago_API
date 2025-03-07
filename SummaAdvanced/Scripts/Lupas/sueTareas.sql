IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueTareas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('sueTareas','Tareas','Tarea_Id,Descripcion,Posteado,Inactivo','sueTareas','','','Tarea_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tareas', CamposSelect='Tarea_Id,Descripcion,Posteado,Inactivo', FromSelect='sueTareas', WhereSelect='', OrderByDefault='', CamposClaves='Tarea_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='sueTareas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueTareas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTareas'),'Tarea_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTareas'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTareas'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTareas'),'Inactivo')
