IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comocestadosar')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comocestadosar','Estados Orden de Compra A y R','Estado_Id,Descripcion','comOcEstados','Estado_Id in (''P'',''A'',''R'')','','Estado_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estados Orden de Compra A y R', CamposSelect='Estado_Id,Descripcion', FromSelect='comOcEstados', WhereSelect='Estado_Id in (''P'',''A'',''R'')', OrderByDefault='', CamposClaves='Estado_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comocestadosar'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comocestadosar')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comocestadosar'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comocestadosar'),'Descripcion')
