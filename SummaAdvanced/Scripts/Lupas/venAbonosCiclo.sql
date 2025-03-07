IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venAbonosCiclo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('venAbonosCiclo','Ciclo de Abonos','FechaDesde,FechaHasta,ClienteDesde,ClienteHasta,vvenAbonosCiclo.Empresa_Id','vvenAbonosCiclo','','FechaDesde Desc','','','venAbonosFacturacion','venAbonosFacturacion','venAbonosFactuSegmentos')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ciclo de Abonos', 
	 CamposSelect='FechaDesde,FechaHasta,ClienteDesde,ClienteHasta,vvenAbonosCiclo.Empresa_Id', 
	 FromSelect='vvenAbonosCiclo', 
	 WhereSelect='', 
	 OrderByDefault='FechaDesde Desc', 
	 CamposClaves='', 
	 CampoDescripcion='', 
	 CampoFKTablaSeg='venAbonosFacturacion', 
	 CampoPKVistaSeg='venAbonosFacturacion', 
	 VistaSeg = 'venAbonosFactuSegmentos'
     WHERE Identidad_Id='venAbonosCiclo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venAbonosCiclo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonosCiclo'),'FechaDesde')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonosCiclo'),'FechaHasta')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonosCiclo'),'ClienteDesde')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonosCiclo'),'ClienteHasta')

Go
 