IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkExistenciaSerieSinVto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkExistenciaSerieSinVto','Existencia_serie_lote_vencimiento',
	   'Serie,Cantidad/isnull(@pPar1,1) as Cantidad,Producto_Id,Deposito_Id,Vencimiento,Empresa_Id','vstkExistenciaSerieVto','','Serie','Serie','Cantidad')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Existencia_serie_lote_vencimiento', 
	 CamposSelect='Serie,Cantidad/isnull(@pPar1,1) as Cantidad,Producto_Id,Deposito_Id,Vencimiento,Empresa_Id', 
	 FromSelect='vstkExistenciaSerieVto', WhereSelect='', 
	 OrderByDefault='Serie', CamposClaves='Serie', CampoDescripcion='Cantidad'
     WHERE Identidad_Id='stkExistenciaSerieSinVto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkExistenciaSerieSinVto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerieSinVto'),'Serie')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerieSinVto'),'Cantidad')
