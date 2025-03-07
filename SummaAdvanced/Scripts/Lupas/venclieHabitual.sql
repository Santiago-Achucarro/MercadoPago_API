IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venclieHabitual')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venclieHabitual','Sucursales Clientes','Sucursal,NombreFantasia,Cliente_Id,CondPagoCli_Id,ListaPrecio_Id,MonedaLista,FormaEntrega_Id,Zona_Id,Vendedor_Id,Inactivo,Posteado,Empresa_Id,MetodoDePago,N_MetodoPago,C_UsoCFDI,UsaComplementoINE,Vendedor,Direccion,MonedaPedido','vClientesHabitual','','','Sucursal','NombreFantasia')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Sucursales Clientes', CamposSelect='Sucursal,NombreFantasia,Cliente_Id,CondPagoCli_Id,ListaPrecio_Id,MonedaLista,FormaEntrega_Id,Zona_Id,Vendedor_Id,Inactivo,Posteado,Empresa_Id,MetodoDePago,N_MetodoPago,C_UsoCFDI,UsaComplementoINE,Vendedor,Direccion,MonedaPedido', 
		FromSelect='vClientesHabitual', 
		WhereSelect='', OrderByDefault='', 
		CamposClaves='Sucursal', 
		CampoDescripcion='NombreFantasia'
     WHERE Identidad_Id='venclieHabitual'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venclieHabitual')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Sucursal')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'NombreFantasia')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Direccion')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Cliente_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'CondPagoCli_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'ListaPrecio_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'FormaEntrega_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Zona_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Vendedor_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'C_UsoCFDI')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'UsaComplementoINE')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Vendedor')