IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venLibros')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venLibros','Libros de impuestos ventas','Libro_Id,Descripcion,Empresa_Id','venLibros','','','Libro_Id','Descripcion','412020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Libros de impuestos ventas', CamposSelect='Libro_Id,Descripcion,Empresa_Id', FromSelect='venLibros', WhereSelect='', OrderByDefault='', CamposClaves='Libro_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '412020'
     WHERE Identidad_Id='venLibros'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venLibros')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venLibros'),'Libro_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venLibros'),'Descripcion')
