IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venImpuestos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venImpuestos','Impuestos','Impuesto_Id,Descripcion,Inactivo,Posteado,Empresa_Id','venImpuestos','','','Impuesto_Id','Descripcion','412010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Impuestos', CamposSelect='Impuesto_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='venImpuestos', WhereSelect='', OrderByDefault='', CamposClaves='Impuesto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '412010'
     WHERE Identidad_Id='venImpuestos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venImpuestos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venImpuestos'),'Impuesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venImpuestos'),'Descripcion')
