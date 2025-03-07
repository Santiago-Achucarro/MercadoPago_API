IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comMovTipos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comMovTipos','','TipoMov,Descripcion','comMovTipos','','TipoMov','TipoMov','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='', CamposSelect='TipoMov,Descripcion', FromSelect='comMovTipos', WhereSelect='', OrderByDefault='TipoMov', CamposClaves='TipoMov', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comMovTipos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comMovTipos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovTipos'),'TipoMov')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovTipos'),'Descripcion')
GO
