IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAsientosGen')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('conAsientosGen','Asientos de Contabilidad General','Fecha,Formulario_Id,Posteado,Anulado,Empresa','vconAsientosGen','','Fecha','','','Asiento_Id','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,Formulario_Id,Posteado,Anulado,Empresa', 
		FromSelect='vconAsientosGen', 
		WhereSelect='', OrderByDefault='Fecha', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='Asiento_Id',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='conAsientosGen'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAsientosGen')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosGen'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosGen'),'Posteado')

GO
