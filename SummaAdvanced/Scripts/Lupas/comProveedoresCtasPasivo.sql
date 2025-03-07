IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresCtasPasivo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresCtasPasivo','Cuentas Pasivo del Proveedor','TipoCtaProv,Descripcion,Moneda_Id,Cuenta_Id,DescripcionCuenta,Proveed_Id','vcomProveedoresCtasPasivo','','','TipoCtaProv','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Pasivo del Proveedor', CamposSelect='TipoCtaProv,Descripcion,Moneda_Id,Cuenta_Id,DescripcionCuenta,Proveed_Id', FromSelect='vcomProveedoresCtasPasivo', WhereSelect='', OrderByDefault='', CamposClaves='TipoCtaProv', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comProveedoresCtasPasivo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresCtasPasivo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'DescripcionCuenta')

GO

