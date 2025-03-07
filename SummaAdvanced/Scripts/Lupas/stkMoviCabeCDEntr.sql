IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkMoviCabeEntr')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, 
		WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkMoviCabeEntr','Cambios_de_Deposito','Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,SegmentoSal,Anulado','vstkMoviCabeEntr','','Fecha','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cambios_de_Deposito', 
		CamposSelect='Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,SegmentoSal,Anulado', 
		FromSelect='vstkMoviCabeEntr', 
		WhereSelect='', OrderByDefault='Fecha', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkMoviCabeEntr'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkMoviCabeEntr')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabeEntr'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabeEntr'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkMoviCabeEntr'), 'SegmentoSal')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkMoviCabeEntr'), 'SubTipomov_Id')


