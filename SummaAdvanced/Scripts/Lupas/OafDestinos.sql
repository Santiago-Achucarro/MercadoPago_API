IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conDestino')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conDestino','Destino','Destino,Descripcion','vconOAFDestinos','','','Destino','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Destino', CamposSelect='Destino,Descripcion', FromSelect='vconOAFDestinos', WhereSelect='', OrderByDefault='', CamposClaves='Destino', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conDestino'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conDestino')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conDestino'),'Destino')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conDestino'),'Descripcion')
