IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proOrdenes')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, CamposClaves, CampoFKTablaSeg,CampoPKVistaSeg,VistaSeg, OrderByDefault, CampoDescripcion)
       Values('proOrdenes','Ordenes Produccion','Producto_Id, DescripcionProducto, FechaNecesidad, FechaEmision, Observaciones,Cantidad, FechaFin, Anulado, Empresa','vproOrden','','', 'proOrden','proOrden','proOrdenSegmento', 'FechaEmision','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ordenes Produccion', 
	 CamposSelect='Producto_Id, DescripcionProducto, FechaNecesidad, FechaEmision, Observaciones,Cantidad, FechaFin, Anulado, Empresa', 
	 FromSelect='vproOrden', 
	 WhereSelect='', 
	 OrderByDefault='FechaEmision',
	 CamposClaves='', 
	 CampoFKTablaSeg='proOrden',
	 VistaSeg='proOrdenSegmento',
	 CampoPKVistaSeg='proOrden'
     WHERE Identidad_Id='proOrdenes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proOrdenes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'DescripcionProducto')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'FechaNecesidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'FechaEmision')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'Observaciones')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'FechaFin')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'Cantidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'Anulado')
