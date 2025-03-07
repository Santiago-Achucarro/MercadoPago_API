IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proTurnos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('proTurnos','Turnos','Turno_Id,Descripcion,Inicio,Fin','proTurnos','','','Turno_Id','Descripcion','9170')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Turnos', CamposSelect='Turno_Id,Descripcion,Inicio,Fin', FromSelect='proTurnos', WhereSelect='', OrderByDefault='', CamposClaves='Turno_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '9170'
     WHERE Identidad_Id='proTurnos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proTurnos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proTurnos'),'Turno_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proTurnos'),'Descripcion')