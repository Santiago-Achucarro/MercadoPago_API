IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comRegiones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comRegiones','Origenes Fiscales','Region_Id,Descripcion,Inactivo,Posteado,Empresa_Id','comRegiones','','','Region_Id','Descripcion','1150')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Origenes Fiscales', CamposSelect='Region_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='comRegiones', WhereSelect='', OrderByDefault='', CamposClaves='Region_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '1150'
     WHERE Identidad_Id='comRegiones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comRegiones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comRegiones'),'Region_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comRegiones'),'Descripcion')


