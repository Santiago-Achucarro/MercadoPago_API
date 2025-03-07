IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venEsquemaAuto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venEsquemaAuto','','EsquemaAuto_Id,Descripcion,Empresa_Id','venEsquemaAuto','','','EsquemaAuto_Id','Descripcion','52105020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='', CamposSelect='EsquemaAuto_Id,Descripcion,Empresa_Id', FromSelect='venEsquemaAuto', WhereSelect='', OrderByDefault='', CamposClaves='EsquemaAuto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '52105020'
     WHERE Identidad_Id='venEsquemaAuto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venEsquemaAuto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venEsquemaAuto'),'EsquemaAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venEsquemaAuto'),'Descripcion')
