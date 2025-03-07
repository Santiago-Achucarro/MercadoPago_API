IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comCategorias')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comCategorias','Categorias','Categoria_Id,Descripcion,Posteado,Inactivo','comCategorias','','','Categoria_Id','Descripcion','1430')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Categorias', CamposSelect='Categoria_Id,Descripcion,Posteado,Inactivo', FromSelect='comCategorias', WhereSelect='', OrderByDefault='', CamposClaves='Categoria_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '1430'
     WHERE Identidad_Id='comCategorias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comCategorias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCategorias'),'Categoria_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCategorias'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCategorias'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCategorias'),'Inactivo')
