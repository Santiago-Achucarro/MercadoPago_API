IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genGrupos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genGrupos','Grupos','Usuario_Id,Apellido_Y_Nombres,TipoUsuario,Empresa_Id,Posteado,Inactivo','genUsuarios','TipoUsuario=''G''','','Usuario_Id','Apellido_Y_Nombres','7130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Grupos', CamposSelect='Usuario_Id,Apellido_Y_Nombres,TipoUsuario,Empresa_Id,Posteado,Inactivo', FromSelect='genUsuarios', WhereSelect='TipoUsuario=''G''', OrderByDefault='', CamposClaves='Usuario_Id', CampoDescripcion='Apellido_Y_Nombres',
		OrdenMenuFormulario = '7130'
     WHERE Identidad_Id='genGrupos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genGrupos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genGrupos'),'Usuario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genGrupos'),'Apellido_Y_Nombres')