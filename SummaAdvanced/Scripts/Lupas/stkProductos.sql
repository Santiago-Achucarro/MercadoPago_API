IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductos','Productos','Producto_Id,Descripcion,codigoBarra,Familia_Id,Inactivo,Posteado,Acepta_Ventas,Acepta_Compras,Medida_Id,MedidaAlterna,Clase,Empresa_Id,TrabajaPorLotes,Serializable,UsaDespachoImportacion,Observaciones','vstkProductos','','','Producto_Id','Descripcion','2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos', 
	 CamposSelect='Producto_Id,Descripcion,codigoBarra,Familia_Id,Inactivo,Posteado,Acepta_Ventas,Acepta_Compras,Medida_Id,MedidaAlterna,Clase,Empresa_Id,TrabajaPorLotes,Serializable,UsaDespachoImportacion,Observaciones', 
	 FromSelect='vstkProductos', WhereSelect='', OrderByDefault='', 
	 CamposClaves='Producto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='stkProductos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'codigoBarra')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Familia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Inactivo')


