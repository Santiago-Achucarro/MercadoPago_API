IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkExistenciaUbiSerie')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkExistenciaUbiSerie','Ubicacion con Serie','Ubicacion_Id,Serie,Producto_Id,Deposito_Id,Cantidad,Empresa_Id','vstkExistenciaUbiSerie','','Ubicacion_Id','Ubicacion_Id','Serie')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ubicacion con Serie', CamposSelect='Ubicacion_Id,Serie,Producto_Id,Deposito_Id,Cantidad,Empresa_Id', 
	 FromSelect='vstkExistenciaUbiSerie', WhereSelect='', OrderByDefault='Ubicacion_Id', CamposClaves='Ubicacion_Id', CampoDescripcion='Serie'
     WHERE Identidad_Id='stkExistenciaUbiSerie'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkExistenciaUbiSerie')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbiSerie'),'Ubicacion_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbiSerie'),'Cantidad', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbiSerie'),'Serie', 0)
