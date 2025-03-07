IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesBancos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesBancos','Bancos','Banco_Id,Descripcion,Inactivo,Posteado,Empresa_Id','tesBancos','','','Banco_Id','Descripcion','612020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Bancos', CamposSelect='Banco_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='tesBancos', WhereSelect='', OrderByDefault='', CamposClaves='Banco_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario  ='612020'
     WHERE Identidad_Id='tesBancos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesBancos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesBancos'),'Banco_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesBancos'),'Descripcion')
