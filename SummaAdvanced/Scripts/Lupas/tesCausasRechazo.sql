IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesCausasRechazo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario) 
	 Values('tesCausasRechazo','Causas de Rechazo','Causa_Id,Descripcion','tesCausasRechazo','','Causa_Id','Causa_Id','Descripcion','612040')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Causas de Rechazo', 
	 CamposSelect='Causa_Id,Descripcion', FromSelect='tesCausasRechazo', 
	 WhereSelect='', OrderByDefault='Causa_Id', CamposClaves='Causa_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario  = '612040'
     WHERE Identidad_Id='tesCausasRechazo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesCausasRechazo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCausasRechazo'),'Causa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCausasRechazo'),'Descripcion')
