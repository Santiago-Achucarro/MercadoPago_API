IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueImpNombre')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueImpNombre','Nombre Importe','Importe_Id,Descripcion','sueImpNombre','','','Importe_Id','Descripcion','S1401020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Nombre Importe', CamposSelect='Importe_Id,Descripcion', FromSelect='sueImpNombre', WhereSelect='', OrderByDefault='', CamposClaves='Importe_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S1401020'
     WHERE Identidad_Id='sueImpNombre'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueImpNombre')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueImpNombre'),'Importe_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueImpNombre'),'Descripcion')
