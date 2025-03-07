IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venBonifTemporal')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('venBonifTemporal','Bonificaciones Termporales','venBonifTemporal.venBonifTemporal, Descripcion, Inactivo, Posteado','venBonifTemporal',
	   '','venBonifTemporal Desc','','','venBonifTemporal','venBonifTemporalSegmento', 'venBonifTemporal')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Bonificaciones Temporales', 
		CamposSelect='venBonifTemporal.venBonifTemporal, Descripcion, Inactivo, Posteado', 
		FromSelect='venBonifTemporal', 
		WhereSelect='', OrderByDefault='venBonifTemporal Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='venBonifTemporal',
		VistaSeg = 'venBonifTemporalSegmento', 
		CampoPKVistaSeg = 'venBonifTemporal'
     WHERE Identidad_Id='venBonifTemporal'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venBonifTemporal')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venBonifTemporal'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venBonifTemporal'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('venBonifTemporal'), 'Inactivo')


