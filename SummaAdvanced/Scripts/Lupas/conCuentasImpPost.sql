IF not EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentasImpPost')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuentasImpPost','Cuentas Contables Imputables y Posteadas','Cuenta_Id,conCuentas.Descripcion,Imputable,conCuentas.Posteado,genMonedas.Moneda_Id,conCuentas.Tipo_Id,isnull(TipoEspe_Id,'' '') as TipoEspe_Id, conCuentas.Empresa_Id','conCuentas INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id LEFT OUTER JOIN conTipoEspecialesCuerpo ON conTipoEspecialesCuerpo.Tipo_Id = conCuentas.Tipo_Id','Imputable=1 and Posteado=1','Cuenta_Id','Cuenta_Id','Descripcion','3110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Contables Imputables y Posteadas', 
		CamposSelect='Cuenta_Id,conCuentas.Descripcion,Imputable,conCuentas.Posteado,genMonedas.Moneda_Id,conCuentas.Tipo_Id,isnull(TipoEspe_Id,'' '') as TipoEspe_Id, conCuentas.Empresa_Id,conCuentas.ReservadaPor', 
		FromSelect='conCuentas INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id LEFT OUTER JOIN conTipoEspecialesCuerpo ON conTipoEspecialesCuerpo.Tipo_Id = conCuentas.Tipo_Id', 
		WhereSelect='Imputable=1 and Posteado=1', OrderByDefault='Cuenta_Id', CamposClaves='Cuenta_Id', CampoDescripcion='Descripcion',
			OrdenMenuFormulario = '3110'
WHERE Identidad_Id='conCuentasImpPost'
DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentasImpPost')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, CondicionInicial) Values( dbo.FuncFklupIdentidades('conCuentasImpPost'),'Cuenta_Id','startsWith')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasImpPost'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasImpPost'),'Moneda_Id')

-- Exec Lup_EjecutarConsulta 'conCuentasImpPost', null, null, null, 0, 999, 'MX'

/*
exec Lup_EjecutarCantidadReg @pidentidad_Id='conCuentasImpPost',@pWhereSP='(Moneda_Id = ''pes'' AND TipoEspe_Id = ''CLIEN'')',@pWhere=NULL,@pDominio='MX'
exec Lup_EjecutarConsulta @pidentidad_Id='conCuentasImpPost',@pWhereSP='(Moneda_Id = ''pes'' AND TipoEspe_Id = ''CLIEN'')',@pWhere=NULL,@pDominio='MX', @pDesde=0, @pHasta=99
exec Lup_EjecutarCantidadReg @pidentidad_Id='venClientes',@pWhereSP=NULL,@pWhere=NULL,@pDominio='MX'
*/