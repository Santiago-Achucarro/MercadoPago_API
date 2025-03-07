IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comMovprov')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('comMovprov', 'Movimientos de Compras', 'Fecha, Proveed_Id, RazonSocial, Tipomov, Formulario_Id, Empresa', 'vcomMovprov', '', 'Fecha', '', '', 'comMovprov', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras', 
	 CamposSelect='Fecha, Proveed_Id, RazonSocial, Tipomov, Formulario_Id, Empresa', 
	 FromSelect='vComMovProv', 
	 WhereSelect='', 
	 OrderByDefault='Fecha', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'comMovprov',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='comMovprov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comMovprov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovprov'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovprov'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovprov'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovprov'),'Tipomov')
GO