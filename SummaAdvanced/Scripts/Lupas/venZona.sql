IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venZona')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venZona','Zona','Zona_Id,Descripcion,Posteado,Inactivo,Empresa_Id','venZona','','','Zona_Id','Descripcion','51500')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Zona', CamposSelect='Zona_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='venZona', WhereSelect='', OrderByDefault='', CamposClaves='Zona_Id', CampoDescripcion='Descripcion',	
	 OrdenMenuFormulario = '51500'
     WHERE Identidad_Id='venZona'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venZona')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venZona'),'Zona_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venZona'),'Descripcion')
