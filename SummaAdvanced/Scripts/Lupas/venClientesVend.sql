IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venClientesVend')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venClientesVend','ClientesVend','Cliente_Id,RazonSocial,SucursalPredeter,Empresa_Id,Posteado,CUIT,idFiscal,TipoDoc,MonedaLimCred,Inactivo,NombreFantasia,Vendedor_Id,TipoCredito','vvenClientesVend','','','Cliente_Id','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='ClientesVend', CamposSelect='Cliente_Id,RazonSocial,SucursalPredeter,Empresa_Id,Posteado,CUIT,idFiscal,TipoDoc,MonedaLimCred,Inactivo,NombreFantasia,Vendedor_Id,TipoCredito', FromSelect='vvenClientesVend', WhereSelect='', OrderByDefault='', CamposClaves='Cliente_Id', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='venClientesVend'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venClientesVend')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientesVend'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientesVend'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientesVend'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientesVend'),'NombreFantasia')

