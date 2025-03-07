IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesCobranzasTodas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesCobranzasTodas','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vTesCobranzas.tesMovimientos, Cliente_Id, RazonSocial','vTesCobranzas','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
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
     WHERE Identidad_Id='tesCobranzasTodas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesCobranzasTodas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCobranzasTodas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCobranzasTodas'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzasTodas'), 'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzasTodas'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzasTodas'), 'Anulado')