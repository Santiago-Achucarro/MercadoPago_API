IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesChequerasEstado')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesChequerasEstado','Estado en Chequeras','Estado_Id,Descripcion','tesChequerasEstado','','Estado_Id','Estado_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estado en Chequeras', CamposSelect='Estado_Id,Descripcion', FromSelect='tesChequerasEstado', WhereSelect='', OrderByDefault='Estado_Id', CamposClaves='Estado_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='tesChequerasEstado'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesChequerasEstado')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequerasEstado'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequerasEstado'),'Descripcion')
GO
