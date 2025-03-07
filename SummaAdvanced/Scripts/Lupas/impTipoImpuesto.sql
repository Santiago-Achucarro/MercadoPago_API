IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impTipoImpuesto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('impTipoImpuesto','Tipo_de_Impuesto','TipoImpuesto,Descripcion,Dominio_Id','impTipoImpuesto','Dominio_Id = @Dominio_Id','','TipoImpuesto','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo_de_Impuesto', CamposSelect='TipoImpuesto,Descripcion,Dominio_Id', FromSelect='impTipoImpuesto', WhereSelect='Dominio_Id = @Dominio_Id', OrderByDefault='', CamposClaves='TipoImpuesto', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='impTipoImpuesto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impTipoImpuesto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impTipoImpuesto'),'TipoImpuesto')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impTipoImpuesto'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impTipoImpuesto'),'Dominio_Id')
