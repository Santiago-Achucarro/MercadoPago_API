IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueConcAcum')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, VistaSeg, 
		CampoPKVistaSeg,CampoDescripcion)
       Values('sueConcAcum','Descuento por Tope','Legajo,Nombres,Concepto_Id,DescripcionConcepto,Fecha,MontoTope,Anulado,Empresa',
		'vsueConcAcum','','','','sueConcAcumSegmento','sueConcAcum','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Descuento por Tope', 
	 CamposSelect='Legajo,Nombres,Concepto_Id,DescripcionConcepto,Fecha,MontoTope,Anulado,Empresa ', 
	 FromSelect='vsueConcAcum', 
	 WhereSelect='', 
	 OrderByDefault='Fecha desc', 
	 CamposClaves='', 
	 CampoFKTablaSeg='sueConcAcum',
	 VistaSeg='sueConcAcumSegmento',
	 CampoPKVistaSeg='sueConcAcum'
     WHERE Identidad_Id='sueConcAcum'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueConcAcum')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'Legajo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'Nombres')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'Concepto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'DescripcionConcepto')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'MontoTope')
GO



