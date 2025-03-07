IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'vtesFormularioCheque')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('vtesFormularioCheque','Fomulario de Cheques','Formulario_Id,Descripcion','vtesFormularioCheque','','Formulario_Id','Formulario_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Fomulario de Cheques', CamposSelect='Formulario_Id,Descripcion', FromSelect='vtesFormularioCheque', WhereSelect='', OrderByDefault='Formulario_Id', CamposClaves='Formulario_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='vtesFormularioCheque'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('vtesFormularioCheque')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vtesFormularioCheque'),'Formulario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vtesFormularioCheque'),'Descripcion')
