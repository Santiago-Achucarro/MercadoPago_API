IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosVen')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductosVen','Productos de Ventas',
	   'Producto_Id,Descripcion,Familia_Id,Medida_Id,ListaPrecio_Id,PrecioLista*Convert(Numeric(15,4),isnull(@pPar1,1)) as PrecioLista,CFVenta_Id,vStkProductosVen.Inactivo,vStkProductosVen.Posteado,vStkProductosVen.Empresa_Id,MedidaAlterna,Clase,Observaciones,VigenciaDesde, VigenciaHasta','vStkProductosVen','','Producto_Id','Producto_Id','Descripcion', '2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos de Ventas', 
	 CamposSelect='Producto_Id,Descripcion,Familia_Id,Medida_Id,ListaPrecio_Id,PrecioLista*Convert(Numeric(15,4),isnull(@pPar1,1)) as PrecioLista,CFVenta_Id,vStkProductosVen.Inactivo,vStkProductosVen.Posteado,vStkProductosVen.Empresa_Id,MedidaAlterna,Clase,Observaciones,VigenciaDesde, VigenciaHasta', 
	 FromSelect='vStkProductosVen', WhereSelect='', OrderByDefault='Producto_Id', 
	 CamposClaves='Producto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='stkProductosVen'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosVen')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'Familia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'PrecioLista')