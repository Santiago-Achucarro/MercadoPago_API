IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comCondFiscal')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comCondFiscal','Condicion Fiscal Compras','CondFiscal_Id,Descripcion,Inactivo,Posteado,Empresa_Id','comCondFiscal','','','CondFiscal_Id','Descripcion', '411030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Condicion Fiscal Compras', CamposSelect='CondFiscal_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='comCondFiscal', WhereSelect='', OrderByDefault='', CamposClaves='CondFiscal_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '411030'
     WHERE Identidad_Id='comCondFiscal'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comCondFiscal')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comCondFiscal'),'CondFiscal_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comCondFiscal'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comCondFiscal'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comCondFiscal'),'Posteado')
