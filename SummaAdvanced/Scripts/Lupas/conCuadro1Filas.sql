IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuadro1Filas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuadro1Filas','Filas_Cuadro_Uno','Cuadro1Fila_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conCuadro1Filas','','Cuadro1Fila_Id','Cuadro1Fila_Id','Descripcion', '3165')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Filas_Cuadro_Uno', CamposSelect='Cuadro1Fila_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='conCuadro1Filas', WhereSelect='', OrderByDefault='Cuadro1Fila_Id', CamposClaves='Cuadro1Fila_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '3165'
     WHERE Identidad_Id='conCuadro1Filas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuadro1Filas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuadro1Filas'),'Cuadro1Fila_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuadro1Filas'),'Descripcion')
