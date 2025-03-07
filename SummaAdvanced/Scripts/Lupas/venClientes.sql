IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venClientes')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venClientes','Clientes',
	   'Cliente_Id,RazonSocial,SucursalPredeter,Empresa_Id,Posteado,CUIT,idFiscal,TipoDoc,CondFisc_Id,MonedaLimCred,Inactivo,NombreFantasia,case when @pPar1 IS NOT NULL AND Cliente_Id = ''COTBASE'' THEN @pPar1 ELSE Vendedor_Id END  Vendedor_Id,TipoCredito,MonedaFactura,MonedaPedido',
	   'vvenClientes','','Cliente_Id','Cliente_Id','RazonSocial')

ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Clientes', 
	 CamposSelect='Cliente_Id,RazonSocial,SucursalPredeter,Empresa_Id,Posteado,CUIT,idFiscal,TipoDoc,CondFisc_Id,MonedaLimCred,Inactivo,NombreFantasia,case when @pPar1 IS NOT NULL AND Cliente_Id = ''COTBASE'' THEN @pPar1 ELSE Vendedor_Id END  Vendedor_Id,TipoCredito,MonedaFactura,MonedaPedido', 
	 FromSelect='vvenClientes', 
	 WhereSelect='', 
	 OrderByDefault='Cliente_Id', 
	 CamposClaves='Cliente_Id', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='venClientes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venClientes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'NombreFantasia')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'Vendedor_Id')
go

