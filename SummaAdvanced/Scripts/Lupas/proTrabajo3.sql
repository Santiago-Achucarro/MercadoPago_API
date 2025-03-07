IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proTrabajo3')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('proTrabajo3','Trabajo Tercero','Trabajo3_Id,Descripcion,Inactivo,Posteado,Empresa_Id','proTrabajo3','','','Trabajo3_Id','Descripcion','9140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Trabajo Tercero', 
	 CamposSelect='Trabajo3_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='proTrabajo3', WhereSelect='', OrderByDefault='', CamposClaves='Trabajo3_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario= '9140'
     WHERE Identidad_Id='proTrabajo3'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proTrabajo3')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proTrabajo3'),'Trabajo3_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proTrabajo3'),'Descripcion')


