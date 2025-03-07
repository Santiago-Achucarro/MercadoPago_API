IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venFormaEntrega')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venFormaEntrega','Forma_de_Entrega','FormaEntrega_Id,RazonSocial,Posteado,Inactivo,Empresa_Id,UsaCartaPorte','venFormaEntrega','','','FormaEntrega_Id','RazonSocial','51300')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Forma_de_Entrega', CamposSelect='FormaEntrega_Id,RazonSocial,Posteado,Inactivo,Empresa_Id,UsaCartaPorte', FromSelect='venFormaEntrega', WhereSelect='', OrderByDefault='', CamposClaves='FormaEntrega_Id', CampoDescripcion='RazonSocial',
		OrdenMenuFormulario = '51300'
     WHERE Identidad_Id='venFormaEntrega'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venFormaEntrega')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venFormaEntrega'),'FormaEntrega_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venFormaEntrega'),'RazonSocial')
