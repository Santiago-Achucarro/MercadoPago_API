IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venListasPrecios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venListasPrecios','Listas de Precios','ListaPrecio_Id,Descripcion,Moneda_Id,DescripcionMoneda,Inactivo,Posteado,Empresa_Id','vvenListasPrecios','','','ListaPrecio_Id','Descripcion','516010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Listas de Precios', CamposSelect='ListaPrecio_Id,Descripcion,Moneda_Id,DescripcionMoneda,Inactivo,Posteado,Empresa_Id', FromSelect='vvenListasPrecios', WhereSelect='', OrderByDefault='', CamposClaves='ListaPrecio_Id', CampoDescripcion='Descripcion',	
		OrdenMenuFormulario = '516010'
     WHERE Identidad_Id='venListasPrecios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venListasPrecios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasPrecios'),'ListaPrecio_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasPrecios'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasPrecios'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasPrecios'),'DescripcionMoneda')
