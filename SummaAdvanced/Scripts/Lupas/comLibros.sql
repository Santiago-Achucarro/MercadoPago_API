IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comLibros')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comLibros','libros compras','Libro_Id,Descripcion,Empresa_Id','comLIbros','','','Libro_Id','Descripcion', '411020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='libros compras', CamposSelect='Libro_Id,Descripcion,Empresa_Id', FromSelect='comLIbros', WhereSelect='', OrderByDefault='', 
	 CamposClaves='Libro_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '411020'
     WHERE Identidad_Id='comLibros'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comLibros')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comLibros'),'Libro_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comLibros'),'Descripcion')
