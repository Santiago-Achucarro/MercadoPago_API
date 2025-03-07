IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'Empresas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('Empresas','Empresas','Empresa_Id,Detalle','genEmpresas','','Detalle','Empresa_Id','Detalle')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Empresas', CamposSelect='Empresa_Id,Detalle', FromSelect='genEmpresas', WhereSelect='', OrderByDefault='Detalle', CamposClaves='Empresa_Id', CampoDescripcion='Detalle'
     WHERE Identidad_Id='Empresas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('Empresas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('Empresas'),'Empresa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('Empresas'),'Detalle')
