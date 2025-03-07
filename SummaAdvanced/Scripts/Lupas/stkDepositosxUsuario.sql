IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkDepositosxUsuario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkDepositosxUsuario','Depositos_del_Usuario','Deposito_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkDepositos Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = stkDepositos.GrupoUsuarios','','Deposito_Id','Deposito_Id','Descripcion','2140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Depositos_del_Usuario', CamposSelect='Deposito_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkDepositos Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = stkDepositos.GrupoUsuarios', WhereSelect='', OrderByDefault='Deposito_Id', CamposClaves='Deposito_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2140'
     WHERE Identidad_Id='stkDepositosxUsuario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkDepositosxUsuario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuario'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuario'),'Descripcion')
