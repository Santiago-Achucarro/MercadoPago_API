IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTareas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genTareas','Tareas','Tarea_Id,Descripcion','genTareas','','Tarea_Id','Tarea_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tareas', CamposSelect='Tarea_Id,Descripcion', FromSelect='genTareas', WhereSelect='', OrderByDefault='Tarea_Id', CamposClaves='Tarea_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genTareas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTareas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTareas'),'Tarea_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTareas'),'Descripcion')

