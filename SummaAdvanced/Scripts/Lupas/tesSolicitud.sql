IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesSolicitud')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('tesSolicitud','Solicitud de Anticipos','Fecha,Solicitante_Id,Nombre,Monto,Empresa,Estado','vtesSolicitud','','Fecha desc','','','tesSolicitud', 'tesSolicitud', 'tesSolSegmentos')
	   
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Solicitud de Anticipos', 
		CamposSelect='Fecha,Solicitante_Id,Nombre, Monto,Empresa,Estado', 
			FromSelect='vtesSolicitud', 
			WhereSelect='', 
			OrderByDefault='Fecha desc'		, CamposClaves='', CampoDescripcion='',
			CampoFKTablaSeg ='tesSolicitud', 
			CampoPKVistaSeg = 'tesSolicitud', 
			VistaSeg = 'tesSolSegmentos'
     WHERE Identidad_Id='tesSolicitud'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesSolicitud')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitud'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitud'),'Solicitante_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitud'),'Nombre')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitud'),'Monto')


GO

