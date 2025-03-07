IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genMenusFormularios')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('genMenusFormularios', 'Formularios', 
		'Formulario_Id, Opcion', 
		'vgenMenusFormularios', '', 'Opcion asc', 'Formulario_Id', 'Opcion', '', '',  '')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Formularios', 
	 CamposSelect='Formulario_Id, Opcion', 
	 FromSelect='vgenMenusFormularios', 
	 WhereSelect='', 
	 OrderByDefault='Opcion asc', 
	 CamposClaves='Formulario_Id', CampoDescripcion='Opcion', 
	 CampoFKTablaSeg = '',  VistaSeg = '', CampoPKVistaSeg = ''
     WHERE Identidad_Id='genMenusFormularios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genMenusFormularios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMenusFormularios'),'Formulario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMenusFormularios'),'Opcion')
GO