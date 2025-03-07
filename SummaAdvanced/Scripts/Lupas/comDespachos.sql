IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comDespachos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comDespachos','Despachos_de_importacion','Despacho_Id,Origen,Aduana,Fecha,Empresa_Id,Cambio,Moneda_Id','vcomDespachos','','','Despacho_Id','Origen','122010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Despachos_de_importacion', 
	 CamposSelect='Despacho_Id,Origen,Aduana,Fecha,Empresa_Id,Cambio,Moneda_Id', FromSelect='vcomDespachos', WhereSelect='', OrderByDefault='', CamposClaves='Despacho_Id', CampoDescripcion='Origen', 
	 OrdenMenuFormulario = '122010'
     WHERE Identidad_Id='comDespachos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comDespachos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comDespachos'),'Despacho_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comDespachos'),'Origen')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comDespachos'),'Aduana')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comDespachos'),'Fecha')
