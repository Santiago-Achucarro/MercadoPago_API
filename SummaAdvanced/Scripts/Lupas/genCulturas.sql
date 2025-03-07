IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genCulturas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genCulturas','Culturas','Cultura,Descripcion','genCulturas','','','Cultura','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Culturas', CamposSelect='Cultura,Descripcion', FromSelect='genCulturas', WhereSelect='', OrderByDefault='', CamposClaves='Cultura', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genCulturas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genCulturas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genCulturas'),'Cultura')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genCulturas'),'Descripcion')
Go
