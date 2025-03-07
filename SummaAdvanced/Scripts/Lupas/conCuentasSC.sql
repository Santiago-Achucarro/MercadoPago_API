IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentasSC')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conCuentasSC','Cuentas Sin SubCuenta','Cuenta_Id,Descripcion, Inactivo, Posteado, Empresa_Id','vconcuentasSinSc','','Cuenta_Id','Cuenta_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Sin SubCuenta', 
	 CamposSelect='Cuenta_Id,Descripcion, Inactivo, Posteado, Empresa_Id', 
	 FromSelect='vconCuentasSinSC', WhereSelect='', OrderByDefault='Cuenta_Id', CamposClaves='Cuenta_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conCuentasSC'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentasSC')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasSC'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasSC'),'Descripcion')


