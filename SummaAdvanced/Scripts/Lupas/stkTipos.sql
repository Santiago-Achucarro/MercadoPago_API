IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkTipos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkTipos','Tipos','Tipo_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkTipos','','Tipo_Id','Tipo_Id','Descripcion','2130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos', CamposSelect='Tipo_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='stkTipos', WhereSelect='', OrderByDefault='Tipo_Id', CamposClaves='Tipo_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2130'
     WHERE Identidad_Id='stkTipos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkTipos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkTipos'),'Tipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkTipos'),'Descripcion')
