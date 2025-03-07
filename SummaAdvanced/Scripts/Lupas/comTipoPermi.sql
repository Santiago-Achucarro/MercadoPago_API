IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comTipoPermi')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comTipoPermi','Tipo Orden de Compra','TipoPermi_Id,Descripcion,Empresa_Id,Posteado,Inactivo,Importaciones','comTipoPermi','','TipoPermi_Id','TipoPermi_Id','Descripcion','1330')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo Orden de Compra', CamposSelect='TipoPermi_Id,Descripcion,Empresa_Id,Posteado,Inactivo,Importaciones', FromSelect='comTipoPermi', WhereSelect='', OrderByDefault='TipoPermi_Id', CamposClaves='TipoPermi_Id', CampoDescripcion='Descripcion' ,
		OrdenMenuFormulario = '1330'
     WHERE Identidad_Id='comTipoPermi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comTipoPermi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermi'),'TipoPermi_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermi'),'Descripcion')
