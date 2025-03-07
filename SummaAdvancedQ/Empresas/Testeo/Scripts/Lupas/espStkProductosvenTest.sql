IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espStkProductosvenTest')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('espStkProductosvenTest','Productos de Ventas','Producto_Id,Descripcion,Familia_Id,Medida_Id,ListaPrecio_Id,PrecioLista*Convert(Numeric(15,4),isnull(@pPar1,1)) as PrecioLista,CFVenta_Id,vespStkProductosvenTest.Inactivo,vespStkProductosvenTest.Posteado,vespStkProductosvenTest.Empresa_Id,MedidaAlterna,Clase,Observaciones, Color_Id, Talle_Id','vespStkProductosvenTest','','Producto_Id','Producto_Id','Descripcion', '2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos de Ventas', 
	 CamposSelect='Producto_Id,Descripcion,Familia_Id,Medida_Id,ListaPrecio_Id,PrecioLista*Convert(Numeric(15,4),isnull(@pPar1,1)) as PrecioLista,CFVenta_Id,vespStkProductosvenTest.Inactivo,vespStkProductosvenTest.Posteado,vespStkProductosvenTest.Empresa_Id,MedidaAlterna,Clase,Observaciones, Color_Id, Talle_Id', 
	 FromSelect='vespStkProductosvenTest', WhereSelect='', OrderByDefault='Producto_Id', 
	 CamposClaves='Producto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='espStkProductosvenTest'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espStkProductosvenTest')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenTest'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenTest'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenTest'),'PrecioLista')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenTest'),'Color_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenTest'),'Talle_Id')