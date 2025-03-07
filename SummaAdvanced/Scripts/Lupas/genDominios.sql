IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genDominios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genDominios','Dominos','Dominio_Id,Descripcion','genDominios','','Descripcion','Dominio_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Dominos', CamposSelect='Dominio_Id,Descripcion', FromSelect='genDominios', WhereSelect='', OrderByDefault='Descripcion', CamposClaves='Dominio_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genDominios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genDominios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genDominios'),'Dominio_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genDominios'),'Descripcion')
