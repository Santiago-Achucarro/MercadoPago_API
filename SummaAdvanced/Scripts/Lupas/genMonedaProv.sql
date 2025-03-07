IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genMonedaProv')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genMonedaProv','Moneda Proveedor','Moneda_Id,DescripcionMoneda,Proveed_Id,TipoCtaProv','vcomProveedoresCtasPasivo','','Moneda_Id','Moneda_Id','DescripcionMoneda')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Moneda Proveedor', CamposSelect='Moneda_Id,DescripcionMoneda,Proveed_Id,TipoCtaProv', FromSelect='vcomProveedoresCtasPasivo', WhereSelect='', OrderByDefault='Moneda_Id', CamposClaves='Moneda_Id', CampoDescripcion='DescripcionMoneda'
     WHERE Identidad_Id='genMonedaProv'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genMonedaProv')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMonedaProv'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMonedaProv'),'DescripcionMoneda')
GO