IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venListasXUsuario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venListasXUsuario','Listas de Precio Por Usuario',
		'ListaPrecio_Id,Descripcion,Moneda_Id,DescripcionMoneda,Inactivo,Posteado,Empresa_Id',
		'vvenListasPrecios Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = vvenListasPrecios.UsuAutorizado',
		'','ListaPrecio_Id','ListaPrecio_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Listas de Precio Por Usuario', 
	 CamposSelect='ListaPrecio_Id,Descripcion,Moneda_Id,DescripcionMoneda,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='vvenListasPrecios Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = vvenListasPrecios.UsuAutorizado', 
	 WhereSelect='', 
	 OrderByDefault='ListaPrecio_Id', 
	 CamposClaves='ListaPrecio_Id'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='venListasXUsuario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venListasXUsuario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasXUsuario'),'ListaPrecio_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasXUsuario'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasXUsuario'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasXUsuario'),'DescripcionMoneda')
GO


