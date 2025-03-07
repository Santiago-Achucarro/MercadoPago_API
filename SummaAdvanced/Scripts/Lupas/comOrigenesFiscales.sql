IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comOrigenesFiscales')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comOrigenesFiscales','Origenes Fiscales','Origen_Id,Descripcion','comOrigenesFiscales','','','Origen_Id','Descripcion', '411040')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Origenes Fiscales', CamposSelect='Origen_Id,Descripcion', FromSelect='comOrigenesFiscales', WhereSelect='', OrderByDefault='',
	 CamposClaves='Origen_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '411040'
     WHERE Identidad_Id='comOrigenesFiscales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comOrigenesFiscales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOrigenesFiscales'),'Origen_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOrigenesFiscales'),'Descripcion')
