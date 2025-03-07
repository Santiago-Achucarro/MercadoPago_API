IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkFamilias')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkFamilias','Familias','Familia_Id,Descripcion,Empresa_Id,Inactivo,Posteado','stkFamilias','','','Familia_Id','Descripcion','2135')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Familias', CamposSelect='Familia_Id,Descripcion,Empresa_Id,Inactivo,Posteado', FromSelect='stkFamilias', WhereSelect='', OrderByDefault='', CamposClaves='Familia_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '2135'
     WHERE Identidad_Id='stkFamilias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkFamilias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkFamilias'),'Familia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkFamilias'),'Descripcion')
