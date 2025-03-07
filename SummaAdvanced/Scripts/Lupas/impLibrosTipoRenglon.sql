IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impLibrosTiposRenglon')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('impLibrosTiposRenglon','tipos renglon libros','TipoRenglon,Descripcion','impLibrosTiposRenglon','','','TipoRenglon','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='tipos renglon libros', CamposSelect='TipoRenglon,Descripcion', FromSelect='impLibrosTiposRenglon', WhereSelect='', OrderByDefault='', CamposClaves='TipoRenglon', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='impLibrosTiposRenglon'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impLibrosTiposRenglon')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLibrosTiposRenglon'),'TipoRenglon')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLibrosTiposRenglon'),'Descripcion')
