IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venRepartos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, 
		CamposClaves, CampoDescripcion, CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('venRepartos','Repartos de pedidos','FechaReparto,FechaEntrega,Automatico,Cerrado,Empresa','vvenReparto',
	   '','FechaReparto Desc','','','venReparto','venReparto','venRepaSegmentos')
ELSE
Begin
     UPDATE lupIdentidades SET 
	 Descripcion ='Repartos de pedidos', 
	 CamposSelect='FechaReparto,FechaEntrega,Automatico,Cerrado,Empresa', 
	 FromSelect='vvenReparto', 
	 WhereSelect='', 
	 OrderByDefault='FechaReparto Desc', 
	 CamposClaves='', 
	 CampoDescripcion='', 
	 VistaSeg = 'venRepaSegmentos',
	 CampoFKTablaSeg = 'venReparto',
	 CampoPKVistaSeg = 'venReparto'
     WHERE Identidad_Id='venRepartos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venRepartos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRepartos'),'FechaReparto')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRepartos'),'FechaEntrega')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRepartos'),'Automatico')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRepartos'),'Cerrado')


