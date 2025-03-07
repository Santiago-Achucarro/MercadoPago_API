IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesT3Promociones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesT3Promociones','Promociones_de_Tarjetas','Promocion_Id,Descripcion,Inactivo,Posteado,Empresa_Id','tesT3Promociones','','','Promocion_Id','Descripcion', '615020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Promociones_de_Tarjetas', CamposSelect='Promocion_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='tesT3Promociones', 
	 WhereSelect='', OrderByDefault='', CamposClaves='Promocion_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '615020'
     WHERE Identidad_Id='tesT3Promociones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesT3Promociones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesT3Promociones'),'Promocion_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesT3Promociones'),'Descripcion')

GO
