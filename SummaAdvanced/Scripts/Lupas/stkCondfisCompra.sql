IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkCondfisCompra')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkCondfisCompra','CF Producto - Impuestos Compras','CFComp_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkCondfisCompra','','CFComp_Id','CFComp_Id','Descripcion','413020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='CF Producto - Impuestos Compras', CamposSelect='CFComp_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkCondfisCompra', WhereSelect='', OrderByDefault='CFComp_Id', CamposClaves='CFComp_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '413020'
     WHERE Identidad_Id='stkCondfisCompra'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkCondfisCompra')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCondfisCompra'),'CFComp_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCondfisCompra'),'Descripcion')
