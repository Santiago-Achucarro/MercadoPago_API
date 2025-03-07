IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'disControlesXFormulario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('disControlesXFormulario','Controles del Formulario',
		'vv.Solapa, vv.Control_Id, vv.Titulo, vv.TipoControl ',
		'vdisControlesXFormulario vv inner join disformularios ON disFormularios.Formulario_Id = vv.formulario_id and disFormularios.Formulario_Id = @pPar1',
		'','Solapa, Titulo','Control_Id','Titulo')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Controles del Formulario', 
	 CamposSelect='vv.Solapa, vv.Control_Id, vv.Titulo, vv.TipoControl', 
	 FromSelect='vdisControlesXFormulario vv inner join disformularios ON disFormularios.Formulario_Id = vv.formulario_id and disFormularios.Formulario_Id = @pPar1', 
	 WhereSelect='', 
	 OrderByDefault='Solapa, Titulo', 
	 CamposClaves='Control_Id'
	 , CampoDescripcion='Titulo'
     WHERE Identidad_Id='disControlesXFormulario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('disControlesXFormulario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('disControlesXFormulario'),'Solapa')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('disControlesXFormulario'),'Control_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('disControlesXFormulario'),'Titulo')
GO

