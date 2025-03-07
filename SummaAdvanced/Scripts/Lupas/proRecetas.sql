IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proRecetas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('proRecetas','Recetas','Receta_Id,Descripcion,Inactivo,Posteado,Empresa_Id','proRecetas','','','Receta_Id','Descripcion','9110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Recetas', CamposSelect='Receta_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='proRecetas', WhereSelect='', OrderByDefault='', CamposClaves='Receta_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '9110'
     WHERE Identidad_Id='proRecetas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proRecetas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetas'),'Receta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetas'),'Descripcion')
