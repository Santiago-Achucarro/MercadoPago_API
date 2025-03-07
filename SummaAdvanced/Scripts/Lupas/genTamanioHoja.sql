IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTamanioHoja')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genTamanioHoja','TamanioHoja','TamanioHoja,Descripcion','genTamanioHoja','','','TamanioHoja','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='TamanioHoja', CamposSelect='TamanioHoja,Descripcion', FromSelect='genTamanioHoja', WhereSelect='', OrderByDefault='', CamposClaves='TamanioHoja', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genTamanioHoja'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTamanioHoja')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('genTamanioHoja'),'TamanioHoja')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('genTamanioHoja'),'Descripcion')
