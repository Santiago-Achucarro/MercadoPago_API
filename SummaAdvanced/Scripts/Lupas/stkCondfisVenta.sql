IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkCondfisVenta')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkCondfisVenta','CF Producto - Impuestos Ventas','CFVenta_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkCondfisVenta','','','CFVenta_Id','Descripcion','413010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='CF Producto - Impuestos Ventas', CamposSelect='CFVenta_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkCondfisVenta', WhereSelect='', OrderByDefault='', CamposClaves='CFVenta_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '413010'
     WHERE Identidad_Id='stkCondfisVenta'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkCondfisVenta')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCondfisVenta'),'CFVenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCondfisVenta'),'Descripcion')
