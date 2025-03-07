IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impRetencionesCFDI')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('impRetencionesCFDI','','Folio,RazonSocial,RFC,FechaExp,Cancelado','impRetencionesCfdi','','Folio,RazonSocial,RFC','Folio','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='', CamposSelect='Folio,RazonSocial,RFC,FechaExp,Cancelado', FromSelect='impRetencionesCfdi', WhereSelect='', OrderByDefault='Folio,RazonSocial,RFC', CamposClaves='Folio', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='impRetencionesCFDI'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impRetencionesCFDI')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'Folio')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'RFC')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'FechaExp')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'Cancelado')
