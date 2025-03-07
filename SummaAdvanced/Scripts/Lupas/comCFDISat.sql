

IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comCFDISat')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comCFDISat','XML DEL SAT','UUID,RFCEmisor,Fecha,Monto,Folio,Serie,Subido,Empresa_Id,TipoDeComprobante','comCFDISat','','UUID','UUID','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='XML DEL SAT', 
	 CamposSelect='UUID,RFCEmisor,Fecha,Monto,Folio,Serie,Subido,Empresa_Id,TipoDeComprobante', 
	 FromSelect='comCFDISat', WhereSelect='', OrderByDefault='UUID', CamposClaves='UUID', CampoDescripcion=''
     WHERE Identidad_Id='comCFDISat'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comCFDISat')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'UUID')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'RFCEmisor')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'Monto')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'Folio')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'TipoDeComprobante')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'Serie')
GO
