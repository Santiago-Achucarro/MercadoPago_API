IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proOrdenCierre')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('proOrdenCierre','Cierre OP','Fecha,Formulario_Id,vconAsientos.Empresa_Id,FechaRegistro,Anulado','vconAsientos','','Fecha','','', 'conAsientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cierre OP', 
	 CamposSelect='Fecha,Formulario_Id,vconAsientos.Empresa_Id,FechaRegistro,Anulado ', 
	 FromSelect='vconAsientos', 
	 WhereSelect='', 
	 OrderByDefault='Fecha', 
	 CamposClaves='', 
	 CampoDescripcion='',
	 CampoFKTablaSeg = 'conAsientos',  
	 VistaSeg = 'genAsiSegmentos', 
	 CampoPKVistaSeg = 'Asiento_Id'
	 WHERE Identidad_Id='proOrdenCierre'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id = dbo.FuncFklupIdentidades('proOrdenCierre')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenCierre'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenCierre'),'FechaRegistro')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenCierre'),'Anulado')
GO
