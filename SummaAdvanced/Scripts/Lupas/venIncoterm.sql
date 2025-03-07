IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venIncoterm')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venIncoterm','Incoterm','Incoterm_Id,Descripcion','venIncoterm','','','Incoterm_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Incoterm', CamposSelect='Incoterm_Id,Descripcion', FromSelect='venIncoterm', WhereSelect='', OrderByDefault='', CamposClaves='Incoterm_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='venIncoterm'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venIncoterm')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venIncoterm'),'Incoterm_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venIncoterm'),'Descripcion')
