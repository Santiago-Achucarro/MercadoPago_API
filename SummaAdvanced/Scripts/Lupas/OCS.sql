IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'OCS')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('OCS','Orden de Compra SUMMA++','espOrdenComp.Proveed_Id,espOrdenComp.Fecha,espOrdenComp.Moneda_Id,espOrdenComp.Monto,espOrdenComp.Clave','espOrdenComp','','','','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Orden de Compra SUMMA++', CamposSelect='espOrdenComp.Proveed_Id,espOrdenComp.Fecha,espOrdenComp.Moneda_Id,espOrdenComp.Monto,espOrdenComp.Clave', FromSelect='espOrdenComp', WhereSelect='', OrderByDefault='', CamposClaves='', CampoDescripcion=''
     WHERE Identidad_Id='OCS'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('OCS')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('OCS'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('OCS'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('OCS'),'Monto')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('OCS'),'Clave')

