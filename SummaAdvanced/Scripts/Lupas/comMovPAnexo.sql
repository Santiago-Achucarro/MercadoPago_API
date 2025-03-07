IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comMovPAnexo')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('comMovPAnexo', 'Movimientos de Compras Menores', 'Fecha_Ane, Cuit, RazonSocial, Tipomov', 'vComMovPAnexo', '', 'Fecha_Ane', '', '', 'Asiento_Id', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras Menores', 
	 CamposSelect='Fecha_Ane, Cuit, RazonSocial, Tipomov', 
	 FromSelect='vComMovPAnexo', 
	 WhereSelect='', 
	 OrderByDefault='Fecha', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'Asiento_Id',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='comMovPAnexo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comMovPAnexo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovPAnexo'),'Fecha_Ane')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovPAnexo'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovPAnexo'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovPAnexo'),'Tipomov')
GO

