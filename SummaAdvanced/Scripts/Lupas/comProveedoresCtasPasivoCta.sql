IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresCtasPasivoCta')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresCtasPasivoCta','Cuentas Pasivo del Proveedor','TipoCtaProv,Descripcion,Moneda_Id,Cuenta_Id,DescripcionCuenta,Proveed_Id','vcomProveedoresCtasPasivo','','','Cuenta_Id','DescripcionCuenta')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Pasivo del Proveedor', CamposSelect='TipoCtaProv,Descripcion,Moneda_Id,Cuenta_Id,DescripcionCuenta,Proveed_Id', FromSelect='vcomProveedoresCtasPasivo', WhereSelect='', OrderByDefault='', CamposClaves='Cuenta_Id', CampoDescripcion='DescripcionCuenta'
     WHERE Identidad_Id='comProveedoresCtasPasivoCta'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'DescripcionCuenta')

GO

