IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venTiposClie')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venTiposClie','Tipos_de_Clientes','TipoClie_Id,Descripcion,Posteado,Empresa_Id','venTiposClie','','','TipoClie_Id','Descripcion','51270')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_de_Clientes', CamposSelect='TipoClie_Id,Descripcion,Posteado,Empresa_Id', FromSelect='venTiposClie', WhereSelect='', OrderByDefault='', CamposClaves='TipoClie_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario= '51270'
     WHERE Identidad_Id='venTiposClie'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venTiposClie')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venTiposClie'),'TipoClie_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venTiposClie'),'Descripcion')
