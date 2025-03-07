IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkDepositos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario, CharCasing, MaximaLongitud)
       Values('stkDepositos','Depositos','Deposito_Id,Descripcion,Inactivo,Posteado,Empresa_Id,AdmiteVentas,UsaUbicacion, Centro1_Id, Centro2_Id','vstkDepositos','','Deposito_Id','Deposito_Id','Descripcion','2140','Upper',15)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Depositos', 
	 CamposSelect='Deposito_Id,Descripcion,Inactivo,Posteado,Empresa_Id,AdmiteVentas,UsaUbicacion, Centro1_Id, Centro2_Id', 
		FromSelect='vstkDepositos', WhereSelect='', OrderByDefault='Deposito_Id', CamposClaves='Deposito_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '2140', 
		CharCasing= 'Upper',
		MaximaLongitud= 15
     WHERE Identidad_Id='stkDepositos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkDepositos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositos'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositos'),'Descripcion')
