IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venRegion')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venRegion','Region','Region_Id,Descripcion,Inactivo,Posteado,Empresa_Id','venRegion','','','Region_Id','Descripcion','51280')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Region', CamposSelect='Region_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='venRegion', WhereSelect='', OrderByDefault='', CamposClaves='Region_Id', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '51280'
     WHERE Identidad_Id='venRegion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venRegion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRegion'),'Region_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRegion'),'Descripcion')
