IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAsientosTipos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conAsientosTipos','AsientosTipos','AsiTipo_Id,LeyendaLibroDiario','conAsientosTipo','','','AsiTipo_Id','LeyendaLibroDiario')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='AsientosTipos', CamposSelect='AsiTipo_Id,LeyendaLibroDiario', FromSelect='conAsientosTipo', WhereSelect='', OrderByDefault='', CamposClaves='AsiTipo_Id', CampoDescripcion='LeyendaLibroDiario'
     WHERE Identidad_Id='conAsientosTipos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAsientosTipos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosTipos'),'AsiTipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosTipos'),'LeyendaLibroDiario')
