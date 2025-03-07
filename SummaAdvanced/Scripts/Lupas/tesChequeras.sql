IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesChequeras')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesChequeras','Chequeras','Chequera_Id,tesChequeras.Estado_Id,TipoChequera,Desde,Hasta,Proximo,tesIdentifica.Cartera_Id,tesChequeras.Inactivo,tesChequeras.Posteado,tesChequeras.Empresa_Id','tesChequeras inner join tesIdentifica ON
tesIdentifica.tesIdentifica = tesChequeras.Cartera_Id','','Chequera_Id','Chequera_Id','TipoChequera','613020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Chequeras', CamposSelect='Chequera_Id,tesChequeras.Estado_Id,TipoChequera,Desde,Hasta,Proximo,tesIdentifica.Cartera_Id,tesChequeras.Inactivo,tesChequeras.Posteado,tesChequeras.Empresa_Id', FromSelect='tesChequeras inner join tesIdentifica ON
	tesIdentifica.tesIdentifica = tesChequeras.Cartera_Id', WhereSelect='', OrderByDefault='Chequera_Id', CamposClaves='Chequera_Id', CampoDescripcion='TipoChequera',
		OrdenMenuFormulario = '613020'
     WHERE Identidad_Id='tesChequeras'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesChequeras')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Chequera_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'TipoChequera')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Desde')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Hasta')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Proximo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Cartera_Id')
GO
