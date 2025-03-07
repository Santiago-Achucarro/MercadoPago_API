IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesMovimientos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesMovimientos','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesMovimientos.tesMovimientos','vtesMovimientos','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesMovimientos.tesMovimientos', 
		FromSelect='vtesMovimientos', 
		WhereSelect='',
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id', 
		OrderByDefault = ' Fecha Desc, tesMovimientos Desc '
     WHERE Identidad_Id='tesMovimientos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesMovimientos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMovimientos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMovimientos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesMovimientos'), 'SubTipo_Id')


/*

*/