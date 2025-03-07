IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueTipoPago')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueTipoPago','TipoPago','TipoPago_Id,Descripcion,Inactivo,Posteado','sueTipoPago','','','TipoPago_Id','Descripcion','S11030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='TipoPago', CamposSelect='TipoPago_Id,Descripcion,Inactivo,Posteado', FromSelect='sueTipoPago', WhereSelect='', OrderByDefault='', CamposClaves='TipoPago_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S11030'
     WHERE Identidad_Id='sueTipoPago'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueTipoPago')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTipoPago'),'TipoPago_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTipoPago'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTipoPago'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTipoPago'),'Posteado')