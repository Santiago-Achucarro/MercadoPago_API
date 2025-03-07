IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impPadron')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('impPadron','Padrones','Padron_Id,Descripcion,Empresa_Id,Posteado,Inactivo','impPadron','','','Padron_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Padrones', CamposSelect='Padron_Id,Descripcion,Empresa_Id,Posteado,Inactivo', FromSelect='impPadron', WhereSelect='', OrderByDefault='', CamposClaves='Padron_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='impPadron'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impPadron')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impPadron'),'Padron_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impPadron'),'Descripcion')
Go
