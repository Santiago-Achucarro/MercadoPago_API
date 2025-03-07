IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'swsUsuarios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('swsUsuarios','Usuarios','Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario','vswsUsuarios','','','Usuario_Id','Apellido_y_Nombres')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Usuarios', CamposSelect='Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario', FromSelect='vswsUsuarios', WhereSelect='', OrderByDefault='', CamposClaves='Usuario_Id', CampoDescripcion='Apellido_y_Nombres'
     WHERE Identidad_Id='swsUsuarios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('swsUsuarios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('swsUsuarios'),'Usuario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('swsUsuarios'),'Apellido_y_Nombres')
