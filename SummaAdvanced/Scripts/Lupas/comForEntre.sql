IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comForEntre')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comForEntre','Forma de Entrega Compras','FormaEnt_Id,Descripcion,Inactivo,Posteado,Empresa_Id','comForEntre','','','FormaEnt_Id','Descripcion', '1130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Forma de Entrega Compras', CamposSelect='FormaEnt_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='comForEntre', 
	 WhereSelect='', OrderByDefault='', CamposClaves='FormaEnt_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '1130'
     WHERE Identidad_Id='comForEntre'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comForEntre')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'FormaEnt_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'Empresa_Id')


