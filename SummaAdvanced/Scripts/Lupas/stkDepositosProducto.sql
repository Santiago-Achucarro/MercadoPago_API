IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkDepositosExistencia')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkDepositosExistencia','Depositos con Existencia','Deposito_Id,Descripcion,Cantidad, CantidadReservada, Inactivo,Posteado,Empresa_Id,AdmiteVentas,UsaUbicacion, Producto_Id','vStkDepoExistencia','','Deposito_Id','Deposito_Id','Descripcion','2140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Depositos con Existencia', 
	 CamposSelect='Deposito_Id,Descripcion,Cantidad,CantidadReservada, Inactivo,Posteado,Empresa_Id,AdmiteVentas,UsaUbicacion,Producto_Id', 
	 FromSelect='vStkDepoExistencia', WhereSelect='', OrderByDefault='Deposito_Id', CamposClaves='Deposito_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '2140'
     WHERE Identidad_Id='stkDepositosExistencia'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkDepositosExistencia')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosExistencia'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosExistencia'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosExistencia'),'Cantidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosExistencia'),'CantidadReservada')
