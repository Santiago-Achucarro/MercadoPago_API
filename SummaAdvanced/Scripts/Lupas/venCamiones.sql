IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCamiones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venCamiones','Camiones','Patente_Id,Descripcion,FormaEntrega_Id,EsAcoplado,CargaMaxima,Tara,Marca,Inspeccion,Inactivo,Posteado,Empresa_Id','vvenCamiones','','','Patente_Id','Descripcion','51290')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Camiones', CamposSelect='Patente_Id,Descripcion,FormaEntrega_Id,EsAcoplado,CargaMaxima,Tara,Marca,Inspeccion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='vvenCamiones', WhereSelect='', OrderByDefault='', CamposClaves='Patente_Id', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '51290'
     WHERE Identidad_Id='venCamiones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCamiones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCamiones'),'Patente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCamiones'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCamiones'),'EsAcoplado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCamiones'),'FormaEntrega_id')

