IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conEjercicio')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conEjercicio','Ejecicios Contables','Ejercicio,Fecha','conEjercicio','','','Ejercicio','Fecha', '325010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ejecicios Contables', CamposSelect='Ejercicio,Fecha', FromSelect='conEjercicio', WhereSelect='', OrderByDefault='', CamposClaves='Ejercicio', CampoDescripcion='Fecha',
		OrdenMenuFormulario = '325010'
     WHERE Identidad_Id='conEjercicio'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conEjercicio')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conEjercicio'),'Ejercicio')
