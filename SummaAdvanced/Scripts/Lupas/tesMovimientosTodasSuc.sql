IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesMovimientosTodasSuc')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesMovimientosTodasSuc','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vtesMovimientosTodasSuc.tesMovimientos','vtesMovimientosTodasSuc','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesMovimientosTodasSuc.tesMovimientos', 
		FromSelect='vtesMovimientosTodasSuc', 
		WhereSelect='', OrderByDefault='Fecha Desc, tesMovimientos Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='tesMovimientosTodasSuc'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesMovimientosTodasSuc')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMovimientosTodasSuc'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMovimientosTodasSuc'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesMovimientosTodasSuc'), 'SubTipo_Id')

