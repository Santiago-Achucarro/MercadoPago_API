IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesIdBancos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesIdBancos','Identificadores','Cartera_Id,Descripcion,TipoCartera,Posteado,Inactivo,Empresa_Id,Cuenta_Id,Moneda_Id, ChequeraPredeter, RepoCheq_Id',
	   'vtesIdBanco','','Cartera_Id','Cartera_Id','Descripcion','6140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Identificadores', 
	 CamposSelect='Cartera_Id,Descripcion,TipoCartera,Posteado,Inactivo,Empresa_Id,Cuenta_Id,Moneda_Id, ChequeraPredeter, RepoCheq_Id', 
	 FromSelect='vtesIdBanco', WhereSelect='', 
	 OrderByDefault='Cartera_Id', 
	 CamposClaves='Cartera_Id'
	 , CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '6140'
     WHERE Identidad_Id='tesIdBancos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesIdBancos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdBancos'),'Cartera_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdBancos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdBancos'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdBancos'),'Moneda_Id')


--exec Lup_EjecutarConsulta @pidentidad_Id='tesIdBancos',@pWhereSP='( IsNull(Empresa_Id, ''1'') =  ''1'')',@pWhere=NULL,@pOrderBy=NULL,@pDesde=1,@pHasta=10,@pDominio='MX',@pP1=NULL,@pP2=NULL,@pP3=NULL,@pP4=NULL,@pP5=NULL,@pP6=NULL,@pP7=NULL,@pP8=NULL,@pP9=NULL,@pP10=NULL
