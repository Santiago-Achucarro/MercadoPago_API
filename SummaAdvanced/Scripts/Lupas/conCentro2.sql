IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCentro2')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCentro2','Centro de Aternativo','Centro2_Id,Descripcion,Nivel,Empresa_Id,Inactivo,Posteado','conCentro2','','','Centro2_Id','Descripcion','3130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro de Aternativo', CamposSelect='Centro2_Id,Descripcion,Nivel,Empresa_Id,Inactivo,Posteado', FromSelect='conCentro2', WhereSelect='', OrderByDefault='', CamposClaves='Centro2_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario= '3130'
     WHERE Identidad_Id='conCentro2'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCentro2')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2'),'Centro2_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2'),'Nivel')
