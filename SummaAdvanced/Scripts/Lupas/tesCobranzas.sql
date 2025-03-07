IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesCobranzas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesCobranzas','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vTesCobranzas.tesMovimientos, Cliente_Id, RazonSocial','vTesCobranzas','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vTesCobranzas.tesMovimientos, Cliente_Id, RazonSocial', 
		FromSelect='vTesCobranzas', 
		WhereSelect='', OrderByDefault='Fecha Desc, tesMovimientos Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='tesCobranzas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesCobranzas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCobranzas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCobranzas'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzas'), 'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzas'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzas'), 'Anulado')





