IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comSubCategorias')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comSubCategorias','SubCategorias','SubCategoria_Id,Descripcion,Categoria_Id','vcomSubCategoria','','','SubCategoria_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SubCategorias', CamposSelect='SubCategoria_Id,Descripcion,Categoria_Id', FromSelect='vcomSubCategoria', WhereSelect='', OrderByDefault='', CamposClaves='SubCategoria_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comSubCategorias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comSubCategorias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comSubCategorias'),'SubCategoria_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comSubCategorias'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comSubCategorias'),'Categoria_Id')
