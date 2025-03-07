IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comEsquemaAuto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comEsquemaAuto','','EsquemaAuto_Id,Descripcion,Empresa_Id,Inactivo,Posteado','comEsquemaAuto','','','EsquemaAuto_Id','Descripcion','1337')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='', CamposSelect='EsquemaAuto_Id,Descripcion,Empresa_Id,Inactivo,Posteado', FromSelect='comEsquemaAuto', WhereSelect='', OrderByDefault='', CamposClaves='EsquemaAuto_Id', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '1337'
     WHERE Identidad_Id='comEsquemaAuto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comEsquemaAuto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comEsquemaAuto'),'EsquemaAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comEsquemaAuto'),'Descripcion')
