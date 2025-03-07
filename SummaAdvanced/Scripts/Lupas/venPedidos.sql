IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venPedidos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('venPedidos','Pedidos','Cliente_Id,RazonSocial,Fecha,Posteado,vvenPedidos.Empresa,AnticipoPendiente,Estado,Vendedor_Id','vvenPedidos','','Fecha Desc','','','venPedidos','venPedidos','venPediSegmentos')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Pedidos', 
	 CamposSelect='Cliente_Id,RazonSocial,Fecha,Posteado,vvenPedidos.Empresa, AnticipoPendiente,Estado,Vendedor_Id', 
	 FromSelect='vvenPedidos', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', 
	 CampoDescripcion='', 
	 CampoFKTablaSeg='venPedidos', 
	 CampoPKVistaSeg='venPedidos', 
	 VistaSeg = 'venPediSegmentos'
     WHERE Identidad_Id='venPedidos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venPedidos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPedidos'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPedidos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPedidos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPedidos'),'Vendedor_Id')

Go
 