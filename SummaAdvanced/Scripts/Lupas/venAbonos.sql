IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venAbonos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('venAbonos','Abonos','Cliente_Id,RazonSocial,FechaInicio,FechaFin,Posteado,vvenAbonos.Empresa,Vendedor_Id','vvenAbonos','','FechaInicio Desc','','','venAbonos','venAbonos','venAbonosSegmentos')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Abonos', 
	 CamposSelect='Cliente_Id,RazonSocial,FechaInicio,FechaFin,Posteado,vvenAbonos.Empresa,Vendedor_Id', 
	 FromSelect='vvenAbonos', 
	 WhereSelect='', 
	 OrderByDefault='FechaInicio Desc', 
	 CamposClaves='', 
	 CampoDescripcion='', 
	 CampoFKTablaSeg='venAbonos', 
	 CampoPKVistaSeg='venAbonos', 
	 VistaSeg = 'venAbonosSegmentos'
     WHERE Identidad_Id='venAbonos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venAbonos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonos'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonos'),'FechaInicio')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonos'),'FechaFin')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venAbonos'),'Vendedor_Id')

Go
 