IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'TesCfdiCobranza')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, 
		WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,
		CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('TesCfdiCobranza','CFDI Cobranza','Cliente_Id,RazonSocial,Empresa,Anulada,Fecha','vtesCfdiCobranza',
	   '','Fecha','','',
	   'TesCfdiCobranza','TesCFDICobranzaSegmentos', 'TesCfdiCobranza')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='CFDI Cobranza', 
	 CamposSelect='Cliente_Id,RazonSocial,Empresa,Anulada,Fecha', 
	 FromSelect='vtesCfdiCobranza', 
	 WhereSelect='', OrderByDefault='Fecha', 
	 CamposClaves='', CampoDescripcion='',
	 CampoFKTablaSeg='TesCfdiCobranza', 
	 VistaSeg='TesCFDICobranzaSegmentos', 
	 CampoPKVistaSeg='TesCfdiCobranza'
     WHERE Identidad_Id='TesCfdiCobranza'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('TesCfdiCobranza')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('TesCfdiCobranza'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('TesCfdiCobranza'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('TesCfdiCobranza'),'Fecha')
GO
