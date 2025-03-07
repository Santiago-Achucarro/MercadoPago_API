IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveeT3')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveeT3','Proveedor de Trabajo de Terceros','Proveed_Id,RazonSocial,Trabajo3_Id,Cantidad,Medida_Id,Precio,Moneda_Id,Inactivo,Posteado,Empresa_Id','vproTrabajo3Prov','','Proveed_Id','Proveed_Id','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Proveedor de Trabajo de Terceros', 
	 CamposSelect='Proveed_Id,RazonSocial,Trabajo3_Id,Cantidad,Medida_Id,Precio,Moneda_Id,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='vproTrabajo3Prov', 
	 WhereSelect='', 
	 OrderByDefault='Proveed_Id', CamposClaves='Proveed_Id', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='comProveeT3'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveeT3')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Cantidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Precio')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Moneda_Id')

GO

