IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueConceptos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueConceptos','Conceptos','Concepto_Id,Descripcion,Inactivo,Posteado','sueConceptos','','','Concepto_Id','Descripcion','S12020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Conceptos', CamposSelect='Concepto_Id,Descripcion,Inactivo,Posteado', FromSelect='sueConceptos', WhereSelect='', OrderByDefault='', CamposClaves='Concepto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S12020'
     WHERE Identidad_Id='sueConceptos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueConceptos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConceptos'),'Concepto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConceptos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConceptos'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConceptos'),'Posteado')
