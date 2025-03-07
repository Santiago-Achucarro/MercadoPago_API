IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkExistenciaSerie')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkExistenciaSerie','Existencia_serie_lote_vencimiento','Serie,Cantidad/isnull(@pPar1,1) as Cantidad,Producto_Id,Deposito_Id,Vencimiento,Empresa_Id','vstkExistenciaSerieVto','','Vencimiento','Serie','Cantidad')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Existencia_serie_lote_vencimiento', CamposSelect='Serie,Cantidad/isnull(@pPar1,1) as Cantidad,Producto_Id,Deposito_Id,Vencimiento,Empresa_Id', 
	 FromSelect='vstkExistenciaSerieVto', WhereSelect='', OrderByDefault='Vencimiento', CamposClaves='Serie', CampoDescripcion='Cantidad'
     WHERE Identidad_Id='stkExistenciaSerie'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkExistenciaSerie')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerie'),'Serie')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerie'),'Cantidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerie'),'Vencimiento')
