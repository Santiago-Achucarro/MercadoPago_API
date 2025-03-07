IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espStkProductosvenKSK')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('espStkProductosvenKSK','Productos de Ventas','Producto_Id,Descripcion,Familia_Id,Medida_Id,ListaPrecio_Id,PrecioLista*Convert(Numeric(15,4),isnull(@pPar1,1)) as PrecioLista,CFVenta_Id,vespStkProductosvenKSK.Inactivo,vespStkProductosvenKSK.Posteado,vespStkProductosvenKSK.Empresa_Id,MedidaAlterna,Clase,Observaciones, Color_Id, Talle_Id','vespStkProductosvenKSK','','Producto_Id','Producto_Id','Descripcion', '2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos de Ventas', 
	 CamposSelect='Producto_Id,Descripcion,Familia_Id,Medida_Id,ListaPrecio_Id,PrecioLista*Convert(Numeric(15,4),isnull(@pPar1,1)) as PrecioLista,CFVenta_Id,vespStkProductosvenKSK.Inactivo,vespStkProductosvenKSK.Posteado,vespStkProductosvenKSK.Empresa_Id,MedidaAlterna,Clase,Observaciones, Color_Id, Talle_Id', 
	 FromSelect='vespStkProductosvenKSK', WhereSelect='', OrderByDefault='Producto_Id', 
	 CamposClaves='Producto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='espStkProductosvenKSK'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espStkProductosvenKSK')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenKSK'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenKSK'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenKSK'),'PrecioLista')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenKSK'),'Color_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('espStkProductosvenKSK'),'Talle_Id')