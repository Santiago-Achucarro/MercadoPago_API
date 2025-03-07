IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'suePersonal')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('suePersonal','Personal','Legajo, Nombres ,Inactivo,Posteado,Empresa_Id','vsuePersonal','','','Legajo','Nombres','S11010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Personal', 
		CamposSelect='Legajo, Nombres,Inactivo,Posteado,Empresa_Id', 
		FromSelect='vsuePersonal', WhereSelect='', OrderByDefault='', 
		CamposClaves='Legajo', 
		CampoDescripcion='Nombres',
		OrdenMenuFormulario = 'S11010'
     WHERE Identidad_Id='suePersonal'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('suePersonal')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePersonal'),'Legajo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePersonal'),'Nombres')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePersonal'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePersonal'),'Posteado')

