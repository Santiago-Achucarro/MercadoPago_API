IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proCentroProductivo')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('proCentroProductivo','Centro Productivo','CtroProd_Id,Descripcion,Inactivo,Posteado','proCentroProductivo','','','CtroProd_Id','Descripcion','9120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro Productivo', CamposSelect='CtroProd_Id,Descripcion,Inactivo,Posteado', FromSelect='proCentroProductivo', WhereSelect='', OrderByDefault='', CamposClaves='CtroProd_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario='9120'
     WHERE Identidad_Id='proCentroProductivo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proCentroProductivo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proCentroProductivo'),'CtroProd_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proCentroProductivo'),'Descripcion')
