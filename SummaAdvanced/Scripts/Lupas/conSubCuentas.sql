IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conSubCuentas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conSubCuentas','SubCuentas','SubCuenta_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conSubCuentas','','SubCuenta_Id','SubCuenta_Id','Descripcion','3120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SubCuentas', CamposSelect='SubCuenta_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
		FromSelect='conSubCuentas', WhereSelect='', OrderByDefault='SubCuenta_Id', CamposClaves='SubCuenta_Id', 
			CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '3120'
     WHERE Identidad_Id='conSubCuentas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conSubCuentas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSubCuentas'),'SubCuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSubCuentas'),'Descripcion')
