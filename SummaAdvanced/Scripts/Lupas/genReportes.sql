IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genReportes')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genReportes','Reportes','Reporte_Id,Titulo,TipoReporte','genReportes','','Reporte_Id','Reporte_Id','Titulo')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Reportes', CamposSelect='Reporte_Id,Titulo,TipoReporte', FromSelect='genReportes', WhereSelect='', OrderByDefault='Reporte_Id', CamposClaves='Reporte_Id', CampoDescripcion='Titulo'
     WHERE Identidad_Id='genReportes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genReportes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genReportes'),'Reporte_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genReportes'),'Titulo')
