IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario, CharCasing, Mascara, MaximaLongitud)
       Values('comProveedores','Proveedores','Proveed_id,RazonSocial,CUIT,CondPago_Id,Empresa_Id,NombreLegal,Origen_Id,Letra_Fact,TipoCtaProv,Inactivo,Posteado,ProvTipo_Id','vComproveedores','','','Proveed_id','RazonSocial', '1110','Upper','',15)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Proveedores', CamposSelect='Proveed_id,RazonSocial,CUIT,CondPago_Id,Empresa_Id,NombreLegal,Origen_Id,Letra_Fact,TipoCtaProv,Inactivo,Posteado,ProvTipo_Id', 
		 FromSelect='vComproveedores', WhereSelect='', OrderByDefault='', CamposClaves='Proveed_id', CampoDescripcion='RazonSocial', OrdenMenuFormulario = '1110',
		 CharCasing = 'Upper',
		 Mascara = '',
		 MaximaLongitud = 15
		 WHERE Identidad_Id='comProveedores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedores'),'Proveed_id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedores'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedores'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedores'),'NombreLegal')