IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueTablaVacacion')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueTablaVacacion','Tablas de Vacaciones','TablaVac_Id,Descripcion,Inactivo,Posteado','sueTablaVacacion','','','TablaVac_Id','Descripcion','S14070')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tablas de Vacaciones', CamposSelect='TablaVac_Id,Descripcion,Inactivo,Posteado', FromSelect='sueTablaVacacion', WhereSelect='', OrderByDefault='', CamposClaves='TablaVac_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S14070'
     WHERE Identidad_Id='sueTablaVacacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueTablaVacacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablaVacacion'),'TablaVac_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablaVacacion'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablaVacacion'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablaVacacion'),'Posteado')
