IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proRecetasProducto')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('proRecetasProducto','Recetas de un producto','Receta_Id,Descripcion,Inactivo,Posteado,Empresa_Id,Producto_Id,Principal,CtroProd_Id','vstkRecetaProducto','','Principal Desc,Receta_Id','Receta_Id','Descripcion','9110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Recetas de un producto', CamposSelect='Receta_Id,Descripcion,Inactivo,Posteado,Empresa_Id,Producto_Id,Principal,CtroProd_Id', FromSelect='vstkRecetaProducto', WhereSelect='', OrderByDefault='Principal Desc,Receta_Id', CamposClaves='Receta_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '9110'
     WHERE Identidad_Id='proRecetasProducto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proRecetasProducto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetasProducto'),'Receta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetasProducto'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetasProducto'),'CtroProd_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetasProducto'),'Principal')
