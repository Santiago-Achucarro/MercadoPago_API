IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comOCEstados')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comOCEstados','Estados Orden de Compra','Estado_Id,Descripcion','comOcEstados','','','Estado_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estados Orden de Compra', CamposSelect='Estado_Id,Descripcion', FromSelect='comOcEstados', WhereSelect='', OrderByDefault='', CamposClaves='Estado_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comOCEstados'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comOCEstados')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOCEstados'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOCEstados'),'Descripcion')
