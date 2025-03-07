IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCondPago')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venCondPago','Condiciones de Pago','CondPagoCli_Id,Descripcion,Dias,Inactivo,Posteado,Empresa_Id','venCondPago','','','CondPagoCli_Id','Descripcion','51240')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Condiciones de Pago', CamposSelect='CondPagoCli_Id,Descripcion,Dias,Inactivo,Posteado,Empresa_Id', FromSelect='venCondPago', WhereSelect='', OrderByDefault='', CamposClaves='CondPagoCli_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '51240'
     WHERE Identidad_Id='venCondPago'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCondPago')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondPago'),'CondPagoCli_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondPago'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondPago'),'Dias')
