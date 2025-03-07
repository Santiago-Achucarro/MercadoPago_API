IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venOtcFormula')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venOtcFormula','Formulas Otros cargos','Formula_Id,Descripcion,Posteado,Empresa_Id,Formula','venOtcFormula','','','Formula_Id','Descripcion', Null)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Formulas Otros cargos', CamposSelect='Formula_Id,Descripcion,Posteado,Empresa_Id,Formula', 
		FromSelect='venOtcFormula', WhereSelect='', OrderByDefault='', CamposClaves='Formula_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = Null
     WHERE Identidad_Id='venOtcFormula'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venOtcFormula')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venOtcFormula'),'Formula_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venOtcFormula'),'Descripcion')


