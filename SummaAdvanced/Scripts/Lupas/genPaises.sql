IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genPaises')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genPaises','Dominos','Pais_Id,Descripcion,Posteado,Inactivo,Empresa_Id','genPaises','','Pais_Id','Pais_Id','Descripcion','7140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Dominos', CamposSelect='Pais_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='genPaises', WhereSelect='', OrderByDefault='Pais_Id', CamposClaves='Pais_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7140'
     WHERE Identidad_Id='genPaises'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genPaises')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genPaises'),'Pais_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genPaises'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genPaises'),'Empresa_Id')
