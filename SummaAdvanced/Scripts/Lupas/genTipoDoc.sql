IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTipoDoc')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genTipoDoc','Tipo_de_Documento','TipoDoc,Descripcion,Dominio_Id','genTiposDoc','Dominio_Id = @Dominio_Id','','TipoDoc','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo_de_Documento', CamposSelect='TipoDoc,Descripcion,Dominio_Id', FromSelect='genTiposDoc', WhereSelect='Dominio_Id = @Dominio_Id', OrderByDefault='', CamposClaves='TipoDoc', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genTipoDoc'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTipoDoc')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTipoDoc'),'TipoDoc')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTipoDoc'),'Descripcion')
Go
