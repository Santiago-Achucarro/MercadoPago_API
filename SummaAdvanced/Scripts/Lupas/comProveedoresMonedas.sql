IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresMonedas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresMonedas','Monedas_del_proveedor','Moneda_Id,DescripcionMoneda,Proveed_Id,TipoCtaProv','vComProveedoresMonedas','','','Moneda_Id','DescripcionMoneda')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Monedas_del_proveedor', CamposSelect='Moneda_Id,DescripcionMoneda,Proveed_Id,TipoCtaProv', FromSelect='vComProveedoresMonedas', WhereSelect='', OrderByDefault='', CamposClaves='Moneda_Id', CampoDescripcion='DescripcionMoneda'
     WHERE Identidad_Id='comProveedoresMonedas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresMonedas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresMonedas'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresMonedas'),'DescripcionMoneda')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresMonedas'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresMonedas'),'TipoCtaProv')

