IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venSubTipoMov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venSubTipoMov','SubTipos de Movimiento','SubTipoMov_Id,Descripcion,MueveStock,venTipomov,Inactivo,Posteado,Empresa_Id,CodigoFiscal,DescFormula,CtaOtrosCargos','vvenSubTipoMov','','','SubTipoMov_Id','Descripcion','5130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SubTipos de Movimiento', CamposSelect='SubTipoMov_Id,Descripcion,MueveStock,venTipomov,Inactivo,Posteado,Empresa_Id,CodigoFiscal,DescFormula,CtaOtrosCargos', 
		FromSelect='vvenSubTipoMov', WhereSelect='', OrderByDefault='', CamposClaves='SubTipoMov_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '5130'
     WHERE Identidad_Id='venSubTipoMov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venSubTipoMov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venSubTipoMov'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venSubTipoMov'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venSubTipoMov'),'venTipomov')


