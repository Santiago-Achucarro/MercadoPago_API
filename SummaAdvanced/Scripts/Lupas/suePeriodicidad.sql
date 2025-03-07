IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'suePeriodos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('suePeriodos','Periodos','Periodo_Id,Descripcion','suePeriodicidad','','','Periodo_Id','Descripcion','S11070')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Periodos', CamposSelect='Periodo_Id,Descripcion', FromSelect='suePeriodicidad', WhereSelect='', OrderByDefault='', CamposClaves='Periodo_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario='S11070'
     WHERE Identidad_Id='suePeriodos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('suePeriodos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePeriodos'),'Periodo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePeriodos'),'Descripcion')
