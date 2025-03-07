IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTareasProgramadas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
      Values('genTareasProgramadas','Tareas_Programadas','TareaProgramada_Id,Descripcion,Posteado,Inactivo,Empresa_Id','genTareasProgramadas','','TareaProgramada_Id','TareaProgramada_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades 
	 SET Descripcion ='Tareas_Programadas', 
		CamposSelect='TareaProgramada_Id,Descripcion,Posteado,Inactivo,Empresa_Id', 
		FromSelect='genTareasProgramadas', WhereSelect='', OrderByDefault='TareaProgramada_Id', 
		CamposClaves='TareaProgramada_Id', CampoDescripcion='Descripcion'
	 WHERE Identidad_Id='genTareasProgramadas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTareasProgramadas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTareasProgramadas'),'TareaProgramada_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTareasProgramadas'),'Descripcion')
