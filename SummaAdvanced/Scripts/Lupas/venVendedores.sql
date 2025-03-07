IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venVendedores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('venVendedores','Vendedores','Vendedor_Id,Nombre,Posteado,Inactivo,Empresa_Id','venVendedores','','','Vendedor_Id','Nombre','51210')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Vendedores', CamposSelect='Vendedor_Id,Nombre,Posteado,Inactivo,Empresa_Id', FromSelect='venVendedores', WhereSelect='', OrderByDefault='', CamposClaves='Vendedor_Id', CampoDescripcion='Nombre',	
		OrdenMenuFormulario = '51210'
     WHERE Identidad_Id='venVendedores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venVendedores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venVendedores'),'Vendedor_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venVendedores'),'Nombre')
