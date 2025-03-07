IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'vProductoMedida')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('vProductoMedida','Producto Unidad de Medida','Medida_Id,Descripcion,Factor,Producto_Id,Inactivo,Posteado,Empresa_Id','vProductoMedida','','','Medida_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Producto Unidad de Medida', CamposSelect='Medida_Id,Descripcion,Factor,Producto_Id,Inactivo,Posteado,Empresa_Id', FromSelect='vProductoMedida', WhereSelect='', OrderByDefault='', CamposClaves='Medida_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='vProductoMedida'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('vProductoMedida')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vProductoMedida'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vProductoMedida'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vProductoMedida'),'Factor')
