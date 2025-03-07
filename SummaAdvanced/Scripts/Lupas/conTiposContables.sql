IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conTiposContables')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('conTiposContables','Tipos_Contables','Tipo_Id,Descripcion,Tipo,Rubro_Id','vconTiposContables','','','Tipo_Id','Descripcion','317020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_Contables', 
	 CamposSelect='Tipo_Id,Descripcion,Tipo,Rubro_Id', FromSelect='vconTiposContables', WhereSelect='', OrderByDefault='', CamposClaves='Tipo_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '317020'
     WHERE Identidad_Id='conTiposContables'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conTiposContables')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposContables'),'Tipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposContables'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposContables'),'Tipo')

