IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genMonedas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genMonedas','Monedas','Moneda_Id,Descripcion,Posteado,Inactivo,Empresa_Id','genMonedas','','Moneda_Id','Moneda_Id','Descripcion','7180')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Monedas', CamposSelect='Moneda_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='genMonedas', WhereSelect='', OrderByDefault='Moneda_Id', CamposClaves='Moneda_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7180'
     WHERE Identidad_Id='genMonedas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genMonedas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMonedas'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMonedas'),'Descripcion')
