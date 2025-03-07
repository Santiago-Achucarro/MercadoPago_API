IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesRFCBanco')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesRFCBanco','RFC Banco','RFC,Descripcion','tesBancos','RFC <> '' ''','RFC','RFC','','612020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='RFC Banco', CamposSelect='RFC,Descripcion', FromSelect='tesBancos', WhereSelect='RFC <> '' ''', OrderByDefault='RFC', CamposClaves='RFC', CampoDescripcion='',
	 OrdenMenuFormulario = '612020'
     WHERE Identidad_Id='tesRFCBanco'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesRFCBanco')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesRFCBanco'),'RFC')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesRFCBanco'),'Descripcion')
