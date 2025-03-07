IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genAtriGralesClases')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genAtriGralesClases','Atributos Generales','Tabla_id,Descripcion','genAtriGralesClases','','','Tabla_id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Atributos Generales', CamposSelect='Tabla_id,Descripcion', FromSelect='genAtriGralesClases', WhereSelect='', OrderByDefault='', CamposClaves='Tabla_id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genAtriGralesClases'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genAtriGralesClases')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genAtriGralesClases'),'Tabla_id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genAtriGralesClases'),'Descripcion')
