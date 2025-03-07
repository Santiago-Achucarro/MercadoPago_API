IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkExistenciaUbi')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkExistenciaUbi','Ubicacion','Ubicacion_Id,Producto_Id,Deposito_Id,Cantidad,Empresa_Id','vstkExistenciaUbi','','Ubicacion_Id','Ubicacion_Id','Producto_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ubicacion', CamposSelect='Ubicacion_Id,Producto_Id,Deposito_Id,Cantidad,Empresa_Id', FromSelect='vstkExistenciaUbi', WhereSelect='', OrderByDefault='Ubicacion_Id', CamposClaves='Ubicacion_Id', CampoDescripcion='Producto_Id'
     WHERE Identidad_Id='stkExistenciaUbi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkExistenciaUbi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbi'),'Ubicacion_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbi'),'Cantidad', 0)
