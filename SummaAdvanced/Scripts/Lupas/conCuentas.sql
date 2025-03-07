IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuentas','Cuentas Contables',
	   'Cuenta_Id,Descripcion,Nivel,Imputable,Inactivo,Posteado,Empresa_Id, CASE WHEN RESERVADAPOR IS NULL THEN 0 ELSE 1 END AS Reservada',
	   'conCuentas','','Cuenta_Id','Cuenta_Id','Descripcion', '3110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Contables', 
	 CamposSelect='Cuenta_Id,Descripcion,Nivel,Imputable,Inactivo,Posteado,Empresa_Id, CASE WHEN RESERVADAPOR IS NULL THEN 0 ELSE 1 END AS Reservada', 
	 FromSelect='conCuentas', WhereSelect='', OrderByDefault='Cuenta_Id', CamposClaves='Cuenta_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '3110'
     WHERE Identidad_Id='conCuentas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, CondicionInicial) Values( dbo.FuncFklupIdentidades('conCuentas'),'Cuenta_Id', 'startsWith')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentas'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentas'),'Nivel')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentas'),'Imputable')
