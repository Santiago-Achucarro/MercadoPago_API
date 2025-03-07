IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCategCredito')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venCategCredito','Categorias de Credito','CategCred_Id,Descripcion,Posteado,Inactivo,Empresa_Id','venCategCredito','','','CategCred_Id','Descripcion','51250')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Categorias de Credito', CamposSelect='CategCred_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='venCategCredito', WhereSelect='', OrderByDefault='', CamposClaves='CategCred_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '51250'
     WHERE Identidad_Id='venCategCredito'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCategCredito')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCategCredito'),'CategCred_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCategCredito'),'Descripcion')

