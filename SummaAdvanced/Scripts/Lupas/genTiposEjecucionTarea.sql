IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTiposEjecucionTarea')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
      Values('genTiposEjecucionTarea','Tipos_Ejecucion_tareas','TipoEjecucionTarea_Id, Descripcion','genTiposEjecucionTarea','','TipoEjecucionTarea_Id','TipoEjecucionTarea_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades 
	 SET Descripcion ='Tareas_Programadas', 
		CamposSelect='TipoEjecucionTarea_Id, Descripcion', 
		FromSelect='genTiposEjecucionTarea', 
		WhereSelect='', 
		OrderByDefault='TipoEjecucionTarea_Id', 
		CamposClaves='TipoEjecucionTarea_Id', 
		CampoDescripcion='Descripcion'
	WHERE Identidad_Id='genTiposEjecucionTarea'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTiposEjecucionTarea')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTiposEjecucionTarea'),'TipoEjecucionTarea_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTiposEjecucionTarea'),'Descripcion')
