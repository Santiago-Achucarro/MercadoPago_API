IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genSucursalesEmpr')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('genSucursalesEmpr','Sucursal','Sucursal,Descripcion,Posteado,Inactivo,Empresa_Id,EmpresaSTR','vgenSucursalesEmpr','','','Sucursal','Descripcion','7160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Sucursal', CamposSelect='Sucursal,Descripcion,Posteado,Inactivo,Empresa_Id,EmpresaSTR', FromSelect='vgenSucursalesEmpr', WhereSelect='', OrderByDefault='', CamposClaves='Sucursal', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7160'
     WHERE Identidad_Id='genSucursalesEmpr'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genSucursalesEmpr')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSucursalesEmpr'),'Sucursal')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSucursalesEmpr'),'Descripcion')