IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkDepositosxUsuarioProd')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkDepositosxUsuarioProd',
	   'Depositos_del_Usuario_Producto',
	   'Deposito_Id,Descripcion,Cantidad,Inactivo,Posteado,Empresa_Id, Producto_Id,AdmiteVentas',
		'vStkDepoExistencia Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = vStkDepoExistencia.GrupoUsuarios',
		'','Deposito_Id','Deposito_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Depositos_del_Usuario', 
	 CamposSelect='Deposito_Id,Descripcion,Cantidad, Inactivo,Posteado,Empresa_Id, Producto_Id,AdmiteVentas',
	  FromSelect=		'vStkDepoExistencia Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = vStkDepoExistencia.GrupoUsuarios',
		  WhereSelect='', OrderByDefault='Deposito_Id', CamposClaves='Deposito_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='stkDepositosxUsuarioProd'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkDepositosxUsuarioProd')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuarioProd'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuarioProd'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuarioProd'),'Cantidad')