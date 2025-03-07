IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conIndicesAjustes')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conIndicesAjustes','Indices de Ajuste','Indice_Id,Descripcion','conIndicesAjustes','','Indice_Id','Indice_Id','Descripcion','3155')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Indices de Ajuste', CamposSelect='Indice_Id,Descripcion', FromSelect='conIndicesAjustes', WhereSelect='', OrderByDefault='Indice_Id', CamposClaves='Indice_Id', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '3155'
     WHERE Identidad_Id='conIndicesAjustes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conIndicesAjustes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conIndicesAjustes'),'Indice_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conIndicesAjustes'),'Descripcion')
