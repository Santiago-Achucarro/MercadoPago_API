IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkMoviCabe')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkMoviCabe','Movimientos de Stock','Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vstkMoviCabe.stkMoviCabe,Signo ','vstkMoviCabe','','Fecha Desc,stkMoviCabe Desc','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Stock', 
		CamposSelect='Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vstkMoviCabe.stkMoviCabe,Signo', 
		FromSelect='vstkMoviCabe', 
		WhereSelect='', OrderByDefault='Fecha Desc, stkMoviCabe Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkMoviCabe'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkMoviCabe')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabe'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabe'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkMoviCabe'), 'SubTipomov_Id')
