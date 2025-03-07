IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosComU')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductosComU','Productos','Producto_Id,stkProductos.Descripcion,stkProductos.Empresa_Id,stkProductos.Posteado,stkProductos.Acepta_Compras,stkUniMed.Medida_Id,stkProductos.Inactivo','stkProductos inner join stkUniMed ON stkProductos.UMCompra  = stkUniMed.stkUniMed','Acepta_Compras=1','','Producto_Id','Descripcion','2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos', 
	 CamposSelect='Producto_Id,stkProductos.Descripcion,stkProductos.Empresa_Id,stkProductos.Posteado,stkProductos.Acepta_Compras,stkUniMed.Medida_Id,stkProductos.Inactivo', 
	 FromSelect='stkProductos inner join stkUniMed ON stkProductos.UMCompra  = stkUniMed.stkUniMed', WhereSelect='Acepta_Compras=1', 
	 OrderByDefault='', CamposClaves='Producto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='stkProductosComU'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosComU')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosComU'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosComU'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosComU'),'Medida_Id')
