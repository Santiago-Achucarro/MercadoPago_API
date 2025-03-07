IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosCom')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductosCom','Productos','Producto_Id,Descripcion,Empresa_Id,Posteado,Acepta_Compras,UMCompra,Costo,Moneda_Id,MedidaAlterna,Inactivo, Familia_Id, Grupo_Id,CodigoBarra','vstkProductosCom','Acepta_Compras=1','Producto_Id','Producto_Id','Descripcion','2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos', 
	 CamposSelect='Producto_Id,Descripcion,Empresa_Id,Posteado,Acepta_Compras,UMCompra,Costo,Moneda_Id,MedidaAlterna,Inactivo,Familia_Id,Grupo_Id,CodigoBarra', 
	 FromSelect='vstkProductosCom', 
	 WhereSelect='Acepta_Compras=1', OrderByDefault='Producto_Id', CamposClaves='Producto_Id', 
	 CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='stkProductosCom'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosCom')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'Familia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'CodigoBarra')

