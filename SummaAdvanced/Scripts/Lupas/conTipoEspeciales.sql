IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conTipoEspeciales')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conTipoEspeciales','Tipos_Especiales','TipoEspe_Id,Descripcion','conTipoEspeciales','','Descripcion','TipoEspe_Id','Descripcion','317030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_Especiales', CamposSelect='TipoEspe_Id,Descripcion', FromSelect='conTipoEspeciales', WhereSelect='', OrderByDefault='Descripcion', CamposClaves='TipoEspe_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario ='317030'
     WHERE Identidad_Id='conTipoEspeciales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conTipoEspeciales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTipoEspeciales'),'TipoEspe_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTipoEspeciales'),'Descripcion')
