IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueConvenio')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueConvenio','Convenio','Convenio_Id,Descripcion,Posteado,Inactivo','sueConvenio','','','Convenio_Id','Descripcion','S11040')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Convenio', CamposSelect='Convenio_Id,Descripcion,Posteado,Inactivo', FromSelect='sueConvenio', WhereSelect='', OrderByDefault='', CamposClaves='Convenio_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S11040'
     WHERE Identidad_Id='sueConvenio'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueConvenio')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConvenio'),'Convenio_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConvenio'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConvenio'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConvenio'),'Inactivo')
