IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genWSFactElec')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genWSFactElec','WS_de_factura_electronica','TipoFE,Descripcion','genWSFactElec','','','TipoFE','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='WS_de_factura_electronica', CamposSelect='TipoFE,Descripcion', FromSelect='genWSFactElec', WhereSelect='', OrderByDefault='', CamposClaves='TipoFE', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genWSFactElec'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genWSFactElec')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genWSFactElec'),'TipoFE')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genWSFactElec'),'Descripcion')
