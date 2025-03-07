IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAnexosOrigenes')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conAnexosOrigenes','Anexos Origenes','Origen,Descripcion,TipoRubro','conAnexosOrigenes','','','Origen','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Anexos Origenes', CamposSelect='Origen,Descripcion,TipoRubro', FromSelect='conAnexosOrigenes', WhereSelect='', OrderByDefault='', CamposClaves='Origen', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conAnexosOrigenes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAnexosOrigenes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosOrigenes'),'Origen')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosOrigenes'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosOrigenes'),'TipoRubro')
