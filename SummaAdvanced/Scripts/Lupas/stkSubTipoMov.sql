IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkSubTipoMov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkSubTipoMov','Sub Tipo de Movimiento de Stock','SubTipoMov_Id,Descripcion','stkSubTipoMov','','SubTipoMov_Id','SubTipoMov_Id','Descripcion','2180')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Sub Tipo de Movimiento de Stock', CamposSelect='SubTipoMov_Id,Descripcion', FromSelect='stkSubTipoMov', WhereSelect='', OrderByDefault='SubTipoMov_Id', CamposClaves='SubTipoMov_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '2180'
     WHERE Identidad_Id='stkSubTipoMov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkSubTipoMov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkSubTipoMov'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkSubTipoMov'),'Descripcion')
