IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkSolicitudCD')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkSolicitudCD','Solicitud Cambio Depositos','Fecha,vstkSolicitudCD.stkSolicitudCD,Estado','vstkSolicitudCD','','Fecha Desc','','', 'stkSolicitudCD','stkSolicitudCDSegmento', 'stkSolicitudCD')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SolicitudesSegmento', 
		CamposSelect='Fecha,vstkSolicitudCD.stkSolicitudCD,Estado', 
		FromSelect='vstkSolicitudCD', 
		WhereSelect='', OrderByDefault='Fecha Desc, stkSolicitudCD Desc', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'stkSolicitudCD',
		 VistaSeg = 'stkSolicitudCDSegmento', 
		 CampoPKVistaSeg = 'stkSolicitudCD'
		     WHERE Identidad_Id='stkSolicitudCD'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkSolicitudCD')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkSolicitudCD'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkSolicitudCD'),'Estado')
