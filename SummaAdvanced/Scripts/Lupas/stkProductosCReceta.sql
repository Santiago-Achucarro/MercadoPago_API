IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosCReceta')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkProductosCReceta','Productos','Producto_Id,Descripcion,Inactivo,Posteado,Medida_Id,Empresa_Id,Receta_Id','vstkProductosCReceta','','','Producto_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos', 
	 CamposSelect='Producto_Id,Descripcion,Inactivo,Posteado,Medida_Id,Empresa_Id,Receta_Id', 
	 FromSelect='vstkProductosCReceta', WhereSelect='', OrderByDefault='', CamposClaves='Producto_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='stkProductosCReceta'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosCReceta')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCReceta'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCReceta'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCReceta'),'Medida_Id')
