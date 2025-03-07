IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesPagosProvTodas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesPagosProvTodas','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vtesPagosProv.tesMovimientos, Proveed_Id, RazonSocial','vtesPagosProv','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesPagosProv.tesMovimientos, Proveed_Id, RazonSocial', 
		FromSelect='vtesPagosProv', 
		WhereSelect='', OrderByDefault='Fecha Desc, tesMovimientos Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='tesPagosProvTodas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesPagosProvTodas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesPagosProvTodas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesPagosProvTodas'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProvTodas'), 'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProvTodas'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProvTodas'), 'Anulado')





