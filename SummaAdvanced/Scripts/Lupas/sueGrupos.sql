IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueGrupos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueGrupos','Grupos','Grupo_Id,Descripcion,Posteado,Inactivo, Periodo_Id, Empresa_Id,Segmento_Id','vsueGrupos','','','Grupo_Id','Descripcion','S12010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Grupos', 
	 CamposSelect='Grupo_Id,Descripcion,Posteado,Inactivo, Periodo_Id, Empresa_Id,Segmento_Id', 
	 FromSelect='vsueGrupos', 
	 WhereSelect='', OrderByDefault='', 
	 CamposClaves='Grupo_Id', 
	 CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = 'S12010'
     WHERE Identidad_Id='sueGrupos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueGrupos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Periodo_Id')


