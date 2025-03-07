IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkCausasMoviXUsuario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkCausasMoviXUsuario','Causa_de_Movimiento','Causa_Id,Descripcion,Inactivo,Posteado,EntSalAmb,Empresa_Id','stkCausasMovi Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = stkCausasMovi .UsuarioAutorizado','','','Causa_Id','Descripcion','2160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Causa_de_Movimiento', CamposSelect='Causa_Id,Descripcion,Inactivo,Posteado,EntSalAmb,Empresa_Id', FromSelect='stkCausasMovi Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = stkCausasMovi .UsuarioAutorizado', WhereSelect='', OrderByDefault='', CamposClaves='Causa_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2160'
     WHERE Identidad_Id='stkCausasMoviXUsuario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkCausasMoviXUsuario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCausasMoviXUsuario'),'Causa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCausasMoviXUsuario'),'Descripcion')
