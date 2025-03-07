IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAsientos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('conAsientos','Asientos Contabilidad','Fecha,Formulario_Id,LeyendaLibroDiario,vconAsientosCon.Empresa,FechaRegistro,Anulado','vconAsientosCon','','Fecha','','', 'conAsientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Asientos Contabilidad', 
	 CamposSelect='Fecha,Formulario_Id,LeyendaLibroDiario,vconAsientosCon.Empresa,FechaRegistro,Anulado ', 
	 FromSelect='vconAsientosCon', 
	 WhereSelect='', 
	 OrderByDefault='Fecha', 
	 CamposClaves='', 
	 CampoDescripcion='',
	 CampoFKTablaSeg = 'conAsientos',  
	 VistaSeg = 'genAsiSegmentos', 
	 CampoPKVistaSeg = 'Asiento_Id'
	 WHERE Identidad_Id='conAsientos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAsientos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientos'),'LeyendaLibroDiario')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientos'),'FechaRegistro')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientos'),'Anulado')

GO
