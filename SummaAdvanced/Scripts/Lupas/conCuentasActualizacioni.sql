IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentasActualizacion')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuentasActualizacion','Cuentas Contables',
	   'Cuenta_Id,Descripcion,Nivel,Imputable,Inactivo,Posteado,Empresa_Id, CASE WHEN RESERVADAPOR IS NULL THEN 0 ELSE 1 END AS Reservada,SubCuenta_Id',
	   'vconCuentasActualizacion','SubCuenta_Id Is Null','Cuenta_Id','Cuenta_Id','Descripcion', '3110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Contables', 
	 CamposSelect='Cuenta_Id,Descripcion,Nivel,Imputable,Inactivo,Posteado,Empresa_Id, CASE WHEN RESERVADAPOR IS NULL THEN 0 ELSE 1 END AS Reservada,SubCuenta_Id', 
	 FromSelect='vconCuentasActualizacion', WhereSelect='SubCuenta_Id Is Null', OrderByDefault='Cuenta_Id', CamposClaves='Cuenta_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '3110'
     WHERE Identidad_Id='conCuentasActualizacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentasActualizacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, CondicionInicial) Values( dbo.FuncFklupIdentidades('conCuentasActualizacion'),'Cuenta_Id', 'startsWith')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasActualizacion'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasActualizacion'),'Nivel')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasActualizacion'),'Imputable')
