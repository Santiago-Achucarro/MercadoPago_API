IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueGanancias')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('sueGanancias','Ganancias','TabGan_Id,Descripcion,FechaRegistro','sueGanTitulo','','','TabGan_Id','Descripcion','S14040')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ganancias', CamposSelect='TabGan_Id,Descripcion,FechaRegistro', FromSelect='sueGanTitulo', WhereSelect='', OrderByDefault='', CamposClaves='TabGan_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S14040'
     WHERE Identidad_Id='sueGanancias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueGanancias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGanancias'),'TabGan_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGanancias'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGanancias'),'FechaRegistro')
