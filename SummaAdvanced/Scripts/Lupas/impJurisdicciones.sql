IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impJurisdicciones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('impJurisdicciones','Jurisdicciones','Juris_Id,Descripcion,Inactivo,Posteado,Empresa_Id','impJurisdicciones','','','Juris_Id','Descripcion','414010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Jurisdicciones', CamposSelect='Juris_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='impJurisdicciones', WhereSelect='', OrderByDefault='', CamposClaves='Juris_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '414010'
     WHERE Identidad_Id='impJurisdicciones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impJurisdicciones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impJurisdicciones'),'Juris_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impJurisdicciones'),'Descripcion')
