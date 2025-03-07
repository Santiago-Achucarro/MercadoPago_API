IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comImpuestos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comImpuestos','Impuestos de Compras','Impuesto_Id,Descripcion,Inactivo,Posteado,Empresa_Id,Porcentaje','comImpuestos','','','Impuesto_Id','Descripcion', '411010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Impuestos de Compras', CamposSelect='Impuesto_Id,Descripcion,Inactivo,Posteado,Empresa_Id, Porcentaje', FromSelect='comImpuestos', 
	 WhereSelect='', OrderByDefault='', CamposClaves='Impuesto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '411010'
     WHERE Identidad_Id='comImpuestos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comImpuestos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comImpuestos'),'Impuesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comImpuestos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comImpuestos'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comImpuestos'),'Posteado')
