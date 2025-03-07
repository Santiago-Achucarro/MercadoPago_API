IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'ClieCtasAnticipo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('ClieCtasAnticipo','Cuentas Anticipo','Cliente_Id,Moneda_Id,CtaAnticipo,DescripcionCtaAnticipo','vvenClientesCtas','','','CtaAnticipo','DescripcionCtaAnticipo')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Anticipo', CamposSelect='Cliente_Id,Moneda_Id,CtaAnticipo,DescripcionCtaAnticipo', FromSelect='vvenClientesCtas', WhereSelect='', OrderByDefault='', CamposClaves='CtaAnticipo', CampoDescripcion='DescripcionCtaAnticipo'
     WHERE Identidad_Id='ClieCtasAnticipo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('ClieCtasAnticipo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('ClieCtasAnticipo'),'CtaAnticipo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('ClieCtasAnticipo'),'DescripcionCtaAnticipo')
