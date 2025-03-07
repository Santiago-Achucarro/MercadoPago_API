IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proVarGlobales')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('proVarGlobales','Variables Globales','Variable_Id,Descripcion','proVarGlobales','','','Variable_Id','Descripcion','9150')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Variables Globales', CamposSelect='Variable_Id,Descripcion', FromSelect='proVarGlobales', WhereSelect='', OrderByDefault='', CamposClaves='Variable_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '9150'
     WHERE Identidad_Id='proVarGlobales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proVarGlobales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proVarGlobales'),'Variable_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proVarGlobales'),'Descripcion')
