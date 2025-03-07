IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesIdTarjetasTipo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesIdTarjetasTipo','Tipos_de_Tarjetas','TipoTarjeta,Descripcion,Inactivo,Posteado,Empresa_Id','tesIdTarjetasTipo','','','TipoTarjeta','Descripcion', '615020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_de_Tarjetas', CamposSelect='TipoTarjeta,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='tesIdTarjetasTipo', 
	 WhereSelect='', OrderByDefault='', CamposClaves='TipoTarjeta', CampoDescripcion='Descripcion', OrdenMenuFormulario = '615020'
     WHERE Identidad_Id='tesIdTarjetasTipo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesIdTarjetasTipo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdTarjetasTipo'),'TipoTarjeta')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdTarjetasTipo'),'Descripcion')

GO
