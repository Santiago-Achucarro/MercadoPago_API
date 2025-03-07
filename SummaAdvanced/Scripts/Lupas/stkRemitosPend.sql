IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkRemitosPend')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkRemitosPend','Remitos Pendientes','Fecha,Cliente_Id, RazonSocial, SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vStkRemitosPend.stkMoviCabe',
	   'vstkRemitosPend', '', 'Fecha Desc , stkMoviCabe Desc','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Remitos Pendientes', 
		CamposSelect='Fecha,Cliente_Id, RazonSocial, SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro, vStkRemitosPend.stkMoviCabe', 
		FromSelect='vStkRemitosPend', 
		WhereSelect='', 
		OrderByDefault='Fecha Desc, stkMoviCabe Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkRemitosPend'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkRemitosPend')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosPend'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosPend'),'Anulado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitosPend'), 'SubTipomov_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitosPend'), 'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitosPend'), 'RazonSocial')
 