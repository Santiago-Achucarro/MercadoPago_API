IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProvAnexo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProvAnexo','Prov Anexo','Codigo,CUIT,RazonSocial,TipoDoc,idFiscal,Direccion1,Direccion2,Cod_Postal,Provincia_Id,CondFiscal_Id,Localidad,Origen_Id,Empresa_Id,Inactivo,Posteado',
	   'vComprovAnexo','','','Codigo','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Prov Anexo', CamposSelect='Codigo,CUIT,RazonSocial,TipoDoc,idFiscal,Direccion1,Direccion2,Cod_Postal,Provincia_Id,CondFiscal_Id,Localidad,Origen_Id,Empresa_Id,Inactivo,Posteado',
	 FromSelect='vComprovAnexo', WhereSelect='', OrderByDefault='', CamposClaves='Codigo', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='comProvAnexo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProvAnexo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'Codigo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'TipoDoc')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'idFiscal')
