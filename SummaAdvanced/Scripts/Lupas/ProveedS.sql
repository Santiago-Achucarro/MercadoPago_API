IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'ProveedS')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('ProveedS','Proveedores SUMMA++','Proveed_Id,RazonSocial','comProveedores','','RazonSocial','Proveed_Id','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Proveedores SUMMA++', CamposSelect='Proveed_Id,RazonSocial', FromSelect='comProveedores', WhereSelect='', OrderByDefault='RazonSocial', CamposClaves='Proveed_Id', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='ProveedS'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('ProveedS')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('ProveedS'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('ProveedS'),'RazonSocial')
