IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkubicaciones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkubicaciones','Ubicaciones','Ubicacion_Id,Capacidad','stkubicaciones','','Ubicacion_Id','Ubicacion_Id','Capacidad')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ubicaciones', CamposSelect='Ubicacion_Id,Capacidad', FromSelect='stkubicaciones', WhereSelect='', OrderByDefault='Ubicacion_Id', CamposClaves='Ubicacion_Id', CampoDescripcion='Capacidad'
     WHERE Identidad_Id='stkubicaciones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkubicaciones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkubicaciones'),'Ubicacion_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkubicaciones'),'Capacidad', 0)
