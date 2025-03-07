IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesSubTiposMov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesSubTiposMov','Sub Tipos Tesoreria','SubTipo_Id,Descripcion','tesSubTiposMov','','SubTipo_Id','SubTipo_Id','Descripcion','6197')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Sub Tipos Tesoreria', CamposSelect='SubTipo_Id,Descripcion', FromSelect='tesSubTiposMov', WhereSelect='', OrderByDefault='SubTipo_Id', CamposClaves='SubTipo_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '6197'
     WHERE Identidad_Id='tesSubTiposMov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesSubTiposMov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSubTiposMov'),'SubTipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSubTiposMov'),'Descripcion')
