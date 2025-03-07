IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proRecetaProd')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('proRecetaProd','Recetas por Producto','Receta_Id,Descripcion,Producto_Id','vproRecetasProductos','','Receta_Id','Receta_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Recetas por Producto', CamposSelect='Receta_Id,Descripcion,Producto_Id', FromSelect='vproRecetasProductos', WhereSelect='', OrderByDefault='Receta_Id', CamposClaves='Receta_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='proRecetaProd'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proRecetaProd')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetaProd'),'Receta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetaProd'),'Descripcion')
