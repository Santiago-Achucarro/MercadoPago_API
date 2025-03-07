IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProvTipos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comProvTipos','Tipos de Proveedores','ProvTipo_Id,Descripcion,Posteado,Inactivo,Empresa_Id','comProvTipos','','ProvTipo_Id','ProvTipo_Id','Descripcion','1140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos de Proveedores', CamposSelect='ProvTipo_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='comProvTipos', WhereSelect='', OrderByDefault='ProvTipo_Id', CamposClaves='ProvTipo_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '1140'
     WHERE Identidad_Id='comProvTipos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProvTipos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvTipos'),'ProvTipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvTipos'),'Descripcion')
