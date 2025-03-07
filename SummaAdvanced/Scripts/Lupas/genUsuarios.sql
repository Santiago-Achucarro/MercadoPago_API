IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genUsuarios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genUsuarios','Usuarios','Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario','genUsuarios','','Usuario_Id','Usuario_Id','Apellido_y_Nombres','7120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Usuarios', 
	 CamposSelect='Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario', 
	 FromSelect='genUsuarios', 
	 WhereSelect='', OrderByDefault='Usuario_Id', CamposClaves='Usuario_Id', CampoDescripcion='Apellido_y_Nombres', 
	 OrdenMenuFormulario = '7120'
     WHERE Identidad_Id='genUsuarios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genUsuarios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genUsuarios'),'Usuario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genUsuarios'),'Apellido_y_Nombres')


