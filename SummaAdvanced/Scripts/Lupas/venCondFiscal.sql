IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCondFiscal')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('venCondFiscal','Condicion Fiscal de Ventas','CondFisc_Id,Descripcion,Posteado,Inactivo,Empresa_Id','venCondFiscal','','','CondFisc_Id','Descripcion','412030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Condicion Fiscal de Ventas', CamposSelect='CondFisc_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='venCondFiscal', WhereSelect='', OrderByDefault='', CamposClaves='CondFisc_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '412030'
     WHERE Identidad_Id='venCondFiscal'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCondFiscal')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondFiscal'),'CondFisc_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondFiscal'),'Descripcion')
