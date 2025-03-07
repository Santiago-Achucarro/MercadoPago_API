IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesIdentificaActualiz')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesIdentificaActualiz','Identificadores','Cartera_Id,tesIdentifica.Descripcion,tesTiposId.TipoCartera,tesIdentifica.Posteado,tesIdentifica.Inactivo,tesIdentifica.Empresa_Id','tesIdentifica inner join tesTiposId ON tesTiposId.tesTiposId = TesIdentifica.TipoCartera','','Cartera_Id','Cartera_Id','Descripcion','6140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Identificadores', 
	 CamposSelect='Cartera_Id,tesIdentifica.Descripcion,tesTiposId.TipoCartera,tesIdentifica.Posteado,tesIdentifica.Inactivo,tesIdentifica.Empresa_Id', 
	 FromSelect='tesIdentifica inner join tesTiposId ON tesTiposId.tesTiposId = TesIdentifica.TipoCartera', 
	 WhereSelect='', 
	 OrderByDefault='Cartera_Id', 
	 CamposClaves='Cartera_Id'
	 , CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '6140'
     WHERE Identidad_Id='tesIdentificaActualiz'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesIdentificaActualiz')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaActualiz'),'Cartera_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaActualiz'),'Descripcion')

