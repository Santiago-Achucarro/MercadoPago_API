IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProvCtaAnti')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProvCtaAnti','Cuentas Anticipos a Proveedores','CtaAnticipo,DescripcionCtaAnticipo,Moneda_Id,Proveed_Id','vvcomProveedoresCtas','CtaAnticipo <> ''  ''','','CtaAnticipo','DescripcionCtaAnticipo')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Anticipos a Proveedores', 
	 CamposSelect='CtaAnticipo,DescripcionCtaAnticipo,Moneda_Id,Proveed_Id', 
	 FromSelect='vvcomProveedoresCtas', WhereSelect='CtaAnticipo <> ''  ''', OrderByDefault='', CamposClaves='CtaAnticipo', CampoDescripcion='DescripcionCtaAnticipo'
     WHERE Identidad_Id='comProvCtaAnti'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProvCtaAnti')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvCtaAnti'),'CtaAnticipo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvCtaAnti'),'DescripcionCtaAnticipo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvCtaAnti'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvCtaAnti'),'Proveed_Id')
GO
