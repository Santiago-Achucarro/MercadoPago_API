IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesIdentificaXUsuario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesIdentificaXUsuario','Identificadores','Cartera_Id,tesIdentifica.Descripcion,tesTiposId.TipoCartera,tesIdentifica.Posteado,tesIdentifica.Inactivo,tesIdentifica.Empresa_Id,conCuentas.Cuenta_Id,genMonedas.Moneda_Id','tesIdentifica inner join tesTiposId ON tesTiposId.tesTiposId = TesIdentifica.TipoCartera Inner join conCuentas ON conCuentas.conCuentas = tesIdentifica.Cuenta_Id inner join genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = tesIdentifica.UsuarioAmo','','Cartera_Id','Cartera_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Identificadores', 
	 CamposSelect='Cartera_Id,tesIdentifica.Descripcion,tesTiposId.TipoCartera,tesIdentifica.Posteado,tesIdentifica.Inactivo,tesIdentifica.Empresa_Id,conCuentas.Cuenta_Id,genMonedas.Moneda_Id', 
	 FromSelect='tesIdentifica inner join tesTiposId ON tesTiposId.tesTiposId = TesIdentifica.TipoCartera Inner join conCuentas ON conCuentas.conCuentas = tesIdentifica.Cuenta_Id inner join genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = tesIdentifica.UsuarioAmo', 
	 WhereSelect='', 
	 OrderByDefault='Cartera_Id', 
	 CamposClaves='Cartera_Id'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='tesIdentificaXUsuario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesIdentificaXUsuario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaXUsuario'),'Cartera_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaXUsuario'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaXUsuario'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaXUsuario'),'Moneda_Id')


--exec Lup_EjecutarConsulta @pidentidad_Id='tesIdentifica',@pWhereSP='( IsNull(Empresa_Id, ''1'') =  ''1'')',@pWhere=NULL,@pOrderBy=NULL,@pDesde=1,@pHasta=10,@pDominio='MX',@pP1=NULL,@pP2=NULL,@pP3=NULL,@pP4=NULL,@pP5=NULL,@pP6=NULL,@pP7=NULL,@pP8=NULL,@pP9=NULL,@pP10=NULL
