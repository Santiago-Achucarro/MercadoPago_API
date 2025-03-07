IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTiposCompAfip')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genTiposCompAfip','Tipos de comprobantes de Afip','Comprobante_Id,Descripcion,Segmento1N,Segmento2N,Segmento3N,Segmento4N,Segmento1C,Segmento2C,Segmento3C,Segmento4C','genTiposCompAfip','','','Comprobante_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos de comprobantes de Afip', CamposSelect='Comprobante_Id,Descripcion,Segmento1N,Segmento2N,Segmento3N,Segmento4N,Segmento1C,Segmento2C,Segmento3C,Segmento4C', FromSelect='genTiposCompAfip', WhereSelect='', OrderByDefault='', CamposClaves='Comprobante_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genTiposCompAfip'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTiposCompAfip')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTiposCompAfip'),'Comprobante_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTiposCompAfip'),'Descripcion')
