IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAsientosT')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('conAsientosT', 'Asientos Todos', 'Fecha, Formulario_Id, vconAsientos.Empresa_Id, FechaRegistro', 'vconAsientos', '', 'Fecha Desc', '', '', 'conAsientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Asientos Todos', 
	 CamposSelect='Fecha, Formulario_Id, vconAsientos.Empresa_Id, FechaRegistro', 
	 FromSelect='vconAsientos', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'conAsientos',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='conAsientosT'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAsientosT')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosT'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosT'),'LeyendaLibroDiario')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosT'),'FechaRegistro')

GO



