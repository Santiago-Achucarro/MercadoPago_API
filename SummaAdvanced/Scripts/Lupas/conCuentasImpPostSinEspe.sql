IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentasImpPostSinEspe')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuentasImpPostSinEspe','Cuentas Imputables y Posteadas sin Especiales',
		'Cuenta_Id,conCuentas.Descripcion,Imputable,conCuentas.Posteado,genMonedas.Moneda_Id,conCuentas.Tipo_Id,conCuentas.Empresa_Id,conCuentas.ReservadaPor,conCuentas.Inactivo','conCuentas INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id','Imputable=1 and Posteado=1 AND Inactivo =0','Cuenta_Id','Cuenta_Id','Descripcion','3110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Imputables y Posteadas sin Especiales', 
	 CamposSelect='Cuenta_Id,conCuentas.Descripcion,Imputable,conCuentas.Posteado,genMonedas.Moneda_Id,conCuentas.Tipo_Id,conCuentas.Empresa_Id,conCuentas.ReservadaPor,conCuentas.Inactivo', 
	 FromSelect='conCuentas INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id', 
	 WhereSelect='Imputable=1 and Posteado=1 AND Inactivo =0', 
	 OrderByDefault='Cuenta_Id', 
	 CamposClaves='Cuenta_Id', 
	 CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '3110'
     WHERE Identidad_Id='conCuentasImpPostSinEspe'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentasImpPostSinEspe')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, CondicionInicial) Values( dbo.FuncFklupIdentidades('conCuentasImpPostSinEspe'),'Cuenta_Id','startsWith')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasImpPostSinEspe'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasImpPostSinEspe'),'Moneda_Id')