IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueVarGlobales')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueVarGlobales','Variables Globales','VarGlobal_Id,Descripcion','sueVarGlobales','','','VarGlobal_Id','Descripcion','S1401010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Variables Globales', CamposSelect='VarGlobal_Id,Descripcion', FromSelect='sueVarGlobales', WhereSelect='', OrderByDefault='', CamposClaves='VarGlobal_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S1401010'
     WHERE Identidad_Id='sueVarGlobales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueVarGlobales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueVarGlobales'),'VarGlobal_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueVarGlobales'),'Descripcion')
