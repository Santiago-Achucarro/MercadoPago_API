IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impImpuestos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('impImpuestos','Impuetos','Impuesto_Id,Descripcion,Posteado,Inactivo','impImpuestos','','','Impuesto_Id','Descripcion','41430')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Impuetos', CamposSelect='Impuesto_Id,Descripcion,Posteado,Inactivo', FromSelect='impImpuestos', WhereSelect='', OrderByDefault='', CamposClaves='Impuesto_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '41430'
     WHERE Identidad_Id='impImpuestos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impImpuestos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impImpuestos'),'Impuesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impImpuestos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impImpuestos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impImpuestos'),'Inactivo')
