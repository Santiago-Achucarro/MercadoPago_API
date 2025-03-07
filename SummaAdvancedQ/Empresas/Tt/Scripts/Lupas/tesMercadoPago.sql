IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesMercadoPago')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('tesMercadoPago','MercadoPago','MercadoPago_Id,Descripcion,Inactivo,Posteado','tesMercadoPago','','','MercadoPago_Id','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='MercadoPago', CamposSelect='MercadoPago_Id,Descripcion,Inactivo,Posteado', FromSelect='tesMercadoPago', WhereSelect='', OrderByDefault='', CamposClaves='MercadoPago_Id', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='tesMercadoPago'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesMercadoPago')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMercadoPago'),'MercadoPago_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMercadoPago'),'Descripcion')