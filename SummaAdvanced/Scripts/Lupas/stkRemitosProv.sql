IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkRemitosProv')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkRemitosProv','Movimientos de Stock','Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vstkRemitosProv.stkMoviCabe, Proveed_Id, RazonSocial ','vstkRemitosProv','','Fecha Desc,stkMoviCabe Desc','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Stock', 
		CamposSelect='Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vstkRemitosProv.stkMoviCabe,Proveed_Id, RazonSocial ', 
		FromSelect='vstkRemitosProv', 
		WhereSelect='', OrderByDefault='Fecha Desc, stkMoviCabe Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkRemitosProv'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkRemitosProv')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'Anulado')

