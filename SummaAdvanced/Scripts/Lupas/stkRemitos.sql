IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkRemitos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkRemitos','Remitos','Fecha,Cliente_Id, RazonSocial, SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vStkRemitos.stkMoviCabe, Estado ','vStkRemitos','',
		'Fecha Desc , stkMoviCabe Desc','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Stock', 
		CamposSelect='Fecha,Cliente_Id, RazonSocial, SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro, vStkRemitos.stkMoviCabe, Estado', 
		FromSelect='vStkRemitos', 
		WhereSelect='', OrderByDefault='Fecha Desc, stkMoviCabe Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkRemitos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkRemitos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitos'),'Anulado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitos'), 'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitos'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitos'), 'Estado')
