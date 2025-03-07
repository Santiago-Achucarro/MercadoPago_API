IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'RubroPrevi_Id')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('RubroPrevi_Id','Anexo_de_Previsiones','RubroPrevi_Id,Descripcion','conRubrosPrevi','','','RubroPrevi_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Anexo_de_Previsiones', CamposSelect='RubroPrevi_Id,Descripcion', FromSelect='conRubrosPrevi', WhereSelect='', OrderByDefault='', CamposClaves='RubroPrevi_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='RubroPrevi_Id'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('RubroPrevi_Id')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('RubroPrevi_Id'),'RubroPrevi_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('RubroPrevi_Id'),'Descripcion')
