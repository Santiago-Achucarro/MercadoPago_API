IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comConPago')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comConPago','Condicion_de_Pago','CondPago_Id,Descripcion,Dias,CantidadCuotas,Inactivo,Posteado,Empresa_Id','comConPago','','','CondPago_Id','Descripcion', '1120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Condicion_de_Pago', CamposSelect='CondPago_Id,Descripcion,Dias,CantidadCuotas,Inactivo,Posteado,Empresa_Id', FromSelect='comConPago', 
	 WhereSelect='', OrderByDefault='', CamposClaves='CondPago_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '1120'
     WHERE Identidad_Id='comConPago'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comConPago')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comConPago'),'CondPago_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comConPago'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comConPago'),'Dias')

GO