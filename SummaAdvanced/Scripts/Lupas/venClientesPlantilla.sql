IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venClientesPlantilla')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venClientesPlantilla','Plantilla_clientes','Plantilla_Id,Descripcion,Inactivo,Posteado,Empresa_Id','venClientesPlantilla','','','Plantilla_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Plantilla_clientes', 
	 CamposSelect='Plantilla_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='venClientesPlantilla', 
	 WhereSelect='', 
	 OrderByDefault='', 
	 CamposClaves='Plantilla_Id', 
	 CampoDescripcion='Descripcion'
     WHERE Identidad_Id='venClientesPlantilla'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venClientesPlantilla')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venClientesPlantilla'),'Plantilla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venClientesPlantilla'),'Descripcion')
