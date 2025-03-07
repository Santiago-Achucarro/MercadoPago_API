IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesClearing')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesClearing','Clearing','Clearing,Descripcion','tesClearing','','','Clearing','Descripcion','612030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Clearing', CamposSelect='Clearing,Descripcion', FromSelect='tesClearing', WhereSelect='', OrderByDefault='', CamposClaves='Clearing', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '612030'
     WHERE Identidad_Id='tesClearing'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesClearing')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesClearing'),'Clearing')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesClearing'),'Descripcion')
