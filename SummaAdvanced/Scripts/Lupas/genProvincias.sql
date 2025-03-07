IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genProvincias')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genProvincias','Dominos','Provincia_Id,Descripcion,Posteado,Inactivo,Empresa_Id','genProvincias','','Provincia_Id','Provincia_Id','Descripcion','7150')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Dominos', CamposSelect='Provincia_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='genProvincias', WhereSelect='', OrderByDefault='Provincia_Id', CamposClaves='Provincia_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7150'
     WHERE Identidad_Id='genProvincias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genProvincias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genProvincias'),'Provincia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genProvincias'),'Descripcion')
