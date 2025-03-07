IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkHojaDeRuta')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('stkHojaDeRuta','Hojas_de_Ruta','FechaRegistro,Estado,FormaEntrega_id,Patente_Id,PatenteAcoplado,Reparto','vstkHojaDeRuta','','FechaRegistro Desc','','','stkHojaDeRuta','stkHojaDeRuta','stkHojaSegmentos')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Hojas_de_Ruta', 
	 CamposSelect='FechaRegistro,Estado,FormaEntrega_id,Patente_Id,PatenteAcoplado,Reparto', 
	 FromSelect='vstkHojaDeRuta', 
	 WhereSelect='', 
	 OrderByDefault='FechaRegistro Desc', 
	 CamposClaves='', 
	 CampoDescripcion='',
	 CampoFKTablaSeg='stkHojaDeRuta', 
	 CampoPKVistaSeg='stkHojaDeRuta', 
	 VistaSeg = 'stkHojaSegmentos'
     WHERE Identidad_Id='stkHojaDeRuta'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkHojaDeRuta')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'FechaRegistro')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'FormaEntrega_id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'Estado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'Patente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'PatenteAcoplado')
GO



