IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genContadores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genContadores','Contadores','Contador,Descripcion,Empresa_Id','genContadores','','','Contador','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Contadores', CamposSelect='Contador,Descripcion,Empresa_Id', FromSelect='genContadores', WhereSelect='', OrderByDefault='', CamposClaves='Contador', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genContadores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genContadores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genContadores'),'Contador')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genContadores'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genContadores'),'Empresa_Id')
