IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCartaPorte')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('venCartaPorte', 'Cartas Porte', 
		'Fecha, Camion_Id, Operador_Id, Formulario_Id, Anulado', 
		'vvenCartaPorte', '', 'Fecha Desc', '', '', 'venMovimientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Carta Porte', 
	 CamposSelect='Fecha, Camion_Id, Operador_Id, Formulario_Id, Anulado', 
	 FromSelect='vvenCartaPorte', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'venMovimientos',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='venCartaPorte'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCartaPorte')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCartaPorte'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCartaPorte'),'Camion_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCartaPorte'),'Operador_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCartaPorte'),'Anulado')
GO