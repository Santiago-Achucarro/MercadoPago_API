IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueCategorias')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueCategorias','Categorias','Categoria_Id,Descripcion,Periodo_Id','vsueCategorias','','','Categoria_Id','Descripcion','S11020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Categorias', CamposSelect='Categoria_Id,Descripcion,Periodo_Id', FromSelect='vsueCategorias', WhereSelect='', OrderByDefault='', CamposClaves='Categoria_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S11020'
     WHERE Identidad_Id='sueCategorias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueCategorias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCategorias'),'Categoria_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCategorias'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCategorias'),'Periodo_Id')
