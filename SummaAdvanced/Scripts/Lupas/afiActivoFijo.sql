IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'afiActivoFijo')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('afiActivoFijo','Activo Fijo','ActivoFijo_Id,Descripcion,Tipo,FechaAlta,Empresa_Id','afiActivoFijo','','ActivoFijo_Id','ActivoFijo_Id','Descripcion','8110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Activo Fijo', CamposSelect='ActivoFijo_Id,Descripcion,Tipo,FechaAlta,Empresa_Id', FromSelect='afiActivoFijo', WhereSelect='', OrderByDefault='ActivoFijo_Id', CamposClaves='ActivoFijo_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '8110'
     WHERE Identidad_Id='afiActivoFijo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('afiActivoFijo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('afiActivoFijo'),'ActivoFijo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('afiActivoFijo'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('afiActivoFijo'),'FechaAlta')


