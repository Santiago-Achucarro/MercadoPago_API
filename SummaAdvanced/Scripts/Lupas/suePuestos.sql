IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'suePuestos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('suePuestos','Puesto','Puesto_Id,Descripcion,Inactivo,Posteado','suePuestos','','','Puesto_Id','Descripcion','S11050')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Puesto', CamposSelect='Puesto_Id,Descripcion,Inactivo,Posteado', FromSelect='suePuestos', WhereSelect='', OrderByDefault='', CamposClaves='Puesto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S11050'
     WHERE Identidad_Id='suePuestos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('suePuestos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePuestos'),'Puesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePuestos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePuestos'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePuestos'),'Posteado')
