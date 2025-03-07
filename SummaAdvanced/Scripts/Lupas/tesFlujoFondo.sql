IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesFlujoFondo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesFlujoFondo','Flujo de Fondos','FechaDesde,FechaHasta,Periodo','vtesFlujoFondo','','FechaDesde Desc','','', 'tesFlujoFondo','tesFFSegmentos', 'tesFlujoFondo')
ELSE
Begin
     UPDATE lupIdentidades 
		SET Descripcion ='Flujo de Fondos', 
		CamposSelect='FechaDesde,FechaHasta,Periodo', 
		FromSelect='vtesFlujoFondo', 
		WhereSelect='', OrderByDefault='FechaDesde Desc', 
		CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'tesFlujoFondo',
		 VistaSeg = 'tesFFSegmentos', 
		 CampoPKVistaSeg = 'tesFlujoFondo'
		     WHERE Identidad_Id='tesFlujoFondo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesFlujoFondo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesFlujoFondo'),'FechaDesde')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesFlujoFondo'),'FechaHasta')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesFlujoFondo'),'Periodo')



