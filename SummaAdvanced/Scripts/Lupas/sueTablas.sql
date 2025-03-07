IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueTablas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueTablas','Tablas','Tabla_Id,Descripcion,FechaRegistro','sueTabTitulo','','','Tabla_Id','Descripcion','S14030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tablas', CamposSelect='Tabla_Id,Descripcion,FechaRegistro', FromSelect='sueTabTitulo', WhereSelect='', OrderByDefault='', CamposClaves='Tabla_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S14030'
     WHERE Identidad_Id='sueTablas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueTablas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablas'),'Tabla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablas'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablas'),'FechaRegistro')
