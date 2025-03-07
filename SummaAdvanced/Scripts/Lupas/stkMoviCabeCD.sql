IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkMoviCabeCD')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkMoviCabeCD','Cambios_de_Deposito','Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado','vstkMoviCabeCD','exists(select 1 from stkEnTransito where stkEntransito.stkMoviCabe=vstkMoviCabe.stkMoviCabe and  stkEnTransito.stkMoviCabeEntr is null)','Fecha','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cambios_de_Deposito', 
		CamposSelect='Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado', 
		FromSelect='vstkMoviCabeCD', 
		WhereSelect='', OrderByDefault='Fecha', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkMoviCabeCD'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkMoviCabeCD')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabeCD'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabeCD'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkMoviCabeCD'), 'SubTipomov_Id')
