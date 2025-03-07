IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conSituPatri')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('conSituPatri','Situacion Patrimo?al','Rubro_Balance,Descripcion,Rubro_Id','conSituPatri','','','Rubro_Balance','Descripcion','317010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Situacion Patrimo?al', CamposSelect='Rubro_Balance,Descripcion,Rubro_Id', FromSelect='conSituPatri', WhereSelect='', OrderByDefault='', CamposClaves='Rubro_Balance', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '317010'
     WHERE Identidad_Id='conSituPatri'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conSituPatri')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSituPatri'),'Rubro_Balance')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSituPatri'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSituPatri'),'Rubro_Id')
